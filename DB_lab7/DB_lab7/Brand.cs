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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            GetSneakersRecord();
        }

        public int BrandID { get; set; }
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=shopsneakers;password=102505");

        private void GetSneakersRecord()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM brand", con);
            DataTable dt = new DataTable();

            con.Open();

            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            BrandDataGrid.DataSource = dt;

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO brand (BrandName) VALUES (@brandname)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@brandname", text_brandname.Text);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Бренд успешно добавлен!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
        }

        private void ResetObjects()
        {
            BrandID = 0;
            text_brandname.Clear();
            text_brandname.Focus();
        }
        private bool IsValid()
        {
            if (text_brandname.Text == String.Empty)
            {
                MessageBox.Show("Бренд не введен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (BrandID > 0)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE brand SET BrandName = @brandname WHERE id = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.BrandID);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Бренд успешно изменен!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите бренд для обновления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BrandID > 0)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM brand WHERE id = @ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.BrandID);

                    con.Open();
                    cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Бренд успешно удален!", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetSneakersRecord();
                    ResetObjects();
                }
                else
                {
                    MessageBox.Show("Пожалуйста выберите бренд для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetObjects();
        }

        private void SneakersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BrandID = Convert.ToInt32(BrandDataGrid.SelectedRows[0].Cells[0].Value);
            text_brandname.Text = BrandDataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
