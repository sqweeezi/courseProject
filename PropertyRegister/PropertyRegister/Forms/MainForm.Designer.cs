namespace PropertyRegister
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buildingButtonDel = new System.Windows.Forms.Button();
            this.buildingButtonEdit = new System.Windows.Forms.Button();
            this.buildingButtonAdd = new System.Windows.Forms.Button();
            this.buildingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyRegisterDataSet = new PropertyRegister.PropertyRegisterDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.orgUnitButtonDelete = new System.Windows.Forms.Button();
            this.orgUnitButtonEdit = new System.Windows.Forms.Button();
            this.orgUnitButtonAdd = new System.Windows.Forms.Button();
            this.orgUnitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.BuildingTableAdapter();
            this.tableAdapterManager = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager();
            this.orgUnitTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chiefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiefTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.ChiefTableAdapter();
            this.chiefDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheifButtonAdd = new System.Windows.Forms.Button();
            this.cheifButtonEdit = new System.Windows.Forms.Button();
            this.cheifButtonDelete = new System.Windows.Forms.Button();
            this.typeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeRoomTableAdapter = new PropertyRegister.PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter();
            this.typeRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRoomButtonAdd = new System.Windows.Forms.Button();
            this.typeRoomButtonEdit = new System.Windows.Forms.Button();
            this.typeRoomButtonDelete = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Controls.Add(this.tabPage5);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1111, 557);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.buildingButtonDel);
            this.tabPage1.Controls.Add(this.buildingButtonEdit);
            this.tabPage1.Controls.Add(this.buildingButtonAdd);
            this.tabPage1.Controls.Add(this.buildingDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1103, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buildingButtonDel
            // 
            this.buildingButtonDel.Location = new System.Drawing.Point(671, 254);
            this.buildingButtonDel.Name = "buildingButtonDel";
            this.buildingButtonDel.Size = new System.Drawing.Size(75, 23);
            this.buildingButtonDel.TabIndex = 3;
            this.buildingButtonDel.Text = "button1";
            this.buildingButtonDel.UseVisualStyleBackColor = true;
            this.buildingButtonDel.Click += new System.EventHandler(this.BuildingButtonDel_Click);
            // 
            // buildingButtonEdit
            // 
            this.buildingButtonEdit.Location = new System.Drawing.Point(514, 254);
            this.buildingButtonEdit.Name = "buildingButtonEdit";
            this.buildingButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.buildingButtonEdit.TabIndex = 2;
            this.buildingButtonEdit.Text = "button1";
            this.buildingButtonEdit.UseVisualStyleBackColor = true;
            this.buildingButtonEdit.Click += new System.EventHandler(this.BuildingButtonEdit_Click);
            // 
            // buildingButtonAdd
            // 
            this.buildingButtonAdd.Location = new System.Drawing.Point(345, 257);
            this.buildingButtonAdd.Name = "buildingButtonAdd";
            this.buildingButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.buildingButtonAdd.TabIndex = 1;
            this.buildingButtonAdd.Text = "button1";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.buildingDataGridView.DataSource = this.buildingBindingSource;
            this.buildingDataGridView.Location = new System.Drawing.Point(6, 6);
            this.buildingDataGridView.Name = "buildingDataGridView";
            this.buildingDataGridView.ReadOnly = true;
            this.buildingDataGridView.Size = new System.Drawing.Size(952, 220);
            this.buildingDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "buildingId";
            this.dataGridViewTextBoxColumn1.HeaderText = "buildingId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "buildingName";
            this.dataGridViewTextBoxColumn2.HeaderText = "buildingName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "land";
            this.dataGridViewTextBoxColumn3.HeaderText = "land";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn4.HeaderText = "address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn5.HeaderText = "year";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "material";
            this.dataGridViewTextBoxColumn6.HeaderText = "material";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "flow";
            this.dataGridViewTextBoxColumn7.HeaderText = "flow";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.orgUnitButtonDelete);
            this.tabPage2.Controls.Add(this.orgUnitButtonEdit);
            this.tabPage2.Controls.Add(this.orgUnitButtonAdd);
            this.tabPage2.Controls.Add(this.orgUnitDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // orgUnitButtonDelete
            // 
            this.orgUnitButtonDelete.Location = new System.Drawing.Point(746, 355);
            this.orgUnitButtonDelete.Name = "orgUnitButtonDelete";
            this.orgUnitButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.orgUnitButtonDelete.TabIndex = 3;
            this.orgUnitButtonDelete.Text = "button3";
            this.orgUnitButtonDelete.UseVisualStyleBackColor = true;
            this.orgUnitButtonDelete.Click += new System.EventHandler(this.OrgUnitButtonDelete_Click);
            // 
            // orgUnitButtonEdit
            // 
            this.orgUnitButtonEdit.Location = new System.Drawing.Point(551, 347);
            this.orgUnitButtonEdit.Name = "orgUnitButtonEdit";
            this.orgUnitButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.orgUnitButtonEdit.TabIndex = 2;
            this.orgUnitButtonEdit.Text = "button2";
            this.orgUnitButtonEdit.UseVisualStyleBackColor = true;
            this.orgUnitButtonEdit.Click += new System.EventHandler(this.OrgUnitButtonEdit_Click);
            // 
            // orgUnitButtonAdd
            // 
            this.orgUnitButtonAdd.Location = new System.Drawing.Point(398, 326);
            this.orgUnitButtonAdd.Name = "orgUnitButtonAdd";
            this.orgUnitButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.orgUnitButtonAdd.TabIndex = 1;
            this.orgUnitButtonAdd.Text = "button1";
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
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.orgUnitDataGridView.DataSource = this.orgUnitBindingSource;
            this.orgUnitDataGridView.Location = new System.Drawing.Point(16, 23);
            this.orgUnitDataGridView.Name = "orgUnitDataGridView";
            this.orgUnitDataGridView.ReadOnly = true;
            this.orgUnitDataGridView.Size = new System.Drawing.Size(706, 220);
            this.orgUnitDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "orgUnitId";
            this.dataGridViewTextBoxColumn8.HeaderText = "orgUnitId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "orgUnitName";
            this.dataGridViewTextBoxColumn9.HeaderText = "orgUnitName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "boss";
            this.dataGridViewTextBoxColumn10.HeaderText = "boss";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn11.HeaderText = "phone";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // orgUnitBindingSource
            // 
            this.orgUnitBindingSource.DataMember = "OrgUnit";
            this.orgUnitBindingSource.DataSource = this.propertyRegisterDataSet;
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
            this.tableAdapterManager.OrgUnitTableAdapter = this.orgUnitTableAdapter;
            this.tableAdapterManager.RevaluationTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.TypeRoomTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PropertyRegister.PropertyRegisterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orgUnitTableAdapter
            // 
            this.orgUnitTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cheifButtonDelete);
            this.tabPage3.Controls.Add(this.cheifButtonEdit);
            this.tabPage3.Controls.Add(this.cheifButtonAdd);
            this.tabPage3.Controls.Add(this.chiefDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1103, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.typeRoomButtonDelete);
            this.tabPage4.Controls.Add(this.typeRoomButtonEdit);
            this.tabPage4.Controls.Add(this.typeRoomButtonAdd);
            this.tabPage4.Controls.Add(this.typeRoomDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1103, 531);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1103, 531);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // chiefDataGridView
            // 
            this.chiefDataGridView.AllowUserToAddRows = false;
            this.chiefDataGridView.AllowUserToDeleteRows = false;
            this.chiefDataGridView.AutoGenerateColumns = false;
            this.chiefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiefDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.chiefDataGridView.DataSource = this.chiefBindingSource;
            this.chiefDataGridView.Location = new System.Drawing.Point(6, 6);
            this.chiefDataGridView.Name = "chiefDataGridView";
            this.chiefDataGridView.ReadOnly = true;
            this.chiefDataGridView.Size = new System.Drawing.Size(719, 220);
            this.chiefDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "chiefId";
            this.dataGridViewTextBoxColumn12.HeaderText = "chiefId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn13.HeaderText = "surname";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn14.HeaderText = "name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn15.HeaderText = "patronymic";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn16.HeaderText = "address";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // cheifButtonAdd
            // 
            this.cheifButtonAdd.Location = new System.Drawing.Point(344, 290);
            this.cheifButtonAdd.Name = "cheifButtonAdd";
            this.cheifButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.cheifButtonAdd.TabIndex = 1;
            this.cheifButtonAdd.Text = "button1";
            this.cheifButtonAdd.UseVisualStyleBackColor = true;
            this.cheifButtonAdd.Click += new System.EventHandler(this.CheifButtonAdd_Click);
            // 
            // cheifButtonEdit
            // 
            this.cheifButtonEdit.Location = new System.Drawing.Point(463, 305);
            this.cheifButtonEdit.Name = "cheifButtonEdit";
            this.cheifButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.cheifButtonEdit.TabIndex = 2;
            this.cheifButtonEdit.Text = "button2";
            this.cheifButtonEdit.UseVisualStyleBackColor = true;
            this.cheifButtonEdit.Click += new System.EventHandler(this.CheifButtonEdit_Click);
            // 
            // cheifButtonDelete
            // 
            this.cheifButtonDelete.Location = new System.Drawing.Point(651, 287);
            this.cheifButtonDelete.Name = "cheifButtonDelete";
            this.cheifButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.cheifButtonDelete.TabIndex = 3;
            this.cheifButtonDelete.Text = "button3";
            this.cheifButtonDelete.UseVisualStyleBackColor = true;
            this.cheifButtonDelete.Click += new System.EventHandler(this.CheifButtonDelete_Click);
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
            // typeRoomDataGridView
            // 
            this.typeRoomDataGridView.AllowUserToAddRows = false;
            this.typeRoomDataGridView.AllowUserToDeleteRows = false;
            this.typeRoomDataGridView.AutoGenerateColumns = false;
            this.typeRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.typeRoomDataGridView.DataSource = this.typeRoomBindingSource;
            this.typeRoomDataGridView.Location = new System.Drawing.Point(6, 6);
            this.typeRoomDataGridView.Name = "typeRoomDataGridView";
            this.typeRoomDataGridView.ReadOnly = true;
            this.typeRoomDataGridView.Size = new System.Drawing.Size(300, 220);
            this.typeRoomDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "typeRoomId";
            this.dataGridViewTextBoxColumn17.HeaderText = "typeRoomId";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "target";
            this.dataGridViewTextBoxColumn18.HeaderText = "target";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // typeRoomButtonAdd
            // 
            this.typeRoomButtonAdd.Location = new System.Drawing.Point(314, 324);
            this.typeRoomButtonAdd.Name = "typeRoomButtonAdd";
            this.typeRoomButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.typeRoomButtonAdd.TabIndex = 1;
            this.typeRoomButtonAdd.Text = "button1";
            this.typeRoomButtonAdd.UseVisualStyleBackColor = true;
            this.typeRoomButtonAdd.Click += new System.EventHandler(this.TypeRoomButtonAdd_Click);
            // 
            // typeRoomButtonEdit
            // 
            this.typeRoomButtonEdit.Location = new System.Drawing.Point(486, 355);
            this.typeRoomButtonEdit.Name = "typeRoomButtonEdit";
            this.typeRoomButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.typeRoomButtonEdit.TabIndex = 2;
            this.typeRoomButtonEdit.Text = "button2";
            this.typeRoomButtonEdit.UseVisualStyleBackColor = true;
            this.typeRoomButtonEdit.Click += new System.EventHandler(this.TypeRoomButtonEdit_Click);
            // 
            // typeRoomButtonDelete
            // 
            this.typeRoomButtonDelete.Location = new System.Drawing.Point(714, 352);
            this.typeRoomButtonDelete.Name = "typeRoomButtonDelete";
            this.typeRoomButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.typeRoomButtonDelete.TabIndex = 3;
            this.typeRoomButtonDelete.Text = "button3";
            this.typeRoomButtonDelete.UseVisualStyleBackColor = true;
            this.typeRoomButtonDelete.Click += new System.EventHandler(this.TypeRoomButtonDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 581);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyRegisterDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUnitBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRoomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private PropertyRegisterDataSet propertyRegisterDataSet;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private PropertyRegisterDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
        private PropertyRegisterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buildingButtonDel;
        private System.Windows.Forms.Button buildingButtonEdit;
        private System.Windows.Forms.Button buildingButtonAdd;
        private System.Windows.Forms.DataGridView buildingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private PropertyRegisterDataSetTableAdapters.OrgUnitTableAdapter orgUnitTableAdapter;
        private System.Windows.Forms.BindingSource orgUnitBindingSource;
        private System.Windows.Forms.DataGridView orgUnitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button orgUnitButtonDelete;
        private System.Windows.Forms.Button orgUnitButtonEdit;
        private System.Windows.Forms.Button orgUnitButtonAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource chiefBindingSource;
        private PropertyRegisterDataSetTableAdapters.ChiefTableAdapter chiefTableAdapter;
        private System.Windows.Forms.Button cheifButtonDelete;
        private System.Windows.Forms.Button cheifButtonEdit;
        private System.Windows.Forms.Button cheifButtonAdd;
        private System.Windows.Forms.DataGridView chiefDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource typeRoomBindingSource;
        private PropertyRegisterDataSetTableAdapters.TypeRoomTableAdapter typeRoomTableAdapter;
        private System.Windows.Forms.Button typeRoomButtonDelete;
        private System.Windows.Forms.Button typeRoomButtonEdit;
        private System.Windows.Forms.Button typeRoomButtonAdd;
        private System.Windows.Forms.DataGridView typeRoomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}

