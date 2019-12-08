using PropertyRegister.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRegister
{
    public partial class MainForm : Form
    {

        #region Общая секция

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.TypeUnit". При необходимости она может быть перемещена или удалена.
            this.typeUnitTableAdapter.Fill(this.propertyRegisterDataSet.TypeUnit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.propertyRegisterDataSet.Storage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.propertyRegisterDataSet.Building);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.TypeRoom". При необходимости она может быть перемещена или удалена.
            this.typeRoomTableAdapter.Fill(this.propertyRegisterDataSet.TypeRoom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.OrgUnit". При необходимости она может быть перемещена или удалена.
            this.orgUnitTableAdapter.Fill(this.propertyRegisterDataSet.OrgUnit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Chief". При необходимости она может быть перемещена или удалена.
            this.chiefTableAdapter.Fill(this.propertyRegisterDataSet.Chief);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Revaluation". При необходимости она может быть перемещена или удалена.
            this.revaluationTableAdapter.Fill(this.propertyRegisterDataSet.Revaluation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.propertyRegisterDataSet.Unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.propertyRegisterDataSet.Inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.propertyRegisterDataSet.Room);

            var tmp = propertyRegisterDataSet.Chief
               .Select(x => new
               {
                   x.chiefId,
                   fio = x.surname + " " + x.name[0] + "." + (x.patronymic[0] + "." ?? null)
               })
               .ToList();

            (roomDataGridView.Columns["chiefIdDataGridViewComboBoxColumn"] as DataGridViewComboBoxColumn).DataSource = tmp;
            (roomDataGridView.Columns["chiefIdDataGridViewComboBoxColumn"] as DataGridViewComboBoxColumn).DisplayMember = "fio";
            (roomDataGridView.Columns["chiefIdDataGridViewComboBoxColumn"] as DataGridViewComboBoxColumn).ValueMember = "chiefId";


            #region Всячина для фильтрации

            // Комбобоксы для фильтрации
            var buildingCB = propertyRegisterDataSet.Building
                .Select(x => new { x.buildingId, x.buildingName })
                .ToList();

            // добавим пустое поле
            buildingCB.Insert(0, new { buildingId = -1, buildingName = "Нет" });

            buildingFilterComboBox.DataSource = buildingCB;
            buildingFilterComboBox.DisplayMember = "buildingName";
            buildingFilterComboBox.ValueMember = "buildingId";
            buildingFilterComboBox.SelectedIndexChanged += (s, ea) => { RoomFilter(); };


            var orgUnitCB = propertyRegisterDataSet.OrgUnit
                .Select(x => new { x.orgUnitId, x.orgUnitName })
                .ToList();

            // добавим пустое поле
            orgUnitCB.Insert(0, new { orgUnitId = -1, orgUnitName = "Нет" });

            orgUnitFilterComboBox.DataSource = orgUnitCB;
            orgUnitFilterComboBox.DisplayMember = "orgUnitName";
            orgUnitFilterComboBox.ValueMember = "orgUnitId";
            orgUnitFilterComboBox.SelectedIndexChanged += (s, ea) => { RoomFilter(); };


            var typeUnitCB = propertyRegisterDataSet.TypeUnit
                .Select(x => new { x.typeUnitId, x.type })
                .ToList();

            // добавим пустое поле
            typeUnitCB.Insert(0, new { typeUnitId = -1, type = "Нет" });

            typeUnitFilterComboBox.DataSource = typeUnitCB;
            typeUnitFilterComboBox.DisplayMember = "type";
            typeUnitFilterComboBox.ValueMember = "typeUnitId";
            typeUnitFilterComboBox.SelectedIndexChanged += (s, ea) => { UnitFilter(); };


            writeOffheckBox.CheckedChanged += (s, ea) => { UnitFilter(); };
            writeOffheckBox.Checked = true;

            #endregion
        }

        private void RoomFilter()
        {
            int first = (buildingFilterComboBox.SelectedValue == null ? -1 : (int)buildingFilterComboBox.SelectedValue);
            int second = (orgUnitFilterComboBox.SelectedValue == null ? -1 : (int)orgUnitFilterComboBox.SelectedValue);
            roomBindingSource.Filter =
                (first != -1 ? "buildingId = '" + first + "'" : "") +
                (first != -1 && second != -1 ? " and " : "") +
                (second != -1 ? "orgUnitId = '" + second + "'" : "");
        }

        private void UnitFilter()
        {
            int first = (typeUnitFilterComboBox.SelectedValue == null ? -1 : (int)typeUnitFilterComboBox.SelectedValue);
            bool second = writeOffheckBox.Checked;
            unitBindingSource.Filter =
                (first != -1 ? "typeUnitId = '" + first + "'" : "") +
                (first != -1 && second ? " and " : "") +
                (!second ? "writeOff = '" + second + "'" : "");
        }

        /// <summary>
        /// Синхронизирует локальные данные с БД
        /// </summary>
        /// <param name="tableName">Имя таблицы, которую необходимо обновить</param>
        private void saveToBD(string tableName)
        {
            try
            {
                //if (tableName == propertyRegisterDataSet.Building.TableName)
                //{
                //    buildingTableAdapter.Update(propertyRegisterDataSet);
                //    propertyRegisterDataSet.Building.AcceptChanges();
                //    return;
                //}
                //if (tableName == propertyRegisterDataSet.OrgUnit.TableName)
                //{
                //    orgUnitTableAdapter.Update(propertyRegisterDataSet);
                //    propertyRegisterDataSet.OrgUnit.AcceptChanges();
                //    return;
                //}
                //if (tableName == propertyRegisterDataSet.Chief.TableName)
                //{
                //    chiefTableAdapter.Update(propertyRegisterDataSet);
                //    propertyRegisterDataSet.Chief.AcceptChanges();
                //    return;
                //}
                //if (tableName == propertyRegisterDataSet.TypeRoom.TableName)
                //{
                //    typeRoomTableAdapter.Update(propertyRegisterDataSet);
                //    propertyRegisterDataSet.TypeRoom.AcceptChanges();
                //    return;
                //}
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            roomDataGridView.Dispose();
        }

        #endregion

        #region Вкладка Помещения

        private void RoomButtonAdd_Click(object sender, EventArgs e)
        {

            RoomEditForm form = new RoomEditForm(propertyRegisterDataSet);
            form.ShowDialog();
        }

        private void RoomButtonEdit_Click(object sender, EventArgs e)
        {
            RoomEditForm form = new RoomEditForm(
                propertyRegisterDataSet,
                roomDataGridView.CurrentRow.Cells[0].Value.ToString()
                );
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
            InventoryEditForm form = new InventoryEditForm(
                propertyRegisterDataSet,
                roomDataGridView.CurrentRow.Cells["roomNameDataGridViewTextBoxColumn"].Value.ToString()
                );
            if (form.ShowDialog() == DialogResult.OK)
            {
                fKInventoryroomN76177A41BindingSource.ResetBindings(true);
            }
        }

        private void InventoryButtonEdit_Click(object sender, EventArgs e)
        {
            InventoryEditForm form = new InventoryEditForm(
                propertyRegisterDataSet,
                roomDataGridView.CurrentRow.Cells["roomNameDataGridViewTextBoxColumn"].Value.ToString(),
                (int)inventoryDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn"].Value
                );
            if (form.ShowDialog() == DialogResult.OK)
            {
                fKInventoryroomN76177A41BindingSource.ResetBindings(false);
            }
        }

        private void InventoryButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Inventory.FindByroomNameunitId(
                    roomDataGridView.CurrentRow.Cells["roomNameDataGridViewTextBoxColumn"].Value.ToString(),
                    (int)inventoryDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn"].Value
                    ).Delete();
                saveToBD(this.propertyRegisterDataSet.Inventory.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                inventoryTableAdapter.Fill(propertyRegisterDataSet.Inventory);
            }
        }

        #endregion

        #region Вкладка Имущество

        private void UnitButtonAdd_Click(object sender, EventArgs e)
        {
            UnitFormEdit form = new UnitFormEdit(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                unitBindingSource.ResetBindings(true);
            }
        }

        private void UnitButtonEdit_Click(object sender, EventArgs e)
        {
            UnitFormEdit form = new UnitFormEdit(
                propertyRegisterDataSet, 
                (int)unitDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn1"].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                unitBindingSource.ResetBindings(false);
            }
        }

        private void UnitButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.Unit.FindByunitId(
                    (int)unitDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn1"].Value).Delete();
                saveToBD(this.propertyRegisterDataSet.Unit.TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                unitTableAdapter.Fill(propertyRegisterDataSet.Unit);
            }
        }

        #endregion

        #region Меню

        private void ЗданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingForm form = new BuildingForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                roomBindingSource.ResetBindings(false);
            }
        }

        private void ПодразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrgUnitForm form = new OrgUnitForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                roomBindingSource.ResetBindings(false);
            }
        }

        private void МатОтвественныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheifForm form = new CheifForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                roomBindingSource.ResetBindings(false);
            }
        }

        private void ТипПомещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeRoomForm form = new TypeRoomForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                roomBindingSource.ResetBindings(false);
            }
        }

        private void ПереоценитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  new PropertyRegisterDataSetTableAdapters.QueriesTableAdapter().Reevaluate();

            //using (var sqlConn = new SqlConnection(Properties.Settings.Default.ConnectionString))
            //{
            //    var sqlCmd = new SqlCommand("Reevaluate", sqlConn);
            //    sqlCmd.CommandType = CommandType.StoredProcedure;

            //    sqlConn.Open();
            //    sqlCmd.ExecuteNonQuery();

            //    this.revaluationTableAdapter.Fill(this.propertyRegisterDataSet.Revaluation);
            //}
        }

        private void СкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm form = new StorageForm(propertyRegisterDataSet);
            if(form.ShowDialog()==DialogResult.OK) roomBindingSource.ResetBindings(false);
        }

        private void ТипИмуществаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeUnitForm form = new TypeUnitForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK) unitBindingSource.ResetBindings(false);
        }

        #endregion
    }
}
