using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class MainForm : Form
    {
        private string currentFilePath;
        private Encoding currentEncoding = Encoding.UTF8;

        public MainForm()
        {
            InitializeComponent();
            PopulateEncodings();
            UpdateFileNameLabel();
        }

        public class ComboItem
        {
            public string Text { get; set; }
            public int CodePage { get; set; }
            public override string ToString() => Text;
        }

        private void PopulateEncodings()
        {
            encodingComboBox.Items.Clear();

            encodingComboBox.Items.Add(new ComboItem { Text = "UTF-8", CodePage = Encoding.UTF8.CodePage });
            encodingComboBox.Items.Add(new ComboItem { Text = "UTF-16 LE", CodePage = Encoding.Unicode.CodePage });
            encodingComboBox.Items.Add(new ComboItem { Text = "UTF-16 BE", CodePage = Encoding.BigEndianUnicode.CodePage });
            encodingComboBox.Items.Add(new ComboItem { Text = "UTF-32", CodePage = Encoding.UTF32.CodePage });
            encodingComboBox.Items.Add(new ComboItem { Text = "ASCII", CodePage = Encoding.ASCII.CodePage });

            foreach (var ei in Encoding.GetEncodings().OrderBy(e => e.DisplayName))
            {
                if (ei.CodePage == Encoding.UTF8.CodePage ||
                    ei.CodePage == Encoding.Unicode.CodePage ||
                    ei.CodePage == Encoding.BigEndianUnicode.CodePage ||
                    ei.CodePage == Encoding.UTF32.CodePage ||
                    ei.CodePage == Encoding.ASCII.CodePage ||
                    ei.CodePage == Encoding.UTF7.CodePage)
                    continue;

                encodingComboBox.Items.Add(new ComboItem
                {
                    Text = $"{ei.DisplayName} ({ei.Name}) - {ei.CodePage}",
                    CodePage = ei.CodePage
                });
            }

            encodingComboBox.SelectedIndex = 0;
        }

        private void UpdateFileNameLabel()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                fileNameLabel.Text = "Файл не выбран";
                fileNameLabel.ForeColor = Color.Gray;
            }
            else
            {
                fileNameLabel.Text = currentFilePath;
                fileNameLabel.ForeColor = Color.Black;
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "C# files (*.cs)|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;

                    if (encodingComboBox.SelectedItem is ComboItem selectedItem)
                    {
                        currentEncoding = Encoding.GetEncoding(selectedItem.CodePage);
                    }

                    LoadFileWithEncoding(currentFilePath, currentEncoding);
                    UpdateFileNameLabel();
                }
            }
        }

        private void LoadFileWithEncoding(string filePath, Encoding encoding)
        {
            try
            {
                // Читаем сырые байты без анализа BOM
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // Принудительно декодируем их в выбранной кодировке
                string content = encoding.GetString(fileBytes);

                codeTextBox.Text = content;
                currentEncoding = encoding;

                constantsTextBox.Clear();
                literalsTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void encodingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (encodingComboBox.SelectedItem is ComboItem selectedItem)
            {
                try
                {
                    Encoding newEncoding = Encoding.GetEncoding(selectedItem.CodePage);

                    if (!string.IsNullOrEmpty(currentFilePath))
                    {
                        currentEncoding = newEncoding;
                        LoadFileWithEncoding(currentFilePath, currentEncoding);
                    }
                    else
                    {
                        currentEncoding = newEncoding;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки кодировки: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("Сначала откройте файл", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFile(currentFilePath);
        }

        private void SaveFileAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "C# files (*.cs)|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    SaveFile(currentFilePath);
                    UpdateFileNameLabel();
                }
            }
        }

        private void SaveFile(string filePath)
        {
            try
            {
                if (encodingComboBox.SelectedItem is ComboItem selectedItem)
                {
                    currentEncoding = Encoding.GetEncoding(selectedItem.CodePage);
                }

                using (var writer = new StreamWriter(filePath, false, currentEncoding))
                {
                    writer.Write(codeTextBox.Text);
                }

                MessageBox.Show($"Файл успешно сохранен в кодировке: {currentEncoding.EncodingName}!", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateFileNameLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Сначала откройте файл", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FindAllStringElements(codeTextBox.Text);
        }

        private void FindAllStringElements(string csharpCode)
        {
            FindStringConstants(csharpCode);
            FindStringLiterals(csharpCode);
        }

        private void FindStringConstants(string csharpCode)
        {
            string constPattern = @"const\s+string\s+([a-zA-Z_][a-zA-Z0-9_]*)\s*=\s*((?:(?:""(?:[^""\\]|\\.)*""|@""(?:[^""]*(?:""""[^""]*)*)"")(?:\s*\+\s*)?)+)\s*;";

            RegexOptions options = RegexOptions.Singleline;
            MatchCollection matches = Regex.Matches(csharpCode, constPattern, options);

            constantsTextBox.Clear();

            if (matches.Count == 0)
            {
                constantsTextBox.Text = "Строковые константы не найдены";
                return;
            }

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string constantName = match.Groups[1].Value;
                    string constantValue = match.Groups[2].Value.Trim();
                    result.AppendLine($"{constantName} = {constantValue}");
                    result.AppendLine();
                }
            }

            constantsTextBox.Text = result.ToString();
        }

        private void FindStringLiterals(string csharpCode)
        {
            string literalPattern = @"(""(?>[^""\\]|\\.)*""|@""(?>[^""]*(?:""""[^""]*)*)"")";

            RegexOptions options = RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline;
            MatchCollection matches = Regex.Matches(csharpCode, literalPattern, options);

            literalsTextBox.Clear();

            if (matches.Count == 0)
            {
                literalsTextBox.Text = "Строковые литералы не найдены";
                return;
            }

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    result.AppendLine(match.Value);
                    result.AppendLine();
                }
            }

            literalsTextBox.Text = result.ToString();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }
    }
}