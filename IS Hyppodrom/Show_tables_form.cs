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
    public partial class Show_tables_form : Form
    {
        public Show_tables_form()
        {
            InitializeComponent();
        }

                private void cynologistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cynologistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hyppodromDataSet);

        }

        private void Show_tables_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Horse". При необходимости она может быть перемещена или удалена.
            this.horseTableAdapter.Fill(this.hyppodromDataSet.Horse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hyppodromDataSet.Cynologist". При необходимости она может быть перемещена или удалена.
            this.cynologistTableAdapter.Fill(this.hyppodromDataSet.Cynologist);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to confirm the changes?", "Data changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cynologistBindingSource.EndEdit();
                cynologistTableAdapter.Update(hyppodromDataSet);
                horseTableAdapter.Update(hyppodromDataSet);
            }

        }
    
    }
}
