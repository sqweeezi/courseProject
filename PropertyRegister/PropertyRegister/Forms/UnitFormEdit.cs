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
    public partial class UnitFormEdit : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.UnitRow unitRow;
        private int unitId = -1;

        public UnitFormEdit(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.unitRow = propertyRegisterDataSet.Unit.NewUnitRow();
        }

        public UnitFormEdit(PropertyRegisterDataSet propertyRegisterDataSet, int unitId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.unitId = unitId;
            this.unitRow = propertyRegisterDataSet.Unit.FindByunitId(unitId);

            unitNameTextBox.DataBindings.Add("Text", unitRow, "unitName");
            datePurchaseDateTimePicker.DataBindings.Add("Text", unitRow, "datePurchase");
            timeEndNumericUpDown.DataBindings.Add("Text", unitRow, "periodDepreciation");
            costNumericUpDown.DataBindings.Add("Text", unitRow, "cost");
        }

        private void UnitFormEdit_Load(object sender, EventArgs e)
        {
            typeUnitIdComboBox.DataSource = propertyRegisterDataSet.TypeUnit;
            typeUnitIdComboBox.DisplayMember = "type";
            typeUnitIdComboBox.ValueMember = "typeUnitId";
            if (unitId != -1) typeUnitIdComboBox.SelectedValue = unitRow.typeUnitId;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            unitRow.unitName = unitNameTextBox.Text;
            unitRow.datePurchase = datePurchaseDateTimePicker.Value;
            unitRow.cost = int.Parse(costNumericUpDown.Text);
            unitRow.periodDepreciation = int.Parse(timeEndNumericUpDown.Text);

            try
            {
                if (unitId == -1) propertyRegisterDataSet.Unit.AddUnitRow(unitRow);
                new PropertyRegisterDataSetTableAdapters.UnitTableAdapter().Update(unitRow);
                propertyRegisterDataSet.Unit.AcceptChanges();
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
