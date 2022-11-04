using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Hyppodrom
{
    public partial class Edit_form : Form
    {
        
        private readonly int horse_id;
       
        readonly bool edit;
        
        public Edit_form()
        {
            InitializeComponent();
            TextBox_age.Minimum = 0;
            TextBox_age.Maximum = 100;
            horseTableAdapter.Fill(hyppodromDataSet.Horse);
            cynologistTableAdapter.Fill(hyppodromDataSet.Cynologist);
            edit = false;
        }
      
        public Edit_form(int horse_id, string name, string color, string country, int age, string breed, string gender,
       int cynologist_id)
        : this()
        {
            horseTableAdapter.Fill(hyppodromDataSet.Horse);
            cynologistTableAdapter.Fill(hyppodromDataSet.Cynologist);
            edit = true;
            this.horse_id = horse_id;
            textBox_name.Text = name;
            textBox_color.Text = color;
            textBox_country.Text = country;
            TextBox_age.Value = age;
            textBox_breed.Text = breed;
            
            switch (gender.ToUpper())
            {
                case "male":
                    comboBox_gender.SelectedIndex = 0;
                    break;
                case "female":
                    comboBox_gender.SelectedIndex = 1;
                    break;
                default:
                    comboBox_gender.SelectedIndex = 0;
                    break;
            }
          
            comboBox_cynologist.SelectedValue = cynologist_id;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (comboBox_gender.SelectedIndex == 0)
            {
                gender = "male";
            }
            else if (comboBox_gender.SelectedIndex == 1)
            {
                gender = "female";
            }
            if (edit)
            {
                horseTableAdapter.UpdateQuery(textBox_name.Text, textBox_color.Text,
               textBox_country.Text, Convert.ToInt32(TextBox_age.Value), textBox_breed.Text, gender,
               Convert.ToInt32(comboBox_cynologist.SelectedValue), horse_id);
            }
            else
            {
                horseTableAdapter.InsertQuery(textBox_name.Text, textBox_color.Text,
               textBox_country.Text, Convert.ToInt32(TextBox_age.Value), textBox_breed.Text, gender,
               Convert.ToInt32(comboBox_cynologist.SelectedValue));
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

