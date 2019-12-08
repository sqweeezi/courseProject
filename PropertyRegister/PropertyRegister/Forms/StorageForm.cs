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
    public partial class StorageForm : Form
    {
        bool dialogRes = false;
        public StorageForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            storageBindingSource.DataSource = propertyRegisterDataSet;
            unitBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.propertyRegisterDataSet.Unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.propertyRegisterDataSet.Storage);
        }

        private void StorageAddButton_Click(object sender, EventArgs e)
        {
            StorageEditForm form = new StorageEditForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                storageBindingSource.ResetBindings(true);
                dialogRes = true;
            }
        }

        private void StorageEditButton_Click(object sender, EventArgs e)
        {
            StorageEditForm form = new StorageEditForm(
                propertyRegisterDataSet, 
                (int)storageDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn"].Value
                );
            if (form.ShowDialog() == DialogResult.OK)
            {
                storageBindingSource.ResetBindings(false);
                dialogRes = true;
            }
        }

        private void StorageDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Storage.FindByunitId(
                    (int)storageDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn"].Value).Delete();
                storageTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.Storage.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                storageTableAdapter.Fill(propertyRegisterDataSet.Storage);
            }
        }

        private void StorageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dialogRes) this.DialogResult = DialogResult.OK;
        }
    }
}
