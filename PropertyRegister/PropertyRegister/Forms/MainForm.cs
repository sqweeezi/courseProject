using PropertyRegister.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
                (first != -1 && !second ? " and " : "") +
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
                if (tableName == propertyRegisterDataSet.Storage.TableName)
                {
                    storageTableAdapter.Update(propertyRegisterDataSet);
                    propertyRegisterDataSet.Storage.AcceptChanges();
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
            unitDataGridView.Dispose();
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
                //storageBindingSource.ResetBindings(false);
                this.storageTableAdapter.Fill(this.propertyRegisterDataSet.Storage);
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
                //storageBindingSource.ResetBindings(false);
                this.storageTableAdapter.Fill(this.propertyRegisterDataSet.Storage);
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
                storageBindingSource.ResetBindings(false);
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

        private void RoomButtonWriteOff_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Вы уверены?",
                    "Выполнить списание",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    new PropertyRegisterDataSetTableAdapters.QueriesTableAdapter()
                        .writeOffUnit(
                        (int)unitDataGridView.CurrentRow.Cells["unitIdDataGridViewTextBoxColumn1"].Value
                        );

                    int selected = unitBindingSource.Position;
                    this.unitTableAdapter.Fill(this.propertyRegisterDataSet.Unit);
                    unitBindingSource.Position = selected;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void СписаноеИмуществоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteOffForm form = new WriteOffForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int pos = unitBindingSource.Position;
                this.unitTableAdapter.Fill(this.propertyRegisterDataSet.Unit);
                unitBindingSource.Position = pos;

                int pos1 = fKInventoryroomN76177A41BindingSource.Position;
                this.inventoryTableAdapter.Fill(this.propertyRegisterDataSet.Inventory);
                fKInventoryroomN76177A41BindingSource.Position = pos1;

            }
        }

        private void ПереоценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevaluationForm form = new RevaluationForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.revaluationTableAdapter.Fill(this.propertyRegisterDataSet.Revaluation);
                fKRevaluatiunitI7246E95DBindingSource.ResetBindings(true);
            }
        }

        #endregion


        private void drawBordersAround(Excel.Range eR, int tL)
        {
            if (tL == 1 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 2 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 3 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 4 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 5 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 7) eR.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
        }


        private void ПолныйОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                    "Создание отчета может занять некоторое время.\n" +
                    "\nПродолжить?",
                    "Однопоточное выполнение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) return;
            

            Excel.Application exApp = new Excel.Application();
            exApp.SheetsInNewWorkbook = 1;
            exApp.Workbooks.Add();
            Excel.Worksheet exSh = exApp.Sheets[1];
            Excel.Range exRange;

            exSh.Columns[2].ColumnWidth = 90;
            exSh.Columns[3].ColumnWidth = 30;
            exSh.Columns[4].ColumnWidth = 30;

            int pY = 1; //текущая строка в excel
            exSh.Name = "Полный отчет";
            exSh.Cells[pY, 2] = "Полный отчет";
            exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
            exRange.Merge(Type.Missing);                                    //Объединяем ячейки
            exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;    //Выравниваем по центру


            pY++;
            exSh.Cells[pY, 2] = "Наименование";
            exSh.Cells[pY, 3] = "Кол-во";
            exSh.Cells[pY, 4] = "Цена";

            exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
            exRange.Interior.Color = Color.FromArgb(255, 255, 255);
            drawBordersAround(exRange, 7); //Рисует границы

            int tSumCount = 0;
            decimal tSumCost = 0;

            var otchet = propertyRegisterDataSet.Building.ToList();


            foreach (PropertyRegisterDataSet.BuildingRow item in otchet)
            {
                pY++;

                exSh.Cells[pY, 2] = item.buildingName;

                exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                exRange.Interior.Color = Color.FromArgb(204, 204, 153);
                drawBordersAround(exRange, 6); //Рисует границы

                var otchet01 = propertyRegisterDataSet.Room.Where(row => row.buildingId == item.buildingId);

                foreach (PropertyRegisterDataSet.RoomRow item01 in otchet01)
                {
                    pY++;

                    exSh.Cells[pY, 2] = item01.roomName;

                    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                    exRange.Interior.Color = Color.FromArgb(255, 255, 153);
                    drawBordersAround(exRange, 6); //Рисует границы
                    exRange.Merge(Type.Missing);                                    //Объединяем ячейки
                    exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;    //Выравниваем по левой стороне

                    var otchet02 = (
                        from inv in propertyRegisterDataSet.Inventory
                        join unit in propertyRegisterDataSet.Unit on inv.unitId equals unit.unitId
                        where inv.roomName == item01.roomName
                        select new
                        {
                            inv.unitId,
                            unit.unitName,
                            unit.cost,
                            inv.count
                        });

                    int sumCount = 0;
                    decimal sumCost = 0;
                    foreach (var item02 in otchet02)
                    {
                        pY++;

                        exSh.Cells[pY, 2] = item02.unitName;
                        exSh.Cells[pY, 3] = item02.count;
                        exSh.Cells[pY, 4] = item02.cost;

                        exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                        exRange.Interior.Color = Color.FromArgb(255, 255, 255);
                        drawBordersAround(exRange, 7); //Рисует границы


                        sumCount += item02.count;
                        sumCost += item02.cost;
                    }

                    pY++;

                    exSh.Cells[pY, 2] = "Итог:";
                    exSh.Cells[pY, 3] = sumCount;
                    exSh.Cells[pY, 4] = sumCost;

                    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                    exRange.Interior.Color = Color.FromArgb(255, 255, 255);
                    drawBordersAround(exRange, 7); //Рисует границы

                    tSumCount += sumCount;
                    tSumCost += sumCost;
                }
            }

            pY += 2;

            exSh.Cells[pY, 2] = "Общий итог:";
            exSh.Cells[pY, 3] = tSumCount;
            exSh.Cells[pY, 4] = tSumCost;
            //foreach (DataGridViewRow item in dataGridViewVibor.Rows)
            //{
            //    pY++;
            //    if ((int)item.Cells[0].Value != trapezi)
            //    {
            //        trapezi = (int)item.Cells[0].Value;
            //        exSh.Cells[pY, 2] = dataSetAll.Trapezi.FindBycod_trapezi((int)item.Cells[0].Value).nazvanie; //Выводим название трапезы

            //        exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 5]];
            //        exRange.Interior.Color = Color.FromArgb(255, 255, 0);
            //        drawBordersAround(exRange, 6); //Рисует границы

            //        pY++;
            //    }

            //    exSh.Cells[pY, 3] = dataSetAll.Vid_blud.FindBycod_vid_bluda((int)item.Cells[1].Value).nazvanie.Trim();
            //    exSh.Cells[pY, 4] = dataSetAll.Bluda.FindBycod_bluda((int)item.Cells[2].Value).nazvanie.Trim();
            //    exSh.Cells[pY, 5] = item.Cells[4].Value + " Ккал";


            //    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 5]];
            //    exRange.Interior.Color = Color.FromArgb(255, 230, 153);
            //    drawBordersAround(exRange, 6); //Рисует границы



            //    //pY++;
            //    //exSh.Cells[pY, 3] = iVb; //Выводим название вида блюд
            //    //exSh.Cells[pY, 5] = "Кол-во"; //Надпись "Кол-во"

            //    //exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 5]];
            //    //exRange.Interior.Color = Color.FromArgb(189, 215, 238);
            //    //drawBordersAround(exRange, 6);
            //    //drawBordersAround(((Excel.Range)exSh.Range[exSh.Cells[pY, 5], exSh.Cells[pY, 5]]), 1);

            //    ////Получаем все блюда для текущей трапезы, вида блюда
            //    //var bluda = dlyaPovara.Where(row => row.trapeza == item && row.vidBluda == iVb).ToList();
            //    //foreach (var iBl in bluda)
            //    //{
            //    //    pY++; exSh.Cells[pY, 4] = iBl.bludo; //Выводим название блюда
            //    //    exSh.Cells[pY, 5] = iBl.kolvo; //Выводим количество блюд

            //    //    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 5]];
            //    //    drawBordersAround(exRange, 6);
            //    //    drawBordersAround(((Excel.Range)exSh.Range[exSh.Cells[pY, 5], exSh.Cells[pY, 5]]), 1);
            //    //}

            //}
            //Задаём ширину столбцов
            ((Excel.Range)exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 3]]).Columns.ColumnWidth = 35;
            ((Excel.Range)exSh.Range[exSh.Cells[pY, 3], exSh.Cells[pY, 5]]).EntireColumn.AutoFit();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "Отчет.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) exApp.ActiveWorkbook.SaveAs(saveFileDialog.FileName);
            exApp.Visible = true;

        }
    }
}
