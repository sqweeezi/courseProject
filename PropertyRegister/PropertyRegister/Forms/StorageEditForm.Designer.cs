namespace PropertyRegister.Forms
{
    partial class StorageEditForm
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
            System.Windows.Forms.Label unitIdLabel;
            System.Windows.Forms.Label countLabel;
            this.unitIdComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCLose = new System.Windows.Forms.Button();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            unitIdLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitIdLabel
            // 
            unitIdLabel.AutoSize = true;
            unitIdLabel.Location = new System.Drawing.Point(17, 21);
            unitIdLabel.Name = "unitIdLabel";
            unitIdLabel.Size = new System.Drawing.Size(85, 16);
            unitIdLabel.TabIndex = 1;
            unitIdLabel.Text = "Имущество:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(44, 51);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(55, 16);
            countLabel.TabIndex = 3;
            countLabel.Text = "Кол-во:";
            // 
            // unitIdComboBox
            // 
            this.unitIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitIdComboBox.FormattingEnabled = true;
            this.unitIdComboBox.Location = new System.Drawing.Point(105, 18);
            this.unitIdComboBox.Name = "unitIdComboBox";
            this.unitIdComboBox.Size = new System.Drawing.Size(200, 23);
            this.unitIdComboBox.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(137, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCLose
            // 
            this.buttonCLose.Location = new System.Drawing.Point(230, 118);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(87, 27);
            this.buttonCLose.TabIndex = 7;
            this.buttonCLose.Text = "Отмена";
            this.buttonCLose.UseVisualStyleBackColor = true;
            this.buttonCLose.Click += new System.EventHandler(this.ButtonCLose_Click);
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(105, 49);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(56, 21);
            this.countNumericUpDown.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countNumericUpDown);
            this.groupBox1.Controls.Add(countLabel);
            this.groupBox1.Controls.Add(unitIdLabel);
            this.groupBox1.Controls.Add(this.unitIdComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // StorageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCLose);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "StorageEditForm";
            this.Text = "StorageEditForm";
            this.Load += new System.EventHandler(this.StorageEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox unitIdComboBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}