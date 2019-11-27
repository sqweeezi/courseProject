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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.propertyRegisterDataSet.Inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.propertyRegisterDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Revaluation". При необходимости она может быть перемещена или удалена.
            this.revaluationTableAdapter.Fill(this.propertyRegisterDataSet.Revaluation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.propertyRegisterDataSet.Unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.TypeRoom". При необходимости она может быть перемещена или удалена.
            this.typeRoomTableAdapter.Fill(this.propertyRegisterDataSet.TypeRoom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Chief". При необходимости она может быть перемещена или удалена.
            this.chiefTableAdapter.Fill(this.propertyRegisterDataSet.Chief);
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
                if (tableName == propertyRegisterDataSet.Chief.TableName)
                {
                    chiefTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.Chief.AcceptChanges();
                    return;
                }
                if (tableName == propertyRegisterDataSet.TypeRoom.TableName)
                {
                    typeRoomTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.TypeRoom.AcceptChanges();
                    return;
                }
                if (tableName == propertyRegisterDataSet.Room.TableName)
                {
                    roomTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.Room.AcceptChanges();
                    return;
                }
                if (tableName == propertyRegisterDataSet.Inventory.TableName)
                {
                    inventoryTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.Inventory.AcceptChanges();
                    return;
                }
                if (tableName == propertyRegisterDataSet.Unit.TableName)
                {
                    unitTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.Unit.AcceptChanges();
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

        private void CheifButtonAdd_Click(object sender, EventArgs e)
        {
            CheifFormEdit form = new CheifFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void CheifButtonEdit_Click(object sender, EventArgs e)
        {
            CheifFormEdit form = new CheifFormEdit(propertyRegisterDataSet, (int)chiefDataGridView.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void CheifButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Chief.FindBychiefId((int)chiefDataGridView.CurrentRow.Cells[0].Value).Delete();
                saveToBD(this.propertyRegisterDataSet.Chief.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                chiefTableAdapter.Fill(propertyRegisterDataSet.Chief);
            }
        }

        private void TypeRoomButtonAdd_Click(object sender, EventArgs e)
        {
            TypeRoomFormEdit form = new TypeRoomFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void TypeRoomButtonEdit_Click(object sender, EventArgs e)
        {
            TypeRoomFormEdit form = new TypeRoomFormEdit(propertyRegisterDataSet, (int)typeRoomDataGridView.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void TypeRoomButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.TypeRoom.FindBytypeRoomId((int)typeRoomDataGridView.CurrentRow.Cells[0].Value).Delete();
                saveToBD(this.propertyRegisterDataSet.TypeRoom.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                typeRoomTableAdapter.Fill(propertyRegisterDataSet.TypeRoom);
            }
        }

        private void RoomButtonAdd_Click(object sender, EventArgs e)
        {
            RoomFormEdit form = new RoomFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void RoomButtonEdit_Click(object sender, EventArgs e)
        {
            RoomFormEdit form = new RoomFormEdit(propertyRegisterDataSet, roomDataGridView.CurrentRow.Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void RoomButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Room.FindByroomName(roomDataGridView.CurrentRow.Cells[0].Value.ToString()).Delete();
                saveToBD(this.propertyRegisterDataSet.Room.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                roomTableAdapter.Fill(propertyRegisterDataSet.Room);
            }
        }

        private void InventoryButtonAdd_Click(object sender, EventArgs e)
        {
            InventoryFormEdit form = new InventoryFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void InventoryButtonEdit_Click(object sender, EventArgs e)
        {
            InventoryFormEdit form = new InventoryFormEdit(
                propertyRegisterDataSet,
                inventoryDataGridView.CurrentRow.Cells[0].Value.ToString(),
                (int)inventoryDataGridView.CurrentRow.Cells[1].Value
                );
            form.ShowDialog();
        }

        private void InventoryButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Inventory.FindByroomNameunitId(
                    inventoryDataGridView.CurrentRow.Cells[0].Value.ToString(),
                    (int)inventoryDataGridView.CurrentRow.Cells[1].Value
                    ).Delete();
                saveToBD(this.propertyRegisterDataSet.Inventory.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inventoryTableAdapter.Fill(propertyRegisterDataSet.Inventory);
            }
        }

        private void UnitButtonAdd_Click(object sender, EventArgs e)
        {
            UnitFormEdit form = new UnitFormEdit(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void UnitButtonEdit_Click(object sender, EventArgs e)
        {
            UnitFormEdit form = new UnitFormEdit(propertyRegisterDataSet, (int)unitDataGridView.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void UnitButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Unit.FindByunitId((int)unitDataGridView.CurrentRow.Cells[0].Value).Delete();
                saveToBD(this.propertyRegisterDataSet.Unit.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                unitTableAdapter.Fill(propertyRegisterDataSet.Unit);
            }
        }
    }
}
