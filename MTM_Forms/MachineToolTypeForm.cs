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
    public partial class MachineToolTypeForm : Form
    {
        public MachineToolType MachineToolType { get; }
        public MachineToolTypeForm(MachineToolType machineTooltype)
        {
            InitializeComponent();

            if (machineTooltype == null)
            {
                return;
            }

            MachineToolType = machineTooltype;
            
            countryComboBox.Items.Add(Country.Russia);
            countryComboBox.Items.Add(Country.USA);
            countryComboBox.Items.Add(Country.China);
            countryComboBox.Items.Add(Country.Germany);
            countryComboBox.SelectedItem = MachineToolType.Country;

            brandComboBox.Items.Add(Brand.Stankoinstrument);
            brandComboBox.Items.Add(Brand.KrasnyProletary);
            brandComboBox.Items.Add(Brand.Haas);
            brandComboBox.Items.Add(Brand.Hardinge);
            brandComboBox.Items.Add(Brand.Dalian);
            brandComboBox.Items.Add(Brand.Jier);
            brandComboBox.Items.Add(Brand.Siemens);
            brandComboBox.Items.Add(Brand.DeckelMaho);
            brandComboBox.SelectedItem = MachineToolType.Brand;

            yearOfManufactureNumericUpDown.Value = MachineToolType.YearOfManufacture;

            warrantyNumericUpDown.Value = MachineToolType.Warranty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MachineToolType.Country = (Country) countryComboBox.SelectedItem;
            MachineToolType.YearOfManufacture = (int) yearOfManufactureNumericUpDown.Value;
            MachineToolType.Brand = (Brand) brandComboBox.SelectedItem;
            MachineToolType.Warranty = (int) warrantyNumericUpDown.Value;
        }
    }
}
