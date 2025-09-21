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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addMachineToolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var machineToolType = new MachineToolType();
            MachineToolTypeForm machineToolTypeForm = new MachineToolTypeForm(machineToolType);
            if (machineToolTypeForm.ShowDialog() == DialogResult.OK)
            {
                Storage.MachineToolTypes.Add(machineToolType.Id, machineToolType);
                updateMachineToolTypesList();
            }
        }

        private void editMachineToolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (machineToolTypeListView.SelectedItems.Count > 0)
            {
                var machineToolType = machineToolTypeListView.SelectedItems[0].Tag as MachineToolType;
                MachineToolTypeForm machineToolTypeForm = new MachineToolTypeForm(machineToolType);
                if (machineToolTypeForm.ShowDialog() == DialogResult.OK)
                {
                    updateMachineToolTypesList();
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateMachineToolTypesList()
        {
            machineToolTypeListView.Items.Clear();
            foreach (var item in Storage.MachineToolTypes)
            {
                var machineToolType = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = machineToolType,
                    Text = machineToolType.Id.ToString()
                };
                listViewItem.SubItems.Add(machineToolType.Country.ToString());
                listViewItem.SubItems.Add(machineToolType.YearOfManufacture.ToString());
                listViewItem.SubItems.Add(machineToolType.Brand.ToString());
                listViewItem.SubItems.Add(machineToolType.Warranty.ToString());
                machineToolTypeListView.Items.Add(listViewItem);
            }
        }

        private void addRepairTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repairType = new RepairType();
            RepairTypeForm repairTypeForm = new RepairTypeForm(repairType);
            if (repairTypeForm.ShowDialog() == DialogResult.OK)
            {
                Storage.RepairTypes.Add(repairType.Name, repairType);
                updateRepairTypesList();
            }
        }

        private void editRepairTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repairTypeListView.SelectedItems.Count > 0)
            {
                var repairType = repairTypeListView.SelectedItems[0].Tag as RepairType;
                RepairTypeForm repairTypeForm = new RepairTypeForm(repairType);
                if (repairTypeForm.ShowDialog() == DialogResult.OK)
                {
                    updateRepairTypesList();
                    updateRepairsList();
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateRepairTypesList()
        {
            repairTypeListView.Items.Clear();
            foreach (var item in Storage.RepairTypes)
            {
                var repairType = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = repairType,
                    Text = repairType.Name
                };
                listViewItem.SubItems.Add(repairType.Duration.ToString(@"d\:hh\:mm"));
                listViewItem.SubItems.Add(repairType.Cost.ToString());
                listViewItem.SubItems.Add(repairType.Notes.ToString());
                repairTypeListView.Items.Add(listViewItem);
            }
        }

        private void addRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repair = new Repair();
            RepairForm repairForm = new RepairForm(repair);
            if (repairForm.ShowDialog() == DialogResult.OK)
            {
                Storage.Repairs.Add(repair);
                updateRepairsList();
            }
        }

        private void editRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repairListView.SelectedItems.Count > 0)
            {
                var repair = repairListView.SelectedItems[0].Tag as Repair;
                RepairForm repairForm = new RepairForm(repair);
                if (repairForm.ShowDialog() == DialogResult.OK)
                {
                    updateRepairsList();
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateRepairsList()
        {
            repairListView.Items.Clear();
            foreach (var repair in Storage.Repairs)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = repair,
                    Text = repair.MachineToolType.Id.ToString()
                };
                listViewItem.SubItems.Add(repair.RepairType.Name);
                listViewItem.SubItems.Add(repair.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(repair.Notes);
                repairListView.Items.Add(listViewItem);
            }
        }
    }
}
