namespace PropertyRegister.Forms
{
    partial class InventoryEditForm
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
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countStorageLabel = new System.Windows.Forms.Label();
            unitIdLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitIdLabel
            // 
            unitIdLabel.AutoSize = true;
            unitIdLabel.Location = new System.Drawing.Point(15, 23);
            unitIdLabel.Name = "unitIdLabel";
            unitIdLabel.Size = new System.Drawing.Size(153, 16);
            unitIdLabel.TabIndex = 3;
            unitIdLabel.Text = "Имущество на складе:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(113, 53);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(55, 16);
            countLabel.TabIndex = 5;
            countLabel.Text = "Кол-во:";
            // 
            // unitIdComboBox
            // 
            this.unitIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitIdComboBox.FormattingEnabled = true;
            this.unitIdComboBox.Location = new System.Drawing.Point(174, 20);
            this.unitIdComboBox.Name = "unitIdComboBox";
            this.unitIdComboBox.Size = new System.Drawing.Size(204, 23);
            this.unitIdComboBox.TabIndex = 7;
            this.unitIdComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitIdComboBox_SelectedIndexChanged);
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(174, 51);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(56, 21);
            this.countNumericUpDown.TabIndex = 8;
            this.countNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(142, 109);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(235, 109);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 27);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countStorageLabel);
            this.groupBox1.Controls.Add(this.unitIdComboBox);
            this.groupBox1.Controls.Add(countLabel);
            this.groupBox1.Controls.Add(unitIdLabel);
            this.groupBox1.Controls.Add(this.countNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // countStorageLabel
            // 
            this.countStorageLabel.AutoSize = true;
            this.countStorageLabel.Location = new System.Drawing.Point(236, 53);
            this.countStorageLabel.Name = "countStorageLabel";
            this.countStorageLabel.Size = new System.Drawing.Size(38, 16);
            this.countStorageLabel.TabIndex = 9;
            this.countStorageLabel.Text = "none";
            // 
            // InventoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 147);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "InventoryEditForm";
            this.Text = "InventoryFormEdit";
            this.Load += new System.EventHandler(this.InventoryFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox unitIdComboBox;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label countStorageLabel;
    }
}