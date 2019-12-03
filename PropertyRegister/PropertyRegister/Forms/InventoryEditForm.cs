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
    public partial class InventoryEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.InventoryRow inventoryRow;
        //private string roomName = "";
        private int unitId = -1;

        public InventoryEditForm(PropertyRegisterDataSet propertyRegisterDataSet, string roomName)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            //this.roomName = roomName;
            this.inventoryRow = propertyRegisterDataSet.Inventory.NewInventoryRow();
            this.inventoryRow.roomName = roomName;
        }

        public InventoryEditForm(PropertyRegisterDataSet propertyRegisterDataSet, string roomName, int unitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            //this.roomName = roomName;
            this.unitId = unitId;
            this.inventoryRow = propertyRegisterDataSet.Inventory.FindByroomNameunitId(roomName,unitId);

            countNumericUpDown.DataBindings.Add("Text", inventoryRow, "count");
           // countNumericUpDown.Maximum = propertyRegisterDataSet.Storage.FindByunitId((int)unitIdComboBox.SelectedValue).count;
        }

        private void InventoryFormEdit_Load(object sender, EventArgs e)
        {
            unitIdComboBox.DataSource = propertyRegisterDataSet.Unit;
            unitIdComboBox.DisplayMember = "unitName";
            unitIdComboBox.ValueMember = "unitId";
            if (unitId != -1) unitIdComboBox.SelectedValue = inventoryRow.unitId;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            inventoryRow.unitId = (int)unitIdComboBox.SelectedValue;
            inventoryRow.count = int.Parse(countNumericUpDown.Text);

            try
            {
                if (unitId == -1) propertyRegisterDataSet.Inventory.AddInventoryRow(inventoryRow);
                new PropertyRegisterDataSetTableAdapters.InventoryTableAdapter().Update(inventoryRow);
                propertyRegisterDataSet.Inventory.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void UnitIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (unitIdComboBox.SelectedValue == null || unitIdComboBox.SelectedIndex == -1) return;
            //int tmp = unitIdComboBox.SelectedValue as int;
            //countStorageLabel.Text ="На складе: "+ propertyRegisterDataSet.Storage.FindByunitId(tmp).count.ToString();
        }
    }
}
