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
    public partial class Query2 : Form
    {
        public Query2()
        {
            InitializeComponent();
        }


        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=shopsneakers;password=102505");

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand("select model, size from Sneakers s join Exemplar e on s.id = e.id_sneakers where size = @size;", con))
            {

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@size", text_size.Text);
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
