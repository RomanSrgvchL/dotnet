using lab11.dao;
using lab11.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab11
{
    public partial class MainForm : Form
    {
        private DepartmentDao departmentDao;
        private EmployeeDao employeeDao;
        public List<Department> departments;

        public MainForm()
        {
            InitializeComponent();
            InitializeDaos();
            AttachEventHandlers();
        }

        private void InitializeDaos()
        {
            try
            {
                departmentDao = new DepartmentDao();
                employeeDao = new EmployeeDao();
                departments = new List<Department>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к БД: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AttachEventHandlers()
        {
            // Обработчики для отделов
            loadDepartmentToolStripButton.Click += LoadAllData;
            addDepartmentToolStripButton.Click += AddDepartmentToolStripButton_Click;
            updateDepartmentToolStripButton.Click += UpdateDepartmentToolStripButton_Click;
            deleteDepartmentToolStripButton.Click += DeleteDepartmentToolStripButton_Click;

            // Обработчики для сотрудников
            loadEmployeeToolStripButton.Click += LoadAllData;
            addEmployeeToolStripButton.Click += AddEmployeeToolStripButton_Click;
            updateEmployeeToolStripButton.Click += UpdateEmployeeToolStripButton_Click;
            deleteEmployeeToolStripButton.Click += DeleteEmployeeToolStripButton_Click;

            // Обработчик выбора сотрудника для отображения фото
            employeesListView.SelectedIndexChanged += EmployeesListView_SelectedIndexChanged;
        }

        // Общий метод для загрузки всех данных
        private void LoadAllData(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmployees();
        }

        private void ClearPhoto()
        {
            pictureBox.Image = null;
            employeesListView.SelectedItems.Clear();
        }

        #region Методы для отделов

        private void LoadDepartments()
        {
            try
            {
                departmensListView.Items.Clear();
                departments = departmentDao.GetDepartments();

                foreach (var department in departments)
                {
                    var item = new ListViewItem(department.Id.ToString());
                    item.SubItems.Add(department.Name);
                    item.SubItems.Add(department.Location);
                    item.SubItems.Add(department.Budget.ToString("N0"));
                    item.SubItems.Add(department.DepartmentType.ToString());

                    item.Tag = department;
                    departmensListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки отделов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDepartmentToolStripButton_Click(object sender, EventArgs e)
        {
            var departmentForm = new DepartmentForm();
            if (departmentForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    departmentDao.Add(departmentForm.Department);
                    LoadDepartments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка добавления отдела: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateDepartmentToolStripButton_Click(object sender, EventArgs e)
        {
            if (departmensListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите отдел для обновления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedDepartment = (Department)departmensListView.SelectedItems[0].Tag;
            var departmentForm = new DepartmentForm(selectedDepartment);

            if (departmentForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    departmentDao.Update(departmentForm.Department);
                    LoadDepartments();
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления отдела: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteDepartmentToolStripButton_Click(object sender, EventArgs e)
        {
            if (departmensListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите отдел для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedDepartment = (Department)departmensListView.SelectedItems[0].Tag;

            try
            {
                departmentDao.Delete(selectedDepartment.Id);
                LoadDepartments();
                LoadEmployees();
                ClearPhoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления отдела: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Методы для сотрудников

        private void LoadEmployees()
        {
            try
            {
                employeesListView.Items.Clear();
                ClearPhoto();

                var employees = employeeDao.GetEmployees();

                foreach (var employee in employees)
                {
                    var item = new ListViewItem(employee.Id.ToString());
                    item.SubItems.Add(employee.FullName);
                    item.SubItems.Add(employee.DepartmentName);
                    item.SubItems.Add(employee.Position);

                    item.Tag = employee;
                    employeesListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployeeToolStripButton_Click(object sender, EventArgs e)
        {
            if (departments.Count == 0)
            {
                MessageBox.Show("Сначала создайте хотя бы один отдел", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var employeeForm = new EmployeeForm(null, departments);
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    employeeDao.Add(employeeForm.Employee);
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка добавления сотрудника: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateEmployeeToolStripButton_Click(object sender, EventArgs e)
        {
            if (employeesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedEmployee = (Employee)employeesListView.SelectedItems[0].Tag;
            var employeeForm = new EmployeeForm(selectedEmployee, departments);

            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    employeeDao.Update(employeeForm.Employee);
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обновления сотрудника: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteEmployeeToolStripButton_Click(object sender, EventArgs e)
        {
            if (employeesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedEmployee = (Employee)employeesListView.SelectedItems[0].Tag;

            try
            {
                employeeDao.Delete(selectedEmployee.Id);
                LoadEmployees();
                ClearPhoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления сотрудника: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeesListView.SelectedItems.Count > 0)
            {
                var selectedEmployee = (Employee)employeesListView.SelectedItems[0].Tag;
                if (selectedEmployee.Photo != null && selectedEmployee.Photo.Length > 0)
                {
                    try
                    {
                        using (var ms = new System.IO.MemoryStream(selectedEmployee.Photo))
                        {
                            var originalImage = Image.FromStream(ms);
                            pictureBox.Image = ResizeImageToFit(originalImage, pictureBox.Size);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки фото: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBox.Image = null;
                    }
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        // Метод для масштабирования изображения
        private Image ResizeImageToFit(Image image, Size containerSize)
        {
            if (image == null) return null;

            // Вычисляем соотношение сторон
            double ratioX = (double)containerSize.Width / image.Width;
            double ratioY = (double)containerSize.Height / image.Height;
            // Используем меньший коэффициент для сохранения пропорций
            double ratio = Math.Min(ratioX, ratioY);

            // Если изображение меньше контейнера, оставляем оригинальный размер
            if (ratio >= 1.0) return image;

            // Вычисляем новые размеры
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            // Создаем новое изображение с нужным размером
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        #endregion
    }
}