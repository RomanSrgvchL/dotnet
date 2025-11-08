namespace lab11
{
    partial class EmployeeForm
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
            this.departmentNameComboBox = new System.Windows.Forms.ComboBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.deparmentNameLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveEmployeeButton = new System.Windows.Forms.Button();
            this.loadPhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentNameComboBox
            // 
            this.departmentNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentNameComboBox.FormattingEnabled = true;
            this.departmentNameComboBox.Location = new System.Drawing.Point(146, 82);
            this.departmentNameComboBox.Name = "departmentNameComboBox";
            this.departmentNameComboBox.Size = new System.Drawing.Size(225, 24);
            this.departmentNameComboBox.TabIndex = 0;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(146, 32);
            this.fullnameTextBox.MaxLength = 100;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(225, 22);
            this.fullnameTextBox.TabIndex = 1;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(146, 138);
            this.positionTextBox.MaxLength = 50;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(225, 22);
            this.positionTextBox.TabIndex = 2;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(403, 28);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(125, 128);
            this.photoPictureBox.TabIndex = 3;
            this.photoPictureBox.TabStop = false;
            // 
            // deparmentNameLabel
            // 
            this.deparmentNameLabel.AutoSize = true;
            this.deparmentNameLabel.Location = new System.Drawing.Point(12, 90);
            this.deparmentNameLabel.Name = "deparmentNameLabel";
            this.deparmentNameLabel.Size = new System.Drawing.Size(126, 16);
            this.deparmentNameLabel.TabIndex = 4;
            this.deparmentNameLabel.Text = "Название отдела:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(50, 38);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(41, 16);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "ФИО:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(32, 141);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 16);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Должность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Фото:";
            // 
            // saveEmployeeButton
            // 
            this.saveEmployeeButton.Location = new System.Drawing.Point(146, 196);
            this.saveEmployeeButton.Name = "saveEmployeeButton";
            this.saveEmployeeButton.Size = new System.Drawing.Size(125, 23);
            this.saveEmployeeButton.TabIndex = 8;
            this.saveEmployeeButton.Text = "Сохранить";
            this.saveEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // loadPhotoButton
            // 
            this.loadPhotoButton.Location = new System.Drawing.Point(389, 196);
            this.loadPhotoButton.Name = "loadPhotoButton";
            this.loadPhotoButton.Size = new System.Drawing.Size(139, 23);
            this.loadPhotoButton.TabIndex = 9;
            this.loadPhotoButton.Text = "Загрузить фото";
            this.loadPhotoButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 231);
            this.Controls.Add(this.loadPhotoButton);
            this.Controls.Add(this.saveEmployeeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.deparmentNameLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.departmentNameComboBox);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentNameComboBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label deparmentNameLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveEmployeeButton;
        private System.Windows.Forms.Button loadPhotoButton;
    }
}