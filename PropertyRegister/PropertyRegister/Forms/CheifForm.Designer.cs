namespace PropertyRegister.Forms
{
    partial class CheifForm
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
            this.chiefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiefTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.ChiefTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.cheifButtonDelete = new System.Windows.Forms.Button();
            this.cheifButtonEdit = new System.Windows.Forms.Button();
            this.cheifButtonAdd = new System.Windows.Forms.Button();
            this.chiefDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiefBindingSource
            // 
            this.chiefBindingSource.DataMember = "Chief";
            this.chiefBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // chiefTableAdapter
            // 
            this.chiefTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.ChiefTableAdapter = this.chiefTableAdapter;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.OrgUnitTableAdapter = null;
            this.tableAdapterManager.RevaluationTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.TypeRoomTableAdapter = null;
            this.tableAdapterManager.TypeUnitTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cheifButtonDelete
            // 
            this.cheifButtonDelete.Location = new System.Drawing.Point(832, 314);
            this.cheifButtonDelete.Name = "cheifButtonDelete";
            this.cheifButtonDelete.Size = new System.Drawing.Size(101, 31);
            this.cheifButtonDelete.TabIndex = 7;
            this.cheifButtonDelete.Text = "Удалить";
            this.cheifButtonDelete.UseVisualStyleBackColor = true;
            this.cheifButtonDelete.Click += new System.EventHandler(this.CheifButtonDelete_Click);
            // 
            // cheifButtonEdit
            // 
            this.cheifButtonEdit.Location = new System.Drawing.Point(723, 314);
            this.cheifButtonEdit.Name = "cheifButtonEdit";
            this.cheifButtonEdit.Size = new System.Drawing.Size(101, 31);
            this.cheifButtonEdit.TabIndex = 6;
            this.cheifButtonEdit.Text = "Изменить";
            this.cheifButtonEdit.UseVisualStyleBackColor = true;
            this.cheifButtonEdit.Click += new System.EventHandler(this.CheifButtonEdit_Click);
            // 
            // cheifButtonAdd
            // 
            this.cheifButtonAdd.Location = new System.Drawing.Point(615, 314);
            this.cheifButtonAdd.Name = "cheifButtonAdd";
            this.cheifButtonAdd.Size = new System.Drawing.Size(101, 31);
            this.cheifButtonAdd.TabIndex = 5;
            this.cheifButtonAdd.Text = "Добавить";
            this.cheifButtonAdd.UseVisualStyleBackColor = true;
            this.cheifButtonAdd.Click += new System.EventHandler(this.CheifButtonAdd_Click);
            // 
            // chiefDataGridView
            // 
            this.chiefDataGridView.AllowUserToAddRows = false;
            this.chiefDataGridView.AllowUserToDeleteRows = false;
            this.chiefDataGridView.AutoGenerateColumns = false;
            this.chiefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiefDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.chiefDataGridView.DataSource = this.chiefBindingSource;
            this.chiefDataGridView.Location = new System.Drawing.Point(14, 14);
            this.chiefDataGridView.Name = "chiefDataGridView";
            this.chiefDataGridView.ReadOnly = true;
            this.chiefDataGridView.RowHeadersVisible = false;
            this.chiefDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chiefDataGridView.Size = new System.Drawing.Size(979, 293);
            this.chiefDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn13.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "chiefId";
            this.dataGridViewTextBoxColumn12.HeaderText = "chiefId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn15.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn16.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 73;
            // 
            // CheifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 352);
            this.Controls.Add(this.cheifButtonDelete);
            this.Controls.Add(this.cheifButtonEdit);
            this.Controls.Add(this.cheifButtonAdd);
            this.Controls.Add(this.chiefDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CheifForm";
            this.Text = "Мат. ответсвенный";
            this.Load += new System.EventHandler(this.CheifForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource chiefBindingSource;
        private PropertyRegisterDataSetTableAdapters.ChiefTableAdapter chiefTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button cheifButtonDelete;
        private System.Windows.Forms.Button cheifButtonEdit;
        private System.Windows.Forms.Button cheifButtonAdd;
        private System.Windows.Forms.DataGridView chiefDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}