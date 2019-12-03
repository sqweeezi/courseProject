namespace PropertyRegister.Forms
{
    partial class StorageForm
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
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.StorageTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.storageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageAddButton = new System.Windows.Forms.Button();
            this.storageEditButton = new System.Windows.Forms.Button();
            this.storageDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StorageTableAdapter = this.storageTableAdapter;
            this.tableAdapterManager.TypeRoomTableAdapter = null;
            this.tableAdapterManager.TypeUnitTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storageDataGridView
            // 
            this.storageDataGridView.AutoGenerateColumns = false;
            this.storageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.storageDataGridView.DataSource = this.storageBindingSource;
            this.storageDataGridView.Location = new System.Drawing.Point(12, 12);
            this.storageDataGridView.Name = "storageDataGridView";
            this.storageDataGridView.Size = new System.Drawing.Size(350, 220);
            this.storageDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "unitId";
            this.dataGridViewTextBoxColumn1.HeaderText = "unitId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn2.HeaderText = "count";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // storageAddButton
            // 
            this.storageAddButton.Location = new System.Drawing.Point(103, 238);
            this.storageAddButton.Name = "storageAddButton";
            this.storageAddButton.Size = new System.Drawing.Size(75, 23);
            this.storageAddButton.TabIndex = 2;
            this.storageAddButton.Text = "button1";
            this.storageAddButton.UseVisualStyleBackColor = true;
            this.storageAddButton.Click += new System.EventHandler(this.StorageAddButton_Click);
            // 
            // storageEditButton
            // 
            this.storageEditButton.Location = new System.Drawing.Point(184, 238);
            this.storageEditButton.Name = "storageEditButton";
            this.storageEditButton.Size = new System.Drawing.Size(75, 23);
            this.storageEditButton.TabIndex = 3;
            this.storageEditButton.Text = "button2";
            this.storageEditButton.UseVisualStyleBackColor = true;
            this.storageEditButton.Click += new System.EventHandler(this.StorageEditButton_Click);
            // 
            // storageDeleteButton
            // 
            this.storageDeleteButton.Location = new System.Drawing.Point(265, 238);
            this.storageDeleteButton.Name = "storageDeleteButton";
            this.storageDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.storageDeleteButton.TabIndex = 4;
            this.storageDeleteButton.Text = "button3";
            this.storageDeleteButton.UseVisualStyleBackColor = true;
            this.storageDeleteButton.Click += new System.EventHandler(this.StorageDeleteButton_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 278);
            this.Controls.Add(this.storageDeleteButton);
            this.Controls.Add(this.storageEditButton);
            this.Controls.Add(this.storageAddButton);
            this.Controls.Add(this.storageDataGridView);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private PropertyRegisterDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView storageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button storageAddButton;
        private System.Windows.Forms.Button storageEditButton;
        private System.Windows.Forms.Button storageDeleteButton;
    }
}