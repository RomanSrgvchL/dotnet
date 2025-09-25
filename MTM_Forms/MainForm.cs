using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineToolMaintenance;
using MTM_FormsControlLibrary;

namespace MTM_Forms
{
    public partial class MainForm : Form
    {
        private readonly Storage _storage = Storage.Instance;
        readonly MachineToolTypeForm _machineToolTypeForm = new MachineToolTypeForm();
        readonly RepairTypeForm _repairTypeForm = new RepairTypeForm();
        readonly RepairForm _repairForm = new RepairForm();

        public MainForm()
        {
            InitializeComponent();
            _storage.MachineToolTypeAdded += _storage_MachineToolTypeAdded;
            _storage.RepairTypeAdded += _storage_RepairTypeAdded;
            _storage.RepairAdded += _storage_RepairAdded;
            _storage.MachineToolTypeRemoved += _storage_MachineToolTypeRemoved;
            _storage.RepairTypeRemoved += _storage_RepairTypeRemoved;
            _storage.RepairRemoved += _storage_RepairRemoved;
        }

        private void _storage_MachineToolTypeAdded(object sender, EventArgs e)
        {
            var machineToolType = sender as MachineToolType;
            if (machineToolType != null)
            {
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

        private void _storage_RepairTypeAdded(object sender, EventArgs e)
        {
            var repairType = sender as RepairType;
            if (repairType != null)
            {
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

        private void _storage_RepairAdded(object sender, EventArgs e)
        {
            var repair = sender as Repair;
            if (repair != null)
            {
                UserControrRepair userControlRepair = new UserControrRepair(repair)
                {
                    Dock = DockStyle.Top
                }; 
                repairTabPage.Controls.Add(userControlRepair);
            }
        }

        private void _storage_MachineToolTypeRemoved(object sender, EventArgs e)
        {
            var machineToolTypeId = (int)sender;
            for (int i = 0; i < machineToolTypeListView.Items.Count; i++)
            {
                if (((MachineToolType)machineToolTypeListView.Items[i].Tag).Id == machineToolTypeId)
                {
                    machineToolTypeListView.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _storage_RepairTypeRemoved(object sender, EventArgs e)
        {
            var repairTypeName = (string)sender;
            for (int i = 0; i < repairTypeListView.Items.Count; i++)
            {
                if (((RepairType)repairTypeListView.Items[i].Tag).Name == repairTypeName)
                {
                    repairTypeListView.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _storage_RepairRemoved(object sender, EventArgs e)
        {
            var repair = sender as Repair;
            for (int i = 0; i < repairTabPage.Controls.Count; i++)
            {
                if ((repairTabPage.Controls[i] as UserControrRepair)?.Repair == repair)
                {
                    repairTabPage.Controls.RemoveAt(i);
                    break;
                }
            }
        }

        private void addMachineToolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var machineToolType = new MachineToolType();
            _machineToolTypeForm.MachineToolType = machineToolType;
            if (_machineToolTypeForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.AddMachineToolType(machineToolType);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        private void editMachineToolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (machineToolTypeListView.SelectedItems.Count > 0)
            {
                var machineToolType = machineToolTypeListView.SelectedItems[0].Tag as MachineToolType;
                _machineToolTypeForm.MachineToolType = machineToolType;
                if (_machineToolTypeForm.ShowDialog() == DialogResult.OK)
                {
                    var item = machineToolTypeListView.SelectedItems[0];
                    item.Text = _machineToolTypeForm.MachineToolType.Id.ToString();
                    item.SubItems[1].Text = _machineToolTypeForm.MachineToolType.Country.ToString();
                    item.SubItems[2].Text = _machineToolTypeForm.MachineToolType.YearOfManufacture.ToString();
                    item.SubItems[3].Text = _machineToolTypeForm.MachineToolType.Brand.ToString();
                    item.SubItems[4].Text = _machineToolTypeForm.MachineToolType.Warranty.ToString(); 
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addRepairTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repairType = new RepairType();
            _repairTypeForm.RepairType = repairType;
            if (_repairTypeForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.AddRepairType(repairType);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void editRepairTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repairTypeListView.SelectedItems.Count > 0)
            {
                var repairType = repairTypeListView.SelectedItems[0].Tag as RepairType;
                _repairTypeForm.RepairType = repairType;
                if (_repairTypeForm.ShowDialog() == DialogResult.OK)
                {
                    var item = repairTypeListView.SelectedItems[0];
                    item.Text = _repairTypeForm.RepairType.Name;
                    item.SubItems[1].Text = _repairTypeForm.RepairType.Duration.ToString(@"d\:hh\:mm");
                    item.SubItems[2].Text = _repairTypeForm.RepairType.Cost.ToString();
                    item.SubItems[3].Text = _repairTypeForm.RepairType.Notes.ToString();

                    // Обновляем имя этого типа ремонта во вкладке ремонтов
                    for (int i = 0; i < repairTabPage.Controls.Count; i++)
                    {
                        var userControl = repairTabPage.Controls[i] as UserControrRepair;
                        if (userControl != null)
                        {
                            if (userControl.Repair.RepairType == repairType)
                            {
                                userControl.Refresh();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var repair = new Repair();
            _repairForm.Repair = repair;
            if (_repairForm.ShowDialog() == DialogResult.OK)
            {
                _storage.AddRepair(repair);
            }
        }

        private void editRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < repairTabPage.Controls.Count; i++)
                {
                    var userControl = repairTabPage.Controls[i] as UserControrRepair;
                    if (userControl != null)
                    {
                        if (userControl.Selected)
                        {
                            var repair = userControl.Repair;
                            _repairForm.Repair = repair;
                            if (_repairForm.ShowDialog() == DialogResult.OK)
                            {
                                userControl.Refresh();
                            }
                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void machineToolTypeListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var machineToolType = machineToolTypeListView.SelectedItems[0].Tag as MachineToolType;
                    if (machineToolType != null)
                    {
                        _storage.RemoveMachineToolType(machineToolType.Id);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите элемент из списка", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void repairTypeListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var repairType = repairTypeListView.SelectedItems[0].Tag as RepairType;
                    if (repairType != null)
                    {
                        _storage.RemoveRepairType(repairType.Name);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите элемент из списка", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
