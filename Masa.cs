using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PB_Cafe
{
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
        }

        private void btn_siparisAl_Click(object sender, EventArgs e)
        {
            pn_dinamik.Controls.Clear();
            SiparisAl frm = new SiparisAl();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pn_dinamik.Controls.Add(frm);
            
        }

        private void btn_masaTasi_Click(object sender, EventArgs e)
        {
            pn_dinamik.Controls.Clear();
            MasaTasi frm = new MasaTasi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pn_dinamik.Controls.Add(frm);
            frm.Show();
        }

        private void btn_adisyon_Click(object sender, EventArgs e)
        {
            pn_dinamik.Controls.Clear();
            Adisyon frm = new Adisyon();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pn_dinamik.Controls.Add(frm);
            
        }

     

        private void btn_menu_Click(object sender, EventArgs e)
        {
            pn_dinamik.Controls.Clear();
           
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pn_dinamik.Controls.Add(frm);
            frm.Show();
        }

        private void btn_anaMenu_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Close();
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            MenuAyar frm = new MenuAyar();
            frm.ShowDialog();
        }
    }
}
