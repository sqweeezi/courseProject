namespace PropertyRegister.Forms
{
    partial class BuildingFormEdit
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
            System.Windows.Forms.Label buildingIdLabel;
            System.Windows.Forms.Label buildingNameLabel;
            System.Windows.Forms.Label landLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label flowLabel;
            this.buildingNameTextBox = new System.Windows.Forms.TextBox();
            this.landTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            buildingIdLabel = new System.Windows.Forms.Label();
            buildingNameLabel = new System.Windows.Forms.Label();
            landLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            flowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingIdLabel
            // 
            buildingIdLabel.AutoSize = true;
            buildingIdLabel.Location = new System.Drawing.Point(134, 73);
            buildingIdLabel.Name = "buildingIdLabel";
            buildingIdLabel.Size = new System.Drawing.Size(58, 13);
            buildingIdLabel.TabIndex = 1;
            buildingIdLabel.Text = "building Id:";
            // 
            // buildingNameLabel
            // 
            buildingNameLabel.AutoSize = true;
            buildingNameLabel.Location = new System.Drawing.Point(134, 99);
            buildingNameLabel.Name = "buildingNameLabel";
            buildingNameLabel.Size = new System.Drawing.Size(77, 13);
            buildingNameLabel.TabIndex = 3;
            buildingNameLabel.Text = "building Name:";
            // 
            // buildingNameTextBox
            // 
            this.buildingNameTextBox.Location = new System.Drawing.Point(217, 96);
            this.buildingNameTextBox.Name = "buildingNameTextBox";
            this.buildingNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.buildingNameTextBox.TabIndex = 4;
            // 
            // landLabel
            // 
            landLabel.AutoSize = true;
            landLabel.Location = new System.Drawing.Point(134, 125);
            landLabel.Name = "landLabel";
            landLabel.Size = new System.Drawing.Size(30, 13);
            landLabel.TabIndex = 5;
            landLabel.Text = "land:";
            // 
            // landTextBox
            // 
            this.landTextBox.Location = new System.Drawing.Point(217, 122);
            this.landTextBox.Name = "landTextBox";
            this.landTextBox.Size = new System.Drawing.Size(226, 20);
            this.landTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(134, 151);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(217, 148);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(226, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(134, 177);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(30, 13);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "year:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(134, 203);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(46, 13);
            materialLabel.TabIndex = 11;
            materialLabel.Text = "material:";
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(217, 200);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(226, 20);
            this.materialTextBox.TabIndex = 12;
            // 
            // flowLabel
            // 
            flowLabel.AutoSize = true;
            flowLabel.Location = new System.Drawing.Point(134, 229);
            flowLabel.Name = "flowLabel";
            flowLabel.Size = new System.Drawing.Size(29, 13);
            flowLabel.TabIndex = 13;
            flowLabel.Text = "flow:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(136, 318);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(368, 318);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "button2";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(217, 174);
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
            this.yearNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.yearNumericUpDown.TabIndex = 17;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // flowNumericUpDown
            // 
            this.flowNumericUpDown.Location = new System.Drawing.Point(217, 226);
            this.flowNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flowNumericUpDown.Name = "flowNumericUpDown";
            this.flowNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.flowNumericUpDown.TabIndex = 18;
            this.flowNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormBuildingEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 600);
            this.Controls.Add(this.flowNumericUpDown);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(buildingIdLabel);
            this.Controls.Add(buildingNameLabel);
            this.Controls.Add(this.buildingNameTextBox);
            this.Controls.Add(landLabel);
            this.Controls.Add(this.landTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(materialLabel);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(flowLabel);
            this.Name = "FormBuildingEdit";
            this.Text = "FormBuildingEdit";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox buildingNameTextBox;
        private System.Windows.Forms.TextBox landTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown flowNumericUpDown;
    }
}