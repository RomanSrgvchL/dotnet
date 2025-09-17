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

            if (repairType == null)
            {
                return;
            }

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
            RepairType.Name = nameTextBox.Text;
            RepairType.Duration = new TimeSpan((int) daysNumericUpDown.Value, (int) hoursNumericUpDown.Value, 
                (int) minutesNumericUpDown.Value, 0);
            RepairType.Cost = (int) costNumericUpDown.Value;
            RepairType.Notes = notesTextBox.Text;
        }
    }
}
