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
    public partial class TypeRoomEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.TypeRoomRow typeRoomRow;
        private int typeRoomId = -1;

        public TypeRoomEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.typeRoomRow = propertyRegisterDataSet.TypeRoom.NewTypeRoomRow();
        }

        public TypeRoomEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int typeRoomId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.typeRoomId = typeRoomId;
            this.typeRoomRow = propertyRegisterDataSet.TypeRoom.FindBytypeRoomId(typeRoomId);

            typeTextBox.DataBindings.Add("Text", typeRoomRow, "type");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            typeRoomRow.type = typeTextBox.Text;

            try
            {
                if (typeRoomId == -1) propertyRegisterDataSet.TypeRoom.AddTypeRoomRow(typeRoomRow);
                new PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter().Update(typeRoomRow);
                propertyRegisterDataSet.TypeRoom.AcceptChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                //this.Close();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
