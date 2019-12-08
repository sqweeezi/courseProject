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
    public partial class WriteOffForm : Form
    {
        bool dialogRes = false;

        public WriteOffForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            unitWriteOffBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void WriteOffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.UnitWriteOff". При необходимости она может быть перемещена или удалена.
            this.unitWriteOffTableAdapter.Fill(this.propertyRegisterDataSet.UnitWriteOff);

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult= MessageBox.Show(
                    "Удаление будет произведено коскадно.\n" +
                    "Отменить удаление не возможно\n" +
                    "\nВы уверены?",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    new PropertyRegisterDataSetTableAdapters.QueriesTableAdapter()
                        .deleteUnit(
                        (int)unitWriteOffDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value
                        );

                    int pos = unitWriteOffBindingSource.Position;
                    this.unitWriteOffTableAdapter.Fill(this.propertyRegisterDataSet.UnitWriteOff);
                    unitWriteOffBindingSource.Position = pos;

                    dialogRes = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRoolBack_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Вы уверены?",
                    "Отменить списание",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    new PropertyRegisterDataSetTableAdapters.QueriesTableAdapter()
                        .roolBackUnit(
                        (int)unitWriteOffDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value
                        );

                    int pos = unitWriteOffBindingSource.Position;
                    this.unitWriteOffTableAdapter.Fill(this.propertyRegisterDataSet.UnitWriteOff);
                    unitWriteOffBindingSource.Position = pos;

                    dialogRes = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteOffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dialogRes) this.DialogResult = DialogResult.OK;
        }
    }
}
