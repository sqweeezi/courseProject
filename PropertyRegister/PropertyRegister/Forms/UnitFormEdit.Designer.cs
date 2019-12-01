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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            unitNameLabel = new System.Windows.Forms.Label();
            dateStartLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEndNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(70, 23);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(110, 16);
            unitNameLabel.TabIndex = 3;
            unitNameLabel.Text = "Наименование:";
            // 
            // dateStartLabel
            // 
            dateStartLabel.AutoSize = true;
            dateStartLabel.Location = new System.Drawing.Point(4, 47);
            dateStartLabel.Name = "dateStartLabel";
            dateStartLabel.Size = new System.Drawing.Size(176, 16);
            dateStartLabel.TabIndex = 5;
            dateStartLabel.Text = "Дата постановки на учет:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(99, 76);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(81, 16);
            costLabel.TabIndex = 7;
            costLabel.Text = "Стоимость:";
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Location = new System.Drawing.Point(186, 20);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(289, 21);
            this.unitNameTextBox.TabIndex = 4;
            // 
            // dateStartDateTimePicker
            // 
            this.dateStartDateTimePicker.Location = new System.Drawing.Point(186, 47);
            this.dateStartDateTimePicker.Name = "dateStartDateTimePicker";
            this.dateStartDateTimePicker.Size = new System.Drawing.Size(154, 21);
            this.dateStartDateTimePicker.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(303, 165);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(396, 165);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 27);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(186, 74);
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
            this.costNumericUpDown.Size = new System.Drawing.Size(154, 21);
            this.costNumericUpDown.TabIndex = 11;
            this.costNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timeEndNumericUpDown);
            this.groupBox1.Controls.Add(this.unitNameTextBox);
            this.groupBox1.Controls.Add(this.costNumericUpDown);
            this.groupBox1.Controls.Add(costLabel);
            this.groupBox1.Controls.Add(this.dateStartDateTimePicker);
            this.groupBox1.Controls.Add(dateStartLabel);
            this.groupBox1.Controls.Add(unitNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // timeEndNumericUpDown
            // 
            this.timeEndNumericUpDown.Location = new System.Drawing.Point(186, 101);
            this.timeEndNumericUpDown.Name = "timeEndNumericUpDown";
            this.timeEndNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.timeEndNumericUpDown.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cрок амортизации:";
            // 
            // UnitFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 204);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UnitFormEdit";
            this.Text = "UnitFormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEndNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.DateTimePicker dateStartDateTimePicker;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown timeEndNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}