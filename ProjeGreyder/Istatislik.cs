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
    public partial class Istatislik : Form
    {
        public Istatislik()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection _connection = new SqlConnection("Data Source=CODECYBER\\SQLEXPRESS;Initial Catalog=emir;Integrated Security=True");
        private void Istatislik_Load(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand marka = new SqlCommand("SELECT marka,COUNT(*) FROM Greyder group by marka", _connection);


            SqlDataReader oku = marka.ExecuteReader();


            while (oku.Read())
            {
              
                this.marka.Series["Greyder"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
               

            }
            oku.Close();

            SqlCommand toplam = new SqlCommand("SELECT count(marka) from Greyder", _connection);
            SqlDataReader read = toplam.ExecuteReader();
            while (read.Read())
            {

                this.Toplam.Series["Greyder"].Points.AddXY("Toplam Ürün",read[0].ToString());

            }
            read.Close();

            SqlCommand model = new SqlCommand("SELECT model,count(model) from Greyder group by model", _connection);
            SqlDataReader rmodel = model.ExecuteReader();
            while (rmodel.Read())
            {

                this.model.Series["Greyder"].Points.AddXY(rmodel[0].ToString(), rmodel[1].ToString());

            }

            rmodel.Close();

            SqlCommand tekerlek = new SqlCommand("SELECT tekerlek,count(tekerlek) from Greyder group by tekerlek", _connection);
            SqlDataReader rtekerlek = tekerlek.ExecuteReader();
            while (rtekerlek.Read())
            {

                this.tekerlek.Series["Greyder"].Points.AddXY(rtekerlek[0].ToString(), rtekerlek[1].ToString());

            }

            rtekerlek.Close();

            SqlCommand agirlik = new SqlCommand("SELECT agirlik,count(agirlik) from Greyder group by agirlik", _connection);
            SqlDataReader ragirlik = agirlik.ExecuteReader();
            while (ragirlik.Read())
            {

                this.agirlik.Series["Greyder"].Points.AddXY(ragirlik[0].ToString(), ragirlik[1].ToString());

            }
            ragirlik.Close();

            SqlCommand fiyat = new SqlCommand("SELECT fiyat,count(fiyat) from Greyder group by fiyat", _connection);
            SqlDataReader rfiyat = fiyat.ExecuteReader();
            while (rfiyat.Read())
            {

                this.fiyat.Series["Greyder"].Points.AddXY(rfiyat[0].ToString(), rfiyat[1].ToString());

            }
            rfiyat.Close();

            SqlCommand uzunluk = new SqlCommand("SELECT uzunluk,count(uzunluk) from Greyder group by uzunluk", _connection);
            SqlDataReader ruzunluk = uzunluk.ExecuteReader();
            while (ruzunluk.Read())
            {

                this.uzunluk.Series["Greyder"].Points.AddXY(ruzunluk[0].ToString(), ruzunluk[1].ToString());

            }

            ruzunluk.Close();

            SqlCommand renk = new SqlCommand("SELECT renk,count(renk) from Greyder group by renk", _connection);
            SqlDataReader rrenk = renk.ExecuteReader();
            while (rrenk.Read())
            {

                this.renk.Series["Greyder"].Points.AddXY(rrenk[0].ToString(), rrenk[1].ToString());

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
