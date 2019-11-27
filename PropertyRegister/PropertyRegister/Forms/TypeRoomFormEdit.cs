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
    public partial class TypeRoomFormEdit : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.TypeRoomRow typeRoomRow;
        private int typeRoomId = -1;

        public TypeRoomFormEdit(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.typeRoomRow = propertyRegisterDataSet.TypeRoom.NewTypeRoomRow();
        }

        public TypeRoomFormEdit(PropertyRegisterDataSet propertyRegisterDataSet, int typeRoomId)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.typeRoomId = typeRoomId;
            this.typeRoomRow = propertyRegisterDataSet.TypeRoom.FindBytypeRoomId(typeRoomId);

            targetTextBox.DataBindings.Add("Text", typeRoomRow, "target");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            typeRoomRow.target = targetTextBox.Text;

            try
            {
                if (typeRoomId == -1) propertyRegisterDataSet.TypeRoom.AddTypeRoomRow(typeRoomRow);
                new PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter().Update(typeRoomRow);
                propertyRegisterDataSet.TypeRoom.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
