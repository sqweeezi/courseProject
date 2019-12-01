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
            this.propertyRegisterDataSet = new PropertyRegister.PropertyRegisterDataSet();
            this.orgUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgUnitTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.orgUnitButtonDelete = new System.Windows.Forms.Button();
            this.orgUnitButtonEdit = new System.Windows.Forms.Button();
            this.orgUnitButtonAdd = new System.Windows.Forms.Button();
            this.orgUnitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.ChiefTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.OrgUnitTableAdapter = this.orgUnitTableAdapter;
            this.tableAdapterManager.RevaluationTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.TypeRoomTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.orgUnitDataGridView.DataSource = this.orgUnitBindingSource;
            this.orgUnitDataGridView.Location = new System.Drawing.Point(14, 14);
            this.orgUnitDataGridView.Name = "orgUnitDataGridView";
            this.orgUnitDataGridView.ReadOnly = true;
            this.orgUnitDataGridView.RowHeadersVisible = false;
            this.orgUnitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orgUnitDataGridView.Size = new System.Drawing.Size(961, 293);
            this.orgUnitDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "orgUnitName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Наименование подразделения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "orgUnitId";
            this.dataGridViewTextBoxColumn8.HeaderText = "orgUnitId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "boss";
            this.dataGridViewTextBoxColumn10.HeaderText = "Заведущий подразделением";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 203;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn11.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 93;
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
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource orgUnitBindingSource;
        private PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter orgUnitTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button orgUnitButtonDelete;
        private System.Windows.Forms.Button orgUnitButtonEdit;
        private System.Windows.Forms.Button orgUnitButtonAdd;
        private System.Windows.Forms.DataGridView orgUnitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}