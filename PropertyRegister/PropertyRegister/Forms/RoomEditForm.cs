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
    public partial class RoomEditForm : Form
    {
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private PropertyRegisterDataSet.RoomRow roomRow;
        private string roomName = "";

        public RoomEditForm(PropertyRegisterDataSet propertyRegisterDataSet)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.roomRow = propertyRegisterDataSet.Room.NewRoomRow();
        }

        public RoomEditForm(PropertyRegisterDataSet propertyRegisterDataSet, string roomName)
        {
            InitializeComponent();
            this.propertyRegisterDataSet = propertyRegisterDataSet;
            this.roomName = roomName;
            this.roomRow = propertyRegisterDataSet.Room.FindByroomName(roomName);

            roomNameTextBox.DataBindings.Add("Text", roomRow, "roomName");
            squareNumericUpDown.DataBindings.Add("Text", roomRow, "square");
            windowsNumericUpDown.DataBindings.Add("Text", roomRow, "windows");

            roomNameTextBox.Text.Trim();
        }

        private void RoomFormEdit_Load(object sender, EventArgs e)
        {
            buildingIdComboBox.DataSource = propertyRegisterDataSet.Building;
            buildingIdComboBox.DisplayMember = "buildingName";
            buildingIdComboBox.ValueMember = "buildingId";
            if (roomName != "") buildingIdComboBox.SelectedValue = roomRow.buildingId;

            typeRoomIdComboBox.DataSource = propertyRegisterDataSet.TypeRoom;
            typeRoomIdComboBox.DisplayMember = "type";
            typeRoomIdComboBox.ValueMember = "typeRoomId";
            if (roomName != "") typeRoomIdComboBox.SelectedValue = roomRow.typeRoomId;

            orgUnitIdComboBox.DataSource = propertyRegisterDataSet.OrgUnit;
            orgUnitIdComboBox.DisplayMember = "orgUnitName";
            orgUnitIdComboBox.ValueMember = "orgUnitId";
            if (roomName != "") orgUnitIdComboBox.SelectedValue = roomRow.orgUnitId;


            var tmp = propertyRegisterDataSet.Chief
                .Select(x => new
                {
                    x.chiefId,
                    fio = x.surname + " " + x.name[0] + "." + (x.patronymic != null ? x.patronymic[0] + "." : null)
                })
                .ToList();

            cheifIdComboBox.DataSource = tmp;
            cheifIdComboBox.DisplayMember = "fio";
            cheifIdComboBox.ValueMember = "chiefId";
            if (roomName != "") cheifIdComboBox.SelectedValue = roomRow.chiefId;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            roomRow.roomName = roomNameTextBox.Text;
            roomRow.square = squareNumericUpDown.Value;
            roomRow.windows = int.Parse(windowsNumericUpDown.Text);
            roomRow.buildingId = (int)buildingIdComboBox.SelectedValue;
            roomRow.typeRoomId = (int)typeRoomIdComboBox.SelectedValue;
            roomRow.orgUnitId = (int)orgUnitIdComboBox.SelectedValue;
            roomRow.chiefId = (int)cheifIdComboBox.SelectedValue;

            try
            {
                if (roomName == "") propertyRegisterDataSet.Room.AddRoomRow(roomRow);
                new PropertyRegisterDataSetTableAdapters.RoomTableAdapter().Update(roomRow);
                propertyRegisterDataSet.Room.AcceptChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
               // this.Close();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
