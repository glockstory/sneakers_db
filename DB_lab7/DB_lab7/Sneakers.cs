using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DB_lab7
{
    public partial class Sneakers : Form
    {
        public Sneakers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSneakersRecord();
        }

        public int BrandID { get; set; }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=shopsneakers;password=102505");
        private void GetSneakersRecord()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sneakers", con);
            DataTable dt = new DataTable();

            con.Open();

            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            SneakersDataGrid.DataSource = dt;

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sneakers (model,gender,price,id_brand) VALUES (@model,@gender,@price,@id_brand)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@model", text_model.Text);
                cmd.Parameters.AddWithValue("@gender", text_gender.Text);
                cmd.Parameters.AddWithValue("@price", text_price.Text);
                cmd.Parameters.AddWithValue("@id_brand", text_idBrand.Text);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Кроссовки успешно добавлены!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
        }

        private bool IsValid()
        {
            if (text_model.Text == String.Empty)
            {
                MessageBox.Show("Модель не введена", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetObjects();
        }

        private void ResetObjects()
        {
            BrandID = 0;
            text_idBrand.Clear();
            text_price.Clear();
            text_gender.Clear();
            text_model.Clear();
            text_model.Focus();
        }

        private void SneakersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BrandID = Convert.ToInt32(SneakersDataGrid.SelectedRows[0].Cells[0].Value);
            text_model.Text = SneakersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            text_gender.Text = SneakersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            text_price.Text = SneakersDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            text_idBrand.Text = SneakersDataGrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (BrandID > 0)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE sneakers SET model = @model, gender = @gender," +
                                                    "price = @price, id_brand = @id_brand WHERE id = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@model", text_model.Text);
                cmd.Parameters.AddWithValue("@gender", text_gender.Text);
                cmd.Parameters.AddWithValue("@price", text_price.Text);
                cmd.Parameters.AddWithValue("@id_brand", text_idBrand.Text);
                cmd.Parameters.AddWithValue("@ID", this.BrandID);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Кроссовки успешно добавлены!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите кроссовки для обновления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
               
            }
            if (BrandID > 0)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM sneakers WHERE id = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.BrandID);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Кроссовки успешно удалены!", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите кроссовки для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
