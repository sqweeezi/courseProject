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
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUnitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.typeDataGridViewTextBoxColumn,
            this.typeUnitIdDataGridViewTextBoxColumn});
            this.typeUnitDataGridView.DataSource = this.typeUnitBindingSource;
            this.typeUnitDataGridView.Location = new System.Drawing.Point(14, 14);
            this.typeUnitDataGridView.Name = "typeUnitDataGridView";
            this.typeUnitDataGridView.ReadOnly = true;
            this.typeUnitDataGridView.RowHeadersVisible = false;
            this.typeUnitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typeUnitDataGridView.Size = new System.Drawing.Size(350, 254);
            this.typeUnitDataGridView.TabIndex = 1;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeUnitIdDataGridViewTextBoxColumn
            // 
            this.typeUnitIdDataGridViewTextBoxColumn.DataPropertyName = "typeUnitId";
            this.typeUnitIdDataGridViewTextBoxColumn.HeaderText = "typeUnitId";
            this.typeUnitIdDataGridViewTextBoxColumn.Name = "typeUnitIdDataGridViewTextBoxColumn";
            this.typeUnitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeUnitIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeUnitAddButton
            // 
            this.typeUnitAddButton.Location = new System.Drawing.Point(72, 274);
            this.typeUnitAddButton.Name = "typeUnitAddButton";
            this.typeUnitAddButton.Size = new System.Drawing.Size(87, 27);
            this.typeUnitAddButton.TabIndex = 2;
            this.typeUnitAddButton.Text = "Добавить";
            this.typeUnitAddButton.UseVisualStyleBackColor = true;
            this.typeUnitAddButton.Click += new System.EventHandler(this.TypeUnitAddButton_Click);
            // 
            // typeUnitEditButton
            // 
            this.typeUnitEditButton.Location = new System.Drawing.Point(165, 274);
            this.typeUnitEditButton.Name = "typeUnitEditButton";
            this.typeUnitEditButton.Size = new System.Drawing.Size(87, 27);
            this.typeUnitEditButton.TabIndex = 3;
            this.typeUnitEditButton.Text = "Изменить";
            this.typeUnitEditButton.UseVisualStyleBackColor = true;
            this.typeUnitEditButton.Click += new System.EventHandler(this.TypeUnitEditButton_Click);
            // 
            // typeUnitDeleteButton
            // 
            this.typeUnitDeleteButton.Location = new System.Drawing.Point(258, 274);
            this.typeUnitDeleteButton.Name = "typeUnitDeleteButton";
            this.typeUnitDeleteButton.Size = new System.Drawing.Size(87, 27);
            this.typeUnitDeleteButton.TabIndex = 4;
            this.typeUnitDeleteButton.Text = "Удалить";
            this.typeUnitDeleteButton.UseVisualStyleBackColor = true;
            this.typeUnitDeleteButton.Click += new System.EventHandler(this.TypeUnitDeleteButton_Click);
            // 
            // TypeUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.typeUnitDeleteButton);
            this.Controls.Add(this.typeUnitEditButton);
            this.Controls.Add(this.typeUnitAddButton);
            this.Controls.Add(this.typeUnitDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TypeUnitForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypeUnitForm_FormClosing);
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
        private System.Windows.Forms.Button typeUnitAddButton;
        private System.Windows.Forms.Button typeUnitEditButton;
        private System.Windows.Forms.Button typeUnitDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeUnitIdDataGridViewTextBoxColumn;
    }
}