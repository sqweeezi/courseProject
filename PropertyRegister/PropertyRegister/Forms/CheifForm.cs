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
    public partial class CheifForm : Form
    {
        public CheifForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            chiefBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void CheifForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Chief". При необходимости она может быть перемещена или удалена.
            this.chiefTableAdapter.Fill(this.propertyRegisterDataSet.Chief);

        }

        private void CheifButtonAdd_Click(object sender, EventArgs e)
        {
            ChiefEditForm form = new ChiefEditForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK) {
                chiefBindingSource.ResetBindings(true);
            }
        }

        private void CheifButtonEdit_Click(object sender, EventArgs e)
        {
            ChiefEditForm form = new ChiefEditForm(propertyRegisterDataSet, (int)chiefDataGridView.CurrentRow.Cells[1].Value);
            form.ShowDialog();
        }

        private void CheifButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Chief.FindBychiefId((int)chiefDataGridView.CurrentRow.Cells[1].Value).Delete();
                chiefTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.Chief.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                chiefTableAdapter.Fill(propertyRegisterDataSet.Chief);
            }
        }
    }
}
