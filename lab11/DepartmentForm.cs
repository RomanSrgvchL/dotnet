using lab11.model;
using System;
using System.Windows.Forms;

namespace lab11
{
    public partial class DepartmentForm : Form
    {
        public Department Department { get; private set; }

        public DepartmentForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public DepartmentForm(Department department) : this()
        {
            Department = department;
            LoadDepartmentData();
        }

        private void InitializeForm()
        {
            // Заполняем ComboBox типами отделов
            departmentTypeComboBox.DataSource = Enum.GetValues(typeof(DepartmentType));

            // Подписываемся на события
            saveDepartmentButton.Click += SaveDepartmentButton_Click;

            LoadDepartmentData();
        }

        private void LoadDepartmentData()
        {
            if (Department != null)
            {
                // Режим редактирования
                nameTextBox.Text = Department.Name;
                locationTextBox.Text = Department.Location;
                budgetNumericUpDown.Value = Department.Budget;
                departmentTypeComboBox.SelectedItem = Department.DepartmentType;
                this.Text = "Редактирование отдела";
            }
            else
            {
                budgetNumericUpDown.Value = 0;
                this.Text = "Добавление отдела";
            }
        }

        private void SaveDepartmentButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveDepartmentData();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Введите название отдела", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Focus();
                return false;
            }

            if (nameTextBox.Text.Length > 255)
            {
                MessageBox.Show("Название отдела не должно превышать 255 символов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                MessageBox.Show("Введите местоположение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                locationTextBox.Focus();
                return false;
            }

            if (locationTextBox.Text.Length > 200)
            {
                MessageBox.Show("Местоположение не должно превышать 200 символов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                locationTextBox.Focus();
                return false;
            }

            if (budgetNumericUpDown.Value < 0 || budgetNumericUpDown.Value > 100000000)
            {
                MessageBox.Show("Бюджет должен быть от 0 до 100 000 000", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                budgetNumericUpDown.Focus();
                return false;
            }

            if (departmentTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите специализацию отдела", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                departmentTypeComboBox.Focus();
                return false;
            }

            return true;
        }

        private void SaveDepartmentData()
        {
            if (Department == null)
            {
                // Создаем новый отдел
                Department = new Department(
                    name: nameTextBox.Text.Trim(),
                    location: locationTextBox.Text.Trim(),
                    budget: (int)budgetNumericUpDown.Value,
                    departmentType: (DepartmentType)departmentTypeComboBox.SelectedItem
                );
            }
            else
            {
                // Обновляем существующий отдел
                Department.Name = nameTextBox.Text.Trim();
                Department.Location = locationTextBox.Text.Trim();
                Department.Budget = (int)budgetNumericUpDown.Value;
                Department.DepartmentType = (DepartmentType)departmentTypeComboBox.SelectedItem;
            }
        }
    }
}