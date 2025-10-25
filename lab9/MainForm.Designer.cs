namespace lab9
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.encodingComboBox = new System.Windows.Forms.ComboBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.constantsTextBox = new System.Windows.Forms.TextBox();
            this.literalsTextBox = new System.Windows.Forms.TextBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.constantsLabel = new System.Windows.Forms.Label();
            this.literalsLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 23);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(145, 47);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Загрузить файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(163, 23);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(164, 47);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Найти строковые константы";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // encodingComboBox
            // 
            this.encodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingComboBox.FormattingEnabled = true;
            this.encodingComboBox.Location = new System.Drawing.Point(567, 67);
            this.encodingComboBox.Name = "encodingComboBox";
            this.encodingComboBox.Size = new System.Drawing.Size(455, 24);
            this.encodingComboBox.TabIndex = 3;
            this.encodingComboBox.SelectedIndexChanged += new System.EventHandler(this.encodingComboBox_SelectedIndexChanged);
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeTextBox.Location = new System.Drawing.Point(12, 76);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeTextBox.Size = new System.Drawing.Size(533, 539);
            this.codeTextBox.TabIndex = 4;
            // 
            // constantsTextBox
            // 
            this.constantsTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.constantsTextBox.Location = new System.Drawing.Point(551, 113);
            this.constantsTextBox.Multiline = true;
            this.constantsTextBox.Name = "constantsTextBox";
            this.constantsTextBox.ReadOnly = true;
            this.constantsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.constantsTextBox.Size = new System.Drawing.Size(251, 502);
            this.constantsTextBox.TabIndex = 5;
            // 
            // literalsTextBox
            // 
            this.literalsTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.literalsTextBox.Location = new System.Drawing.Point(808, 113);
            this.literalsTextBox.Multiline = true;
            this.literalsTextBox.Name = "literalsTextBox";
            this.literalsTextBox.ReadOnly = true;
            this.literalsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.literalsTextBox.Size = new System.Drawing.Size(231, 502);
            this.literalsTextBox.TabIndex = 6;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(333, 23);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(163, 47);
            this.saveFileButton.TabIndex = 7;
            this.saveFileButton.Text = "Сохранить файл";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // constantsLabel
            // 
            this.constantsLabel.AutoSize = true;
            this.constantsLabel.Location = new System.Drawing.Point(589, 94);
            this.constantsLabel.Name = "constantsLabel";
            this.constantsLabel.Size = new System.Drawing.Size(151, 16);
            this.constantsLabel.TabIndex = 8;
            this.constantsLabel.Text = "Строковые константы";
            // 
            // literalsLabel
            // 
            this.literalsLabel.AutoSize = true;
            this.literalsLabel.Location = new System.Drawing.Point(842, 94);
            this.literalsLabel.Name = "literalsLabel";
            this.literalsLabel.Size = new System.Drawing.Size(146, 16);
            this.literalsLabel.TabIndex = 9;
            this.literalsLabel.Text = "Строковые литералы";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(512, 38);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 16);
            this.fileNameLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 636);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.literalsLabel);
            this.Controls.Add(this.constantsLabel);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.literalsTextBox);
            this.Controls.Add(this.constantsTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.encodingComboBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.openFileButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Л/Р 9 - Вариант 12 (Выделение строковых констант)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox encodingComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox constantsTextBox;
        private System.Windows.Forms.TextBox literalsTextBox;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Label constantsLabel;
        private System.Windows.Forms.Label literalsLabel;
        private System.Windows.Forms.Label fileNameLabel;
    }
}