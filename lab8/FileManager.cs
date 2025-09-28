using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab8
{
    public class FileManager
    {
        public string FilePath { get; private set; }
        private FileSystemWatcher watcher;
        private bool SelfChange = false;
        private Timer debounceTimer;

        public event Action<string> FileChangedExternally;

        public FileManager(string filePath)
        {
            FilePath = filePath;
            SetupWatcher();
        }

        private void SetupWatcher()
        {
            watcher = new FileSystemWatcher(Path.GetDirectoryName(FilePath), Path.GetFileName(FilePath));
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
            watcher.Changed += OnChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            // игнорируем свои изменения
            if (SelfChange) return;

            // таймер обновляется при каждом новом событии
            debounceTimer?.Dispose();
            debounceTimer = new Timer(_ =>
            {
                try
                {
                    FileChangedExternally?.Invoke(FilePath);
                }
                catch (IOException)
                {
                    // если файл занят, пробуем ещё раз
                    Task.Delay(400).ContinueWith(__ =>
                    {
                        try 
                        { 
                            FileChangedExternally?.Invoke(FilePath); 
                        }
                        catch
                        { 
                            /* если не получилось, игнорируем */ 
                        }
                    });
                }
            }, null, 500, Timeout.Infinite);
        }

        public string ReadFile()
        {
            return File.ReadAllText(FilePath);
        }

        public void WriteFile(string content)
        {
            SelfChange = true;
            File.WriteAllText(FilePath, content);
            Task.Delay(300).ContinueWith(_ => SelfChange = false);
        }
    }
}
