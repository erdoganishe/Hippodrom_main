namespace IS_Hyppodrom
{
    partial class Show_tables_form
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
            System.Windows.Forms.Label cynologist_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label expirienceLabel;
            System.Windows.Forms.Label incomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_tables_form));
            this.hyppodromDataSet = new IS_Hyppodrom.HyppodromDataSet();
            this.cynologistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cynologistTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.CynologistTableAdapter();
            this.tableAdapterManager = new IS_Hyppodrom.HyppodromDataSetTableAdapters.TableAdapterManager();
            this.horseTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.HorseTableAdapter();
            this.cynologistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cynologistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cynologist_idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.expirienceTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.horseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            cynologist_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            expirienceLabel = new System.Windows.Forms.Label();
            incomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingNavigator)).BeginInit();
            this.cynologistBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cynologist_idLabel
            // 
            cynologist_idLabel.AutoSize = true;
            cynologist_idLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cynologist_idLabel.Location = new System.Drawing.Point(5, 67);
            cynologist_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cynologist_idLabel.Name = "cynologist_idLabel";
            cynologist_idLabel.Size = new System.Drawing.Size(123, 23);
            cynologist_idLabel.TabIndex = 1;
            cynologist_idLabel.Text = "cynologist id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(5, 100);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(63, 23);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ageLabel.Location = new System.Drawing.Point(5, 133);
            ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(45, 23);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "age:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderLabel.Location = new System.Drawing.Point(3, 169);
            genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(74, 23);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "gender:";
            // 
            // expirienceLabel
            // 
            expirienceLabel.AutoSize = true;
            expirienceLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            expirienceLabel.Location = new System.Drawing.Point(5, 202);
            expirienceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            expirienceLabel.Name = "expirienceLabel";
            expirienceLabel.Size = new System.Drawing.Size(104, 23);
            expirienceLabel.TabIndex = 9;
            expirienceLabel.Text = "expirience:";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            incomeLabel.Location = new System.Drawing.Point(5, 235);
            incomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(78, 23);
            incomeLabel.TabIndex = 11;
            incomeLabel.Text = "income:";
            // 
            // hyppodromDataSet
            // 
            this.hyppodromDataSet.DataSetName = "HyppodromDataSet";
            this.hyppodromDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cynologistBindingSource
            // 
            this.cynologistBindingSource.DataMember = "Cynologist";
            this.cynologistBindingSource.DataSource = this.hyppodromDataSet;
            // 
            // cynologistTableAdapter
            // 
            this.cynologistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BetTableAdapter = null;
            this.tableAdapterManager.CynologistTableAdapter = this.cynologistTableAdapter;
            this.tableAdapterManager.HorseTableAdapter = this.horseTableAdapter;
            this.tableAdapterManager.RaceTableAdapter = null;
            this.tableAdapterManager.ResTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IS_Hyppodrom.HyppodromDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // horseTableAdapter
            // 
            this.horseTableAdapter.ClearBeforeFill = true;
            // 
            // cynologistBindingNavigator
            // 
            this.cynologistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cynologistBindingNavigator.BindingSource = this.cynologistBindingSource;
            this.cynologistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cynologistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cynologistBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.cynologistBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cynologistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.cynologistBindingNavigatorSaveItem});
            this.cynologistBindingNavigator.Location = new System.Drawing.Point(7, 23);
            this.cynologistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cynologistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cynologistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cynologistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cynologistBindingNavigator.Name = "cynologistBindingNavigator";
            this.cynologistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cynologistBindingNavigator.Size = new System.Drawing.Size(273, 27);
            this.cynologistBindingNavigator.TabIndex = 0;
            this.cynologistBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // cynologistBindingNavigatorSaveItem
            // 
            this.cynologistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cynologistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cynologistBindingNavigatorSaveItem.Image")));
            this.cynologistBindingNavigatorSaveItem.Name = "cynologistBindingNavigatorSaveItem";
            this.cynologistBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.cynologistBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cynologistBindingNavigatorSaveItem.Click += new System.EventHandler(this.cynologistBindingNavigatorSaveItem_Click);
            // 
            // cynologist_idTextBox
            // 
            this.cynologist_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "cynologist_id", true));
            this.cynologist_idTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cynologist_idTextBox.Location = new System.Drawing.Point(132, 61);
            this.cynologist_idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cynologist_idTextBox.Name = "cynologist_idTextBox";
            this.cynologist_idTextBox.Size = new System.Drawing.Size(76, 29);
            this.cynologist_idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(132, 94);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 29);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "age", true));
            this.ageTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageTextBox.Location = new System.Drawing.Point(132, 127);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(76, 29);
            this.ageTextBox.TabIndex = 6;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "gender", true));
            this.genderTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderTextBox.Location = new System.Drawing.Point(132, 163);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(76, 29);
            this.genderTextBox.TabIndex = 8;
            // 
            // expirienceTextBox
            // 
            this.expirienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "expirience", true));
            this.expirienceTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirienceTextBox.Location = new System.Drawing.Point(132, 196);
            this.expirienceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expirienceTextBox.Name = "expirienceTextBox";
            this.expirienceTextBox.Size = new System.Drawing.Size(76, 29);
            this.expirienceTextBox.TabIndex = 10;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "income", true));
            this.incomeTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeTextBox.Location = new System.Drawing.Point(132, 229);
            this.incomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(76, 29);
            this.incomeTextBox.TabIndex = 12;
            // 
            // horseDataGridView
            // 
            this.horseDataGridView.AutoGenerateColumns = false;
            this.horseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.horseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.horseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.horseDataGridView.DataSource = this.horseBindingSource;
            this.horseDataGridView.Location = new System.Drawing.Point(7, 262);
            this.horseDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.horseDataGridView.Name = "horseDataGridView";
            this.horseDataGridView.RowHeadersWidth = 51;
            this.horseDataGridView.RowTemplate.Height = 24;
            this.horseDataGridView.Size = new System.Drawing.Size(929, 179);
            this.horseDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "horse_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "horse_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn3.HeaderText = "color";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn4.HeaderText = "country";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn5.HeaderText = "age";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "breed";
            this.dataGridViewTextBoxColumn6.HeaderText = "breed";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "gender";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cynologist_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "cynologist_id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // horseBindingSource
            // 
            this.horseBindingSource.DataMember = "FK_Horse_Cynologist";
            this.horseBindingSource.DataSource = this.cynologistBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(659, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirm changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_tables_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horseDataGridView);
            this.Controls.Add(cynologist_idLabel);
            this.Controls.Add(this.cynologist_idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(expirienceLabel);
            this.Controls.Add(this.expirienceTextBox);
            this.Controls.Add(incomeLabel);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.cynologistBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Show_tables_form";
            this.Text = "Show_tables_form";
            this.Load += new System.EventHandler(this.Show_tables_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingNavigator)).EndInit();
            this.cynologistBindingNavigator.ResumeLayout(false);
            this.cynologistBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HyppodromDataSet hyppodromDataSet;
        private System.Windows.Forms.BindingSource cynologistBindingSource;
        private HyppodromDataSetTableAdapters.CynologistTableAdapter cynologistTableAdapter;
        private HyppodromDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cynologistBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cynologistBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cynologist_idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox expirienceTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private HyppodromDataSetTableAdapters.HorseTableAdapter horseTableAdapter;
        private System.Windows.Forms.BindingSource horseBindingSource;
        private System.Windows.Forms.DataGridView horseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
    }
}