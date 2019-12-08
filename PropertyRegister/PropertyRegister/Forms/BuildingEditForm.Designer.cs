namespace PropertyRegister.Forms
{
    partial class BuildingEditForm
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
            System.Windows.Forms.Label buildingNameLabel;
            System.Windows.Forms.Label landLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label flowLabel;
            this.buildingNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.landNumericUpDown = new System.Windows.Forms.NumericUpDown();
            buildingNameLabel = new System.Windows.Forms.Label();
            landLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            flowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingNameLabel
            // 
            buildingNameLabel.AutoSize = true;
            buildingNameLabel.Location = new System.Drawing.Point(64, 23);
            buildingNameLabel.Name = "buildingNameLabel";
            buildingNameLabel.Size = new System.Drawing.Size(110, 16);
            buildingNameLabel.TabIndex = 3;
            buildingNameLabel.Text = "Наименование:";
            // 
            // landLabel
            // 
            landLabel.AutoSize = true;
            landLabel.Location = new System.Drawing.Point(105, 53);
            landLabel.Name = "landLabel";
            landLabel.Size = new System.Drawing.Size(69, 16);
            landLabel.TabIndex = 5;
            landLabel.Text = "Площадь:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(123, 83);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(51, 16);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Адрес:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(60, 112);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(114, 16);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "Год подстройки:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(14, 143);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(160, 16);
            materialLabel.TabIndex = 11;
            materialLabel.Text = "Материал стен здания:";
            // 
            // flowLabel
            // 
            flowLabel.AutoSize = true;
            flowLabel.Location = new System.Drawing.Point(68, 172);
            flowLabel.Name = "flowLabel";
            flowLabel.Size = new System.Drawing.Size(106, 16);
            flowLabel.TabIndex = 13;
            flowLabel.Text = "Кол-во этажей:";
            // 
            // buildingNameTextBox
            // 
            this.buildingNameTextBox.Location = new System.Drawing.Point(180, 20);
            this.buildingNameTextBox.Name = "buildingNameTextBox";
            this.buildingNameTextBox.Size = new System.Drawing.Size(263, 21);
            this.buildingNameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(180, 80);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(263, 21);
            this.addressTextBox.TabIndex = 8;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(180, 140);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(263, 21);
            this.materialTextBox.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(275, 223);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(368, 223);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 27);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(180, 110);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(64, 21);
            this.yearNumericUpDown.TabIndex = 17;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // flowNumericUpDown
            // 
            this.flowNumericUpDown.Location = new System.Drawing.Point(180, 170);
            this.flowNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flowNumericUpDown.Name = "flowNumericUpDown";
            this.flowNumericUpDown.Size = new System.Drawing.Size(64, 21);
            this.flowNumericUpDown.TabIndex = 18;
            this.flowNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.landNumericUpDown);
            this.groupBox1.Controls.Add(this.buildingNameTextBox);
            this.groupBox1.Controls.Add(this.flowNumericUpDown);
            this.groupBox1.Controls.Add(flowLabel);
            this.groupBox1.Controls.Add(this.yearNumericUpDown);
            this.groupBox1.Controls.Add(this.materialTextBox);
            this.groupBox1.Controls.Add(materialLabel);
            this.groupBox1.Controls.Add(yearLabel);
            this.groupBox1.Controls.Add(buildingNameLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(landLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 205);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // landNumericUpDown
            // 
            this.landNumericUpDown.Location = new System.Drawing.Point(180, 50);
            this.landNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.landNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.landNumericUpDown.Name = "landNumericUpDown";
            this.landNumericUpDown.Size = new System.Drawing.Size(64, 21);
            this.landNumericUpDown.TabIndex = 19;
            this.landNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BuildingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BuildingEditForm";
            this.Text = "FormBuildingEdit";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox buildingNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown flowNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown landNumericUpDown;
    }
}