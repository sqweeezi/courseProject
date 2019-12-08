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
    public partial class ChiefEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.ChiefRow chiefRow;
        private int cheifId = -1;

        public ChiefEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.chiefRow = propertyRegisterDataSet.Chief.NewChiefRow();
        }

        public ChiefEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int cheifId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.cheifId = cheifId;
            this.chiefRow = propertyRegisterDataSet.Chief.FindBychiefId(cheifId);

            surnameTextBox.DataBindings.Add("Text", chiefRow, "surname");
            nameTextBox.DataBindings.Add("Text", chiefRow, "name");
            patronymicTextBox.DataBindings.Add("Text", chiefRow, "patronymic");
            addressTextBox.DataBindings.Add("Text", chiefRow, "address");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            chiefRow.surname = surnameTextBox.Text;
            chiefRow.name = nameTextBox.Text;
            chiefRow.patronymic = patronymicTextBox.Text;
            chiefRow.address = addressTextBox.Text;

            try
            {
                if (cheifId == -1) propertyRegisterDataSet.Chief.AddChiefRow(chiefRow);
                new PropertyRegisterDataSetTableAdapters.ChiefTableAdapter().Update(chiefRow);
                propertyRegisterDataSet.Chief.AcceptChanges();
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
