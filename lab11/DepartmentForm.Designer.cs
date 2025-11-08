namespace lab11
{
    partial class DepartmentForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.budgetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.departmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveDepartmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.budgetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(190, 24);
            this.nameTextBox.MaxLength = 255;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(307, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(190, 71);
            this.locationTextBox.MaxLength = 200;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(307, 22);
            this.locationTextBox.TabIndex = 1;
            // 
            // budgetNumericUpDown
            // 
            this.budgetNumericUpDown.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.budgetNumericUpDown.Location = new System.Drawing.Point(190, 120);
            this.budgetNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.budgetNumericUpDown.Name = "budgetNumericUpDown";
            this.budgetNumericUpDown.Size = new System.Drawing.Size(125, 22);
            this.budgetNumericUpDown.TabIndex = 2;
            // 
            // departmentTypeComboBox
            // 
            this.departmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentTypeComboBox.FormattingEnabled = true;
            this.departmentTypeComboBox.Location = new System.Drawing.Point(190, 163);
            this.departmentTypeComboBox.Name = "departmentTypeComboBox";
            this.departmentTypeComboBox.Size = new System.Drawing.Size(307, 24);
            this.departmentTypeComboBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(47, 77);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(124, 16);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Местоположение:";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(70, 126);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(61, 16);
            this.budgetLabel.TabIndex = 6;
            this.budgetLabel.Text = "Бюджет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Специализация:";
            // 
            // saveDepartmentButton
            // 
            this.saveDepartmentButton.Location = new System.Drawing.Point(190, 220);
            this.saveDepartmentButton.Name = "saveDepartmentButton";
            this.saveDepartmentButton.Size = new System.Drawing.Size(134, 23);
            this.saveDepartmentButton.TabIndex = 8;
            this.saveDepartmentButton.Text = "Сохранить";
            this.saveDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 255);
            this.Controls.Add(this.saveDepartmentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.departmentTypeComboBox);
            this.Controls.Add(this.budgetNumericUpDown);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел";
            ((System.ComponentModel.ISupportInitialize)(this.budgetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.NumericUpDown budgetNumericUpDown;
        private System.Windows.Forms.ComboBox departmentTypeComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveDepartmentButton;
    }
}