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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.machineToolTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMachineToolTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMachineToolTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRepairTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRepairTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineToolTypeToolStripMenuItem,
            this.repairTypeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(882, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // machineToolTypeToolStripMenuItem
            // 
            this.machineToolTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMachineToolTypeToolStripMenuItem,
            this.editMachineToolTypeToolStripMenuItem});
            this.machineToolTypeToolStripMenuItem.Name = "machineToolTypeToolStripMenuItem";
            this.machineToolTypeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.machineToolTypeToolStripMenuItem.Text = "Вид станка";
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
            this.repairTypeToolStripMenuItem.Text = "Вид ремонта";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техническое обслуживание станков";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem machineToolTypeToolStripMenuItem;
        private ToolStripMenuItem repairTypeToolStripMenuItem;
        private ToolStripMenuItem addMachineToolTypeToolStripMenuItem;
        private ToolStripMenuItem editMachineToolTypeToolStripMenuItem;
        private ToolStripMenuItem addRepairTypeToolStripMenuItem;
        private ToolStripMenuItem editRepairTypeToolStripMenuItem;
    }
}