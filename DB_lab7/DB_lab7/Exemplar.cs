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
    public partial class Exemplar : Form
    {
        public Exemplar()
        {
            InitializeComponent();
        }

        public int ExemplarID { get; set; }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=shopsneakers;password=102505");
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO exemplar (count,size,color,id_sneakers,id_delivery,id_sale)" +
                                                    " VALUES (@count,@size,@color,@id_sneakers,@id_delivery,@id_sale)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@count", text_count.Text);
                cmd.Parameters.AddWithValue("@color", text_color.Text);
                cmd.Parameters.AddWithValue("@size", text_size.Text);
                cmd.Parameters.AddWithValue("@id_delivery", text_idDelivery.Text);
                cmd.Parameters.AddWithValue("@id_sale", text_idSale.Text);
                cmd.Parameters.AddWithValue("@id_sneakers", text_idSneakers.Text);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Экземпляр успешно добавлен!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
        }

        private void ResetObjects()
        {
            ExemplarID = 0;
            text_count.Clear();
            text_color.Clear();
            text_size.Clear();
            text_idDelivery.Clear();
            text_idSale.Clear();
            text_idSneakers.Clear();
            text_count.Focus();
        }

        private bool IsValid()
        {
            if (text_count.Text == String.Empty)
            {
                MessageBox.Show("Количество не введено", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ExemplarID > 0)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE exemplar SET count = @count," +
                                                    "size = @size, color = @color," +
                                                    "id_sneakers = @id_sneakers," +
                                                    "id_delivery = @id_delivery,id_sale = @id_sale WHERE id = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@count", text_count.Text);
                cmd.Parameters.AddWithValue("@color", text_color.Text);
                cmd.Parameters.AddWithValue("@size", text_size.Text);
                cmd.Parameters.AddWithValue("@id_delivery", text_idDelivery.Text);
                cmd.Parameters.AddWithValue("@id_sale", text_idSale.Text);
                cmd.Parameters.AddWithValue("@id_sneakers", text_idSneakers.Text);
                cmd.Parameters.AddWithValue("@ID", this.ExemplarID);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Экземпляр успешно изменен!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSneakersRecord();
                ResetObjects();
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите экземпляр для обновления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExemplarID > 0)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM exemplar WHERE id = @ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.ExemplarID);

                    con.Open();
                    cmd.ExecuteReader();
                    con.Close();

                    MessageBox.Show("Экземпляр успешно удален!", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetSneakersRecord();
                    ResetObjects();
                }
                else
                {
                    MessageBox.Show("Пожалуйста выберите экземпляр для удаления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ExemplarID = Convert.ToInt32(ExemplarDataGrid.SelectedRows[0].Cells[0].Value);
            text_count.Text = ExemplarDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            text_size.Text = ExemplarDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            text_color.Text = ExemplarDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            text_idSneakers.Text = ExemplarDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            text_idDelivery.Text = ExemplarDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            text_idSale.Text = ExemplarDataGrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Exemplar_Load(object sender, EventArgs e)
        {
            GetSneakersRecord();
        }

        private void GetSneakersRecord()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM exemplar", con);
            DataTable dt = new DataTable();

            con.Open();

            MySqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            ExemplarDataGrid.DataSource = dt;

        }

    }
}
