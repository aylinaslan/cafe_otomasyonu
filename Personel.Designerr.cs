namespace PB_Cafe
{
    partial class Personel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.cb_gorev = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_resimEkle = new System.Windows.Forms.Button();
            this.btn_resimSil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_düzenle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_anaMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_resimYol = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 391);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayrılan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(240, 391);
            this.dataGridView2.TabIndex = 1;
            // 
            // tb_ara
            // 
            this.tb_ara.Location = new System.Drawing.Point(90, 444);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(122, 20);
            this.tb_ara.TabIndex = 1;
            this.tb_ara.TextChanged += new System.EventHandler(this.tb_ara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara:";
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(348, 34);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(122, 20);
            this.tb_ad.TabIndex = 3;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(348, 73);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(122, 20);
            this.tb_soyad.TabIndex = 4;
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(348, 108);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(122, 20);
            this.tb_telefon.TabIndex = 5;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(348, 144);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(122, 20);
            this.tb_mail.TabIndex = 6;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(348, 182);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(122, 66);
            this.tb_adres.TabIndex = 7;
            // 
            // cb_gorev
            // 
            this.cb_gorev.FormattingEnabled = true;
            this.cb_gorev.Location = new System.Drawing.Point(349, 254);
            this.cb_gorev.Name = "cb_gorev";
            this.cb_gorev.Size = new System.Drawing.Size(121, 21);
            this.cb_gorev.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_resimEkle
            // 
            this.btn_resimEkle.Location = new System.Drawing.Point(288, 343);
            this.btn_resimEkle.Name = "btn_resimEkle";
            this.btn_resimEkle.Size = new System.Drawing.Size(50, 23);
            this.btn_resimEkle.TabIndex = 10;
            this.btn_resimEkle.Text = "Yükle";
            this.btn_resimEkle.UseVisualStyleBackColor = true;
            this.btn_resimEkle.Click += new System.EventHandler(this.btn_resimEkle_Click);
            // 
            // btn_resimSil
            // 
            this.btn_resimSil.Location = new System.Drawing.Point(288, 372);
            this.btn_resimSil.Name = "btn_resimSil";
            this.btn_resimSil.Size = new System.Drawing.Size(50, 23);
            this.btn_resimSil.TabIndex = 11;
            this.btn_resimSil.Text = "Sil";
            this.btn_resimSil.UseVisualStyleBackColor = true;
            this.btn_resimSil.Click += new System.EventHandler(this.btn_resimSil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(286, 441);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_düzenle
            // 
            this.btn_düzenle.Location = new System.Drawing.Point(367, 441);
            this.btn_düzenle.Name = "btn_düzenle";
            this.btn_düzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_düzenle.TabIndex = 13;
            this.btn_düzenle.Text = "Düzenle";
            this.btn_düzenle.UseVisualStyleBackColor = true;
            this.btn_düzenle.Click += new System.EventHandler(this.btn_düzenle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(448, 441);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_anaMenu
            // 
            this.btn_anaMenu.Location = new System.Drawing.Point(367, 470);
            this.btn_anaMenu.Name = "btn_anaMenu";
            this.btn_anaMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_anaMenu.TabIndex = 15;
            this.btn_anaMenu.Text = "Ana Menü";
            this.btn_anaMenu.UseVisualStyleBackColor = true;
            this.btn_anaMenu.Click += new System.EventHandler(this.btn_anaMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Görev:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Resim:";
            // 
            // tb_resimYol
            // 
            this.tb_resimYol.Enabled = false;
            this.tb_resimYol.Location = new System.Drawing.Point(348, 410);
            this.tb_resimYol.Name = "tb_resimYol";
            this.tb_resimYol.Size = new System.Drawing.Size(134, 20);
            this.tb_resimYol.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 502);
            this.Controls.Add(this.tb_resimYol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_anaMenu);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_düzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_resimSil);
            this.Controls.Add(this.btn_resimEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_gorev);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ara);
            this.Controls.Add(this.tabControl1);
            this.Name = "Personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.ComboBox cb_gorev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_resimEkle;
        private System.Windows.Forms.Button btn_resimSil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_düzenle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_anaMenu;
      
    }
}