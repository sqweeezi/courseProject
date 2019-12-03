namespace PropertyRegister.Forms
{
    partial class TypeUnitForm
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
            this.components = new System.ComponentModel.Container();
            this.propertyRegisterDataSet = new PropertyRegister.PropertyRegisterDataSet();
            this.typeUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUnitTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TypeUnitTableAdapter();
            this.typeUnitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUnitAddButton = new System.Windows.Forms.Button();
            this.typeUnitEditButton = new System.Windows.Forms.Button();
            this.typeUnitDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUnitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeUnitBindingSource
            // 
            this.typeUnitBindingSource.DataMember = "TypeUnit";
            this.typeUnitBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // typeUnitTableAdapter
            // 
            this.typeUnitTableAdapter.ClearBeforeFill = true;
            // 
            // typeUnitDataGridView
            // 
            this.typeUnitDataGridView.AllowUserToAddRows = false;
            this.typeUnitDataGridView.AllowUserToDeleteRows = false;
            this.typeUnitDataGridView.AutoGenerateColumns = false;
            this.typeUnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeUnitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.typeUnitDataGridView.DataSource = this.typeUnitBindingSource;
            this.typeUnitDataGridView.Location = new System.Drawing.Point(12, 12);
            this.typeUnitDataGridView.Name = "typeUnitDataGridView";
            this.typeUnitDataGridView.ReadOnly = true;
            this.typeUnitDataGridView.RowHeadersVisible = false;
            this.typeUnitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typeUnitDataGridView.Size = new System.Drawing.Size(300, 220);
            this.typeUnitDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "typeUnitId";
            this.dataGridViewTextBoxColumn1.HeaderText = "typeUnitId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // typeUnitAddButton
            // 
            this.typeUnitAddButton.Location = new System.Drawing.Point(76, 262);
            this.typeUnitAddButton.Name = "typeUnitAddButton";
            this.typeUnitAddButton.Size = new System.Drawing.Size(75, 23);
            this.typeUnitAddButton.TabIndex = 2;
            this.typeUnitAddButton.Text = "button1";
            this.typeUnitAddButton.UseVisualStyleBackColor = true;
            this.typeUnitAddButton.Click += new System.EventHandler(this.TypeUnitAddButton_Click);
            // 
            // typeUnitEditButton
            // 
            this.typeUnitEditButton.Location = new System.Drawing.Point(157, 262);
            this.typeUnitEditButton.Name = "typeUnitEditButton";
            this.typeUnitEditButton.Size = new System.Drawing.Size(75, 23);
            this.typeUnitEditButton.TabIndex = 3;
            this.typeUnitEditButton.Text = "button2";
            this.typeUnitEditButton.UseVisualStyleBackColor = true;
            this.typeUnitEditButton.Click += new System.EventHandler(this.TypeUnitEditButton_Click);
            // 
            // typeUnitDeleteButton
            // 
            this.typeUnitDeleteButton.Location = new System.Drawing.Point(238, 262);
            this.typeUnitDeleteButton.Name = "typeUnitDeleteButton";
            this.typeUnitDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.typeUnitDeleteButton.TabIndex = 4;
            this.typeUnitDeleteButton.Text = "button3";
            this.typeUnitDeleteButton.UseVisualStyleBackColor = true;
            this.typeUnitDeleteButton.Click += new System.EventHandler(this.TypeUnitDeleteButton_Click);
            // 
            // TypeUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 374);
            this.Controls.Add(this.typeUnitDeleteButton);
            this.Controls.Add(this.typeUnitEditButton);
            this.Controls.Add(this.typeUnitAddButton);
            this.Controls.Add(this.typeUnitDataGridView);
            this.Name = "TypeUnitForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TypeUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUnitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource typeUnitBindingSource;
        private PropertyRegisterDataSetTableAdapters.TypeUnitTableAdapter typeUnitTableAdapter;
        private System.Windows.Forms.DataGridView typeUnitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button typeUnitAddButton;
        private System.Windows.Forms.Button typeUnitEditButton;
        private System.Windows.Forms.Button typeUnitDeleteButton;
    }
}