namespace PropertyRegister.Forms
{
    partial class OrgUnitFormEdit
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
            System.Windows.Forms.Label orgUnitNameLabel;
            System.Windows.Forms.Label bossLabel;
            System.Windows.Forms.Label phoneLabel;
            this.orgUnitNameTextBox = new System.Windows.Forms.TextBox();
            this.bossTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            orgUnitNameLabel = new System.Windows.Forms.Label();
            bossLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orgUnitNameLabel
            // 
            orgUnitNameLabel.AutoSize = true;
            orgUnitNameLabel.Location = new System.Drawing.Point(16, 28);
            orgUnitNameLabel.Name = "orgUnitNameLabel";
            orgUnitNameLabel.Size = new System.Drawing.Size(110, 16);
            orgUnitNameLabel.TabIndex = 3;
            orgUnitNameLabel.Text = "Наименование:";
            // 
            // bossLabel
            // 
            bossLabel.AutoSize = true;
            bossLabel.Location = new System.Drawing.Point(41, 55);
            bossLabel.Name = "bossLabel";
            bossLabel.Size = new System.Drawing.Size(85, 16);
            bossLabel.TabIndex = 5;
            bossLabel.Text = "Заведущий:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(55, 82);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(71, 16);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Телефон:";
            // 
            // orgUnitNameTextBox
            // 
            this.orgUnitNameTextBox.Location = new System.Drawing.Point(132, 25);
            this.orgUnitNameTextBox.Name = "orgUnitNameTextBox";
            this.orgUnitNameTextBox.Size = new System.Drawing.Size(207, 21);
            this.orgUnitNameTextBox.TabIndex = 4;
            // 
            // bossTextBox
            // 
            this.bossTextBox.Location = new System.Drawing.Point(132, 52);
            this.bossTextBox.Name = "bossTextBox";
            this.bossTextBox.Size = new System.Drawing.Size(207, 21);
            this.bossTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(132, 79);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(207, 21);
            this.phoneTextBox.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(171, 139);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 27);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(264, 139);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 27);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orgUnitNameTextBox);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(orgUnitNameLabel);
            this.groupBox1.Controls.Add(this.bossTextBox);
            this.groupBox1.Controls.Add(bossLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // OrgUnitFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 177);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OrgUnitFormEdit";
            this.Text = "OrgUnitFormEdit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox orgUnitNameTextBox;
        private System.Windows.Forms.TextBox bossTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}