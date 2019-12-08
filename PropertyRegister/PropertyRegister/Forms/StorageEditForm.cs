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
    public partial class StorageEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.StorageRow storageRow;
        private int unitId = -1;

        public StorageEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.storageRow = propertyRegisterDataSet.Storage.NewStorageRow();
        }

        public StorageEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int unitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.unitId = unitId;
            this.storageRow = propertyRegisterDataSet.Storage.FindByunitId(unitId);

            countNumericUpDown.DataBindings.Add("Text", storageRow, "count");
        }

        private void StorageEditForm_Load(object sender, EventArgs e)
        {
            // получим все имущество по имени помещения
            var tmp = propertyRegisterDataSet.Storage
                .Select(x => x.unitId)                              /*получаем все имущество*/
                .ToList();

            if (unitId != -1) tmp.Remove(unitId);                   /*удалим unitId что-бы он остался в коллекции*/

            var tmp1 = propertyRegisterDataSet.Unit
                .Join(
                propertyRegisterDataSet.Unit                        /*второй набор*/
                    .Select(x => x.unitId)                          /*получаем все имущество со склада*/
                    .ToList()
                    .Except(tmp),                                   /*выдаем все элементы которых нет в tmp*/
                p => p.unitId,                                      /*свойство-селектор объекта из первого набора*/
                x => x,                                             /*свойство-селектор объекта из второго набора*/
                (p, x) => new { p.unitId, p.unitName }              /*результат*/
                )
                .ToList();

            if (tmp1.Count == 0) {
                MessageBox.Show("В данный момент нет имущества не зрагестрированого на складе.");
                this.Close();
            }

            unitIdComboBox.DataSource = tmp1;
            unitIdComboBox.DisplayMember = "unitName";
            unitIdComboBox.ValueMember = "unitId";
            if (unitId != -1) unitIdComboBox.SelectedValue = storageRow.unitId;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            storageRow.unitId = (int)unitIdComboBox.SelectedValue;
            storageRow.count = int.Parse(countNumericUpDown.Text);

            try
            {
                if (unitId == -1) propertyRegisterDataSet.Storage.AddStorageRow(storageRow);
                new PropertyRegisterDataSetTableAdapters.StorageTableAdapter().Update(storageRow);
                propertyRegisterDataSet.Storage.AcceptChanges();
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
    }
}
