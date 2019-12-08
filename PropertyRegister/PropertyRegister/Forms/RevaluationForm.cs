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
    public partial class RevaluationForm : Form
    {
        public RevaluationForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            notRevaluationBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void RevaluationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.NotRevaluation". При необходимости она может быть перемещена или удалена.
            this.notRevaluationTableAdapter.Fill(this.propertyRegisterDataSet.NotRevaluation);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (notRevaluationBindingSource.Count == 0)
                {
                    MessageBox.Show("Нет не переоцененного имущества", "Переоценка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                new PropertyRegisterDataSetTableAdapters.QueriesTableAdapter().ReRevaluation();
                //queriesTableAdapter.ReRevaluation();


                MessageBox.Show("Переоценка выполнена успешно", "Переоценка", MessageBoxButtons.OK, MessageBoxIcon.Information);

                notRevaluationBindingSource.ResetBindings(true);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
