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
    public partial class TypeUnitEditForm : Form
    {

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.TypeUnitRow typeUnitRow;
        private int typeUnitId = -1;

        public TypeUnitEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.typeUnitRow = propertyRegisterDataSet.TypeUnit.NewTypeUnitRow();
        }

        public TypeUnitEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int typeUnitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.typeUnitId = typeUnitId;
            this.typeUnitRow = propertyRegisterDataSet.TypeUnit.FindBytypeUnitId(typeUnitId);

            typeTextBox.DataBindings.Add("Text", typeUnitRow, "type");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            typeUnitRow.type = typeTextBox.Text;

            try
            {
                if (typeUnitId == -1) propertyRegisterDataSet.TypeUnit.AddTypeUnitRow(typeUnitRow);
                new PropertyRegisterDataSetTableAdapters.TypeUnitTableAdapter().Update(typeUnitRow);
                propertyRegisterDataSet.TypeUnit.AcceptChanges();
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
