namespace PropertyRegister.Forms
{
    partial class UnitFormEdit
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
            System.Windows.Forms.Label unitNameLabel;
            System.Windows.Forms.Label dateStartLabel;
            System.Windows.Forms.Label costLabel;
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.dateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            unitNameLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(48, 43);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(58, 13);
            unitNameLabel.TabIndex = 3;
            unitNameLabel.Text = "unit Name:";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(48, 70);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(56, 13);
            dateStartLabel.TabIndex = 5;
            dateStartLabel.Text = "date Start:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(48, 95);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(30, 13);
            costLabel.TabIndex = 7;
            costLabel.Text = "cost:";
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Location = new System.Drawing.Point(112, 40);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.unitNameTextBox.TabIndex = 4;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(112, 66);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateStartDateTimePicker.TabIndex = 6;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(112, 92);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 20);
            this.costTextBox.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(112, 168);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(220, 168);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "button2";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(350, 92);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.costNumericUpDown.TabIndex = 11;
            this.costNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UnitFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(unitNameLabel);
            this.Controls.Add(this.unitNameTextBox);
            this.Controls.Add(dateStartLabel);
            this.Controls.Add(this.dateStartDateTimePicker);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Name = "UnitFormEdit";
            this.Text = "UnitFormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
    }
}