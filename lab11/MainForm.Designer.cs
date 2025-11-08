namespace lab11
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.employeesTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.loadEmployeeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addEmployeeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.updateEmployeeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteEmployeeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeesListView = new System.Windows.Forms.ListView();
            this.employeeIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmentColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullnameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmensTabPage = new System.Windows.Forms.TabPage();
            this.departmensToolStrip = new System.Windows.Forms.ToolStrip();
            this.loadDepartmentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addDepartmentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.updateDepartmentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteDepartmentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.departmensListView = new System.Windows.Forms.ListView();
            this.departmentIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.budgetColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.employeesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.departmensTabPage.SuspendLayout();
            this.departmensToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.employeesTabPage);
            this.tabControl.Controls.Add(this.departmensTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1002, 507);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // employeesTabPage
            // 
            this.employeesTabPage.Controls.Add(this.pictureBox);
            this.employeesTabPage.Controls.Add(this.toolStrip);
            this.employeesTabPage.Controls.Add(this.employeesListView);
            this.employeesTabPage.Location = new System.Drawing.Point(4, 29);
            this.employeesTabPage.Name = "employeesTabPage";
            this.employeesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTabPage.Size = new System.Drawing.Size(994, 474);
            this.employeesTabPage.TabIndex = 0;
            this.employeesTabPage.Text = "Сотрудники";
            this.employeesTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(591, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(328, 395);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadEmployeeToolStripButton,
            this.addEmployeeToolStripButton,
            this.updateEmployeeToolStripButton,
            this.deleteEmployeeToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(580, 16);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(329, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "employeersToolStrip";
            // 
            // loadEmployeeToolStripButton
            // 
            this.loadEmployeeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadEmployeeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("loadEmployeeToolStripButton.Image")));
            this.loadEmployeeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadEmployeeToolStripButton.Name = "loadEmployeeToolStripButton";
            this.loadEmployeeToolStripButton.Size = new System.Drawing.Size(81, 24);
            this.loadEmployeeToolStripButton.Text = "Загрузить";
            // 
            // addEmployeeToolStripButton
            // 
            this.addEmployeeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addEmployeeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addEmployeeToolStripButton.Image")));
            this.addEmployeeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEmployeeToolStripButton.Name = "addEmployeeToolStripButton";
            this.addEmployeeToolStripButton.Size = new System.Drawing.Size(84, 24);
            this.addEmployeeToolStripButton.Text = " Добавить";
            // 
            // updateEmployeeToolStripButton
            // 
            this.updateEmployeeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateEmployeeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateEmployeeToolStripButton.Image")));
            this.updateEmployeeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateEmployeeToolStripButton.Name = "updateEmployeeToolStripButton";
            this.updateEmployeeToolStripButton.Size = new System.Drawing.Size(82, 24);
            this.updateEmployeeToolStripButton.Text = "Обновить";
            // 
            // deleteEmployeeToolStripButton
            // 
            this.deleteEmployeeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteEmployeeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmployeeToolStripButton.Image")));
            this.deleteEmployeeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteEmployeeToolStripButton.Name = "deleteEmployeeToolStripButton";
            this.deleteEmployeeToolStripButton.Size = new System.Drawing.Size(69, 24);
            this.deleteEmployeeToolStripButton.Text = "Удалить";
            // 
            // employeesListView
            // 
            this.employeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIdColumnHeader,
            this.fullnameColumnHeader,
            this.departmentColumnHeader,
            this.positionColumnHeader});
            this.employeesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.employeesListView.FullRowSelect = true;
            this.employeesListView.GridLines = true;
            this.employeesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.employeesListView.HideSelection = false;
            this.employeesListView.Location = new System.Drawing.Point(3, 3);
            this.employeesListView.MultiSelect = false;
            this.employeesListView.Name = "employeesListView";
            this.employeesListView.Size = new System.Drawing.Size(516, 468);
            this.employeesListView.TabIndex = 0;
            this.employeesListView.UseCompatibleStateImageBehavior = false;
            this.employeesListView.View = System.Windows.Forms.View.Details;
            // 
            // employeeIdColumnHeader
            // 
            this.employeeIdColumnHeader.Tag = "1";
            this.employeeIdColumnHeader.Text = "ID";
            this.employeeIdColumnHeader.Width = 40;
            // 
            // departmentColumnHeader
            // 
            this.departmentColumnHeader.Tag = "3";
            this.departmentColumnHeader.Text = "Отдел";
            this.departmentColumnHeader.Width = 150;
            // 
            // fullnameColumnHeader
            // 
            this.fullnameColumnHeader.Tag = "2";
            this.fullnameColumnHeader.Text = "ФИО";
            this.fullnameColumnHeader.Width = 200;
            // 
            // positionColumnHeader
            // 
            this.positionColumnHeader.Tag = "4";
            this.positionColumnHeader.Text = "Должность";
            this.positionColumnHeader.Width = 200;
            // 
            // departmensTabPage
            // 
            this.departmensTabPage.Controls.Add(this.departmensToolStrip);
            this.departmensTabPage.Controls.Add(this.departmensListView);
            this.departmensTabPage.Location = new System.Drawing.Point(4, 29);
            this.departmensTabPage.Name = "departmensTabPage";
            this.departmensTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departmensTabPage.Size = new System.Drawing.Size(994, 474);
            this.departmensTabPage.TabIndex = 1;
            this.departmensTabPage.Text = "Отделы";
            this.departmensTabPage.UseVisualStyleBackColor = true;
            // 
            // departmensToolStrip
            // 
            this.departmensToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.departmensToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDepartmentToolStripButton,
            this.addDepartmentToolStripButton,
            this.updateDepartmentToolStripButton,
            this.deleteDepartmentToolStripButton});
            this.departmensToolStrip.Location = new System.Drawing.Point(3, 3);
            this.departmensToolStrip.Name = "departmensToolStrip";
            this.departmensToolStrip.Size = new System.Drawing.Size(988, 27);
            this.departmensToolStrip.TabIndex = 2;
            this.departmensToolStrip.Text = "departmentToolStrip";
            // 
            // loadDepartmentToolStripButton
            // 
            this.loadDepartmentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadDepartmentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("loadDepartmentToolStripButton.Image")));
            this.loadDepartmentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadDepartmentToolStripButton.Name = "loadDepartmentToolStripButton";
            this.loadDepartmentToolStripButton.Size = new System.Drawing.Size(81, 24);
            this.loadDepartmentToolStripButton.Text = "Загрузить";
            // 
            // addDepartmentToolStripButton
            // 
            this.addDepartmentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addDepartmentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addDepartmentToolStripButton.Image")));
            this.addDepartmentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDepartmentToolStripButton.Name = "addDepartmentToolStripButton";
            this.addDepartmentToolStripButton.Size = new System.Drawing.Size(84, 24);
            this.addDepartmentToolStripButton.Text = " Добавить";
            // 
            // updateDepartmentToolStripButton
            // 
            this.updateDepartmentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.updateDepartmentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updateDepartmentToolStripButton.Image")));
            this.updateDepartmentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateDepartmentToolStripButton.Name = "updateDepartmentToolStripButton";
            this.updateDepartmentToolStripButton.Size = new System.Drawing.Size(82, 24);
            this.updateDepartmentToolStripButton.Text = "Обновить";
            // 
            // deleteDepartmentToolStripButton
            // 
            this.deleteDepartmentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteDepartmentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteDepartmentToolStripButton.Image")));
            this.deleteDepartmentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteDepartmentToolStripButton.Name = "deleteDepartmentToolStripButton";
            this.deleteDepartmentToolStripButton.Size = new System.Drawing.Size(69, 24);
            this.deleteDepartmentToolStripButton.Text = "Удалить";
            // 
            // departmensListView
            // 
            this.departmensListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.departmentIdColumnHeader,
            this.nameColumnHeader,
            this.locationColumnHeader,
            this.budgetColumnHeader,
            this.typeColumnHeader});
            this.departmensListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.departmensListView.FullRowSelect = true;
            this.departmensListView.GridLines = true;
            this.departmensListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.departmensListView.HideSelection = false;
            this.departmensListView.Location = new System.Drawing.Point(3, 43);
            this.departmensListView.MultiSelect = false;
            this.departmensListView.Name = "departmensListView";
            this.departmensListView.Size = new System.Drawing.Size(988, 428);
            this.departmensListView.TabIndex = 1;
            this.departmensListView.UseCompatibleStateImageBehavior = false;
            this.departmensListView.View = System.Windows.Forms.View.Details;
            // 
            // departmentIdColumnHeader
            // 
            this.departmentIdColumnHeader.Tag = "1";
            this.departmentIdColumnHeader.Text = "ID";
            this.departmentIdColumnHeader.Width = 40;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Tag = "2";
            this.nameColumnHeader.Text = "Название";
            this.nameColumnHeader.Width = 150;
            // 
            // locationColumnHeader
            // 
            this.locationColumnHeader.Tag = "3";
            this.locationColumnHeader.Text = "Адрес";
            this.locationColumnHeader.Width = 150;
            // 
            // budgetColumnHeader
            // 
            this.budgetColumnHeader.Tag = "4";
            this.budgetColumnHeader.Text = "Бюджет";
            this.budgetColumnHeader.Width = 150;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Специализация";
            this.typeColumnHeader.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 507);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №11";
            this.tabControl.ResumeLayout(false);
            this.employeesTabPage.ResumeLayout(false);
            this.employeesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.departmensTabPage.ResumeLayout(false);
            this.departmensTabPage.PerformLayout();
            this.departmensToolStrip.ResumeLayout(false);
            this.departmensToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage employeesTabPage;
        private System.Windows.Forms.TabPage departmensTabPage;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton loadEmployeeToolStripButton;
        private System.Windows.Forms.ToolStripButton addEmployeeToolStripButton;
        private System.Windows.Forms.ToolStripButton updateEmployeeToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteEmployeeToolStripButton;
        private System.Windows.Forms.ListView employeesListView;
        private System.Windows.Forms.ColumnHeader employeeIdColumnHeader;
        private System.Windows.Forms.ColumnHeader departmentColumnHeader;
        private System.Windows.Forms.ColumnHeader fullnameColumnHeader;
        private System.Windows.Forms.ColumnHeader positionColumnHeader;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView departmensListView;
        private System.Windows.Forms.ColumnHeader departmentIdColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader locationColumnHeader;
        private System.Windows.Forms.ColumnHeader budgetColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ToolStrip departmensToolStrip;
        private System.Windows.Forms.ToolStripButton loadDepartmentToolStripButton;
        private System.Windows.Forms.ToolStripButton addDepartmentToolStripButton;
        private System.Windows.Forms.ToolStripButton updateDepartmentToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteDepartmentToolStripButton;
    }
}