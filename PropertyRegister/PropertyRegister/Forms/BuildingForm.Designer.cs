namespace PropertyRegister.Forms
{
    partial class BuildingForm
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
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyRegisterDataSet = new PropertyRegister.PropertyRegisterDataSet();
            this.buildingTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.BuildingTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.buildingButtonDel = new System.Windows.Forms.Button();
            this.buildingButtonEdit = new System.Windows.Forms.Button();
            this.buildingButtonAdd = new System.Windows.Forms.Button();
            this.buildingDataGridView = new System.Windows.Forms.DataGridView();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "Building";
            this.buildingBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = this.buildingTableAdapter;
            this.tableAdapterManager.ChiefTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.OrgUnitTableAdapter = null;
            this.tableAdapterManager.RevaluationTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.TypeRoomTableAdapter = null;
            this.tableAdapterManager.TypeUnitTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UnitWriteOffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buildingButtonDel
            // 
            this.buildingButtonDel.Location = new System.Drawing.Point(612, 311);
            this.buildingButtonDel.Name = "buildingButtonDel";
            this.buildingButtonDel.Size = new System.Drawing.Size(101, 31);
            this.buildingButtonDel.TabIndex = 6;
            this.buildingButtonDel.Text = "Удалить";
            this.buildingButtonDel.UseVisualStyleBackColor = true;
            this.buildingButtonDel.Click += new System.EventHandler(this.BuildingButtonDel_Click);
            // 
            // buildingButtonEdit
            // 
            this.buildingButtonEdit.Location = new System.Drawing.Point(505, 311);
            this.buildingButtonEdit.Name = "buildingButtonEdit";
            this.buildingButtonEdit.Size = new System.Drawing.Size(101, 31);
            this.buildingButtonEdit.TabIndex = 5;
            this.buildingButtonEdit.Text = "Изменить";
            this.buildingButtonEdit.UseVisualStyleBackColor = true;
            this.buildingButtonEdit.Click += new System.EventHandler(this.BuildingButtonEdit_Click);
            // 
            // buildingButtonAdd
            // 
            this.buildingButtonAdd.Location = new System.Drawing.Point(398, 311);
            this.buildingButtonAdd.Name = "buildingButtonAdd";
            this.buildingButtonAdd.Size = new System.Drawing.Size(101, 31);
            this.buildingButtonAdd.TabIndex = 4;
            this.buildingButtonAdd.Text = "Добавить";
            this.buildingButtonAdd.UseVisualStyleBackColor = true;
            this.buildingButtonAdd.Click += new System.EventHandler(this.BuildingButtonAdd_Click);
            // 
            // buildingDataGridView
            // 
            this.buildingDataGridView.AllowUserToAddRows = false;
            this.buildingDataGridView.AllowUserToDeleteRows = false;
            this.buildingDataGridView.AutoGenerateColumns = false;
            this.buildingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingNameDataGridViewTextBoxColumn,
            this.buildingIdDataGridViewTextBoxColumn,
            this.landDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.flowDataGridViewTextBoxColumn});
            this.buildingDataGridView.DataSource = this.buildingBindingSource;
            this.buildingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.buildingDataGridView.Name = "buildingDataGridView";
            this.buildingDataGridView.ReadOnly = true;
            this.buildingDataGridView.RowHeadersVisible = false;
            this.buildingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buildingDataGridView.Size = new System.Drawing.Size(720, 293);
            this.buildingDataGridView.TabIndex = 7;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "buildingName";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            this.buildingNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingIdDataGridViewTextBoxColumn
            // 
            this.buildingIdDataGridViewTextBoxColumn.DataPropertyName = "buildingId";
            this.buildingIdDataGridViewTextBoxColumn.HeaderText = "buildingId";
            this.buildingIdDataGridViewTextBoxColumn.Name = "buildingIdDataGridViewTextBoxColumn";
            this.buildingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // landDataGridViewTextBoxColumn
            // 
            this.landDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.landDataGridViewTextBoxColumn.DataPropertyName = "land";
            this.landDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.landDataGridViewTextBoxColumn.Name = "landDataGridViewTextBoxColumn";
            this.landDataGridViewTextBoxColumn.ReadOnly = true;
            this.landDataGridViewTextBoxColumn.Width = 91;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 73;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Год постройки";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 117;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Материал стен";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDataGridViewTextBoxColumn.Width = 121;
            // 
            // flowDataGridViewTextBoxColumn
            // 
            this.flowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.flowDataGridViewTextBoxColumn.DataPropertyName = "flow";
            this.flowDataGridViewTextBoxColumn.HeaderText = "Кол-во этажей";
            this.flowDataGridViewTextBoxColumn.Name = "flowDataGridViewTextBoxColumn";
            this.flowDataGridViewTextBoxColumn.ReadOnly = true;
            this.flowDataGridViewTextBoxColumn.Width = 117;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 358);
            this.Controls.Add(this.buildingDataGridView);
            this.Controls.Add(this.buildingButtonDel);
            this.Controls.Add(this.buildingButtonEdit);
            this.Controls.Add(this.buildingButtonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BuildingForm";
            this.Text = "BuildingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuildingForm_FormClosing);
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private PropertyRegisterDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buildingButtonDel;
        private System.Windows.Forms.Button buildingButtonEdit;
        private System.Windows.Forms.Button buildingButtonAdd;
        private System.Windows.Forms.DataGridView buildingDataGridView;
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowDataGridViewTextBoxColumn;
    }
}