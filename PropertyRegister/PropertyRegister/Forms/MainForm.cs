using PropertyRegister.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRegister
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.OrgUnit". При необходимости она может быть перемещена или удалена.
            this.orgUnitTableAdapter.Fill(this.propertyRegisterDataSet.OrgUnit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.propertyRegisterDataSet.Building);

        }

        /// <summary>
        /// Синхронизирует локальные данные с БД
        /// </summary>
        /// <param name="tableName">Имя таблицы, которую необходимо обновить</param>
        private void saveToBD(string tableName)
        {
            try
            {
                if (tableName == propertyRegisterDataSet.Building.TableName)
                {
                    buildingTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.Building.AcceptChanges();
                    return;
                }
                if (tableName == propertyRegisterDataSet.OrgUnit.TableName)
                {
                    orgUnitTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.OrgUnit.AcceptChanges();
                    return;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void BuildingButtonAdd_Click(object sender, EventArgs e)
        {
            BuildingFormEdit form = new BuildingFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void BuildingButtonEdit_Click(object sender, EventArgs e)
        {
            BuildingFormEdit form = new BuildingFormEdit(propertyRegisterDataSet, (int)buildingDataGridView.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void BuildingButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Building.FindBybuildingId((int)buildingDataGridView.CurrentRow.Cells[0].Value).Delete();
                saveToBD(this.propertyRegisterDataSet.Building.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buildingTableAdapter.Fill(propertyRegisterDataSet.Building);
            }
        }

        private void OrgUnitButtonAdd_Click(object sender, EventArgs e)
        {
            OrgUnitFormEdit form = new OrgUnitFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void OrgUnitButtonEdit_Click(object sender, EventArgs e)
        {
            OrgUnitFormEdit form = new OrgUnitFormEdit(propertyRegisterDataSet, (int)orgUnitDataGridView.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void OrgUnitButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.OrgUnit.FindByorgUnitId((int)orgUnitDataGridView.CurrentRow.Cells[0].Value).Delete();
                saveToBD(this.propertyRegisterDataSet.OrgUnit.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                orgUnitTableAdapter.Fill(propertyRegisterDataSet.OrgUnit);
            }
        }
    }
}
