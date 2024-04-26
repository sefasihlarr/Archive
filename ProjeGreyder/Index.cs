using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeGreyder
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emirDataSet1.Greyder' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'emirDataSet.Urun' table. You can move, or remove it, as needed.
            SqlConnection _connection = new SqlConnection("Data Source=CODECYBER\\SQLEXPRESS;Initial Catalog=emir;Integrated Security=True");
            _connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select id,isim,model,marka,tekerlek,agirlik,renk,fiyat,uzunluk,resim from Greyder", _connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Columns.Add("RESİM", Type.GetType("System.Byte[]"));

            foreach (DataRow item in dt.Rows)
            {
                item["RESİM"] = File.ReadAllBytes(item["resim"].ToString());
            }

            dataGridView2.DataSource = dt;
            _connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Istatislik istatislik = new Istatislik();
            istatislik.Show();
        }
    }
}
