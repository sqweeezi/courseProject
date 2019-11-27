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
            orgUnitNameLabel = new System.Windows.Forms.Label();
            bossLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orgUnitNameLabel
            // 
            orgUnitNameLabel.AutoSize = true;
            orgUnitNameLabel.Location = new System.Drawing.Point(57, 41);
            orgUnitNameLabel.Name = "orgUnitNameLabel";
            orgUnitNameLabel.Size = new System.Drawing.Size(78, 13);
            orgUnitNameLabel.TabIndex = 3;
            orgUnitNameLabel.Text = "org Unit Name:";
            // 
            // orgUnitNameTextBox
            // 
            this.orgUnitNameTextBox.Location = new System.Drawing.Point(141, 38);
            this.orgUnitNameTextBox.Name = "orgUnitNameTextBox";
            this.orgUnitNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.orgUnitNameTextBox.TabIndex = 4;
            // 
            // bossLabel
            // 
            bossLabel.AutoSize = true;
            bossLabel.Location = new System.Drawing.Point(57, 67);
            bossLabel.Name = "bossLabel";
            bossLabel.Size = new System.Drawing.Size(32, 13);
            bossLabel.TabIndex = 5;
            bossLabel.Text = "boss:";
            // 
            // bossTextBox
            // 
            this.bossTextBox.Location = new System.Drawing.Point(141, 64);
            this.bossTextBox.Name = "bossTextBox";
            this.bossTextBox.Size = new System.Drawing.Size(100, 20);
            this.bossTextBox.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(57, 93);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(141, 90);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(336, 302);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(534, 303);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "button2";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // OrgUnitFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(orgUnitNameLabel);
            this.Controls.Add(this.orgUnitNameTextBox);
            this.Controls.Add(bossLabel);
            this.Controls.Add(this.bossTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Name = "OrgUnitFormEdit";
            this.Text = "OrgUnitFormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox orgUnitNameTextBox;
        private System.Windows.Forms.TextBox bossTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
    }
}