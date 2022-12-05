namespace IS_Hyppodrom
{
    partial class Edit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_breed = new System.Windows.Forms.TextBox();
            this.TextBox_age = new System.Windows.Forms.NumericUpDown();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_cynologist = new System.Windows.Forms.ComboBox();
            this.cynologistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hyppodromDataSet = new IS_Hyppodrom.HyppodromDataSet();
            this.cynologistTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.CynologistTableAdapter();
            this.horseTableAdapter = new IS_Hyppodrom.HyppodromDataSetTableAdapters.HorseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Breed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cynologist";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(157, 49);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(152, 20);
            this.textBox_name.TabIndex = 7;
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(157, 79);
            this.textBox_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(152, 20);
            this.textBox_color.TabIndex = 8;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(157, 108);
            this.textBox_country.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(152, 20);
            this.textBox_country.TabIndex = 9;
            // 
            // textBox_breed
            // 
            this.textBox_breed.Location = new System.Drawing.Point(157, 164);
            this.textBox_breed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_breed.Name = "textBox_breed";
            this.textBox_breed.Size = new System.Drawing.Size(152, 20);
            this.textBox_breed.TabIndex = 11;
            // 
            // TextBox_age
            // 
            this.TextBox_age.Location = new System.Drawing.Point(157, 135);
            this.TextBox_age.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.Size = new System.Drawing.Size(151, 20);
            this.TextBox_age.TabIndex = 12;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBox_gender.Location = new System.Drawing.Point(157, 189);
            this.comboBox_gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(152, 21);
            this.comboBox_gender.TabIndex = 13;
            // 
            // comboBox_cynologist
            // 
            this.comboBox_cynologist.DataSource = this.cynologistBindingSource;
            this.comboBox_cynologist.DisplayMember = "cynologist_id";
            this.comboBox_cynologist.FormattingEnabled = true;
            this.comboBox_cynologist.Location = new System.Drawing.Point(157, 219);
            this.comboBox_cynologist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_cynologist.Name = "comboBox_cynologist";
            this.comboBox_cynologist.Size = new System.Drawing.Size(152, 21);
            this.comboBox_cynologist.TabIndex = 14;
            this.comboBox_cynologist.ValueMember = "cynologist_id";
            // 
            // cynologistBindingSource
            // 
            this.cynologistBindingSource.DataMember = "Cynologist";
            this.cynologistBindingSource.DataSource = this.hyppodromDataSet;
            // 
            // hyppodromDataSet
            // 
            this.hyppodromDataSet.DataSetName = "HyppodromDataSet";
            this.hyppodromDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cynologistTableAdapter
            // 
            this.cynologistTableAdapter.ClearBeforeFill = true;
            // 
            // horseTableAdapter
            // 
            this.horseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_cynologist);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.TextBox_age);
            this.Controls.Add(this.textBox_breed);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.textBox_color);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Edit_form";
            this.Text = "Edit_form";
            ((System.ComponentModel.ISupportInitialize)(this.TextBox_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynologistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyppodromDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.TextBox textBox_breed;
        private System.Windows.Forms.NumericUpDown TextBox_age;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.ComboBox comboBox_cynologist;
        private HyppodromDataSet hyppodromDataSet;
        private System.Windows.Forms.BindingSource cynologistBindingSource;
        private HyppodromDataSetTableAdapters.CynologistTableAdapter cynologistTableAdapter;
        private HyppodromDataSetTableAdapters.HorseTableAdapter horseTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}