using System.Windows.Forms;

namespace MTM_FormsControlLibrary
{
    partial class UserControrRepair
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.machineToolTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.repairNameTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.machineToolTypeIdLabel = new System.Windows.Forms.Label();
            this.repairNameLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machineToolTypeIdTextBox
            // 
            this.machineToolTypeIdTextBox.Location = new System.Drawing.Point(139, 10);
            this.machineToolTypeIdTextBox.Name = "machineToolTypeIdTextBox";
            this.machineToolTypeIdTextBox.ReadOnly = true;
            this.machineToolTypeIdTextBox.Size = new System.Drawing.Size(129, 22);
            this.machineToolTypeIdTextBox.TabIndex = 0;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(471, 10);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.ReadOnly = true;
            this.startDateTextBox.Size = new System.Drawing.Size(137, 22);
            this.startDateTextBox.TabIndex = 1;
            // 
            // repairNameTextBox
            // 
            this.repairNameTextBox.Location = new System.Drawing.Point(156, 45);
            this.repairNameTextBox.Name = "repairNameTextBox";
            this.repairNameTextBox.ReadOnly = true;
            this.repairNameTextBox.Size = new System.Drawing.Size(452, 22);
            this.repairNameTextBox.TabIndex = 2;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(156, 75);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(397, 22);
            this.notesTextBox.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(302, 16);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(152, 16);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Дата начала ремонта:";
            // 
            // machineToolTypeIdLabel
            // 
            this.machineToolTypeIdLabel.AutoSize = true;
            this.machineToolTypeIdLabel.Location = new System.Drawing.Point(19, 16);
            this.machineToolTypeIdLabel.Name = "machineToolTypeIdLabel";
            this.machineToolTypeIdLabel.Size = new System.Drawing.Size(105, 16);
            this.machineToolTypeIdLabel.TabIndex = 5;
            this.machineToolTypeIdLabel.Text = "ID типа станка:";
            // 
            // repairNameLabel
            // 
            this.repairNameLabel.AutoSize = true;
            this.repairNameLabel.Location = new System.Drawing.Point(15, 48);
            this.repairNameLabel.Name = "repairNameLabel";
            this.repairNameLabel.Size = new System.Drawing.Size(135, 16);
            this.repairNameLabel.TabIndex = 6;
            this.repairNameLabel.Text = "Название ремонта:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(19, 78);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(92, 16);
            this.notesLabel.TabIndex = 7;
            this.notesLabel.Text = "Примечания:";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(567, 75);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(41, 31);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UserControrRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.repairNameLabel);
            this.Controls.Add(this.machineToolTypeIdLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.repairNameTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.machineToolTypeIdTextBox);
            this.Name = "UserControrRepair";
            this.Size = new System.Drawing.Size(627, 110);
            this.Click += new System.EventHandler(this.UserControlSettlement_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlRepair_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox machineToolTypeIdTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox repairNameTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label machineToolTypeIdLabel;
        private System.Windows.Forms.Label repairNameLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
