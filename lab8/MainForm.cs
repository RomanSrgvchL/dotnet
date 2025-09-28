using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab8
{
    public partial class MainForm : Form
    {
        private FileManager fileManager;

        public MainForm()
        {
            InitializeComponent();
            fileTextBox.Enabled = false;
            saveFileButton.Enabled = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    fileManager = new FileManager(openFileDialog.FileName);
                    fileManager.FileChangedExternally += OnFileChangedExternally;
                    fileTextBox.Text = fileManager.ReadFile();
                    fileTextBox.Enabled = true;
                    saveFileButton.Enabled = true;
                }
            }
            finally
            {
                openFileDialog.Dispose();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileManager != null)
                fileManager.WriteFile(fileTextBox.Text);
        }

        private void OnFileChangedExternally(string path)
        {
            // Обновление файла
            if (InvokeRequired)
            {
                Invoke(new Action(() => fileTextBox.Text = fileManager.ReadFile()));
            }
            else
            {
                fileTextBox.Text = fileManager.ReadFile();
            }
            MessageBox.Show("Файл был изменён другим процессом");
        }
    }
}
