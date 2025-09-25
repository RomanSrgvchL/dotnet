using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineToolMaintenance;

namespace MTM_FormsControlLibrary
{
    public partial class UserControrRepair: UserControl
    {
        public UserControrRepair()
        {
            InitializeComponent();
        }

        private readonly Storage _storage = Storage.Instance;
        public Repair Repair { get; }

        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControrRepair)) continue;
                            var userControlRepair = control as UserControrRepair;
                            if (userControlRepair != this)
                            {
                                userControlRepair.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }

        public UserControrRepair(Repair repair)
        {
            InitializeComponent();
            Repair = repair;
        }

        private void UserControlRepair_Paint(object sender, PaintEventArgs e)
        {
            machineToolTypeIdTextBox.Text = Repair.MachineToolType.Id.ToString();
            repairNameTextBox.Text = Repair.RepairType.Name;
    
            startDateTextBox.Text = Repair.StartDate.ToShortDateString();

            if (Repair.StartDate < DateTime.Today)
            {
                // Ремонт был
                startDateTextBox.BackColor = Color.Gray;
            }
            else if (Repair.StartDate == DateTime.Today)
            {
                // Ремонт сегодня
                startDateTextBox.BackColor = Color.Green;
            }
            else
            {
                // Ремонт будет
                startDateTextBox.BackColor = Color.Yellow;
            }

            notesTextBox.Text = Repair.Notes;

            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;
        }

        private void UserControlSettlement_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _storage.RemoveRepair(Repair);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите элемент из списка", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
