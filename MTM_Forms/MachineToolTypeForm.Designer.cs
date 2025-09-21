namespace MTM_Forms
{
    partial class MachineToolTypeForm
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
            this.countryLabel = new System.Windows.Forms.Label();
            this.yearOfManufactureLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.yearOfManufactureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.warrayntyLabel = new System.Windows.Forms.Label();
            this.warrantyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfManufactureNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warrantyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(91, 66);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(163, 16);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "Страна производителя:";
            // 
            // yearOfManufactureLabel
            // 
            this.yearOfManufactureLabel.AutoSize = true;
            this.yearOfManufactureLabel.Location = new System.Drawing.Point(123, 112);
            this.yearOfManufactureLabel.Name = "yearOfManufactureLabel";
            this.yearOfManufactureLabel.Size = new System.Drawing.Size(91, 16);
            this.yearOfManufactureLabel.TabIndex = 1;
            this.yearOfManufactureLabel.Text = "Год выпуска:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(138, 165);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(52, 16);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Марка:";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(321, 281);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(164, 45);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(287, 63);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(121, 24);
            this.countryComboBox.TabIndex = 7;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(287, 165);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 24);
            this.brandComboBox.TabIndex = 8;
            // 
            // yearOfManufactureNumericUpDown
            // 
            this.yearOfManufactureNumericUpDown.Location = new System.Drawing.Point(288, 112);
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
            this.yearOfManufactureNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.yearOfManufactureNumericUpDown.TabIndex = 9;
            this.yearOfManufactureNumericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // warrayntyLabel
            // 
            this.warrayntyLabel.AutoSize = true;
            this.warrayntyLabel.Location = new System.Drawing.Point(100, 211);
            this.warrayntyLabel.Name = "warrayntyLabel";
            this.warrayntyLabel.Size = new System.Drawing.Size(146, 16);
            this.warrayntyLabel.TabIndex = 10;
            this.warrayntyLabel.Text = "Гарантия (в месяцах):";
            // 
            // warrantyNumericUpDown
            // 
            this.warrantyNumericUpDown.Location = new System.Drawing.Point(288, 211);
            this.warrantyNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.warrantyNumericUpDown.Name = "warrantyNumericUpDown";
            this.warrantyNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.warrantyNumericUpDown.TabIndex = 11;
            // 
            // MachineToolTypeForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 338);
            this.Controls.Add(this.warrantyNumericUpDown);
            this.Controls.Add(this.warrayntyLabel);
            this.Controls.Add(this.yearOfManufactureNumericUpDown);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.yearOfManufactureLabel);
            this.Controls.Add(this.countryLabel);
            this.Name = "MachineToolTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип станка";
            ((System.ComponentModel.ISupportInitialize)(this.yearOfManufactureNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warrantyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label yearOfManufactureLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.NumericUpDown yearOfManufactureNumericUpDown;
        private System.Windows.Forms.Label warrayntyLabel;
        private System.Windows.Forms.NumericUpDown warrantyNumericUpDown;
    }
}