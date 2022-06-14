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
    public partial class MenuGoster : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionString);
        public MenuGoster()
        {
            InitializeComponent();
        }

        public void kategoriDoldur()
        {
            baglanti.Open();
            string sorgu = "Select kategoriAd From tbl_Kategori";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void MenuGoster_Load(object sender, EventArgs e)
        {
            kategoriDoldur();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select yemekResim, yemekFiyat From tbl_Menu Where yemekAd=@p1";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@p1", comboBox1.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pictureBox1.ImageLocation = dr["yemekResim"].ToString();
                tb_fiyat.Text = dr["yemekFiyat"].ToString();
            }
            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen kategoriye göre yemekler listelenecek.
            comboBox1.Items.Clear();
            baglanti.Open();
            string sorgu = "Select yemekAd From tbl_Menu Where yemekKategori=@p1";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@p1", comboBox2.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["yemekAd"]);
            }
            baglanti.Close();
        }
    }
}
