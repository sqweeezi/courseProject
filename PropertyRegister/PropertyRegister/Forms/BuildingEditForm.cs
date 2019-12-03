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
    public partial class BuildingEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.BuildingRow buildingRow;
        private int buildingId = -1;

        public BuildingEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.buildingRow = propertyRegisterDataSet.Building.NewBuildingRow();
        }

        public BuildingEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int buildingId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.buildingId = buildingId;
            this.buildingRow = propertyRegisterDataSet.Building.FindBybuildingId(buildingId);

            buildingNameTextBox.DataBindings.Add("Text", buildingRow, "buildingName");
            landNumericUpDown.DataBindings.Add("Text", buildingRow, "land");
            addressTextBox.DataBindings.Add("Text", buildingRow, "address");
            yearNumericUpDown.DataBindings.Add("Text", buildingRow, "year");
            materialTextBox.DataBindings.Add("Text", buildingRow, "material");
            flowNumericUpDown.DataBindings.Add("Text", buildingRow, "flow");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            buildingRow.buildingName = buildingNameTextBox.Text;
            buildingRow.land = int.Parse(landNumericUpDown.Text);
            buildingRow.address = addressTextBox.Text;
            buildingRow.year = int.Parse(yearNumericUpDown.Text);
            buildingRow.material = materialTextBox.Text;
            buildingRow.flow = int.Parse(flowNumericUpDown.Text);

            try
            {
                if (buildingId == -1) propertyRegisterDataSet.Building.AddBuildingRow(buildingRow);
                new PropertyRegisterDataSetTableAdapters.BuildingTableAdapter().Update(buildingRow);
                propertyRegisterDataSet.Building.AcceptChanges();
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
