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
            unitIdLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // unitIdLabel
            // 
            unitIdLabel.AutoSize = true;
            unitIdLabel.Location = new System.Drawing.Point(106, 18);
            unitIdLabel.Name = "unitIdLabel";
            unitIdLabel.Size = new System.Drawing.Size(45, 16);
            unitIdLabel.TabIndex = 1;
            unitIdLabel.Text = "unit Id:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(106, 48);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(43, 16);
            countLabel.TabIndex = 3;
            countLabel.Text = "count:";
            // 
            // unitIdComboBox
            // 
            this.unitIdComboBox.FormattingEnabled = true;
            this.unitIdComboBox.Location = new System.Drawing.Point(159, 14);
            this.unitIdComboBox.Name = "unitIdComboBox";
            this.unitIdComboBox.Size = new System.Drawing.Size(140, 23);
            this.unitIdComboBox.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(104, 99);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCLose
            // 
            this.buttonCLose.Location = new System.Drawing.Point(198, 99);
            this.buttonCLose.Name = "buttonCLose";
            this.buttonCLose.Size = new System.Drawing.Size(87, 27);
            this.buttonCLose.TabIndex = 7;
            this.buttonCLose.Text = "button2";
            this.buttonCLose.UseVisualStyleBackColor = true;
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(159, 43);
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(56, 21);
            this.countNumericUpDown.TabIndex = 9;
            // 
            // StorageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 196);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.buttonCLose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.unitIdComboBox);
            this.Controls.Add(unitIdLabel);
            this.Controls.Add(countLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "StorageEditForm";
            this.Text = "StorageEditForm";
            this.Load += new System.EventHandler(this.StorageEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox unitIdComboBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCLose;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
    }
}