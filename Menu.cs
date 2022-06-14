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
    public partial class Menu : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlDataAdapter da;
        public Menu()
        {
            InitializeComponent();
        }
        public void getir()
        {
            string sorgu = "Select * From tbl_Menu";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public void kategoriDoldur()
        {
            baglanti.Open();
            string sorgu = "Select kategoriAd From tbl_Kategori";
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_kategori.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            getir();
            kategoriDoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                int comboDeger = cb_kategori.SelectedIndex;
                string sql = "insert into tbl_Menu (yemekAd, yemekKategori, yemekFiyat, yemekMaliyet, yemekResim)";
                sql += "values(@ad, @kategori, @fiyat, @maliyet, @resim)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@ad", tb_yemekAd.Text);
                cmd.Parameters.AddWithValue("@kategori", comboDeger + 1);
                cmd.Parameters.AddWithValue("@fiyat", tb_yemekFiyat.Text);
                cmd.Parameters.AddWithValue("@maliyet", tb_yemekMaliyet.Text);
                cmd.Parameters.AddWithValue("@resim", tb_resimYol.Text);
                cmd.Connection = baglanti;
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                getir();
            }
        }

        private void btn_düzenle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                int comboDeger = cb_kategori.SelectedIndex;
                string sql = "Update tbl_Menu ";
                sql += "Set yemekAd=@ad, yemekKategori=@kategori, yemekFiyat=@fiyat, " +
                "yemekMaliyet=@maliyet, yemekResim=@resim From tbl_Menu m join tbl_Kategori k on m.yemekKategori=k.KategoriId Where yemekId=@id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                cmd.Parameters.AddWithValue("@ad", tb_yemekAd.Text);
                cmd.Parameters.AddWithValue("@kategori", comboDeger + 1);
                cmd.Parameters.AddWithValue("@fiyat", tb_yemekFiyat.Text);
                cmd.Parameters.AddWithValue("@maliyet", tb_yemekMaliyet.Text);
                cmd.Parameters.AddWithValue("@resim", tb_resimYol.Text);
                cmd.Connection = baglanti;
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                getir();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = "Delete From tbl_Menu ";
                sql += "Where yemekId=@id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                cmd.Connection = baglanti;
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                getir();
            }
        }

        private void btn_anaMenu_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tb_yemekAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cb_kategori.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_yemekFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_yemekMaliyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_resimYol.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.ImageLocation = tb_resimYol.Text;
        }

    }
}
