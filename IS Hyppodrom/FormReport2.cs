using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace IS_Hyppodrom
{
    public partial class FormReport2 : Form
    {
        const string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";
        public FormReport2()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string select = $"select * from Bet";
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            int count = dataSet.Tables[0].Rows.Count;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = count - 1;
            sqlcon.Close();
        }
        public string getHorse(int id)
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
            rep = $"     Name: {name};\n     Color: {color};\n     Country: {country};\n     Age: {age};\n     Breed: {breed};\n     Gender: {gender};\n    Jockey: {cynologist_id}";
            sqlcon.Close();
            return rep;
        }
        public string getQuery(int id)
        {
            string str = "";
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            sqlcon.Open();
            string select = $"Select DATEADD(minute, duration_time, date_time), sum, res.coeficient, bet.coeficient, res.horse_id, res.race_id, res.number from race, bet, res where bet.result_id = res.result_id and res.race_id = race.race_id and bet.bet_id={id} order by bet_id";
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            string dateTime = dataSet.Tables[0].Rows[0][0].ToString();
            int sum = Convert.ToInt32(dataSet.Tables[0].Rows[0][1].ToString());
            double rescoef = Convert.ToDouble(dataSet.Tables[0].Rows[0][2].ToString());
            double propcoef = Convert.ToDouble(dataSet.Tables[0].Rows[0][3].ToString());
            int horse_id = Convert.ToInt32(dataSet.Tables[0].Rows[0][4].ToString());
            int race_id = Convert.ToInt32(dataSet.Tables[0].Rows[0][5].ToString());
            int number = Convert.ToInt32(dataSet.Tables[0].Rows[0][6].ToString());
            sqlcon.Close();
            str += $"Bet #{id.ToString()}\n";
            str += $"Bet result time: {dateTime}\n";
            str += $"Sum: {sum.ToString()}\n";
            str += $"Coeficient: {rescoef.ToString()}\n";
            str += $"Props: {propcoef.ToString()}\n";
            str += $"Horse:\n {getHorse(horse_id)}\n";
            str += $"Race number: {race_id}\n";
            str += $"Horse`s result: {number}\n";
            if (number == 0)
            {
                str += $"Result: not passed\n";
            }
            else
            {
                if (number == 1)
                {
                    str += $"Result: victory\n";
                    str += $"Total: {(Convert.ToDouble(sum) * rescoef * (1 - propcoef)).ToString()}\n";
                }
                else
                {
                    str += $"Result: lose\n";
                }
            }
            return str;
        }
        private void getReport()
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream($"../../reports/report2.{numericUpDown1}.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph(getQuery(Convert.ToInt32(numericUpDown1.Value)));
            doc.Add(p1);
            doc.Close();
        }

        private void button1_Click(object sender,
            EventArgs e)=> getReport();
    }
}
