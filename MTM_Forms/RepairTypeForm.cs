using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineToolMaintenance;

namespace MTM_Forms
{
    public partial class RepairTypeForm : Form
    {
        public RepairType RepairType { get; }
        
        public RepairTypeForm(RepairType repairType)
        {
            InitializeComponent();

            RepairType = repairType;

            nameTextBox.Text = RepairType.Name;
            daysNumericUpDown.Value = RepairType.Duration.Days;
            hoursNumericUpDown.Value = RepairType.Duration.Hours;
            minutesNumericUpDown.Value = RepairType.Duration.Minutes;
            costNumericUpDown.Value = RepairType.Cost;
            notesTextBox.Text = RepairType.Notes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var repairType in Storage.RepairTypes)
            {
                if (repairType.Value.Name.Equals(nameTextBox.Text.Trim()) && RepairType != repairType.Value)
                {
                    MessageBox.Show("Ремонт с таким названием уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }

            RepairType.Name = nameTextBox.Text.Trim();
            RepairType.Duration = new TimeSpan((int)daysNumericUpDown.Value, (int)hoursNumericUpDown.Value,
                (int)minutesNumericUpDown.Value, 0);
            RepairType.Cost = (int)costNumericUpDown.Value;
            RepairType.Notes = notesTextBox.Text;
        }
    }
}
