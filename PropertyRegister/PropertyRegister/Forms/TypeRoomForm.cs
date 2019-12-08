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
    public partial class TypeRoomForm : Form
    {
        public TypeRoomForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            typeRoomBindingSource.DataSource = propertyRegisterDataSet;
        }

        private void TypeRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propertyRegisterDataSet.TypeRoom". При необходимости она может быть перемещена или удалена.
            this.typeRoomTableAdapter.Fill(this.propertyRegisterDataSet.TypeRoom);
        }

        private void TypeRoomButtonAdd_Click(object sender, EventArgs e)
        {
            TypeRoomEditForm form = new TypeRoomEditForm(propertyRegisterDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                typeRoomBindingSource.ResetBindings(true);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TypeRoomButtonEdit_Click(object sender, EventArgs e)
        {
            TypeRoomEditForm form = new TypeRoomEditForm(
                propertyRegisterDataSet, 
                (int)typeRoomDataGridView.CurrentRow.Cells[1].Value
                );
            if (form.ShowDialog() == DialogResult.OK)
            {
                typeRoomBindingSource.ResetBindings(false);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TypeRoomButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                propertyRegisterDataSet.TypeRoom.FindBytypeRoomId((int)typeRoomDataGridView.CurrentRow.Cells[1].Value).Delete();
                typeRoomTableAdapter.Update(propertyRegisterDataSet);
                propertyRegisterDataSet.TypeRoom.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                typeRoomTableAdapter.Fill(propertyRegisterDataSet.TypeRoom);
            }
        }
    }
}
