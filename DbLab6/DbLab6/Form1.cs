using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace DbLab6
{
    public partial class Form1 : Form
    {
        //private DataSet OurDataSet; - существует
        //private SqlDataAdapter adapter; - существует
        private SqlCommandBuilder ourCommandBuilder;
        private string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;password=102505;database=shopsneakers";
        //private string sql = "SELECT * FROM Brand";
        public Form1()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            Form addBrand = new AddBrand();
            addBrand.Owner = this;
            addBrand.Show();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopsneakersDataSet.brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.shopsneakersDataSet.brand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brandTableAdapter.Update(shopsneakersDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void toFormSneakers_Click(object sender, EventArgs e)
        {
            Form sf = new SneakersForm();
            sf.Owner = this;
            sf.Show();
        }
    }
}
