using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_lab7
{
    public partial class ChooseForms : Form
    {
        public ChooseForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form toSn = new Sneakers();
            toSn.Owner = this;
            toSn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form toEx = new Exemplar();
            toEx.Owner = this;
            toEx.Show();
        }

        private void ChooseForms_Load(object sender, EventArgs e)
        {

        }

        private void query1_Click(object sender, EventArgs e)
        {
            Form toQ1 = new Query1();
            toQ1.Owner = this;
            toQ1.Show();
        }

        private void query2_Click(object sender, EventArgs e)
        {
            Form toQ2 = new Query2();
            toQ2.Owner = this;
            toQ2.Show();
        }

        private void selectPrice_Click(object sender, EventArgs e)
        {
            Form toForm = new Query3();
            toForm.Owner = this;
            toForm.Show();
        }
    }
}
