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
            this.typeRoomButtonDelete = new System.Windows.Forms.Button();
            this.typeRoomButtonEdit = new System.Windows.Forms.Button();
            this.typeRoomButtonAdd = new System.Windows.Forms.Button();
            this.typeRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRoomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyRegisterDataSet = new PropertyRegister.PropertyRegisterDataSet();
            this.typeRoomTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // typeRoomButtonDelete
            // 
            this.typeRoomButtonDelete.Location = new System.Drawing.Point(304, 314);
            this.typeRoomButtonDelete.Name = "typeRoomButtonDelete";
            this.typeRoomButtonDelete.Size = new System.Drawing.Size(101, 31);
            this.typeRoomButtonDelete.TabIndex = 7;
            this.typeRoomButtonDelete.Text = "Удалить";
            this.typeRoomButtonDelete.UseVisualStyleBackColor = true;
            this.typeRoomButtonDelete.Click += new System.EventHandler(this.TypeRoomButtonDelete_Click);
            // 
            // typeRoomButtonEdit
            // 
            this.typeRoomButtonEdit.Location = new System.Drawing.Point(196, 314);
            this.typeRoomButtonEdit.Name = "typeRoomButtonEdit";
            this.typeRoomButtonEdit.Size = new System.Drawing.Size(101, 31);
            this.typeRoomButtonEdit.TabIndex = 6;
            this.typeRoomButtonEdit.Text = "Изменить";
            this.typeRoomButtonEdit.UseVisualStyleBackColor = true;
            this.typeRoomButtonEdit.Click += new System.EventHandler(this.TypeRoomButtonEdit_Click);
            // 
            // typeRoomButtonAdd
            // 
            this.typeRoomButtonAdd.Location = new System.Drawing.Point(87, 314);
            this.typeRoomButtonAdd.Name = "typeRoomButtonAdd";
            this.typeRoomButtonAdd.Size = new System.Drawing.Size(101, 31);
            this.typeRoomButtonAdd.TabIndex = 5;
            this.typeRoomButtonAdd.Text = "Добавить";
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
            this.typeDataGridViewTextBoxColumn,
            this.typeRoomIdDataGridViewTextBoxColumn});
            this.typeRoomDataGridView.DataSource = this.typeRoomBindingSource;
            this.typeRoomDataGridView.Location = new System.Drawing.Point(12, 15);
            this.typeRoomDataGridView.Name = "typeRoomDataGridView";
            this.typeRoomDataGridView.ReadOnly = true;
            this.typeRoomDataGridView.RowHeadersVisible = false;
            this.typeRoomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typeRoomDataGridView.Size = new System.Drawing.Size(408, 293);
            this.typeRoomDataGridView.TabIndex = 4;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeRoomIdDataGridViewTextBoxColumn
            // 
            this.typeRoomIdDataGridViewTextBoxColumn.DataPropertyName = "typeRoomId";
            this.typeRoomIdDataGridViewTextBoxColumn.HeaderText = "typeRoomId";
            this.typeRoomIdDataGridViewTextBoxColumn.Name = "typeRoomIdDataGridViewTextBoxColumn";
            this.typeRoomIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeRoomIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeRoomBindingSource
            // 
            this.typeRoomBindingSource.DataMember = "TypeRoom";
            this.typeRoomBindingSource.DataSource = this.propertyRegisterDataSet;
            // 
            // propertyRegisterDataSet
            // 
            this.propertyRegisterDataSet.DataSetName = "PropertyRegisterDataSet";
            this.propertyRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeRoomTableAdapter
            // 
            this.typeRoomTableAdapter.ClearBeforeFill = true;
            // 
            // TypeRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 353);
            this.Controls.Add(this.typeRoomButtonDelete);
            this.Controls.Add(this.typeRoomButtonEdit);
            this.Controls.Add(this.typeRoomButtonAdd);
            this.Controls.Add(this.typeRoomDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TypeRoomForm";
            this.Text = "TypeRoomForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypeRoomForm_FormClosing);
            this.Load += new System.EventHandler(this.TypeRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button typeRoomButtonDelete;
        private System.Windows.Forms.Button typeRoomButtonEdit;
        private System.Windows.Forms.Button typeRoomButtonAdd;
        private System.Windows.Forms.DataGridView typeRoomDataGridView;
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource typeRoomBindingSource;
        private PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter typeRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRoomIdDataGridViewTextBoxColumn;
    }
}