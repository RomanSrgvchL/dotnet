namespace lab10_client
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ptsNumberLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.carBodyTypeLabel = new System.Windows.Forms.Label();
            this.yearOfManufactureLabel = new System.Windows.Forms.Label();
            this.carColorTypeLabel = new System.Windows.Forms.Label();
            this.ptsNumberTextBox = new System.Windows.Forms.TextBox();
            this.carBodyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfManufactureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.carColorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfManufactureNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(324, 326);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 39);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(463, 326);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 39);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(186, 326);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(103, 39);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(595, 326);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 39);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ptsNumberLabel
            // 
            this.ptsNumberLabel.AutoSize = true;
            this.ptsNumberLabel.Location = new System.Drawing.Point(199, 137);
            this.ptsNumberLabel.Name = "ptsNumberLabel";
            this.ptsNumberLabel.Size = new System.Drawing.Size(84, 16);
            this.ptsNumberLabel.TabIndex = 4;
            this.ptsNumberLabel.Text = "Номер ПТС:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(216, 171);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(52, 16);
            this.brandLabel.TabIndex = 5;
            this.brandLabel.Text = "Марка:";
            // 
            // carBodyTypeLabel
            // 
            this.carBodyTypeLabel.AutoSize = true;
            this.carBodyTypeLabel.Location = new System.Drawing.Point(198, 208);
            this.carBodyTypeLabel.Name = "carBodyTypeLabel";
            this.carBodyTypeLabel.Size = new System.Drawing.Size(85, 16);
            this.carBodyTypeLabel.TabIndex = 6;
            this.carBodyTypeLabel.Text = "Тип кузова:";
            // 
            // yearOfManufactureLabel
            // 
            this.yearOfManufactureLabel.AutoSize = true;
            this.yearOfManufactureLabel.Location = new System.Drawing.Point(198, 240);
            this.yearOfManufactureLabel.Name = "yearOfManufactureLabel";
            this.yearOfManufactureLabel.Size = new System.Drawing.Size(91, 16);
            this.yearOfManufactureLabel.TabIndex = 7;
            this.yearOfManufactureLabel.Text = "Год выпуска:";
            // 
            // carColorTypeLabel
            // 
            this.carColorTypeLabel.AutoSize = true;
            this.carColorTypeLabel.Location = new System.Drawing.Point(216, 269);
            this.carColorTypeLabel.Name = "carColorTypeLabel";
            this.carColorTypeLabel.Size = new System.Drawing.Size(42, 16);
            this.carColorTypeLabel.TabIndex = 8;
            this.carColorTypeLabel.Text = "Цвет:";
            // 
            // ptsNumberTextBox
            // 
            this.ptsNumberTextBox.Location = new System.Drawing.Point(306, 134);
            this.ptsNumberTextBox.MaxLength = 10;
            this.ptsNumberTextBox.Name = "ptsNumberTextBox";
            this.ptsNumberTextBox.Size = new System.Drawing.Size(121, 22);
            this.ptsNumberTextBox.TabIndex = 9;
            // 
            // carBodyTypeComboBox
            // 
            this.carBodyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBodyTypeComboBox.FormattingEnabled = true;
            this.carBodyTypeComboBox.Location = new System.Drawing.Point(306, 205);
            this.carBodyTypeComboBox.Name = "carBodyTypeComboBox";
            this.carBodyTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.carBodyTypeComboBox.TabIndex = 10;
            // 
            // yearOfManufactureNumericUpDown
            // 
            this.yearOfManufactureNumericUpDown.Location = new System.Drawing.Point(306, 238);
            this.yearOfManufactureNumericUpDown.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.yearOfManufactureNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearOfManufactureNumericUpDown.Name = "yearOfManufactureNumericUpDown";
            this.yearOfManufactureNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.yearOfManufactureNumericUpDown.TabIndex = 11;
            this.yearOfManufactureNumericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // brandComboBox
            // 
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(306, 168);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 24);
            this.brandComboBox.TabIndex = 12;
            // 
            // carColorTypeComboBox
            // 
            this.carColorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carColorTypeComboBox.FormattingEnabled = true;
            this.carColorTypeComboBox.Location = new System.Drawing.Point(306, 266);
            this.carColorTypeComboBox.Name = "carColorTypeComboBox";
            this.carColorTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.carColorTypeComboBox.TabIndex = 13;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(476, 137);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(398, 153);
            this.statusLabel.TabIndex = 15;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLabel.Location = new System.Drawing.Point(12, 9);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(0, 20);
            this.portLabel.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 499);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.carColorTypeComboBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.yearOfManufactureNumericUpDown);
            this.Controls.Add(this.carBodyTypeComboBox);
            this.Controls.Add(this.ptsNumberTextBox);
            this.Controls.Add(this.carColorTypeLabel);
            this.Controls.Add(this.yearOfManufactureLabel);
            this.Controls.Add(this.carBodyTypeLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.ptsNumberLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент для управления автомобилями";
            ((System.ComponentModel.ISupportInitialize)(this.yearOfManufactureNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label ptsNumberLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label carBodyTypeLabel;
        private System.Windows.Forms.Label yearOfManufactureLabel;
        private System.Windows.Forms.Label carColorTypeLabel;
        private System.Windows.Forms.TextBox ptsNumberTextBox;
        private System.Windows.Forms.ComboBox carBodyTypeComboBox;
        private System.Windows.Forms.NumericUpDown yearOfManufactureNumericUpDown;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox carColorTypeComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label portLabel;
    }
}

