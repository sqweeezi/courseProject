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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.inventoryButtonDelete = new System.Windows.Forms.Button();
            this.inventoryButtonAdd = new System.Windows.Forms.Button();
            this.inventoryButtonEdit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.buildingId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeRoomId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orgUnitId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chiefId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomButtonAdd = new System.Windows.Forms.Button();
            this.roomButtonEdit = new System.Windows.Forms.Button();
            this.roomButtonDelete = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.revaluationDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unitDataGridView = new System.Windows.Forms.DataGridView();
            this.unitButtonDelete = new System.Windows.Forms.Button();
            this.unitButtonAdd = new System.Windows.Forms.Button();
            this.unitButtonEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матОтвественныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типПомещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переоценкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переоценитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControlMain.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revaluationDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage6);
            this.tabControlMain.Controls.Add(this.tabPage5);
            this.tabControlMain.Location = new System.Drawing.Point(6, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1284, 438);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1276, 410);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Помещения";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.inventoryDataGridView);
            this.groupBox4.Controls.Add(this.inventoryButtonDelete);
            this.groupBox4.Controls.Add(this.inventoryButtonAdd);
            this.groupBox4.Controls.Add(this.inventoryButtonEdit);
            this.groupBox4.Location = new System.Drawing.Point(811, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 395);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список имущества";
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Location = new System.Drawing.Point(6, 20);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.RowHeadersVisible = false;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.Size = new System.Drawing.Size(447, 336);
            this.inventoryDataGridView.TabIndex = 1;
            // 
            // inventoryButtonDelete
            // 
            this.inventoryButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryButtonDelete.Location = new System.Drawing.Point(317, 362);
            this.inventoryButtonDelete.Name = "inventoryButtonDelete";
            this.inventoryButtonDelete.Size = new System.Drawing.Size(87, 27);
            this.inventoryButtonDelete.TabIndex = 7;
            this.inventoryButtonDelete.Text = "Удалить";
            this.inventoryButtonDelete.UseVisualStyleBackColor = true;
            this.inventoryButtonDelete.Click += new System.EventHandler(this.InventoryButtonDelete_Click);
            // 
            // inventoryButtonAdd
            // 
            this.inventoryButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryButtonAdd.Location = new System.Drawing.Point(131, 362);
            this.inventoryButtonAdd.Name = "inventoryButtonAdd";
            this.inventoryButtonAdd.Size = new System.Drawing.Size(87, 27);
            this.inventoryButtonAdd.TabIndex = 5;
            this.inventoryButtonAdd.Text = "Добавить";
            this.inventoryButtonAdd.UseVisualStyleBackColor = true;
            this.inventoryButtonAdd.Click += new System.EventHandler(this.InventoryButtonAdd_Click);
            // 
            // inventoryButtonEdit
            // 
            this.inventoryButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryButtonEdit.Location = new System.Drawing.Point(224, 362);
            this.inventoryButtonEdit.Name = "inventoryButtonEdit";
            this.inventoryButtonEdit.Size = new System.Drawing.Size(87, 27);
            this.inventoryButtonEdit.TabIndex = 6;
            this.inventoryButtonEdit.Text = "Изменить";
            this.inventoryButtonEdit.UseVisualStyleBackColor = true;
            this.inventoryButtonEdit.Click += new System.EventHandler(this.InventoryButtonEdit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.roomDataGridView);
            this.groupBox3.Controls.Add(this.roomButtonAdd);
            this.groupBox3.Controls.Add(this.roomButtonEdit);
            this.groupBox3.Controls.Add(this.roomButtonDelete);
            this.groupBox3.Location = new System.Drawing.Point(6, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 395);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Помещение";
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            this.roomDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingId,
            this.typeRoomId,
            this.orgUnitId,
            this.chiefId});
            this.roomDataGridView.Location = new System.Drawing.Point(6, 20);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            this.roomDataGridView.RowHeadersVisible = false;
            this.roomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDataGridView.Size = new System.Drawing.Size(787, 336);
            this.roomDataGridView.TabIndex = 0;
            // 
            // buildingId
            // 
            this.buildingId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.buildingId.DataPropertyName = "buildingId";
            this.buildingId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.buildingId.HeaderText = "Здание";
            this.buildingId.Name = "buildingId";
            this.buildingId.ReadOnly = true;
            this.buildingId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buildingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buildingId.Width = 82;
            // 
            // typeRoomId
            // 
            this.typeRoomId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.typeRoomId.DataPropertyName = "typeRoomId";
            this.typeRoomId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeRoomId.HeaderText = "Тип помещения";
            this.typeRoomId.Name = "typeRoomId";
            this.typeRoomId.ReadOnly = true;
            this.typeRoomId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeRoomId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeRoomId.Width = 123;
            // 
            // orgUnitId
            // 
            this.orgUnitId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orgUnitId.DataPropertyName = "orgUnitId";
            this.orgUnitId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orgUnitId.HeaderText = "Подразделение";
            this.orgUnitId.Name = "orgUnitId";
            this.orgUnitId.ReadOnly = true;
            this.orgUnitId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orgUnitId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orgUnitId.Width = 139;
            // 
            // chiefId
            // 
            this.chiefId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chiefId.DataPropertyName = "chiefId";
            this.chiefId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.chiefId.HeaderText = "Мат. отвественный";
            this.chiefId.Name = "chiefId";
            this.chiefId.ReadOnly = true;
            this.chiefId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chiefId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chiefId.Width = 145;
            // 
            // roomButtonAdd
            // 
            this.roomButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roomButtonAdd.Location = new System.Drawing.Point(499, 362);
            this.roomButtonAdd.Name = "roomButtonAdd";
            this.roomButtonAdd.Size = new System.Drawing.Size(87, 27);
            this.roomButtonAdd.TabIndex = 2;
            this.roomButtonAdd.Text = "Добавить";
            this.roomButtonAdd.UseVisualStyleBackColor = true;
            this.roomButtonAdd.Click += new System.EventHandler(this.RoomButtonAdd_Click);
            // 
            // roomButtonEdit
            // 
            this.roomButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roomButtonEdit.Location = new System.Drawing.Point(592, 362);
            this.roomButtonEdit.Name = "roomButtonEdit";
            this.roomButtonEdit.Size = new System.Drawing.Size(87, 27);
            this.roomButtonEdit.TabIndex = 3;
            this.roomButtonEdit.Text = "Изменить";
            this.roomButtonEdit.UseVisualStyleBackColor = true;
            this.roomButtonEdit.Click += new System.EventHandler(this.RoomButtonEdit_Click);
            // 
            // roomButtonDelete
            // 
            this.roomButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roomButtonDelete.Location = new System.Drawing.Point(685, 362);
            this.roomButtonDelete.Name = "roomButtonDelete";
            this.roomButtonDelete.Size = new System.Drawing.Size(87, 27);
            this.roomButtonDelete.TabIndex = 4;
            this.roomButtonDelete.Text = "Удалить";
            this.roomButtonDelete.UseVisualStyleBackColor = true;
            this.roomButtonDelete.Click += new System.EventHandler(this.RoomButtonDelete_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1276, 410);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Имущество";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.revaluationDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(811, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 395);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Переоценка";
            // 
            // revaluationDataGridView
            // 
            this.revaluationDataGridView.AllowUserToAddRows = false;
            this.revaluationDataGridView.AllowUserToDeleteRows = false;
            this.revaluationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revaluationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revaluationDataGridView.Location = new System.Drawing.Point(6, 20);
            this.revaluationDataGridView.Name = "revaluationDataGridView";
            this.revaluationDataGridView.ReadOnly = true;
            this.revaluationDataGridView.RowHeadersVisible = false;
            this.revaluationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.revaluationDataGridView.Size = new System.Drawing.Size(447, 319);
            this.revaluationDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.unitDataGridView);
            this.groupBox1.Controls.Add(this.unitButtonDelete);
            this.groupBox1.Controls.Add(this.unitButtonAdd);
            this.groupBox1.Controls.Add(this.unitButtonEdit);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 395);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имущество";
            // 
            // unitDataGridView
            // 
            this.unitDataGridView.AllowUserToAddRows = false;
            this.unitDataGridView.AllowUserToDeleteRows = false;
            this.unitDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitDataGridView.Location = new System.Drawing.Point(6, 20);
            this.unitDataGridView.Name = "unitDataGridView";
            this.unitDataGridView.ReadOnly = true;
            this.unitDataGridView.RowHeadersVisible = false;
            this.unitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unitDataGridView.Size = new System.Drawing.Size(787, 336);
            this.unitDataGridView.TabIndex = 0;
            // 
            // unitButtonDelete
            // 
            this.unitButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unitButtonDelete.Location = new System.Drawing.Point(685, 362);
            this.unitButtonDelete.Name = "unitButtonDelete";
            this.unitButtonDelete.Size = new System.Drawing.Size(87, 27);
            this.unitButtonDelete.TabIndex = 4;
            this.unitButtonDelete.Text = "Удалить";
            this.unitButtonDelete.UseVisualStyleBackColor = true;
            this.unitButtonDelete.Click += new System.EventHandler(this.UnitButtonDelete_Click);
            // 
            // unitButtonAdd
            // 
            this.unitButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unitButtonAdd.Location = new System.Drawing.Point(499, 362);
            this.unitButtonAdd.Name = "unitButtonAdd";
            this.unitButtonAdd.Size = new System.Drawing.Size(87, 27);
            this.unitButtonAdd.TabIndex = 2;
            this.unitButtonAdd.Text = "Добавить";
            this.unitButtonAdd.UseVisualStyleBackColor = true;
            this.unitButtonAdd.Click += new System.EventHandler(this.UnitButtonAdd_Click);
            // 
            // unitButtonEdit
            // 
            this.unitButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unitButtonEdit.Location = new System.Drawing.Point(592, 362);
            this.unitButtonEdit.Name = "unitButtonEdit";
            this.unitButtonEdit.Size = new System.Drawing.Size(87, 27);
            this.unitButtonEdit.TabIndex = 3;
            this.unitButtonEdit.Text = "Изменить";
            this.unitButtonEdit.UseVisualStyleBackColor = true;
            this.unitButtonEdit.Click += new System.EventHandler(this.UnitButtonEdit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.переоценкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зданияToolStripMenuItem,
            this.подразделенияToolStripMenuItem,
            this.матОтвественныеToolStripMenuItem,
            this.типПомещенияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // зданияToolStripMenuItem
            // 
            this.зданияToolStripMenuItem.Name = "зданияToolStripMenuItem";
            this.зданияToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.зданияToolStripMenuItem.Text = "Здания";
            this.зданияToolStripMenuItem.Click += new System.EventHandler(this.ЗданияToolStripMenuItem_Click);
            // 
            // подразделенияToolStripMenuItem
            // 
            this.подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
            this.подразделенияToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.подразделенияToolStripMenuItem.Text = "Подразделения";
            this.подразделенияToolStripMenuItem.Click += new System.EventHandler(this.ПодразделенияToolStripMenuItem_Click);
            // 
            // матОтвественныеToolStripMenuItem
            // 
            this.матОтвественныеToolStripMenuItem.Name = "матОтвественныеToolStripMenuItem";
            this.матОтвественныеToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.матОтвественныеToolStripMenuItem.Text = "Мат. отвественные";
            this.матОтвественныеToolStripMenuItem.Click += new System.EventHandler(this.МатОтвественныеToolStripMenuItem_Click);
            // 
            // типПомещенияToolStripMenuItem
            // 
            this.типПомещенияToolStripMenuItem.Name = "типПомещенияToolStripMenuItem";
            this.типПомещенияToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.типПомещенияToolStripMenuItem.Text = "Тип помещения";
            this.типПомещенияToolStripMenuItem.Click += new System.EventHandler(this.ТипПомещенияToolStripMenuItem_Click);
            // 
            // переоценкаToolStripMenuItem
            // 
            this.переоценкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переоценитьToolStripMenuItem});
            this.переоценкаToolStripMenuItem.Name = "переоценкаToolStripMenuItem";
            this.переоценкаToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.переоценкаToolStripMenuItem.Text = "Переоценка";
            // 
            // переоценитьToolStripMenuItem
            // 
            this.переоценитьToolStripMenuItem.Name = "переоценитьToolStripMenuItem";
            this.переоценитьToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.переоценитьToolStripMenuItem.Text = "Переоценить";
            this.переоценитьToolStripMenuItem.Click += new System.EventHandler(this.ПереоценитьToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1293, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.revaluationDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView unitDataGridView;
        private System.Windows.Forms.DataGridView revaluationDataGridView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Button inventoryButtonDelete;
        private System.Windows.Forms.Button inventoryButtonEdit;
        private System.Windows.Forms.Button inventoryButtonAdd;
        private System.Windows.Forms.Button roomButtonDelete;
        private System.Windows.Forms.Button roomButtonEdit;
        private System.Windows.Forms.Button roomButtonAdd;
        private System.Windows.Forms.Button unitButtonDelete;
        private System.Windows.Forms.Button unitButtonEdit;
        private System.Windows.Forms.Button unitButtonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подразделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матОтвественныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типПомещенияToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewComboBoxColumn buildingId;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeRoomId;
        private System.Windows.Forms.DataGridViewComboBoxColumn orgUnitId;
        private System.Windows.Forms.DataGridViewComboBoxColumn chiefId;
        private System.Windows.Forms.ToolStripMenuItem переоценкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переоценитьToolStripMenuItem;
    }
}

