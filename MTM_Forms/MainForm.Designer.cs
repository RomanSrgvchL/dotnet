using System.Windows.Forms;

namespace MTM_Forms
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
            this.machineToolTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMachineToolTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMachineToolTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRepairTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRepairTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.machineToolTypeTabPage = new System.Windows.Forms.TabPage();
            this.machineToolTypeListView = new System.Windows.Forms.ListView();
            this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearOfManufactureColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brandColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.warrantyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairTypeTabPage = new System.Windows.Forms.TabPage();
            this.repairTypeListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairTypeNotesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairTabPage = new System.Windows.Forms.TabPage();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.machineToolTypeTabPage.SuspendLayout();
            this.repairTypeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // machineToolTypeToolStripMenuItem
            // 
            this.machineToolTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMachineToolTypeToolStripMenuItem,
            this.editMachineToolTypeToolStripMenuItem});
            this.machineToolTypeToolStripMenuItem.Name = "machineToolTypeToolStripMenuItem";
            this.machineToolTypeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.machineToolTypeToolStripMenuItem.Text = "Тип станка";
            // 
            // addMachineToolTypeToolStripMenuItem
            // 
            this.addMachineToolTypeToolStripMenuItem.Name = "addMachineToolTypeToolStripMenuItem";
            this.addMachineToolTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addMachineToolTypeToolStripMenuItem.Text = "Добавить";
            this.addMachineToolTypeToolStripMenuItem.Click += new System.EventHandler(this.addMachineToolTypeToolStripMenuItem_Click);
            // 
            // editMachineToolTypeToolStripMenuItem
            // 
            this.editMachineToolTypeToolStripMenuItem.Name = "editMachineToolTypeToolStripMenuItem";
            this.editMachineToolTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editMachineToolTypeToolStripMenuItem.Text = "Редактировать";
            this.editMachineToolTypeToolStripMenuItem.Click += new System.EventHandler(this.editMachineToolTypeToolStripMenuItem_Click);
            // 
            // repairTypeToolStripMenuItem
            // 
            this.repairTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRepairTypeToolStripMenuItem,
            this.editRepairTypeToolStripMenuItem});
            this.repairTypeToolStripMenuItem.Name = "repairTypeToolStripMenuItem";
            this.repairTypeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.repairTypeToolStripMenuItem.Text = "Тип ремонта";
            // 
            // addRepairTypeToolStripMenuItem
            // 
            this.addRepairTypeToolStripMenuItem.Name = "addRepairTypeToolStripMenuItem";
            this.addRepairTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addRepairTypeToolStripMenuItem.Text = "Добавить";
            this.addRepairTypeToolStripMenuItem.Click += new System.EventHandler(this.addRepairTypeToolStripMenuItem_Click);
            // 
            // editRepairTypeToolStripMenuItem
            // 
            this.editRepairTypeToolStripMenuItem.Name = "editRepairTypeToolStripMenuItem";
            this.editRepairTypeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editRepairTypeToolStripMenuItem.Text = "Редактировать";
            this.editRepairTypeToolStripMenuItem.Click += new System.EventHandler(this.editRepairTypeToolStripMenuItem_Click);
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRepairToolStripMenuItem,
            this.editRepairToolStripMenuItem});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.repairToolStripMenuItem.Text = "Ремонты";
            // 
            // addRepairToolStripMenuItem
            // 
            this.addRepairToolStripMenuItem.Name = "addRepairToolStripMenuItem";
            this.addRepairToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.addRepairToolStripMenuItem.Text = "Добавить";
            this.addRepairToolStripMenuItem.Click += new System.EventHandler(this.addRepairToolStripMenuItem_Click);
            // 
            // editRepairToolStripMenuItem
            // 
            this.editRepairToolStripMenuItem.Name = "editRepairToolStripMenuItem";
            this.editRepairToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.editRepairToolStripMenuItem.Text = "Редактировать";
            this.editRepairToolStripMenuItem.Click += new System.EventHandler(this.editRepairToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.machineToolTypeToolStripMenuItem,
            this.repairTypeToolStripMenuItem,
            this.repairToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(905, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveXMLToolStripMenuItem,
            this.saveJSONToolStripMenuItem,
            this.saveBinaryToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveXMLToolStripMenuItem.Text = "XML";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // saveJSONToolStripMenuItem
            // 
            this.saveJSONToolStripMenuItem.Name = "saveJSONToolStripMenuItem";
            this.saveJSONToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveJSONToolStripMenuItem.Text = "JSON";
            this.saveJSONToolStripMenuItem.Click += new System.EventHandler(this.saveJSONToolStripMenuItem_Click);
            // 
            // saveBinaryToolStripMenuItem
            // 
            this.saveBinaryToolStripMenuItem.Name = "saveBinaryToolStripMenuItem";
            this.saveBinaryToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveBinaryToolStripMenuItem.Text = "Двоичный";
            this.saveBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveBinaryToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLToolStripMenuItem,
            this.loadJSONToolStripMenuItem,
            this.loadBinaryToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.loadToolStripMenuItem.Text = "Загрузить";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.loadXMLToolStripMenuItem.Text = "XML";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // loadJSONToolStripMenuItem
            // 
            this.loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
            this.loadJSONToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.loadJSONToolStripMenuItem.Text = "JSON";
            this.loadJSONToolStripMenuItem.Click += new System.EventHandler(this.loadJSONToolStripMenuItem_Click);
            // 
            // loadBinaryToolStripMenuItem
            // 
            this.loadBinaryToolStripMenuItem.Name = "loadBinaryToolStripMenuItem";
            this.loadBinaryToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.loadBinaryToolStripMenuItem.Text = "Двоичный";
            this.loadBinaryToolStripMenuItem.Click += new System.EventHandler(this.loadBinaryToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.machineToolTypeTabPage);
            this.tabControl.Controls.Add(this.repairTypeTabPage);
            this.tabControl.Controls.Add(this.repairTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(905, 378);
            this.tabControl.TabIndex = 2;
            // 
            // machineToolTypeTabPage
            // 
            this.machineToolTypeTabPage.Controls.Add(this.machineToolTypeListView);
            this.machineToolTypeTabPage.Location = new System.Drawing.Point(4, 25);
            this.machineToolTypeTabPage.Name = "machineToolTypeTabPage";
            this.machineToolTypeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.machineToolTypeTabPage.Size = new System.Drawing.Size(897, 349);
            this.machineToolTypeTabPage.TabIndex = 0;
            this.machineToolTypeTabPage.Text = "Тип станка";
            this.machineToolTypeTabPage.UseVisualStyleBackColor = true;
            // 
            // machineToolTypeListView
            // 
            this.machineToolTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.countryColumnHeader,
            this.yearOfManufactureColumnHeader2,
            this.brandColumnHeader,
            this.warrantyColumnHeader});
            this.machineToolTypeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineToolTypeListView.FullRowSelect = true;
            this.machineToolTypeListView.GridLines = true;
            this.machineToolTypeListView.HideSelection = false;
            this.machineToolTypeListView.Location = new System.Drawing.Point(3, 3);
            this.machineToolTypeListView.Name = "machineToolTypeListView";
            this.machineToolTypeListView.Size = new System.Drawing.Size(891, 343);
            this.machineToolTypeListView.TabIndex = 1;
            this.machineToolTypeListView.UseCompatibleStateImageBehavior = false;
            this.machineToolTypeListView.View = System.Windows.Forms.View.Details;
            this.machineToolTypeListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.machineToolTypeListView_KeyUp);
            // 
            // IdColumnHeader
            // 
            this.IdColumnHeader.Text = "ID";
            this.IdColumnHeader.Width = 50;
            // 
            // countryColumnHeader
            // 
            this.countryColumnHeader.Text = "Страна производителя";
            this.countryColumnHeader.Width = 150;
            // 
            // yearOfManufactureColumnHeader2
            // 
            this.yearOfManufactureColumnHeader2.Text = "Год выпуска";
            this.yearOfManufactureColumnHeader2.Width = 100;
            // 
            // brandColumnHeader
            // 
            this.brandColumnHeader.Text = "Марка";
            this.brandColumnHeader.Width = 150;
            // 
            // warrantyColumnHeader
            // 
            this.warrantyColumnHeader.Text = "Срок гарантии (в месяцах)";
            this.warrantyColumnHeader.Width = 200;
            // 
            // repairTypeTabPage
            // 
            this.repairTypeTabPage.Controls.Add(this.repairTypeListView);
            this.repairTypeTabPage.Location = new System.Drawing.Point(4, 25);
            this.repairTypeTabPage.Name = "repairTypeTabPage";
            this.repairTypeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.repairTypeTabPage.Size = new System.Drawing.Size(897, 349);
            this.repairTypeTabPage.TabIndex = 1;
            this.repairTypeTabPage.Text = "Тип ремонта";
            this.repairTypeTabPage.UseVisualStyleBackColor = true;
            // 
            // repairTypeListView
            // 
            this.repairTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.durationColumnHeader,
            this.costColumnHeader,
            this.repairTypeNotesColumnHeader});
            this.repairTypeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairTypeListView.FullRowSelect = true;
            this.repairTypeListView.GridLines = true;
            this.repairTypeListView.HideSelection = false;
            this.repairTypeListView.Location = new System.Drawing.Point(3, 3);
            this.repairTypeListView.Name = "repairTypeListView";
            this.repairTypeListView.Size = new System.Drawing.Size(891, 343);
            this.repairTypeListView.TabIndex = 0;
            this.repairTypeListView.UseCompatibleStateImageBehavior = false;
            this.repairTypeListView.View = System.Windows.Forms.View.Details;
            this.repairTypeListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.repairTypeListView_KeyUp);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Название ремонта";
            this.nameColumnHeader.Width = 200;
            // 
            // durationColumnHeader
            // 
            this.durationColumnHeader.Text = "Продолжительность";
            this.durationColumnHeader.Width = 150;
            // 
            // costColumnHeader
            // 
            this.costColumnHeader.Text = "Стоимость (руб)";
            this.costColumnHeader.Width = 100;
            // 
            // repairTypeNotesColumnHeader
            // 
            this.repairTypeNotesColumnHeader.Text = "Примечания";
            this.repairTypeNotesColumnHeader.Width = 150;
            // 
            // repairTabPage
            // 
            this.repairTabPage.AutoScroll = true;
            this.repairTabPage.Location = new System.Drawing.Point(4, 25);
            this.repairTabPage.Name = "repairTabPage";
            this.repairTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.repairTabPage.Size = new System.Drawing.Size(897, 349);
            this.repairTabPage.TabIndex = 2;
            this.repairTabPage.Text = "Ремонты";
            this.repairTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 406);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техническое обслуживание станков";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.machineToolTypeTabPage.ResumeLayout(false);
            this.repairTypeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem machineToolTypeToolStripMenuItem;
        private ToolStripMenuItem addMachineToolTypeToolStripMenuItem;
        private ToolStripMenuItem editMachineToolTypeToolStripMenuItem;
        private ToolStripMenuItem repairTypeToolStripMenuItem;
        private ToolStripMenuItem addRepairTypeToolStripMenuItem;
        private ToolStripMenuItem editRepairTypeToolStripMenuItem;
        private ToolStripMenuItem repairToolStripMenuItem;
        private ToolStripMenuItem addRepairToolStripMenuItem;
        private ToolStripMenuItem editRepairToolStripMenuItem;
        private MenuStrip menuStrip;
        private TabControl tabControl;
        private TabPage machineToolTypeTabPage;
        private TabPage repairTypeTabPage;
        private ListView machineToolTypeListView;
        private TabPage repairTabPage;
        private ListView repairTypeListView;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader IdColumnHeader;
        private ColumnHeader countryColumnHeader;
        private ColumnHeader yearOfManufactureColumnHeader2;
        private ColumnHeader brandColumnHeader;
        private ColumnHeader warrantyColumnHeader;
        private ColumnHeader costColumnHeader;
        private ColumnHeader repairTypeNotesColumnHeader;
        private ColumnHeader durationColumnHeader;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveXMLToolStripMenuItem;
        private ToolStripMenuItem saveJSONToolStripMenuItem;
        private ToolStripMenuItem saveBinaryToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem loadXMLToolStripMenuItem;
        private ToolStripMenuItem loadJSONToolStripMenuItem;
        private ToolStripMenuItem loadBinaryToolStripMenuItem;
        private OpenFileDialog openFileDialogMain;
        private SaveFileDialog saveFileDialogMain;
    }
}