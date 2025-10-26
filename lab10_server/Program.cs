using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarClassLibrary;
using Newtonsoft.Json;

namespace CarServer
{
    class Program
    {
        private static readonly ConcurrentDictionary<string, Car> _cars = new ConcurrentDictionary<string, Car>();
        private const string FilePath = "cars.json";
        private static readonly object _fileLock = new object();

        static void Main(string[] args)
        {
            // Загружаем справочник из JSON при старте
            LoadFromFile();

            // Запускаем автосохранение в отдельном потоке
            Task.Run(AutoSaveLoop);

            // Настройка TCP
            IPAddress ipAddr = IPAddress.Loopback;
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8080);

            Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(ipEndPoint);
                listener.Listen(10);
                Console.WriteLine($"Сервер запущен, порт: {ipEndPoint.Port}");
                Console.WriteLine("Ожидание подключений...\n");

                while (true)
                {
                    Socket socket = listener.Accept();
                    Console.WriteLine($"Подключился клиент: {socket.RemoteEndPoint}\n");
                    Task.Run(() => HandleClient(socket));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private static void HandleClient(Socket socket)
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[10240];
                    int bytesRec = socket.Receive(buffer);
                    if (bytesRec == 0) break;

                    string json = Encoding.UTF8.GetString(buffer, 0, bytesRec);
                    Console.WriteLine($"Получен запрос: {json}");

                    var request = JsonConvert.DeserializeObject<CarRequest>(json);
                    string jsonResponse = ProcessRequest(request);

                    byte[] responseBytes = Encoding.UTF8.GetBytes(jsonResponse);
                    socket.Send(responseBytes);
                    Console.WriteLine($"Отправлен ответ: {jsonResponse}\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

        private static string ProcessRequest(CarRequest request)
        {
            if (request == null)
            {
                var error = new { IsSuccess = false, ErrorMessage = "Некорректный запрос" };
                return JsonConvert.SerializeObject(error);
            }

            switch (request.Type)
            {
                case CarRequestType.Get:
                    if (_cars.TryGetValue(request.PtsNumber, out Car foundCar))
                    {
                        var success = new { IsSuccess = true, request.PtsNumber, Car = foundCar };
                        return JsonConvert.SerializeObject(success);
                    }
                    else
                    {
                        var error = new { IsSuccess = false, ErrorMessage = "Автомобиль не найден" };
                        return JsonConvert.SerializeObject(error);
                    }

                case CarRequestType.Add:
                    if (request.Car == null)
                        return JsonConvert.SerializeObject(new { IsSuccess = false, ErrorMessage = "Нет данных автомобиля" });

                    if (_cars.ContainsKey(request.Car.PtsNumber))
                    {
                        var error = new { IsSuccess = false, ErrorMessage = "Автомобиль с таким ПТС уже существует" };
                        return JsonConvert.SerializeObject(error);
                    }

                    _cars[request.Car.PtsNumber] = request.Car;
                    return JsonConvert.SerializeObject(new { IsSuccess = true,  request.Car.PtsNumber, request.Car });

                case CarRequestType.Update:
                    if (request.Car == null)
                        return JsonConvert.SerializeObject(new { IsSuccess = false, ErrorMessage = "Нет данных для обновления" });

                    if (_cars.ContainsKey(request.Car.PtsNumber))
                    {
                        _cars[request.Car.PtsNumber] = request.Car;
                        return JsonConvert.SerializeObject(new { IsSuccess = true, request.Car.PtsNumber, request.Car });
                    }
                    else
                    {
                        var error = new { IsSuccess = false, ErrorMessage = "Невозможно обновить, авто не найдено" };
                        return JsonConvert.SerializeObject(error);
                    }

                case CarRequestType.Remove:
                    if (_cars.TryRemove(request.PtsNumber, out _))
                    {
                        return JsonConvert.SerializeObject(new { IsSuccess = true, request.PtsNumber });
                    }
                    else
                    {
                        var error = new { IsSuccess = false, ErrorMessage = "Не удалось удалить авто" };
                        return JsonConvert.SerializeObject(error);
                    }

                default:
                    return JsonConvert.SerializeObject(new { IsSuccess = false, ErrorMessage = "Неизвестный тип запроса" });
            }
        }

        private static void AutoSaveLoop()
        {
            while (true)
            {
                Thread.Sleep(10000);
                SaveToFile();
            }
        }

        private static void SaveToFile()
        {
            try
            {
                lock (_fileLock)
                {
                    string json = JsonConvert.SerializeObject(_cars, Formatting.Indented);
                    File.WriteAllText(FilePath, json);
                }
                Console.WriteLine($"Сохранено в {FilePath} ({DateTime.Now:T})\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении: {ex.Message}\n");
            }
        }

        private static void LoadFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    var loaded = JsonConvert.DeserializeObject<ConcurrentDictionary<string, Car>>(json);
                    if (loaded != null)
                    {
                        foreach (var kv in loaded)
                            _cars.TryAdd(kv.Key, kv.Value);
                    }
                    Console.WriteLine($"Загружено автомобилей: {_cars.Count}");
                }
                else
                {
                    Console.WriteLine("Файл cars.json не был найден и автоматически создастся при сохранении");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки: {ex.Message}");
            }
        }
    }
}
