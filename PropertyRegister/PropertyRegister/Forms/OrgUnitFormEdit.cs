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
    public partial class OrgUnitFormEdit : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.OrgUnitRow orgUnitRow;
        private int orgUnitId = -1;

        public OrgUnitFormEdit(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.orgUnitRow = propertyRegisterDataSet.OrgUnit.NewOrgUnitRow();
        }

        public OrgUnitFormEdit(PropertyRegisterDataSet propertyRegisterDataSet, int orgUnitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.orgUnitId = orgUnitId;
            this.orgUnitRow = propertyRegisterDataSet.OrgUnit.FindByorgUnitId(orgUnitId);

            orgUnitNameTextBox.DataBindings.Add("Text", orgUnitRow, "orgUnitName");
            bossTextBox.DataBindings.Add("Text", orgUnitRow, "boss");
            phoneTextBox.DataBindings.Add("Text", orgUnitRow, "phone");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            orgUnitRow.orgUnitName = orgUnitNameTextBox.Text;
            orgUnitRow.boss = bossTextBox.Text;
            orgUnitRow.phone = phoneTextBox.Text;

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
                this.Close();
            }
        }
    }
}
