namespace MTM_Forms
{
    partial class RepairForm
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
            this.machineToolTypeLabel = new System.Windows.Forms.Label();
            this.repairTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.machineToolTypeComboBox = new System.Windows.Forms.ComboBox();
            this.repairTypeComboBox = new System.Windows.Forms.ComboBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machineToolTypeLabel
            // 
            this.machineToolTypeLabel.AutoSize = true;
            this.machineToolTypeLabel.Location = new System.Drawing.Point(90, 24);
            this.machineToolTypeLabel.Name = "machineToolTypeLabel";
            this.machineToolTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.machineToolTypeLabel.TabIndex = 0;
            this.machineToolTypeLabel.Text = "Тип станка:";
            // 
            // repairTypeLabel
            // 
            this.repairTypeLabel.AutoSize = true;
            this.repairTypeLabel.Location = new System.Drawing.Point(90, 75);
            this.repairTypeLabel.Name = "repairTypeLabel";
            this.repairTypeLabel.Size = new System.Drawing.Size(94, 16);
            this.repairTypeLabel.TabIndex = 1;
            this.repairTypeLabel.Text = "Тип ремонта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Примечания к записи:";
            // 
            // machineToolTypeComboBox
            // 
            this.machineToolTypeComboBox.FormattingEnabled = true;
            this.machineToolTypeComboBox.Location = new System.Drawing.Point(236, 21);
            this.machineToolTypeComboBox.Name = "machineToolTypeComboBox";
            this.machineToolTypeComboBox.Size = new System.Drawing.Size(295, 24);
            this.machineToolTypeComboBox.TabIndex = 3;
            // 
            // repairTypeComboBox
            // 
            this.repairTypeComboBox.FormattingEnabled = true;
            this.repairTypeComboBox.Location = new System.Drawing.Point(236, 72);
            this.repairTypeComboBox.Name = "repairTypeComboBox";
            this.repairTypeComboBox.Size = new System.Drawing.Size(295, 24);
            this.repairTypeComboBox.TabIndex = 4;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(270, 172);
            this.notesTextBox.MaxLength = 200;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(232, 22);
            this.notesTextBox.TabIndex = 5;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(65, 127);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(152, 16);
            this.startDateLabel.TabIndex = 6;
            this.startDateLabel.Text = "Дата начала ремонта:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(285, 122);
            this.startDateTimePicker.MaxDate = new System.DateTime(2027, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(442, 221);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 44);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RepairForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 277);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.repairTypeComboBox);
            this.Controls.Add(this.machineToolTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repairTypeLabel);
            this.Controls.Add(this.machineToolTypeLabel);
            this.Name = "RepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label machineToolTypeLabel;
        private System.Windows.Forms.Label repairTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox machineToolTypeComboBox;
        private System.Windows.Forms.ComboBox repairTypeComboBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button saveButton;
    }
}