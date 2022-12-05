namespace IS_Hyppodrom
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hyppodromDataSet = new IS_Hyppodrom.HyppodromDataSet();
            this.horseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cynologistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cynologistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetelmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryeditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futureRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantsnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.raceTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.RaceTableAdapter();
            this.horseTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.HorseTableAdapter();
            this.cynologistTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.CynologistTableAdapter();
            this.betTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.BetTableAdapter();
            this.resTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.ResTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceBindingSource
            // 
            this.raceBindingSource.DataMember = "Race";
            this.raceBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.hyppodromDataSet;
            this.bindingSource1.Position = 0;
            // 
            // hyppodromDataSet
            // 
            this.hyppodromDataSet.DataSetName = "HyppodromDataSet";
            this.hyppodromDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horseBindingSource
            // 
            this.horseBindingSource.DataMember = "Horse";
            this.horseBindingSource.DataSource = this.bindingSource1;
            // 
            // cynologistBindingSource
            // 
            this.cynologistBindingSource.DataMember = "Cynologist";
            this.cynologistBindingSource.DataSource = this.bindingSource1;
            // 
            // betBindingSource
            // 
            this.betBindingSource.DataMember = "Bet";
            this.betBindingSource.DataSource = this.bindingSource1;
            // 
            // resBindingSource
            // 
            this.resBindingSource.DataMember = "Res";
            this.resBindingSource.DataSource = this.bindingSource1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editformToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.topRequestsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raceToolStripMenuItem,
            this.horseToolStripMenuItem,
            this.cynologistsToolStripMenuItem,
            this.betsToolStripMenuItem,
            this.resultsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "Database";
            // 
            // raceToolStripMenuItem
            // 
            this.raceToolStripMenuItem.Name = "raceToolStripMenuItem";
            this.raceToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.raceToolStripMenuItem.Text = "Races";
            this.raceToolStripMenuItem.Click += new System.EventHandler(this.raceToolStripMenuItem_Click);
            // 
            // horseToolStripMenuItem
            // 
            this.horseToolStripMenuItem.Name = "horseToolStripMenuItem";
            this.horseToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.horseToolStripMenuItem.Text = "Horses";
            this.horseToolStripMenuItem.Click += new System.EventHandler(this.horseToolStripMenuItem_Click);
            // 
            // cynologistsToolStripMenuItem
            // 
            this.cynologistsToolStripMenuItem.Name = "cynologistsToolStripMenuItem";
            this.cynologistsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cynologistsToolStripMenuItem.Text = "Cynologists";
            this.cynologistsToolStripMenuItem.Click += new System.EventHandler(this.cynologistsToolStripMenuItem_Click);
            // 
            // betsToolStripMenuItem
            // 
            this.betsToolStripMenuItem.Name = "betsToolStripMenuItem";
            this.betsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.betsToolStripMenuItem.Text = "Bets";
            this.betsToolStripMenuItem.Click += new System.EventHandler(this.betsToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.resultsToolStripMenuItem.Text = "Results";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetelmentToolStripMenuItem,
            this.queryeditToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // resetelmentToolStripMenuItem
            // 
            this.resetelmentToolStripMenuItem.Name = "resetelmentToolStripMenuItem";
            this.resetelmentToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.resetelmentToolStripMenuItem.Text = "Resettelment";
            this.resetelmentToolStripMenuItem.Click += new System.EventHandler(this.resetelmentToolStripMenuItem_Click);
            // 
            // queryeditToolStripMenuItem
            // 
            this.queryeditToolStripMenuItem.Name = "queryeditToolStripMenuItem";
            this.queryeditToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.queryeditToolStripMenuItem.Text = "query_edit";
            this.queryeditToolStripMenuItem.Click += new System.EventHandler(this.queryeditToolStripMenuItem_Click);
            // 
            // editformToolStripMenuItem
            // 
            this.editformToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.editformToolStripMenuItem.Name = "editformToolStripMenuItem";
            this.editformToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.editformToolStripMenuItem.Text = "Edit_form";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horseReportToolStripMenuItem,
            this.betReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // horseReportToolStripMenuItem
            // 
            this.horseReportToolStripMenuItem.Name = "horseReportToolStripMenuItem";
            this.horseReportToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.horseReportToolStripMenuItem.Text = "Horse report";
            this.horseReportToolStripMenuItem.Click += new System.EventHandler(this.horseReportToolStripMenuItem_Click);
            // 
            // betReportToolStripMenuItem
            // 
            this.betReportToolStripMenuItem.Name = "betReportToolStripMenuItem";
            this.betReportToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.betReportToolStripMenuItem.Text = "Bet report";
            this.betReportToolStripMenuItem.Click += new System.EventHandler(this.betReportToolStripMenuItem_Click);
            // 
            // topRequestsToolStripMenuItem
            // 
            this.topRequestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futureRacesToolStripMenuItem,
            this.horseInfoToolStripMenuItem,
            this.previousRacesToolStripMenuItem,
            this.betRequestToolStripMenuItem});
            this.topRequestsToolStripMenuItem.Name = "topRequestsToolStripMenuItem";
            this.topRequestsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.topRequestsToolStripMenuItem.Text = "Top-Requests";
            // 
            // futureRacesToolStripMenuItem
            // 
            this.futureRacesToolStripMenuItem.Name = "futureRacesToolStripMenuItem";
            this.futureRacesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.futureRacesToolStripMenuItem.Text = "Future races";
            this.futureRacesToolStripMenuItem.Click += new System.EventHandler(this.futureRacesToolStripMenuItem_Click);
            // 
            // horseInfoToolStripMenuItem
            // 
            this.horseInfoToolStripMenuItem.Name = "horseInfoToolStripMenuItem";
            this.horseInfoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.horseInfoToolStripMenuItem.Text = "Horse info";
            this.horseInfoToolStripMenuItem.Click += new System.EventHandler(this.horseInfoToolStripMenuItem_Click);
            // 
            // previousRacesToolStripMenuItem
            // 
            this.previousRacesToolStripMenuItem.Name = "previousRacesToolStripMenuItem";
            this.previousRacesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.previousRacesToolStripMenuItem.Text = "Previous races";
            this.previousRacesToolStripMenuItem.Click += new System.EventHandler(this.previousRacesToolStripMenuItem_Click);
            // 
            // betRequestToolStripMenuItem
            // 
            this.betRequestToolStripMenuItem.Name = "betRequestToolStripMenuItem";
            this.betRequestToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.betRequestToolStripMenuItem.Text = "Bet request";
            this.betRequestToolStripMenuItem.Click += new System.EventHandler(this.betRequestToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raceidDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.durationtimeDataGridViewTextBoxColumn,
            this.participantsnumberDataGridViewTextBoxColumn,
            this.channelsDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // raceidDataGridViewTextBoxColumn
            // 
            this.raceidDataGridViewTextBoxColumn.DataPropertyName = "race_id";
            this.raceidDataGridViewTextBoxColumn.HeaderText = "race_id";
            this.raceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.raceidDataGridViewTextBoxColumn.Name = "raceidDataGridViewTextBoxColumn";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "date_time";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "date_time";
            this.datetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            // 
            // durationtimeDataGridViewTextBoxColumn
            // 
            this.durationtimeDataGridViewTextBoxColumn.DataPropertyName = "duration_time";
            this.durationtimeDataGridViewTextBoxColumn.HeaderText = "duration_time";
            this.durationtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationtimeDataGridViewTextBoxColumn.Name = "durationtimeDataGridViewTextBoxColumn";
            // 
            // participantsnumberDataGridViewTextBoxColumn
            // 
            this.participantsnumberDataGridViewTextBoxColumn.DataPropertyName = "participants_number";
            this.participantsnumberDataGridViewTextBoxColumn.HeaderText = "participants_number";
            this.participantsnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.participantsnumberDataGridViewTextBoxColumn.Name = "participantsnumberDataGridViewTextBoxColumn";
            // 
            // channelsDataGridViewTextBoxColumn
            // 
            this.channelsDataGridViewTextBoxColumn.DataPropertyName = "channels";
            this.channelsDataGridViewTextBoxColumn.HeaderText = "channels";
            this.channelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.channelsDataGridViewTextBoxColumn.Name = "channelsDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.raceBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(375, 352);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(249, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Races";
            // 
            // raceTableAdapter
            // 
            this.raceTableAdapter.ClearBeforeFill = true;
            // 
            // horseTableAdapter
            // 
            this.horseTableAdapter.ClearBeforeFill = true;
            // 
            // cynologistTableAdapter
            // 
            this.cynologistTableAdapter.ClearBeforeFill = true;
            // 
            // betTableAdapter
            // 
            this.betTableAdapter.ClearBeforeFill = true;
            // 
            // resTableAdapter
            // 
            this.resTableAdapter.ClearBeforeFill = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_form_FormClosing);
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private HyppodromDataSet hyppodromDataSet;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private HyppodromDataSetTableAdapters.RaceTableAdapter raceTableAdapter;
        private System.Windows.Forms.BindingSource horseBindingSource;
        private HyppodromDataSetTableAdapters.HorseTableAdapter horseTableAdapter;
        private System.Windows.Forms.BindingSource cynologistBindingSource;
        private HyppodromDataSetTableAdapters.CynologistTableAdapter cynologistTableAdapter;
        private System.Windows.Forms.BindingSource betBindingSource;
        private HyppodromDataSetTableAdapters.BetTableAdapter betTableAdapter;
        private System.Windows.Forms.BindingSource resBindingSource;
        private HyppodromDataSetTableAdapters.ResTableAdapter resTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cynologistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantsnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetelmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryeditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futureRacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousRacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betReportToolStripMenuItem;
    }
}