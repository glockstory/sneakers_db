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
    }
}
