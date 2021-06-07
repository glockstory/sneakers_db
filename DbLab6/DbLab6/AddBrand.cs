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
    public partial class AddBrand : Form
    {
        public AddBrand()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.shopsneakersDataSet.Tables[0].NewRow();
                int rowCount = main.dataGridView1.RowCount + 1;
                //nRow[0] = rowCount;
                nRow[1] = textBox_BrandName.Text;
                main.shopsneakersDataSet.Tables[0].Rows.Add(nRow);
                main.brandTableAdapter.Update(main.shopsneakersDataSet.brand);
                main.shopsneakersDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox_BrandName.Clear();
                MessageBox.Show("Запись успешно добавлена");
            }
            else
            {
                MessageBox.Show("Невозможно добавить запись!");
            }
        }
    }
}
