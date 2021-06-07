using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbLab6
{
    public partial class SneakersForm : Form
    {
        public SneakersForm()
        {
            InitializeComponent();
        }

        private void SneakersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopsneakersDataSet1.sneakers". При необходимости она может быть перемещена или удалена.
            this.sneakersTableAdapter.Fill(this.shopsneakersDataSet1.sneakers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form addSnek = new AddSneakers();
            addSnek.Owner = this;
            addSnek.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
