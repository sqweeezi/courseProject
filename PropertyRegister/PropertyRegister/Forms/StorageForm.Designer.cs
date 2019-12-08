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
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageAddButton = new System.Windows.Forms.Button();
            this.storageEditButton = new System.Windows.Forms.Button();
            this.storageDeleteButton = new System.Windows.Forms.Button();
            this.unitTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.UnitTableAdapter();
            this.unitIdDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
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
            this.storageDataGridView.AllowUserToAddRows = false;
            this.storageDataGridView.AllowUserToDeleteRows = false;
            this.storageDataGridView.AutoGenerateColumns = false;
            this.storageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIdDataGridViewComboBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.unitIdDataGridViewTextBoxColumn});
            this.storageDataGridView.DataSource = this.storageBindingSource;
            this.storageDataGridView.Location = new System.Drawing.Point(14, 14);
            this.storageDataGridView.Name = "storageDataGridView";
            this.storageDataGridView.ReadOnly = true;
            this.storageDataGridView.RowHeadersVisible = false;
            this.storageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageDataGridView.Size = new System.Drawing.Size(408, 254);
            this.storageDataGridView.TabIndex = 1;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // storageAddButton
            // 
            this.storageAddButton.Location = new System.Drawing.Point(120, 275);
            this.storageAddButton.Name = "storageAddButton";
            this.storageAddButton.Size = new System.Drawing.Size(87, 27);
            this.storageAddButton.TabIndex = 2;
            this.storageAddButton.Text = "Добавить";
            this.storageAddButton.UseVisualStyleBackColor = true;
            this.storageAddButton.Click += new System.EventHandler(this.StorageAddButton_Click);
            // 
            // storageEditButton
            // 
            this.storageEditButton.Location = new System.Drawing.Point(215, 275);
            this.storageEditButton.Name = "storageEditButton";
            this.storageEditButton.Size = new System.Drawing.Size(87, 27);
            this.storageEditButton.TabIndex = 3;
            this.storageEditButton.Text = "Изменить";
            this.storageEditButton.UseVisualStyleBackColor = true;
            this.storageEditButton.Click += new System.EventHandler(this.StorageEditButton_Click);
            // 
            // storageDeleteButton
            // 
            this.storageDeleteButton.Location = new System.Drawing.Point(309, 275);
            this.storageDeleteButton.Name = "storageDeleteButton";
            this.storageDeleteButton.Size = new System.Drawing.Size(87, 27);
            this.storageDeleteButton.TabIndex = 4;
            this.storageDeleteButton.Text = "Удалить";
            this.storageDeleteButton.UseVisualStyleBackColor = true;
            this.storageDeleteButton.Click += new System.EventHandler(this.StorageDeleteButton_Click);
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // unitIdDataGridViewComboBoxColumn
            // 
            this.unitIdDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitIdDataGridViewComboBoxColumn.DataPropertyName = "unitId";
            this.unitIdDataGridViewComboBoxColumn.DataSource = this.unitBindingSource;
            this.unitIdDataGridViewComboBoxColumn.DisplayMember = "unitName";
            this.unitIdDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIdDataGridViewComboBoxColumn.HeaderText = "Имущество";
            this.unitIdDataGridViewComboBoxColumn.Name = "unitIdDataGridViewComboBoxColumn";
            this.unitIdDataGridViewComboBoxColumn.ReadOnly = true;
            this.unitIdDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIdDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIdDataGridViewComboBoxColumn.ValueMember = "unitId";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 111;
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            this.unitIdDataGridViewTextBoxColumn.DataPropertyName = "unitId";
            this.unitIdDataGridViewTextBoxColumn.HeaderText = "unitId";
            this.unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            this.unitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 314);
            this.Controls.Add(this.storageDeleteButton);
            this.Controls.Add(this.storageEditButton);
            this.Controls.Add(this.storageAddButton);
            this.Controls.Add(this.storageDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private PropertyRegisterDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView storageDataGridView;
        private System.Windows.Forms.Button storageAddButton;
        private System.Windows.Forms.Button storageEditButton;
        private System.Windows.Forms.Button storageDeleteButton;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private PropertyRegisterDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIdDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdDataGridViewTextBoxColumn;
    }
}