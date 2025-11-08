using lab11.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab11
{
    public partial class EmployeeForm : Form
    {
        public Employee Employee { get; private set; }
        public List<Department> Departments { get; set; }

        private byte[] _originalPhoto; // сохраняем исходное фото
        private bool _photoChanged = false; // флаг изменения фото

        public EmployeeForm()
        {
            InitializeComponent();
            InitializeForm(new List<Department>(), null);
        }

        public EmployeeForm(Employee employee, List<Department> departments)
        {
            InitializeComponent();
            InitializeForm(departments, employee);
        }

        private void InitializeForm(List<Department> departments, Employee employee)
        {
            Employee = employee;
            Departments = departments;

            // Устанавливаем режим отображения фото
            photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Подписываемся на события кнопок
            saveEmployeeButton.Click += SaveEmployeeButton_Click;
            loadPhotoButton.Click += LoadPhotoButton_Click;

            // Загружаем данные
            LoadEmployeeData();

            if (employee != null)
            {
                _originalPhoto = employee.Photo;
            }
        }

        private void LoadEmployeeData()
        {
            // Заполняем ComboBox отделами
            departmentNameComboBox.DataSource = Departments;
            departmentNameComboBox.DisplayMember = "Name";
            departmentNameComboBox.ValueMember = "Id";

            if (Employee != null)
            {
                // Режим редактирования
                fullnameTextBox.Text = Employee.FullName;
                positionTextBox.Text = Employee.Position;

                var department = Departments.Find(d => d.Id == Employee.DepartmentId);
                if (department != null)
                {
                    departmentNameComboBox.SelectedItem = department;
                }
                else if (Departments.Count > 0)
                {
                    departmentNameComboBox.SelectedIndex = 0;
                }

                if (Employee.Photo != null)
                {
                    photoPictureBox.Image = ConvertByteArrayToImage(Employee.Photo);
                }

                Text = "Редактирование сотрудника";
            }
            else
            {
                Text = "Добавление сотрудника";
            }
        }

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveEmployeeData();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void LoadPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите фото сотрудника";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        photoPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        _photoChanged = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    // ПРОСТО КОНВЕРТИРУЕМ - Zoom сделает всё сам
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(fullnameTextBox.Text))
            {
                MessageBox.Show("Введите ФИО сотрудника", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                fullnameTextBox.Focus();
                return false;
            }

            if (fullnameTextBox.Text.Length > 100)
            {
                MessageBox.Show("ФИО не должно превышать 100 символов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                fullnameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(positionTextBox.Text))
            {
                MessageBox.Show("Введите должность", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                positionTextBox.Focus();
                return false;
            }

            if (positionTextBox.Text.Length > 50)
            {
                MessageBox.Show("Должность не должна превышать 50 символов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                positionTextBox.Focus();
                return false;
            }

            if (departmentNameComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите отдел", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                departmentNameComboBox.Focus();
                return false;
            }

            return true;
        }

        private void SaveEmployeeData()
        {
            byte[] photoBytes = null;

            // Определяем какие данные фото использовать
            if (_photoChanged && photoPictureBox.Image != null)
            {
                // конвертируем только если фото изменилось
                photoBytes = ConvertImageToByteArray(photoPictureBox.Image);
            }
            else if (!_photoChanged && Employee != null)
            {
                // если не менялось - берем оригинал
                photoBytes = _originalPhoto;
            }
            else if (photoPictureBox.Image != null)
            {
                // Новый сотрудник с фото (для случая добавления)
                photoBytes = ConvertImageToByteArray(photoPictureBox.Image);
            }

            if (Employee == null)
            {
                // Создаем нового сотрудника
                Employee = new Employee(
                    (int)departmentNameComboBox.SelectedValue,
                    fullnameTextBox.Text.Trim(),
                    positionTextBox.Text.Trim(),
                    photoBytes
                );
            }
            else
            {
                // Обновляем существующего
                Employee.DepartmentId = (int)departmentNameComboBox.SelectedValue;
                Employee.FullName = fullnameTextBox.Text.Trim();
                Employee.Position = positionTextBox.Text.Trim();
                Employee.Photo = photoBytes;
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения изображения: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}