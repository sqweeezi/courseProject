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
    public partial class TypeUnitForm : Form
    {
        public TypeUnitForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            typeUnitBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void TypeUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.TypeUnit". При необходимости она может быть перемещена или удалена.
            this.typeUnitTableAdapter.Fill(this.propertyRegisterDataSet.TypeUnit);
        }

        private void TypeUnitAddButton_Click(object sender, EventArgs e)
        {
            TypeRoomEditForm form = new TypeRoomEditForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TypeUnitEditButton_Click(object sender, EventArgs e)
        {
            TypeRoomEditForm form = new TypeRoomEditForm(
                propertyRegisterDataSet, 
                (int)typeUnitDataGridView.CurrentRow.Cells[1].Value
                );
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void TypeUnitDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.TypeUnit.FindBytypeUnitId((int)typeUnitDataGridView.CurrentRow.Cells[1].Value).Delete();
                typeUnitTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.TypeUnit.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                typeUnitTableAdapter.Fill(propertyRegisterDataSet.TypeUnit);
            }
        }
    }
}
