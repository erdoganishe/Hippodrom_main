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
    public partial class Request_Form : Form
    {
        const string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";
       
        public Request_Form(string select)
        {
        InitializeComponent(); 
        SqlConnection sqlcon = new SqlConnection(ConnectionString);
        sqlcon.Open();
        SqlDataAdapter oda = new SqlDataAdapter(select, sqlcon);
        DataTable dt = new DataTable();
        oda.Fill(dt);
        dataGridView1.DataSource = dt;
        sqlcon.Close();
        dataGridView1.Height = 8+(dataGridView1.Rows.Count+2)*20;
        }
    }
}
