using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRegister.Forms
{
    public partial class OrgUnitEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.OrgUnitRow orgUnitRow;
        private int orgUnitId = -1;

        public OrgUnitEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.orgUnitRow = propertyRegisterDataSet.OrgUnit.NewOrgUnitRow();
        }

        public OrgUnitEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int orgUnitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.orgUnitId = orgUnitId;
            this.orgUnitRow = propertyRegisterDataSet.OrgUnit.FindByorgUnitId(orgUnitId);

            orgUnitNameTextBox.DataBindings.Add("Text", orgUnitRow, "orgUnitName");
            phoneMaskedTextBox.DataBindings.Add("Text", orgUnitRow, "phone");
        }

        private void OrgUnitFormEdit_Load(object sender, EventArgs e)
        {
            var tmp = propertyRegisterDataSet.Chief
               .Select(x => new
               {
                   x.chiefId,
                   fio = x.surname + " " + x.name[0] + "." + (x.patronymic != null ? x.patronymic[0] + "." : null)
               })
               .ToList();

            cheifIdComboBox.DataSource = tmp;
            cheifIdComboBox.DisplayMember = "fio";
            cheifIdComboBox.ValueMember = "chiefId";
            if (orgUnitId != -1) cheifIdComboBox.SelectedValue = orgUnitRow.chiefId;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            orgUnitRow.orgUnitName = orgUnitNameTextBox.Text;
            orgUnitRow.chiefId = (int)cheifIdComboBox.SelectedValue;
            orgUnitRow.phone = Regex.Replace(phoneMaskedTextBox.Text, @"[^\d]+", "");

            try
            {
                if (orgUnitId == -1) propertyRegisterDataSet.OrgUnit.AddOrgUnitRow(orgUnitRow);
                new PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter().Update(orgUnitRow);
                propertyRegisterDataSet.OrgUnit.AcceptChanges();
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
