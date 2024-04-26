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

namespace ProjeGreyder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection("Data Source=CODECYBER\\SQLEXPRESS;Initial Catalog=emir;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textresim.Text = openFileDialog1.FileName;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Greyder(isim,model,marka,tekerlek,agirlik,renk,fiyat,uzunluk,resim) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",_connection);
            cmd.Parameters.AddWithValue("@p1", textisim.Text);
            cmd.Parameters.AddWithValue("@p2", textmodel.Text);
            cmd.Parameters.AddWithValue("@p3", textmarka.Text);
            cmd.Parameters.AddWithValue("@p4", texttekerlek.Text);
            cmd.Parameters.AddWithValue("@p5", textagirlilk.Text);
            cmd.Parameters.AddWithValue("@p6", textrenk.Text);
            cmd.Parameters.AddWithValue("@p7", textfiyat.Text);
            cmd.Parameters.AddWithValue("@p8", textuzunluk.Text);
            cmd.Parameters.AddWithValue("@p9", textresim.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ekleme işlemi başarılı");
            _connection.Close();

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Index ındex = new Index();
            ındex.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Istatislik ista = new Istatislik();
            ista.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void textisim_Resize(object sender, EventArgs e)
        {

        }
    }
}
