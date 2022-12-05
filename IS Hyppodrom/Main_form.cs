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
    public partial class Main_form : Form
    {
        int access;
        public Main_form()
        {
            InitializeComponent();
        }
        public Main_form(int a)
        {
            InitializeComponent();
            access = a;
           
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Res". При необходимости она может быть перемещена или удалена.
            this.resTableAdapter.Fill(this.hyppodromDataSet.Res);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Bet". При необходимости она может быть перемещена или удалена.
            this.betTableAdapter.Fill(this.hyppodromDataSet.Bet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Cynologist". При необходимости она может быть перемещена или удалена.
            this.cynologistTableAdapter.Fill(this.hyppodromDataSet.Cynologist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Horse". При необходимости она может быть перемещена или удалена.
            this.horseTableAdapter.Fill(this.hyppodromDataSet.Horse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Race". При необходимости она может быть перемещена или удалена.
            this.raceTableAdapter.Fill(this.hyppodromDataSet.Race);
            dataGridView1.AutoGenerateColumns = true;

        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            betTableAdapter.Update(hyppodromDataSet.Bet);
            resTableAdapter.Update(hyppodromDataSet.Res);
            cynologistTableAdapter.Update(hyppodromDataSet.Cynologist);
            //horseTableAdapter.Update(hyppodromDataSet.Horse);
            raceTableAdapter.Update(hyppodromDataSet.Race);
        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = horseBindingSource;
            dataGridView1.DataSource = horseBindingSource;
            label1.Text = "Horses";
        }

        private void raceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = raceBindingSource;
            dataGridView1.DataSource = raceBindingSource;
            label1.Text = "Races";
        }

        private void cynologistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = cynologistBindingSource;
            dataGridView1.DataSource = cynologistBindingSource;
            label1.Text = "Cynologists";
        }

        private void betsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = betBindingSource;
            dataGridView1.DataSource = betBindingSource;
            label1.Text = "Bets";
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = resBindingSource;
            dataGridView1.DataSource = resBindingSource;
            label1.Text = "Results";
        }

        private void resetelmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var show_table = new Show_tables_form();
            show_table.ShowDialog();
            horseTableAdapter.Fill(hyppodromDataSet.Horse);
            betTableAdapter.Fill(hyppodromDataSet.Bet);
            raceTableAdapter.Fill(hyppodromDataSet.Race);
            cynologistTableAdapter.Fill(hyppodromDataSet.Cynologist);
            resTableAdapter.Fill(hyppodromDataSet.Res);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void queryeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sf = new Sql_form();
            sf.ShowDialog();
        }
        private bool edit=true;
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!edit) return;
            var edt = new Edit_form();
            edt.ShowDialog();
            horseTableAdapter.Fill(hyppodromDataSet.Horse);
            hyppodromDataSet.AcceptChanges();
        }   

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // label2.Text = Convert.ToInt32(dataGridView1.SelectedCells[0].Value).ToString();
            if (!edit) return;
            horseTableAdapter.DeleteQuery(
            Convert.ToInt32(dataGridView1.SelectedCells[0].Value)
            );
            horseTableAdapter.Fill(hyppodromDataSet.Horse);
            hyppodromDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;
            var st = new HyppodromDataSet.HorseDataTable();
            horseTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new Edit_form(
            Convert.ToInt32(row[0]),
            row[1].ToString(),
            row[2].ToString(),
            row[3].ToString(),
           Convert.ToInt32(row[4]),
            row[5].ToString(),
            row[6].ToString(),
            Convert.ToInt32(row[7])
            );
            edt.ShowDialog();
            horseTableAdapter.Fill(hyppodromDataSet.Horse);
            hyppodromDataSet.AcceptChanges();
        }

        private void horseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sf = new FormReport1();
            sf.ShowDialog();
        }

        private void futureRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string select = "Select * from Race where state = 'Not passed'";
            var rf = new Request_Form(select);             
            rf.ShowDialog();
        }

        private void horseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string select = "Select * from Horse";
            var rf = new Request_Form(select);
            rf.ShowDialog();
        }

        private void previousRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string select = "Select * from Race where state = 'Passed'";
            var rf = new Request_Form(select);
            rf.ShowDialog();
        }

        private void betRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var af = new AskForm();
            af.ShowDialog();
        }

        private void betReportToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            var sf = new FormReport2();
            sf.ShowDialog();
        }
    }
}
