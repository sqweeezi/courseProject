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
           
        }

        private void InventoryFormEdit_Load(object sender, EventArgs e)
        {
            // получим все имущество по имени помещения
            var tmp = propertyRegisterDataSet.Inventory
                .Where(x => x.roomName == inventoryRow.roomName)
                .Select(x => x.unitId)                              /*получаем все имущество*/
                .ToList();

            if (unitId != -1) tmp.Remove(unitId);                   /*удалим unitId что-бы он остался в коллекции*/

            var tmp1 = propertyRegisterDataSet.Unit.Join(
                propertyRegisterDataSet.Storage                     /*второй набор*/
                    .Select(x => x.unitId)                          /*получаем все имущество со склада*/
                    .ToList()
                    .Except(tmp),                                   /*выдаем все элементы которых нет в tmp*/
                p => p.unitId,                                      /*свойство-селектор объекта из первого набора*/
                x => x,                                             /*свойство-селектор объекта из второго набора*/
                (p, x) => new { p.unitId, p.unitName }              /*результат*/
                )
                .ToList();

            if (tmp1.Count == 0)
            {
                MessageBox.Show("Больше нет имущества на складе для этого помещения.");
                this.Close();
            }

            unitIdComboBox.DataSource = tmp1;
            unitIdComboBox.DisplayMember = "unitName";
            unitIdComboBox.ValueMember = "unitId";
            if (unitId != -1) unitIdComboBox.SelectedValue = inventoryRow.unitId;

            UnitIdComboBox_SelectedIndexChanged(sender, e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(countNumericUpDown.Text) == 0)
            {
                MessageBox.Show("Укажите кол-во");
                return;
            }
            inventoryRow.unitId = (int)unitIdComboBox.SelectedValue;
            inventoryRow.count = int.Parse(countNumericUpDown.Text);

            try
            {
                if (unitId == -1) propertyRegisterDataSet.Inventory.AddInventoryRow(inventoryRow);
                new PropertyRegisterDataSetTableAdapters.InventoryTableAdapter().Update(inventoryRow);
                propertyRegisterDataSet.Inventory.AcceptChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                //this.Close();
            }
        }

        private void UnitIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(unitIdComboBox.SelectedValue is int)) return; // не большой костыль

            var tmp = propertyRegisterDataSet.Storage.FindByunitId((int)unitIdComboBox.SelectedValue);
            countStorageLabel.Text = "На складе: " + tmp.count.ToString();
            if (tmp.unitId == unitId) countNumericUpDown.Maximum = tmp.count + inventoryRow.count;
            else countNumericUpDown.Maximum = tmp.count;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
