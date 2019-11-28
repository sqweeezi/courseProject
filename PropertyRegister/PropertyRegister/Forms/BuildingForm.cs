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
    public partial class BuildingForm : Form
    {
        public BuildingForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            buildingBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.propertyRegisterDataSet.Building);
        }

        private void BuildingButtonAdd_Click(object sender, EventArgs e)
        {
            BuildingFormEdit form = new BuildingFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void BuildingButtonEdit_Click(object sender, EventArgs e)
        {
            BuildingFormEdit form = new BuildingFormEdit(propertyRegisterDataSet, (int)buildingDataGridView.CurrentRow.Cells[1].Value);
            form.ShowDialog();
        }

        private void BuildingButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Building.FindBybuildingId((int)buildingDataGridView.CurrentRow.Cells[1].Value).Delete();
                buildingTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.Building.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buildingTableAdapter.Fill(propertyRegisterDataSet.Building);
            }
        }
    }
}
