namespace PropertyRegister.Forms
{
    partial class InventoryFormEdit
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
            this.unitIdTextBox = new System.Windows.Forms.TextBox();
            this.unitIdComboBox = new System.Windows.Forms.ComboBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            unitIdLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // unitIdLabel
            // 
            unitIdLabel.AutoSize = true;
            unitIdLabel.Location = new System.Drawing.Point(54, 102);
            unitIdLabel.Name = "unitIdLabel";
            unitIdLabel.Size = new System.Drawing.Size(39, 13);
            unitIdLabel.TabIndex = 3;
            unitIdLabel.Text = "unit Id:";
            // 
            // unitIdTextBox
            // 
            this.unitIdTextBox.Location = new System.Drawing.Point(124, 99);
            this.unitIdTextBox.Name = "unitIdTextBox";
            this.unitIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitIdTextBox.TabIndex = 4;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(54, 128);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(37, 13);
            countLabel.TabIndex = 5;
            countLabel.Text = "count:";
            // 
            // unitIdComboBox
            // 
            this.unitIdComboBox.FormattingEnabled = true;
            this.unitIdComboBox.Location = new System.Drawing.Point(240, 99);
            this.unitIdComboBox.Name = "unitIdComboBox";
            this.unitIdComboBox.Size = new System.Drawing.Size(154, 21);
            this.unitIdComboBox.TabIndex = 7;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(124, 125);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 20);
            this.countTextBox.TabIndex = 6;
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(240, 128);
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(154, 20);
            this.countNumericUpDown.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(379, 325);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(625, 324);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "button2";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // InventoryFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 557);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.unitIdComboBox);
            this.Controls.Add(unitIdLabel);
            this.Controls.Add(this.unitIdTextBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Name = "InventoryFormEdit";
            this.Text = "InventoryFormEdit";
            this.Load += new System.EventHandler(this.InventoryFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unitIdTextBox;
        private System.Windows.Forms.ComboBox unitIdComboBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
    }
}