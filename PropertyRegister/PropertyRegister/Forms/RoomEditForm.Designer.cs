namespace PropertyRegister.Forms
{
    partial class RoomEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label squareLabel;
            System.Windows.Forms.Label windowsLabel;
            System.Windows.Forms.Label buildingIdLabel;
            System.Windows.Forms.Label typeRoomIdLabel;
            System.Windows.Forms.Label orgUnitIdLabel;
            System.Windows.Forms.Label chiefIdLabel;
            System.Windows.Forms.Label roomNameLabel;
            this.buildingIdComboBox = new System.Windows.Forms.ComboBox();
            this.typeRoomIdComboBox = new System.Windows.Forms.ComboBox();
            this.orgUnitIdComboBox = new System.Windows.Forms.ComboBox();
            this.cheifIdComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.windowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.squareNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            squareLabel = new System.Windows.Forms.Label();
            windowsLabel = new System.Windows.Forms.Label();
            buildingIdLabel = new System.Windows.Forms.Label();
            typeRoomIdLabel = new System.Windows.Forms.Label();
            orgUnitIdLabel = new System.Windows.Forms.Label();
            chiefIdLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.windowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // squareLabel
            // 
            squareLabel.AutoSize = true;
            squareLabel.Location = new System.Drawing.Point(83, 49);
            squareLabel.Name = "squareLabel";
            squareLabel.Size = new System.Drawing.Size(69, 16);
            squareLabel.TabIndex = 3;
            squareLabel.Text = "Площадь:";
            // 
            // windowsLabel
            // 
            windowsLabel.AutoSize = true;
            windowsLabel.Location = new System.Drawing.Point(63, 79);
            windowsLabel.Name = "windowsLabel";
            windowsLabel.Size = new System.Drawing.Size(89, 16);
            windowsLabel.TabIndex = 5;
            windowsLabel.Text = "Кол-во окон:";
            // 
            // buildingIdLabel
            // 
            buildingIdLabel.AutoSize = true;
            buildingIdLabel.Location = new System.Drawing.Point(92, 113);
            buildingIdLabel.Name = "buildingIdLabel";
            buildingIdLabel.Size = new System.Drawing.Size(60, 16);
            buildingIdLabel.TabIndex = 7;
            buildingIdLabel.Text = "Здание:";
            // 
            // typeRoomIdLabel
            // 
            typeRoomIdLabel.AutoSize = true;
            typeRoomIdLabel.Location = new System.Drawing.Point(40, 144);
            typeRoomIdLabel.Name = "typeRoomIdLabel";
            typeRoomIdLabel.Size = new System.Drawing.Size(112, 16);
            typeRoomIdLabel.TabIndex = 9;
            typeRoomIdLabel.Text = "Тип помещения:";
            // 
            // orgUnitIdLabel
            // 
            orgUnitIdLabel.AutoSize = true;
            orgUnitIdLabel.Location = new System.Drawing.Point(35, 175);
            orgUnitIdLabel.Name = "orgUnitIdLabel";
            orgUnitIdLabel.Size = new System.Drawing.Size(117, 16);
            orgUnitIdLabel.TabIndex = 11;
            orgUnitIdLabel.Text = "Подразделение:";
            // 
            // chiefIdLabel
            // 
            chiefIdLabel.AutoSize = true;
            chiefIdLabel.Location = new System.Drawing.Point(15, 207);
            chiefIdLabel.Name = "chiefIdLabel";
            chiefIdLabel.Size = new System.Drawing.Size(137, 16);
            chiefIdLabel.TabIndex = 13;
            chiefIdLabel.Text = "Мат. ответсвенный:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(75, 23);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(77, 16);
            roomNameLabel.TabIndex = 1;
            roomNameLabel.Text = "Название:";
            // 
            // buildingIdComboBox
            // 
            this.buildingIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingIdComboBox.FormattingEnabled = true;
            this.buildingIdComboBox.Location = new System.Drawing.Point(158, 110);
            this.buildingIdComboBox.Name = "buildingIdComboBox";
            this.buildingIdComboBox.Size = new System.Drawing.Size(182, 23);
            this.buildingIdComboBox.TabIndex = 15;
            // 
            // typeRoomIdComboBox
            // 
            this.typeRoomIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeRoomIdComboBox.FormattingEnabled = true;
            this.typeRoomIdComboBox.Location = new System.Drawing.Point(158, 141);
            this.typeRoomIdComboBox.Name = "typeRoomIdComboBox";
            this.typeRoomIdComboBox.Size = new System.Drawing.Size(182, 23);
            this.typeRoomIdComboBox.TabIndex = 16;
            // 
            // orgUnitIdComboBox
            // 
            this.orgUnitIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgUnitIdComboBox.FormattingEnabled = true;
            this.orgUnitIdComboBox.Location = new System.Drawing.Point(158, 172);
            this.orgUnitIdComboBox.Name = "orgUnitIdComboBox";
            this.orgUnitIdComboBox.Size = new System.Drawing.Size(182, 23);
            this.orgUnitIdComboBox.TabIndex = 17;
            // 
            // cheifIdComboBox
            // 
            this.cheifIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cheifIdComboBox.FormattingEnabled = true;
            this.cheifIdComboBox.Location = new System.Drawing.Point(158, 204);
            this.cheifIdComboBox.Name = "cheifIdComboBox";
            this.cheifIdComboBox.Size = new System.Drawing.Size(182, 23);
            this.cheifIdComboBox.TabIndex = 18;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(172, 260);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(265, 260);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 27);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // windowsNumericUpDown
            // 
            this.windowsNumericUpDown.Location = new System.Drawing.Point(158, 77);
            this.windowsNumericUpDown.Name = "windowsNumericUpDown";
            this.windowsNumericUpDown.Size = new System.Drawing.Size(72, 21);
            this.windowsNumericUpDown.TabIndex = 21;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(158, 20);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(72, 21);
            this.roomNameTextBox.TabIndex = 2;
            // 
            // squareNumericUpDown
            // 
            this.squareNumericUpDown.Location = new System.Drawing.Point(158, 47);
            this.squareNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.squareNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.squareNumericUpDown.Name = "squareNumericUpDown";
            this.squareNumericUpDown.Size = new System.Drawing.Size(72, 21);
            this.squareNumericUpDown.TabIndex = 22;
            this.squareNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheifIdComboBox);
            this.groupBox1.Controls.Add(this.squareNumericUpDown);
            this.groupBox1.Controls.Add(chiefIdLabel);
            this.groupBox1.Controls.Add(this.windowsNumericUpDown);
            this.groupBox1.Controls.Add(orgUnitIdLabel);
            this.groupBox1.Controls.Add(typeRoomIdLabel);
            this.groupBox1.Controls.Add(buildingIdLabel);
            this.groupBox1.Controls.Add(windowsLabel);
            this.groupBox1.Controls.Add(this.orgUnitIdComboBox);
            this.groupBox1.Controls.Add(squareLabel);
            this.groupBox1.Controls.Add(this.typeRoomIdComboBox);
            this.groupBox1.Controls.Add(this.roomNameTextBox);
            this.groupBox1.Controls.Add(this.buildingIdComboBox);
            this.groupBox1.Controls.Add(roomNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 242);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // RoomFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RoomFormEdit";
            this.Text = "RoomFormEdit";
            this.Load += new System.EventHandler(this.RoomFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.windowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox buildingIdComboBox;
        private System.Windows.Forms.ComboBox typeRoomIdComboBox;
        private System.Windows.Forms.ComboBox orgUnitIdComboBox;
        private System.Windows.Forms.ComboBox cheifIdComboBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown windowsNumericUpDown;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.NumericUpDown squareNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}