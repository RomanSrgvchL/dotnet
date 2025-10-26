using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using CarClassLibrary;
using Newtonsoft.Json;

namespace lab10_client
{
    public partial class MainForm : Form
    {
        private const int SERVER_PORT = 8080;
        private Socket _socket;
        private readonly byte[] _buffer = new byte[10240];

        public MainForm()
        {
            InitializeComponent();
            InitializeFormData();
            ConnectToServer();
        }

        private void InitializeFormData()
        {
            brandComboBox.DataSource = Enum.GetValues(typeof(CarBrandType));
            carBodyTypeComboBox.DataSource = Enum.GetValues(typeof(CarBodyType));
            carColorTypeComboBox.DataSource = Enum.GetValues(typeof(CarColorType));
        }

        private void ConnectToServer()
        {
            try
            {
                IPAddress ipAddr = IPAddress.Loopback;
                IPEndPoint endPoint = new IPEndPoint(ipAddr, SERVER_PORT);

                _socket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect(endPoint);

                ShowStatus("Подключение установлено");
                SetButtonsEnabled(true);

                if (_socket.LocalEndPoint is IPEndPoint localEP)
                {
                    portLabel.Text = $"Порт клиента: {localEP.Port}";
                }
            }
            catch (Exception ex)
            {
                ShowStatus($"Ошибка подключения: {ex.Message}", false);
                SetButtonsEnabled(false);
            }
        }

        private void SetButtonsEnabled(bool enabled)
        {
            addButton.Enabled = enabled;
            updateButton.Enabled = enabled;
            findButton.Enabled = enabled;
            deleteButton.Enabled = enabled;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _socket?.Shutdown(SocketShutdown.Both);
                _socket?.Close();
            }
            catch { }
        }

        private Car CreateCarFromForm()
        {
            return new Car
            {
                PtsNumber = ptsNumberTextBox.Text.Trim(),
                CarBrandType = (CarBrandType)brandComboBox.SelectedItem,
                CarBodyType = (CarBodyType)carBodyTypeComboBox.SelectedItem,
                Year = (int)yearOfManufactureNumericUpDown.Value,
                CarColorType = (CarColorType)carColorTypeComboBox.SelectedItem
            };
        }

        private void ShowStatus(string message, bool success = true)
        {
            statusLabel.Text = message;
            statusLabel.ForeColor = success ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private string SendRequest(CarRequest request)
        {
            try
            {
                string json = JsonConvert.SerializeObject(request);
                byte[] msg = Encoding.UTF8.GetBytes(json);
                _socket.Send(msg);

                int bytesRec = _socket.Receive(_buffer);
                return Encoding.UTF8.GetString(_buffer, 0, bytesRec);
            }
            catch (Exception ex)
            {
                ShowStatus($"Ошибка при обмене данными: {ex.Message}", false);
                return null;
            }
        }

        private void FillFormWithCar(Car car)
        {
            if (car == null) return;
            ptsNumberTextBox.Text = car.PtsNumber;
            brandComboBox.SelectedItem = car.CarBrandType;
            carBodyTypeComboBox.SelectedItem = car.CarBodyType;
            carColorTypeComboBox.SelectedItem = car.CarColorType;
            yearOfManufactureNumericUpDown.Value = car.Year;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ptsNumberTextBox.Text))
            {
                ShowStatus("Введите номер ПТС для поиска", false);
                return;
            }

            var request = new CarRequest
            {
                Type = CarRequestType.Get,
                PtsNumber = ptsNumberTextBox.Text.Trim()
            };

            string responseJson = SendRequest(request);
            if (responseJson == null) return;

            dynamic response = JsonConvert.DeserializeObject(responseJson);
            if (response.IsSuccess == true)
            {
                Car foundCar = JsonConvert.DeserializeObject<Car>(response.Car.ToString());
                FillFormWithCar(foundCar);
                ShowStatus("Автомобиль найден");
            }
            else
            {
                ShowStatus((string)response.ErrorMessage, false);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var car = CreateCarFromForm();
            if (string.IsNullOrWhiteSpace(car.PtsNumber))
            {
                ShowStatus("Введите ПТС номер", false);
                return;
            }

            var request = new CarRequest
            {
                Type = CarRequestType.Add,
                Car = car
            };

            string responseJson = SendRequest(request);
            if (responseJson == null) return;

            dynamic response = JsonConvert.DeserializeObject(responseJson);
            ShowStatus(response.IsSuccess == true ? "Автомобиль добавлен" : (string)response.ErrorMessage, (bool)response.IsSuccess);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var car = CreateCarFromForm();
            if (string.IsNullOrWhiteSpace(car.PtsNumber))
            {
                ShowStatus("Введите ПТС номер", false);
                return;
            }

            var request = new CarRequest
            {
                Type = CarRequestType.Update,
                Car = car
            };

            string responseJson = SendRequest(request);
            if (responseJson == null) return;

            dynamic response = JsonConvert.DeserializeObject(responseJson);
            ShowStatus(response.IsSuccess == true ? "Данные обновлены" : (string)response.ErrorMessage, (bool)response.IsSuccess);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ptsNumberTextBox.Text))
            {
                ShowStatus("Введите номер ПТС для удаления", false);
                return;
            }

            var request = new CarRequest
            {
                Type = CarRequestType.Remove,
                PtsNumber = ptsNumberTextBox.Text.Trim()
            };

            string responseJson = SendRequest(request);
            if (responseJson == null) return;

            dynamic response = JsonConvert.DeserializeObject(responseJson);
            ShowStatus(response.IsSuccess == true ? "Автомобиль удалён" : (string)response.ErrorMessage, (bool)response.IsSuccess);
        }
    }
}
