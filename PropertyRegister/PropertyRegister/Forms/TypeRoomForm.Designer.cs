namespace PropertyRegister.Forms
{
    partial class TypeRoomForm
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
            this.typeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeRoomTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.typeRoomButtonDelete = new System.Windows.Forms.Button();
            this.typeRoomButtonEdit = new System.Windows.Forms.Button();
            this.typeRoomButtonAdd = new System.Windows.Forms.Button();
            this.typeRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeRoomBindingSource
            // 
            this.typeRoomBindingSource.DataMember = "TypeRoom";
            this.typeRoomBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // typeRoomTableAdapter
            // 
            this.typeRoomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.ChiefTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.OrgUnitTableAdapter = null;
            this.tableAdapterManager.RevaluationTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.TypeRoomTableAdapter = this.typeRoomTableAdapter;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeRoomButtonDelete
            // 
            this.typeRoomButtonDelete.Location = new System.Drawing.Point(261, 272);
            this.typeRoomButtonDelete.Name = "typeRoomButtonDelete";
            this.typeRoomButtonDelete.Size = new System.Drawing.Size(87, 27);
            this.typeRoomButtonDelete.TabIndex = 7;
            this.typeRoomButtonDelete.Text = "button3";
            this.typeRoomButtonDelete.UseVisualStyleBackColor = true;
            this.typeRoomButtonDelete.Click += new System.EventHandler(this.TypeRoomButtonDelete_Click);
            // 
            // typeRoomButtonEdit
            // 
            this.typeRoomButtonEdit.Location = new System.Drawing.Point(168, 272);
            this.typeRoomButtonEdit.Name = "typeRoomButtonEdit";
            this.typeRoomButtonEdit.Size = new System.Drawing.Size(87, 27);
            this.typeRoomButtonEdit.TabIndex = 6;
            this.typeRoomButtonEdit.Text = "button2";
            this.typeRoomButtonEdit.UseVisualStyleBackColor = true;
            this.typeRoomButtonEdit.Click += new System.EventHandler(this.TypeRoomButtonEdit_Click);
            // 
            // typeRoomButtonAdd
            // 
            this.typeRoomButtonAdd.Location = new System.Drawing.Point(75, 272);
            this.typeRoomButtonAdd.Name = "typeRoomButtonAdd";
            this.typeRoomButtonAdd.Size = new System.Drawing.Size(87, 27);
            this.typeRoomButtonAdd.TabIndex = 5;
            this.typeRoomButtonAdd.Text = "button1";
            this.typeRoomButtonAdd.UseVisualStyleBackColor = true;
            this.typeRoomButtonAdd.Click += new System.EventHandler(this.TypeRoomButtonAdd_Click);
            // 
            // typeRoomDataGridView
            // 
            this.typeRoomDataGridView.AllowUserToAddRows = false;
            this.typeRoomDataGridView.AllowUserToDeleteRows = false;
            this.typeRoomDataGridView.AutoGenerateColumns = false;
            this.typeRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn17});
            this.typeRoomDataGridView.DataSource = this.typeRoomBindingSource;
            this.typeRoomDataGridView.Location = new System.Drawing.Point(12, 12);
            this.typeRoomDataGridView.Name = "typeRoomDataGridView";
            this.typeRoomDataGridView.ReadOnly = true;
            this.typeRoomDataGridView.RowHeadersVisible = false;
            this.typeRoomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typeRoomDataGridView.Size = new System.Drawing.Size(350, 254);
            this.typeRoomDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "target";
            this.dataGridViewTextBoxColumn18.HeaderText = "Название";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "typeRoomId";
            this.dataGridViewTextBoxColumn17.HeaderText = "typeRoomId";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // TypeRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 335);
            this.Controls.Add(this.typeRoomButtonDelete);
            this.Controls.Add(this.typeRoomButtonEdit);
            this.Controls.Add(this.typeRoomButtonAdd);
            this.Controls.Add(this.typeRoomDataGridView);
            this.Name = "TypeRoomForm";
            this.Text = "TypeRoomForm";
            this.Load += new System.EventHandler(this.TypeRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource typeRoomBindingSource;
        private PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter typeRoomTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button typeRoomButtonDelete;
        private System.Windows.Forms.Button typeRoomButtonEdit;
        private System.Windows.Forms.Button typeRoomButtonAdd;
        private System.Windows.Forms.DataGridView typeRoomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}