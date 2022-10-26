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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_tables_form));
            System.Windows.Forms.Label cynologist_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label expirienceLabel;
            System.Windows.Forms.Label incomeLabel;
            this.hyppodromDataSet = new IS_Hyppodrom.HyppodromDataSet();
            this.cynologistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cynologistTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.CynologistTableAdapter();
            this.tableAdapterManager = new IS_Hyppodrom.HyppodromDataSetTableAdapters.TableAdapterManager();
            this.cynologistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cynologistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cynologist_idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.expirienceTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.horseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.HorseTableAdapter();
            this.horseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // 
            // cynologistBindingNavigator
            // 
            this.cynologistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cynologistBindingNavigator.BindingSource = this.cynologistBindingSource;
            this.cynologistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cynologistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.cynologistBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cynologistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cynologistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cynologistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cynologistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cynologistBindingNavigator.Name = "cynologistBindingNavigator";
            this.cynologistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cynologistBindingNavigator.Size = new System.Drawing.Size(1263, 27);
            this.cynologistBindingNavigator.TabIndex = 0;
            this.cynologistBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // cynologistBindingNavigatorSaveItem
            // 
            this.cynologistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cynologistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cynologistBindingNavigatorSaveItem.Image")));
            this.cynologistBindingNavigatorSaveItem.Name = "cynologistBindingNavigatorSaveItem";
            this.cynologistBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cynologistBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cynologistBindingNavigatorSaveItem.Click += new System.EventHandler(this.cynologistBindingNavigatorSaveItem_Click);
            // 
            // cynologist_idLabel
            // 
            cynologist_idLabel.AutoSize = true;
            cynologist_idLabel.Location = new System.Drawing.Point(59, 59);
            cynologist_idLabel.Name = "cynologist_idLabel";
            cynologist_idLabel.Size = new System.Drawing.Size(85, 16);
            cynologist_idLabel.TabIndex = 1;
            cynologist_idLabel.Text = "cynologist id:";
            // 
            // cynologist_idTextBox
            // 
            this.cynologist_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "cynologist_id", true));
            this.cynologist_idTextBox.Location = new System.Drawing.Point(150, 56);
            this.cynologist_idTextBox.Name = "cynologist_idTextBox";
            this.cynologist_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.cynologist_idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(59, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(150, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(59, 115);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(34, 16);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(150, 112);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 6;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(59, 143);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(53, 16);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(150, 140);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 8;
            // 
            // expirienceLabel
            // 
            expirienceLabel.AutoSize = true;
            expirienceLabel.Location = new System.Drawing.Point(59, 171);
            expirienceLabel.Name = "expirienceLabel";
            expirienceLabel.Size = new System.Drawing.Size(72, 16);
            expirienceLabel.TabIndex = 9;
            expirienceLabel.Text = "expirience:";
            // 
            // expirienceTextBox
            // 
            this.expirienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "expirience", true));
            this.expirienceTextBox.Location = new System.Drawing.Point(150, 168);
            this.expirienceTextBox.Name = "expirienceTextBox";
            this.expirienceTextBox.Size = new System.Drawing.Size(100, 22);
            this.expirienceTextBox.TabIndex = 10;
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new System.Drawing.Point(59, 199);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(54, 16);
            incomeLabel.TabIndex = 11;
            incomeLabel.Text = "income:";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cynologistBindingSource, "income", true));
            this.incomeTextBox.Location = new System.Drawing.Point(150, 196);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.incomeTextBox.TabIndex = 12;
            // 
            // horseBindingSource
            // 
            this.horseBindingSource.DataMember = "FK_Horse_Cynologist";
            this.horseBindingSource.DataSource = this.cynologistBindingSource;
            // 
            // horseTableAdapter
            // 
            this.horseTableAdapter.ClearBeforeFill = true;
            // 
            // horseDataGridView
            // 
            this.horseDataGridView.AutoGenerateColumns = false;
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
            this.horseDataGridView.Location = new System.Drawing.Point(12, 237);
            this.horseDataGridView.Name = "horseDataGridView";
            this.horseDataGridView.RowHeadersWidth = 51;
            this.horseDataGridView.RowTemplate.Height = 24;
            this.horseDataGridView.Size = new System.Drawing.Size(1239, 220);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirm changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_tables_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 556);
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
            this.Name = "Show_tables_form";
            this.Text = "Show_tables_form";
            this.Load += new System.EventHandler(this.Show_tables_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingNavigator)).EndInit();
            this.cynologistBindingNavigator.ResumeLayout(false);
            this.cynologistBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseDataGridView)).EndInit();
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