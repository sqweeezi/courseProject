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
    public partial class OrgUnitForm : Form
    {
        public OrgUnitForm()
        {
            InitializeComponent();
        }

        private void OrgUnitForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.OrgUnit". При необходимости она может быть перемещена или удалена.
            this.orgUnitTableAdapter.Fill(this.propertyRegisterDataSet.OrgUnit);

        }

        private void OrgUnitButtonAdd_Click(object sender, EventArgs e)
        {
            OrgUnitFormEdit form = new OrgUnitFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void OrgUnitButtonEdit_Click(object sender, EventArgs e)
        {
            OrgUnitFormEdit form = new OrgUnitFormEdit(propertyRegisterDataSet, (int)orgUnitDataGridView.CurrentRow.Cells[1].Value);
            form.ShowDialog();
        }

        private void OrgUnitButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.OrgUnit.FindByorgUnitId((int)orgUnitDataGridView.CurrentRow.Cells[1].Value).Delete();
                orgUnitTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.OrgUnit.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                orgUnitTableAdapter.Fill(propertyRegisterDataSet.OrgUnit);
            }
        }
    }
}
