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
        bool dialogRes = false;

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
            BuildingEditForm form = new BuildingEditForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                buildingBindingSource.ResetBindings(true);
                dialogRes = true;
            }
        }

        private void BuildingButtonEdit_Click(object sender, EventArgs e)
        {
            BuildingEditForm form = new BuildingEditForm(propertyRegisterDataSet, (int)buildingDataGridView.CurrentRow.Cells[1].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                buildingBindingSource.ResetBindings(false);
                dialogRes = true;
            }
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

        private void BuildingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dialogRes) this.DialogResult = DialogResult.OK;
        }
    }
}
