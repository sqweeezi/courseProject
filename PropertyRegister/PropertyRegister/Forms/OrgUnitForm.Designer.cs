namespace PropertyRegister.Forms
{
    partial class OrgUnitForm
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
            this.orgUnitButtonDelete = new System.Windows.Forms.Button();
            this.orgUnitButtonEdit = new System.Windows.Forms.Button();
            this.orgUnitButtonAdd = new System.Windows.Forms.Button();
            this.orgUnitDataGridView = new System.Windows.Forms.DataGridView();
            this.propertyRegisterDataSet = new PropertyRegister.PropertyRegisterDataSet();
            this.orgUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgUnitTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter();
            this.orgUnitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgUnitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orgUnitButtonDelete
            // 
            this.orgUnitButtonDelete.Location = new System.Drawing.Point(826, 314);
            this.orgUnitButtonDelete.Name = "orgUnitButtonDelete";
            this.orgUnitButtonDelete.Size = new System.Drawing.Size(101, 31);
            this.orgUnitButtonDelete.TabIndex = 7;
            this.orgUnitButtonDelete.Text = "Удалить";
            this.orgUnitButtonDelete.UseVisualStyleBackColor = true;
            this.orgUnitButtonDelete.Click += new System.EventHandler(this.OrgUnitButtonDelete_Click);
            // 
            // orgUnitButtonEdit
            // 
            this.orgUnitButtonEdit.Location = new System.Drawing.Point(717, 314);
            this.orgUnitButtonEdit.Name = "orgUnitButtonEdit";
            this.orgUnitButtonEdit.Size = new System.Drawing.Size(101, 31);
            this.orgUnitButtonEdit.TabIndex = 6;
            this.orgUnitButtonEdit.Text = "Изменить";
            this.orgUnitButtonEdit.UseVisualStyleBackColor = true;
            this.orgUnitButtonEdit.Click += new System.EventHandler(this.OrgUnitButtonEdit_Click);
            // 
            // orgUnitButtonAdd
            // 
            this.orgUnitButtonAdd.Location = new System.Drawing.Point(609, 314);
            this.orgUnitButtonAdd.Name = "orgUnitButtonAdd";
            this.orgUnitButtonAdd.Size = new System.Drawing.Size(101, 31);
            this.orgUnitButtonAdd.TabIndex = 5;
            this.orgUnitButtonAdd.Text = "Добавить";
            this.orgUnitButtonAdd.UseVisualStyleBackColor = true;
            this.orgUnitButtonAdd.Click += new System.EventHandler(this.OrgUnitButtonAdd_Click);
            // 
            // orgUnitDataGridView
            // 
            this.orgUnitDataGridView.AllowUserToAddRows = false;
            this.orgUnitDataGridView.AllowUserToDeleteRows = false;
            this.orgUnitDataGridView.AutoGenerateColumns = false;
            this.orgUnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgUnitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orgUnitIdDataGridViewTextBoxColumn,
            this.orgUnitNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.chiefIdDataGridViewTextBoxColumn});
            this.orgUnitDataGridView.DataSource = this.orgUnitBindingSource;
            this.orgUnitDataGridView.Location = new System.Drawing.Point(14, 14);
            this.orgUnitDataGridView.Name = "orgUnitDataGridView";
            this.orgUnitDataGridView.ReadOnly = true;
            this.orgUnitDataGridView.RowHeadersVisible = false;
            this.orgUnitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orgUnitDataGridView.Size = new System.Drawing.Size(961, 293);
            this.orgUnitDataGridView.TabIndex = 4;
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orgUnitBindingSource
            // 
            this.orgUnitBindingSource.DataMember = "OrgUnit";
            this.orgUnitBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // orgUnitTableAdapter
            // 
            this.orgUnitTableAdapter.ClearBeforeFill = true;
            // 
            // orgUnitIdDataGridViewTextBoxColumn
            // 
            this.orgUnitIdDataGridViewTextBoxColumn.DataPropertyName = "orgUnitId";
            this.orgUnitIdDataGridViewTextBoxColumn.HeaderText = "orgUnitId";
            this.orgUnitIdDataGridViewTextBoxColumn.Name = "orgUnitIdDataGridViewTextBoxColumn";
            this.orgUnitIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orgUnitNameDataGridViewTextBoxColumn
            // 
            this.orgUnitNameDataGridViewTextBoxColumn.DataPropertyName = "orgUnitName";
            this.orgUnitNameDataGridViewTextBoxColumn.HeaderText = "orgUnitName";
            this.orgUnitNameDataGridViewTextBoxColumn.Name = "orgUnitNameDataGridViewTextBoxColumn";
            this.orgUnitNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiefIdDataGridViewTextBoxColumn
            // 
            this.chiefIdDataGridViewTextBoxColumn.DataPropertyName = "chiefId";
            this.chiefIdDataGridViewTextBoxColumn.HeaderText = "chiefId";
            this.chiefIdDataGridViewTextBoxColumn.Name = "chiefIdDataGridViewTextBoxColumn";
            this.chiefIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrgUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 357);
            this.Controls.Add(this.orgUnitButtonDelete);
            this.Controls.Add(this.orgUnitButtonEdit);
            this.Controls.Add(this.orgUnitButtonAdd);
            this.Controls.Add(this.orgUnitDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OrgUnitForm";
            this.Text = "OrgUnitForm";
            this.Load += new System.EventHandler(this.OrgUnitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button orgUnitButtonDelete;
        private System.Windows.Forms.Button orgUnitButtonEdit;
        private System.Windows.Forms.Button orgUnitButtonAdd;
        private System.Windows.Forms.DataGridView orgUnitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource orgUnitBindingSource;
        private PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter orgUnitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgUnitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgUnitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiefIdDataGridViewTextBoxColumn;
    }
}