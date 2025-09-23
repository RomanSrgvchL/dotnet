using MachineToolMaintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTM_Forms
{
    public partial class RepairForm : Form
    {
        private Repair _repair;
        public Repair Repair
        {
            get
            {
                return _repair;
            }
            set
            {
                _repair = value;

                machineToolTypeComboBox.Items.Clear();
                foreach (var machineToolType in Storage.Instance.MachineToolTypes)
                {
                    machineToolTypeComboBox.Items.Add(machineToolType);
                }
                machineToolTypeComboBox.SelectedItem = _repair.MachineToolType;

                repairTypeComboBox.Items.Clear();
                foreach (var repairType in Storage.Instance.RepairTypes)
                {
                    repairTypeComboBox.Items.Add(repairType);
                }
                repairTypeComboBox.SelectedItem = _repair.RepairType;

                startDateTimePicker.Value = _repair.StartDate;
                notesTextBox.Text = _repair.Notes;
            }
        }
        public RepairForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (machineToolTypeComboBox.SelectedItem != null && repairTypeComboBox.SelectedItem != null)
            {
                _repair.MachineToolType = (MachineToolType) machineToolTypeComboBox.SelectedItem;
                _repair.RepairType = (RepairType) repairTypeComboBox.SelectedItem;
                _repair.StartDate = startDateTimePicker.Value;
                _repair.Notes = notesTextBox.Text;
            }
            else
            {
                MessageBox.Show("Не указано значение в выпадащем списке", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
