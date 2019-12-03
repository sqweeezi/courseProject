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
    public partial class StorageEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.StorageRow storageRow;
        //private int typeRoomId = -1;

        public StorageEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.storageRow = propertyRegisterDataSet.Storage.NewStorageRow();
        }

        //public StorageEditForm(PropertyRegisterDataSet propertyRegisterDataSet, int typeRoomId)
        //{
        //    InitializeComponent();
        //    this.propertyRegisterDataSet = propertyRegisterDataSet;
        //    this.typeRoomId = typeRoomId;
        //    this.typeRoomRow = propertyRegisterDataSet.TypeRoom.FindBytypeRoomId(typeRoomId);

        //    //targetTextBox.DataBindings.Add("Text", typeRoomRow, "target");
        //}
    }
}
