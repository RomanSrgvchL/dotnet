using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
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
        private MachineToolType _machineToolType;
        public MachineToolType MachineToolType {
            get 
            { 
                return _machineToolType; 
            }
            set
            {
                _machineToolType = value;

                countryComboBox.Items.Clear();
                countryComboBox.Items.Add(Country.Russia);
                countryComboBox.Items.Add(Country.USA);
                countryComboBox.Items.Add(Country.China);
                countryComboBox.Items.Add(Country.Germany);
                countryComboBox.SelectedItem = _machineToolType.Country;

                brandComboBox.Items.Clear();
                brandComboBox.Items.Add(Brand.Stankoinstrument);
                brandComboBox.Items.Add(Brand.KrasnyProletary);
                brandComboBox.Items.Add(Brand.Haas);
                brandComboBox.Items.Add(Brand.Hardinge);
                brandComboBox.Items.Add(Brand.Dalian);
                brandComboBox.Items.Add(Brand.Jier);
                brandComboBox.Items.Add(Brand.Siemens);
                brandComboBox.Items.Add(Brand.DeckelMaho);
                brandComboBox.SelectedItem = _machineToolType.Brand;

                yearOfManufactureNumericUpDown.Value = _machineToolType.YearOfManufacture;
                warrantyNumericUpDown.Value = _machineToolType.Warranty;
            }
        }

        public MachineToolTypeForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (countryComboBox.SelectedItem != null && brandComboBox.SelectedItem != null)
            {
                _machineToolType.Country = (Country) countryComboBox.SelectedItem;
                _machineToolType.YearOfManufacture = (int) yearOfManufactureNumericUpDown.Value;
                _machineToolType.Brand = (Brand) brandComboBox.SelectedItem;
                _machineToolType.Warranty = (int) warrantyNumericUpDown.Value;
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
