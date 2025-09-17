namespace MTM_Forms
{
    partial class RepairTypeForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(135, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название ремонта:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(12, 134);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(203, 16);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Text = "Продолжительность ремонта:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(50, 218);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(174, 16);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "Стоимость ремонта (руб):";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(64, 272);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(150, 16);
            this.notesLabel.TabIndex = 0;
            this.notesLabel.Text = "Примечания к станку:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(242, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(269, 266);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(138, 22);
            this.notesTextBox.TabIndex = 1;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(269, 216);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(138, 22);
            this.costNumericUpDown.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(350, 318);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 42);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(306, 104);
            this.daysNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.daysNumericUpDown.TabIndex = 4;
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Location = new System.Drawing.Point(306, 132);
            this.hoursNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.hoursNumericUpDown.TabIndex = 5;
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Location = new System.Drawing.Point(306, 160);
            this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.minutesNumericUpDown.TabIndex = 6;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(230, 110);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(35, 16);
            this.daysLabel.TabIndex = 7;
            this.daysLabel.Text = "Дни:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(230, 138);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(43, 16);
            this.hoursLabel.TabIndex = 8;
            this.hoursLabel.Text = "Часы:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(230, 166);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(61, 16);
            this.minutesLabel.TabIndex = 9;
            this.minutesLabel.Text = "Минуты:";
            // 
            // RepairTypeForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.minutesNumericUpDown);
            this.Controls.Add(this.hoursNumericUpDown);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.notesLabel);
            this.Name = "RepairTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
    }
}