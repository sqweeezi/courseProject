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

            //targetTextBox.DataBindings.Add("Text", typeRoomRow, "target");
        }

        private void StorageEditForm_Load(object sender, EventArgs e)
        {
            unitIdComboBox.DataSource = propertyRegisterDataSet.Unit;
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
