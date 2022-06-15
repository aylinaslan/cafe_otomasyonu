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

     
