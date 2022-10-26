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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
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

        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            betTableAdapter.Update(hyppodromDataSet.Bet);
            resTableAdapter.Update(hyppodromDataSet.Res);
            cynologistTableAdapter.Update(hyppodromDataSet.Cynologist);
            horseTableAdapter.Update(hyppodromDataSet.Horse);
            raceTableAdapter.Update(hyppodromDataSet.Race);
        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
