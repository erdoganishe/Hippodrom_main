using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

namespace IS_Hyppodrom
{
    public partial class FormReport1 : Form
    {
        
        const string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";
        public FormReport1()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string select = $"select name from Horse";
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            int count = dataSet.Tables[0].Rows.Count;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = count-1;
            sqlcon.Close();
        }

        public string getQuery(int id)
        {           
            string rep = "";            
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string name;
            string color;
            string country;
            int age;
            string breed;
            string gender;
            int cynologist_id;
            string cyno_name;
            int cyno_age;
            string cyno_gender;
            int cyno_expirience;
            int cyno_income;            
            int race_id;
            double coef;
            int number;


            sqlcon.Open();
            string select = $"select * from Horse where horse_id={id}";
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            name = dataSet.Tables[0].Rows[0][1].ToString();
            color = dataSet.Tables[0].Rows[0][2].ToString();            
            country = dataSet.Tables[0].Rows[0][3].ToString();
            age = Convert.ToInt32(dataSet.Tables[0].Rows[0][4].ToString());            
            breed = dataSet.Tables[0].Rows[0][5].ToString();
            gender = dataSet.Tables[0].Rows[0][6].ToString();
            cynologist_id = Convert.ToInt32(dataSet.Tables[0].Rows[0][7].ToString());
            rep = $"Name: {name};\nColor: {color};\nCountry: {country};\nAge: {age};\nBreed: {breed};\nGender: {gender};\n";
            select = $"select * from cynologist where cynologist_id={cynologist_id}";
            adapter = new SqlDataAdapter(select, sqlcon);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            cyno_name = dataSet.Tables[0].Rows[0][1].ToString();
            cyno_age = Convert.ToInt32(dataSet.Tables[0].Rows[0][2].ToString());
            cyno_gender = dataSet.Tables[0].Rows[0][3].ToString();
            cyno_expirience = Convert.ToInt32(dataSet.Tables[0].Rows[0][4].ToString());
            cyno_income = Convert.ToInt32(dataSet.Tables[0].Rows[0][5].ToString());
            rep += $"\nJockey info:\n   Name: {cyno_name};\n   Age: {cyno_age};\n   Gender: {cyno_gender};\n   Expirience: {cyno_expirience};\n   Income: {cyno_income};\n";
            rep += $"\nResults info:\n";
            select = $"select race_id, coeficient, number from res where horse_id={id}";
            adapter = new SqlDataAdapter(select, sqlcon);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    race_id = Convert.ToInt32(dataSet.Tables[0].Rows[i][0].ToString());
                    coef = Convert.ToDouble(dataSet.Tables[0].Rows[i][1].ToString());
                    number = Convert.ToInt32(dataSet.Tables[0].Rows[i][2].ToString());
                    rep += $"Race {race_id}:\n";
                    rep += $"   Result: {number}\n";
                    rep += $"   Coeficient: {coef}\n";
                    rep += "\n";
                }
            sqlcon.Close();
            return rep;
        }
        private void getReport()
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("../../reports/1.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph(getQuery(Convert.ToInt32(numericUpDown1.Value)));             
            doc.Add(p1);
            doc.Close();
        }
        private void button1_Click(object sender,
            EventArgs e) => getReport();


    }
}
