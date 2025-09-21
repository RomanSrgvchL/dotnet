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
        public Repair Repair { get; }
        public RepairForm(Repair repair)
        {
            InitializeComponent();

            Repair = repair;

            foreach (var machineToolType in Storage.MachineToolTypes)
            {
                machineToolTypeComboBox.Items.Add(machineToolType.Value);
            }
            machineToolTypeComboBox.SelectedItem = Repair.MachineToolType;

            foreach (var repairType in Storage.RepairTypes)
            {
                repairTypeComboBox.Items.Add(repairType.Value);
            }
            repairTypeComboBox.SelectedItem = Repair.RepairType;

            startDateTimePicker.Value = Repair.StartDate;
            notesTextBox.Text = Repair.Notes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (machineToolTypeComboBox.SelectedItem != null && repairTypeComboBox.SelectedItem != null)
            {
                Repair.MachineToolType = (MachineToolType) machineToolTypeComboBox.SelectedItem;
                Repair.RepairType = (RepairType) repairTypeComboBox.SelectedItem;
                Repair.StartDate = startDateTimePicker.Value;
                Repair.Notes = notesTextBox.Text;
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
