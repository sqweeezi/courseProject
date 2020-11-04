using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PropertyRegister.Forms
{
    public partial class OtchetForm : Form
    {
        BindingSource bindingSource = new BindingSource();


        public OtchetForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.buildingBindingSource.DataSource = propertyRegisterDataSet;
            this.roomBindingSource.DataSource = propertyRegisterDataSet;
            this.orgUnitBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void OtchetForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.OrgUnit". При необходимости она может быть перемещена или удалена.
            this.orgUnitTableAdapter.Fill(this.propertyRegisterDataSet.OrgUnit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.propertyRegisterDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.propertyRegisterDataSet.Building);




            //(checkedListBox1 as ListBox).DataSource = buildingBindingSource;
            //(checkedListBox1 as ListBox).DisplayMember = "buildingName";
            //(checkedListBox1 as ListBox).ValueMember = "buildingId";

            //(checkedListBox2 as ListBox).DataSource = orgUnitBindingSource;
            //(checkedListBox2 as ListBox).DisplayMember = "orgUnitName";
            //(checkedListBox2 as ListBox).ValueMember = "orgUnitId";



            //var tmp = propertyRegisterDataSet.Inventory
            //    .Where(x => x.roomName == inventoryRow.roomName)
            //    .Select(x => x.unitId)                              
            //    .ToList();


            //(checkedListBox3 as ListBox).DataSource = roomBindingSource;
            //(checkedListBox3 as ListBox).DisplayMember = "roomName";
            //(checkedListBox3 as ListBox).ValueMember = "roomName";






            checkedListBox1.Items.Insert(0, "(Выделить все)");
            checkedListBox1.Items.AddRange(propertyRegisterDataSet.Building.Select(x => x.buildingName).ToArray());

            checkedListBox2.Items.Insert(0, "(Выделить все)");
            checkedListBox2.Items.AddRange(propertyRegisterDataSet.OrgUnit.Select(x => x.orgUnitName).ToArray());

            checkedListBox3.Items.Insert(0, "(Выделить все)");
            checkedListBox3.Items.AddRange(propertyRegisterDataSet.Room.Select(x => x.roomName).ToArray());

            checkedListBox1.ItemCheck += ItemCheck;
            checkedListBox2.ItemCheck += ItemCheck;
            checkedListBox3.ItemCheck += ItemCheck;

            checkedListBox1.ItemCheck += ItemCheck_1;
            checkedListBox2.ItemCheck += ItemCheck_2;

            checkedListBox1.SetItemChecked(0, true);
            checkedListBox2.SetItemChecked(0, true);
            checkedListBox3.SetItemChecked(0, true);
        }

        private void ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            List<string> lst = new List<string>();

            for (int i = 1; i < checkedListBox1.Items.Count; i++)
            {
                bool flag = checkedListBox1.GetItemChecked(i);
                if (i == e.Index) flag = e.NewValue == CheckState.Checked ? true : false;

                if (flag)
                    lst.Add(checkedListBox1.Items[i].ToString());
            }

            var tmp = (
                from tab1 in propertyRegisterDataSet.Room
                join tab2 in propertyRegisterDataSet.OrgUnit on tab1.orgUnitId equals tab2.orgUnitId
                join tab3 in propertyRegisterDataSet.Building on tab1.buildingId equals tab3.buildingId
                select new
                {
                    tab3.buildingName,
                    tab2.orgUnitName,
                    tab1.roomName
                });

            //var result = tmp
            //    .Where(n => lst.Any(t => t == n.buildingName))
            //    .Select(x => x.orgUnitName)
            //    .Distinct();

            var result = (
                from tab1 in tmp
                join tab2 in lst on tab1.buildingName equals tab2

                select new
                {
                    tab1.orgUnitName
                })
                .Select(x => x.orgUnitName)
                .Distinct();

            checkedListBox2.Items.Clear();
            checkedListBox2.Items.Insert(0, "(Выделить все)");
            checkedListBox2.Items.AddRange(result.ToArray());
            checkedListBox2.SetItemChecked(0, true);







            List<string> lst1 = new List<string>();

            for (int i = 1; i < checkedListBox2.Items.Count; i++)
            {
                bool flag = checkedListBox2.GetItemChecked(i);
                //if (i == e.Index) flag = e.NewValue == CheckState.Checked ? true : false;

                if (flag)
                    lst1.Add(checkedListBox2.Items[i].ToString());
            }


            var tmp1 = (
                from tab1 in propertyRegisterDataSet.Room
                join tab2 in propertyRegisterDataSet.OrgUnit on tab1.orgUnitId equals tab2.orgUnitId
                join tab3 in propertyRegisterDataSet.Building on tab1.buildingId equals tab3.buildingId
                select new
                {
                    tab3.buildingName,
                    tab2.orgUnitName,
                    tab1.roomName
                });

            //var result = tmp
            //    .Where(n => lst.Any(t => t == n.buildingName))
            //    .Select(x => x.orgUnitName)
            //    .Distinct();

            var result1 = (
                from tab1 in tmp1
                join tab2 in lst on tab1.buildingName equals tab2
                join tab3 in lst1 on tab1.orgUnitName equals tab3


                select new
                {
                    tab1.roomName
                })
                .Select(x => x.roomName)
                .Distinct();

            checkedListBox3.Items.Clear();
            checkedListBox3.Items.Insert(0, "(Выделить все)");
            checkedListBox3.Items.AddRange(result1.ToArray());
            checkedListBox3.SetItemChecked(0, true);
        }

        private void ItemCheck_2(object sender, ItemCheckEventArgs e)
        {
            List<string> lst = new List<string>();

            for (int i = 1; i < checkedListBox1.Items.Count; i++)
            {
                bool flag = checkedListBox1.GetItemChecked(i);
                //if (i == e.Index) flag = e.NewValue == CheckState.Checked ? true : false;

                if (flag)
                    lst.Add(checkedListBox1.Items[i].ToString());
            }


            List<string> lst1 = new List<string>();

            for (int i = 1; i < checkedListBox2.Items.Count; i++)
            {
                bool flag = checkedListBox2.GetItemChecked(i);
                if (i == e.Index) flag = e.NewValue == CheckState.Checked ? true : false;

                if (flag)
                    lst1.Add(checkedListBox2.Items[i].ToString());
            }

            var tmp1 = (
                from tab1 in propertyRegisterDataSet.Room
                join tab2 in propertyRegisterDataSet.OrgUnit on tab1.orgUnitId equals tab2.orgUnitId
                join tab3 in propertyRegisterDataSet.Building on tab1.buildingId equals tab3.buildingId
                select new
                {
                    tab3.buildingName,
                    tab2.orgUnitName,
                    tab1.roomName
                });

            //var result = tmp
            //    .Where(n => lst.Any(t => t == n.buildingName))
            //    .Select(x => x.orgUnitName)
            //    .Distinct();

            var result1 = (
                from tab1 in tmp1
                join tab2 in lst on tab1.buildingName equals tab2
                join tab3 in lst1 on tab1.orgUnitName equals tab3

                select new
                {
                    tab1.roomName
                })
                .Select(x => x.roomName)
                .Distinct();

            checkedListBox3.Items.Clear();
            checkedListBox3.Items.Insert(0, "(Выделить все)");
            checkedListBox3.Items.AddRange(result1.ToArray());
            checkedListBox3.SetItemChecked(0, true);
        }

        void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox lb = sender as CheckedListBox;

            checkedListBox1.ItemCheck -= ItemCheck_1;
            checkedListBox2.ItemCheck -= ItemCheck_2;

            if (e.Index != 0)
            {
                lb.ItemCheck -= ItemCheck;

                if (lb.GetItemChecked(0))
                    lb.SetItemChecked(0, false);

                // Установим флажок на 0 элементе, если все остальные выделены
                if (!lb.GetItemChecked(0))
                {
                    bool isChecked = true;
                    // 
                    for (int i = 1; i < lb.Items.Count; i++)
                    {
                        bool flag = lb.GetItemChecked(i);
                        if (i == e.Index) flag = e.NewValue == CheckState.Checked ? true : false;

                        if (!flag)
                        {
                            isChecked = false;
                            break;
                        }
                    }
                    if (isChecked) lb.SetItemChecked(0, true);
                }

                lb.ItemCheck += ItemCheck;
            }

            if (e.Index == 0)
            {
                lb.ItemCheck -= ItemCheck;

                bool flag = e.NewValue == CheckState.Checked ? true : false;
                for (int i = 1; i < lb.Items.Count; i++)
                    lb.SetItemChecked(i, flag);

                lb.ItemCheck += ItemCheck;
            }
            checkedListBox1.ItemCheck += ItemCheck_1;
            checkedListBox2.ItemCheck += ItemCheck_2;
        }

        private void drawBordersAround(Excel.Range eR, int tL)
        {
            if (tL == 1 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 2 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 3 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 4 || tL == 6 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 5 || tL == 7) eR.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            if (tL == 7) eR.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            /*List<string> lst = new List<string>();

            for (int i = 1; i < checkedListBox3.Items.Count; i++)
            {
                if (checkedListBox3.GetItemChecked(i))
                    lst.Add(checkedListBox3.Items[i].ToString());
            }


            var tmp1 = (
                from tab1 in propertyRegisterDataSet.Room
                join tab2 in propertyRegisterDataSet.OrgUnit on tab1.orgUnitId equals tab2.orgUnitId
                join tab3 in propertyRegisterDataSet.Building on tab1.buildingId equals tab3.buildingId
                join tab4lst in lst on tab1.roomName equals tab4lst

                select new
                {
                    tab3.buildingName,
                    tab2.orgUnitName,
                    tab1.roomName
                });


            string str = "";
            string buildingName = "";
            string orgUnitName = "";
            string roomName = "";

            foreach (var item in tmp1)
            {
                if (buildingName != item.buildingName) {
                    str += item.buildingName +"\n";

                    buildingName = item.buildingName;
                }

                if (orgUnitName != item.orgUnitName) {
                    str += "\t"+item.orgUnitName + "\n";

                    orgUnitName = item.orgUnitName;
                }

                if (roomName != item.roomName) {
                    str += "\t" + item.roomName+"\n";

                    roomName = item.roomName;
                }

                var tmpUnit = (
                        from inv in propertyRegisterDataSet.Inventory
                        join unit in propertyRegisterDataSet.Unit on inv.unitId equals unit.unitId
                        where inv.roomName == item.roomName
                        select new
                        {
                            inv.unitId,
                            unit.unitName,
                            unit.cost,
                            inv.count
                        });

                foreach (var itemUnit in tmpUnit)
                {
                    str += "\t\t" + itemUnit.unitName + "\n";
                }
            }

            MessageBox.Show(str);*/


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
            exSh.Name = "Пользовательский отчет";
            exSh.Cells[pY, 2] = "Пользовательский отчет " + DateTime.Now.Date.ToShortDateString();
            exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
            exRange.Merge(Type.Missing);                                    //Объединяем ячейки
            exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;    //Выравниваем по центру


            int tSumCount = 0;
            decimal tSumCost = 0;


            List<string> lst = new List<string>();

            for (int i = 1; i < checkedListBox3.Items.Count; i++)
            {
                if (checkedListBox3.GetItemChecked(i))
                    lst.Add(checkedListBox3.Items[i].ToString());
            }


            var otchet = (
                from tab1 in propertyRegisterDataSet.Room
                join tab2 in propertyRegisterDataSet.OrgUnit on tab1.orgUnitId equals tab2.orgUnitId
                join tab3 in propertyRegisterDataSet.Building on tab1.buildingId equals tab3.buildingId
                join tab4lst in lst on tab1.roomName equals tab4lst

                orderby tab3.buildingName, tab2.orgUnitName descending

                select new
                {
                    tab3.buildingName,
                    tab2.orgUnitName,
                    tab1.roomName
                });

            string buildingName = "";
            string orgUnitName = "";
            string roomName = "";

            foreach (var item in otchet)
            {
                //pY++;
                if (buildingName != item.buildingName)
                {
                    pY+=2;

                    exSh.Cells[pY, 2] = item.buildingName;

                    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                    exRange.Interior.Color = Color.FromArgb(204, 204, 153);
                    drawBordersAround(exRange, 6); //Рисует границы
                    exRange.Merge(Type.Missing);                                    //Объединяем ячейки
                    exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;    //Выравниваем по левой стороне

                    buildingName = item.buildingName;


                    if (orgUnitName == item.orgUnitName)
                    {
                        pY += 2;

                        exSh.Cells[pY, 2] = item.orgUnitName;

                        exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                        exRange.Interior.Color = Color.FromArgb(220, 220, 220);
                        drawBordersAround(exRange, 6); //Рисует границы
                        exRange.Merge(Type.Missing);                                    //Объединяем ячейки
                        exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;    //Выравниваем по левой стороне

                        orgUnitName = item.orgUnitName;
                    }
                }

                if (orgUnitName != item.orgUnitName)
                {
                    pY+=2;

                    exSh.Cells[pY, 2] = item.orgUnitName;

                    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                    exRange.Interior.Color = Color.FromArgb(220, 220, 220);
                    drawBordersAround(exRange, 6); //Рисует границы
                    exRange.Merge(Type.Missing);                                    //Объединяем ячейки
                    exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;    //Выравниваем по левой стороне

                    orgUnitName = item.orgUnitName;
                }

                if (roomName != item.roomName)
                {
                    pY++;

                    exSh.Cells[pY, 2] = item.roomName;

                    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                    exRange.Interior.Color = Color.FromArgb(255, 255, 153);
                    drawBordersAround(exRange, 6); //Рисует границы
                    exRange.Merge(Type.Missing);                                    //Объединяем ячейки
                    exRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;    //Выравниваем по левой стороне

                    roomName = item.roomName;
                }

                var tmpUnit = (
                        from inv in propertyRegisterDataSet.Inventory
                        join unit in propertyRegisterDataSet.Unit on inv.unitId equals unit.unitId
                        where inv.roomName == item.roomName
                        select new
                        {
                            inv.unitId,
                            unit.unitName,
                            unit.cost,
                            inv.count
                        });

                int sumCount = 0;
                decimal sumCost = 0;

                pY++;
                exSh.Cells[pY, 2] = "Наименование";
                exSh.Cells[pY, 3] = "Кол-во";
                exSh.Cells[pY, 4] = "Цена";
                exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                exRange.Interior.Color = Color.FromArgb(255, 255, 255);
                drawBordersAround(exRange, 7); //Рисует границы

                foreach (var itemUnit in tmpUnit)
                {
                    

                    pY++;

                    exSh.Cells[pY, 2] = itemUnit.unitName;
                    exSh.Cells[pY, 3] = itemUnit.count;
                    exSh.Cells[pY, 4] = itemUnit.cost;

                    exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                    exRange.Interior.Color = Color.FromArgb(255, 255, 255);
                    drawBordersAround(exRange, 7); //Рисует границы


                    sumCount += itemUnit.count;
                    sumCost += itemUnit.cost;
                }

                //pY++;

                exSh.Cells[pY, 2] = "Итог:";
                exSh.Cells[pY, 3] = sumCount;
                exSh.Cells[pY, 4] = sumCost;

                exRange = exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 4]];
                exRange.Interior.Color = Color.FromArgb(255, 255, 255);
                drawBordersAround(exRange, 7); //Рисует границы

                tSumCount += sumCount;
                tSumCost += sumCost;
            }

            pY += 2;

            exSh.Cells[pY, 2] = "Общий итог:";
            exSh.Cells[pY, 3] = tSumCount;
            exSh.Cells[pY, 4] = tSumCost;
            //Задаём ширину столбцов
            ((Excel.Range)exSh.Range[exSh.Cells[pY, 2], exSh.Cells[pY, 3]]).Columns.ColumnWidth = 35;
            ((Excel.Range)exSh.Range[exSh.Cells[pY, 3], exSh.Cells[pY, 5]]).EntireColumn.AutoFit();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "Пользовательский_отчет_" + DateTime.Now.Date.ToShortDateString() + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) exApp.ActiveWorkbook.SaveAs(saveFileDialog.FileName);
            exApp.Visible = true;

        }
    }
}

