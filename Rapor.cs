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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using DGVPrinterHelper;

namespace PB_Cafe
{
    public partial class Rapor : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["PBCafe"].ConnectionString;
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataTable tablo = new DataTable();
        public Rapor()
        {
            InitializeComponent();
        }

        public void doldur()
        {
            string sorgu = "Select * From tbl_Rapor";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public void getir()
        {
            tablo.Clear();
            string sorgu = "Select * From tbl_Rapor Where tarih between @tr1 and @tr2";
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@tr1", dateTimePicker1.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@tr2", dateTimePicker2.Value.Date);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btn_anaMenu_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Close();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            //doldur();
        }

        public int gelirHesap()
        {
            int gelirToplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                gelirToplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value);
            }
            return gelirToplam;
        }

        public int giderHesap()
        {
            int giderToplam = 0;
            int yemekToplam = 0;
            int kampanyaToplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                yemekToplam += (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)) * (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                kampanyaToplam += (Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value)) * (Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value));
            }
            giderToplam = yemekToplam + kampanyaToplam;
            return giderToplam;
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            getir();
            lbl_gelir.Text = gelirHesap().ToString() + " TL";
            lbl_gider.Text = giderHesap().ToString() + " TL";
            int durum = gelirHesap() - giderHesap();
            if (durum < 0)
            {
                lbl_karzarar.Text = durum.ToString() + " TL zarar.";
            }
            else
            {
                lbl_karzarar.Text = durum.ToString() + " TL kâr.";
            }
        }

        public void pdfYazdir(DataGridView dg, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dg.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dg.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);

            }
            foreach (DataGridViewRow row in dg.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        public void dgvPrinter()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Rapor";
            printer.SubTitle = string.Format("Tarih: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Pastorize Bilişim";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            //pdfYazdir(dataGridView1, "Rapor Tablosu");
            dgvPrinter();
        }
    }
}
