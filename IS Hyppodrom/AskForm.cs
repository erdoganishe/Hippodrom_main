using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Hyppodrom
{
    public partial class AskForm : Form
    {
        int race_id;
        public AskForm()
        {
            InitializeComponent();
            string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string select = $"select * from race";
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            int count = dataSet.Tables[0].Rows.Count;
            sqlcon.Close();
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = count-1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            race_id = Convert.ToInt32(numericUpDown1.Value);
            string select = $"Select res.result_id, res.race_id as 'Race number', race.date_time as 'Date', race.duration_time as 'Duration', race.type as 'Race type', res.horse_id as 'Horse number', horse.name as 'Horse name', res.coeficient as 'Coeficient on victory', '5168-7451-1198-4024' as Props from res, horse, race where res.horse_id= horse.horse_id and res.race_id=race.race_id and race.race_id ={race_id}";
            var rf = new Request_Form(select);
            rf.ShowDialog();
        }
    }
}
