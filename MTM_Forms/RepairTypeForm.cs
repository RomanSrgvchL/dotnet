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
        private RepairType _repairType;
        public RepairType RepairType
        {
            get
            {
                return _repairType;
            }
            set
            {
                _repairType = value;

                nameTextBox.Text = _repairType.Name;
                daysNumericUpDown.Value = _repairType.Duration.Days;
                hoursNumericUpDown.Value = _repairType.Duration.Hours;
                minutesNumericUpDown.Value = _repairType.Duration.Minutes;
                costNumericUpDown.Value = _repairType.Cost;
                notesTextBox.Text = _repairType.Notes;
            }
        }

        public RepairTypeForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var repairType in Storage.Instance.RepairTypes)
            {
                if (repairType.Name.Equals(nameTextBox.Text.Trim()) && RepairType != repairType)
                {
                    MessageBox.Show("Ремонт с таким названием уже существует", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }

            _repairType.Name = nameTextBox.Text.Trim();
            _repairType.Duration = new TimeSpan((int)daysNumericUpDown.Value, (int)hoursNumericUpDown.Value,
                (int)minutesNumericUpDown.Value, 0);
            _repairType.Cost = (int)costNumericUpDown.Value;
            _repairType.Notes = notesTextBox.Text;
        }
    }
}
