namespace PropertyRegister.Forms
{
    partial class RevaluationForm
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
            this.notRevaluationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notRevaluationTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.NotRevaluationTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.notRevaluationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRevaluationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRevaluationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notRevaluationBindingSource
            // 
            this.notRevaluationBindingSource.DataMember = "NotRevaluation";
            this.notRevaluationBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // notRevaluationTableAdapter
            // 
            this.notRevaluationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingTableAdapter = null;
            this.tableAdapterManager.ChiefTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // notRevaluationDataGridView
            // 
            this.notRevaluationDataGridView.AllowUserToAddRows = false;
            this.notRevaluationDataGridView.AllowUserToDeleteRows = false;
            this.notRevaluationDataGridView.AutoGenerateColumns = false;
            this.notRevaluationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notRevaluationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1});
            this.notRevaluationDataGridView.DataSource = this.notRevaluationBindingSource;
            this.notRevaluationDataGridView.Location = new System.Drawing.Point(14, 14);
            this.notRevaluationDataGridView.Name = "notRevaluationDataGridView";
            this.notRevaluationDataGridView.ReadOnly = true;
            this.notRevaluationDataGridView.RowHeadersVisible = false;
            this.notRevaluationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notRevaluationDataGridView.Size = new System.Drawing.Size(905, 254);
            this.notRevaluationDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "unitName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имущество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата посл. переоценки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 168;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "costAfter";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена после переоценки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 173;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "unitId";
            this.dataGridViewTextBoxColumn1.HeaderText = "unitId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(688, 275);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(207, 27);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Переоценить все";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // RevaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 317);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.notRevaluationDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RevaluationForm";
            this.Text = "RevaluationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RevaluationForm_FormClosing);
            this.Load += new System.EventHandler(this.RevaluationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRevaluationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRevaluationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource notRevaluationBindingSource;
        private PropertyRegisterDataSetTableAdapters.NotRevaluationTableAdapter notRevaluationTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView notRevaluationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonOk;
    }
}