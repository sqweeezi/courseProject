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
        bool dialogRes = false;
        public OrgUnitForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            orgUnitBindingSource.DataSource = propertyRegisterDataSet;
            chiefBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void OrgUnitForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Chief". При необходимости она может быть перемещена или удалена.
            this.chiefTableAdapter.Fill(this.propertyRegisterDataSet.Chief);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.OrgUnit". При необходимости она может быть перемещена или удалена.
            this.orgUnitTableAdapter.Fill(this.propertyRegisterDataSet.OrgUnit);



            var tmp = propertyRegisterDataSet.Chief
               .Select(x => new
               {
                   x.chiefId,
                   fio = x.surname + " " + x.name[0] + "." + (x.patronymic[0] + "." ?? null)
               })
               .ToList();

            (orgUnitDataGridView.Columns["chiefIdDataGridViewComboBoxColumn"] as DataGridViewComboBoxColumn).DataSource = tmp;
            (orgUnitDataGridView.Columns["chiefIdDataGridViewComboBoxColumn"] as DataGridViewComboBoxColumn).DisplayMember = "fio";
            (orgUnitDataGridView.Columns["chiefIdDataGridViewComboBoxColumn"] as DataGridViewComboBoxColumn).ValueMember = "chiefId";

        }

        private void OrgUnitButtonAdd_Click(object sender, EventArgs e)
        {
            OrgUnitEditForm form = new OrgUnitEditForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK) {
                orgUnitBindingSource.ResetBindings(true);
                dialogRes = true;
            }
        }

        private void OrgUnitButtonEdit_Click(object sender, EventArgs e)
        {
            OrgUnitEditForm form = new OrgUnitEditForm(
                propertyRegisterDataSet, 
                (int)orgUnitDataGridView.CurrentRow.Cells["orgUnitIdDataGridViewTextBoxColumn"].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                orgUnitBindingSource.ResetBindings(false);
                dialogRes = true;
            }
        }

        private void OrgUnitButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.OrgUnit.FindByorgUnitId(
                    (int)orgUnitDataGridView.CurrentRow.Cells["orgUnitIdDataGridViewTextBoxColumn"].Value).Delete();
                orgUnitTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.OrgUnit.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                orgUnitTableAdapter.Fill(propertyRegisterDataSet.OrgUnit);
            }
        }

        private void OrgUnitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dialogRes) this.DialogResult = DialogResult.OK;
        }
    }
}
