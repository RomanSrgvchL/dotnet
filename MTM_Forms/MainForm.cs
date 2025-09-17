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
        private MachineToolType _machineToolType = null;
        private RepairType _repairType = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void addMachineToolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _machineToolType = new MachineToolType();
            MachineToolTypeForm machineToolTypeForm = new MachineToolTypeForm(_machineToolType);
            if (machineToolTypeForm.ShowDialog() == DialogResult.OK)
            {
                _machineToolType = machineToolTypeForm.MachineToolType;
            }
        }

        private void editMachineToolTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MachineToolTypeForm machineToolTypeForm = new MachineToolTypeForm(_machineToolType);
            if (machineToolTypeForm.ShowDialog() == DialogResult.OK)
            {
                _machineToolType = machineToolTypeForm.MachineToolType;
            }   
        }

        private void addRepairTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _repairType = new RepairType();
            RepairTypeForm repairTypeForm = new RepairTypeForm(_repairType);
            if (repairTypeForm.ShowDialog() == DialogResult.OK)
            {
                _repairType = repairTypeForm.RepairType;
            }
        }

        private void editRepairTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairTypeForm repairTypeForm = new RepairTypeForm(_repairType);
            if (repairTypeForm.ShowDialog() == DialogResult.OK)
            {
                _repairType = repairTypeForm.RepairType;
            }
        }
    }
}
