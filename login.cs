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
using System.Security.Cryptography;

namespace PB_Cafe
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            tb_kullaniciSifre.PasswordChar = '*';
            tb_kullaniciSifre.MaxLength = 10;
        }

        public void temizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM tbl_kullanici where kullaniciAd=@ad AND kullaniciSifre=@sifre";
                baglanti = new SqlConnection(connectionString);
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", tb_kullaniciAd.Text);
                komut.Parameters.AddWithValue("@sifre", tb_kullaniciSifre.Text);
                baglanti.Open();
                dr = komut.ExecuteReader();
