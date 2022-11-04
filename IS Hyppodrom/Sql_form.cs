using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS_Hyppodrom
{
    public partial class Sql_form : Form
    {
        const string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";
        public Sql_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "Select";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
