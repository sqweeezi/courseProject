using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRegister.Forms
{
    public partial class InventoryFormEdit : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.InventoryRow inventoryRow;
        private string roomName = "";

        public InventoryFormEdit(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.inventoryRow = propertyRegisterDataSet.Inventory.NewInventoryRow();
        }

        public InventoryFormEdit(PropertyRegisterDataSet propertyRegisterDataSet, string roomName, int unitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.roomName = roomName;
            this.inventoryRow = propertyRegisterDataSet.Inventory.FindByroomNameunitId(roomName,unitId);

            countNumericUpDown.DataBindings.Add("Text", inventoryRow, "count");
        }

        private void InventoryFormEdit_Load(object sender, EventArgs e)
        {
            unitIdComboBox.DataSource = propertyRegisterDataSet.Unit;
            unitIdComboBox.DisplayMember = "unitName";
            unitIdComboBox.ValueMember = "unitId";
            if (roomName != "") unitIdComboBox.SelectedValue = inventoryRow.unitId;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            inventoryRow.unitId = (int)unitIdComboBox.SelectedValue;
            inventoryRow.count = int.Parse(countNumericUpDown.Text);

            try
            {
                if (roomName == "") propertyRegisterDataSet.Inventory.AddInventoryRow(inventoryRow);
                new PropertyRegisterDataSetTableAdapters.InventoryTableAdapter().Update(inventoryRow);
                propertyRegisterDataSet.Inventory.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
