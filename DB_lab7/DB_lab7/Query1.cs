using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_lab7
{
    public partial class Query1 : Form
    {
        public Query1()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=shopsneakers;password=102505");

        private void Query1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand("select model, BrandName from Sneakers join Brand on sneakers.id_brand = brand.id where brandname = @brand ", con))
            {

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@brand", text_brand.Text);
                DataTable dt = new DataTable();

                con.Open();

                MySqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
