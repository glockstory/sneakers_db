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
    public partial class AddSneakers : Form
    {
        public AddSneakers()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SneakersForm main = this.Owner as SneakersForm;
            if (main != null)
            {
                DataRow nRow = main.shopsneakersDataSet1.Tables[0].NewRow();
                int rowCount = main.dataGridView1.RowCount + 1;
                nRow[1] = textBox_model.Text;
                nRow[2] = textBox_gender.Text;
                nRow[3] = textBox_price.Text;
                nRow[4] = textBox_id_brand.Text;
                main.shopsneakersDataSet1.Tables[0].Rows.Add(nRow);
                main.sneakersTableAdapter.Update(main.shopsneakersDataSet1.sneakers);
                main.shopsneakersDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox_model.Clear();
                textBox_gender.Clear();
                textBox_price.Clear();
                textBox_id_brand.Clear();
                MessageBox.Show("Запись успешно добавлена");
            }
            else
            {
                MessageBox.Show("Невозможно добавить запись!");
            }
        }
    }
}

