using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace PB_Cafe
{
    public partial class Personel : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Personel()
        {
            InitializeComponent();
            doldur();
        }

        public void doldur()
        {
            string[] gorev = { "Şef", "Garson", "Komi" };
            foreach (var item in gorev)
            {
                cb_gorev.Items.Add(item);
            }
        }

        public void getir()
        {
            string sorgu = "Select * From tbl_Personel";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public void getir2()
        {
            string sorgu = "Select * From tbl_silinenPersonel";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }

        public int kontrol(Control ctl)
        {
            int deger = 0;
            foreach (Control tb in this.Controls)
            {
                if (tb is TextBox && tb.Text == String.Empty)
                {
                    MessageBox.Show(Convert.ToString(((TextBox)tb).Tag + "boş geçilemez!!"));
                    deger = 0;
                }
                else
                {
                    deger = 1;
                }
            }
            return deger;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into tbl_Personel (personelAd, personelSoyad, personelTelefon, personelMail, personelAdres,personelGorev,personelResim) " +
                            "values (@ad,@soyad,@telefon,@mail,@adres,@gorev,@resim)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", tb_ad.Text);
            komut.Parameters.AddWithValue("@soyad", tb_soyad.Text);
            komut.Parameters.AddWithValue("@telefon", tb_telefon.Text);
            komut.Parameters.AddWithValue("@mail", tb_mail.Text);
            komut.Parameters.AddWithValue("@adres", tb_adres.Text);
            komut.Parameters.AddWithValue("@gorev", cb_gorev.Text);
            komut.Parameters.AddWithValue("@resim", tb_resimYol.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            getir();
        }

