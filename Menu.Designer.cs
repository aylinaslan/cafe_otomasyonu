namespace PB_Cafe
{
    partial class Menu
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_yemekMaliyet = new System.Windows.Forms.TextBox();
            this.tb_resimYol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_anaMenu = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_düzenle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_resimSil = new System.Windows.Forms.Button();
            this.btn_resimEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_yemekFiyat = new System.Windows.Forms.TextBox();
            this.tb_yemekAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Menü";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(331, 408);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Maliyet:";
            // 
            // tb_yemekMaliyet
            // 
            this.tb_yemekMaliyet.Location = new System.Drawing.Point(455, 138);
            this.tb_yemekMaliyet.Name = "tb_yemekMaliyet";
            this.tb_yemekMaliyet.Size = new System.Drawing.Size(122, 20);
            this.tb_yemekMaliyet.TabIndex = 66;
            // 
            // tb_resimYol
            // 
            this.tb_resimYol.Enabled = false;
            this.tb_resimYol.Location = new System.Drawing.Point(455, 293);
            this.tb_resimYol.Name = "tb_resimYol";
            this.tb_resimYol.Size = new System.Drawing.Size(134, 20);
            this.tb_resimYol.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Resim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Yemek Adı:";
            // 
            // btn_anaMenu
            // 
            this.btn_anaMenu.Location = new System.Drawing.Point(474, 353);
            this.btn_anaMenu.Name = "btn_anaMenu";
            this.btn_anaMenu.Size = new System.Drawing.Size(75, 54);
            this.btn_anaMenu.TabIndex = 59;
            this.btn_anaMenu.Text = "Ana Menü";
            this.btn_anaMenu.UseVisualStyleBackColor = true;
            this.btn_anaMenu.Click += new System.EventHandler(this.btn_anaMenu_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(555, 324);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 58;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_düzenle
            // 
            this.btn_düzenle.Location = new System.Drawing.Point(474, 324);
            this.btn_düzenle.Name = "btn_düzenle";
            this.btn_düzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_düzenle.TabIndex = 57;
            this.btn_düzenle.Text = "Düzenle";
            this.btn_düzenle.UseVisualStyleBackColor = true;
            this.btn_düzenle.Click += new System.EventHandler(this.btn_düzenle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(393, 324);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 56;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_resimSil
            // 
            this.btn_resimSil.Location = new System.Drawing.Point(395, 255);
            this.btn_resimSil.Name = "btn_resimSil";
            this.btn_resimSil.Size = new System.Drawing.Size(50, 23);
            this.btn_resimSil.TabIndex = 55;
            this.btn_resimSil.Text = "Sil";
            this.btn_resimSil.UseVisualStyleBackColor = true;
            this.btn_resimSil.Click += new System.EventHandler(this.btn_resimSil_Click);
            // 
            // btn_resimEkle
            // 
            this.btn_resimEkle.Location = new System.Drawing.Point(395, 226);
            this.btn_resimEkle.Name = "btn_resimEkle";
            this.btn_resimEkle.Size = new System.Drawing.Size(50, 23);
            this.btn_resimEkle.TabIndex = 54;
            this.btn_resimEkle.Text = "Yükle";
            this.btn_resimEkle.UseVisualStyleBackColor = true;
            this.btn_resimEkle.Click += new System.EventHandler(this.btn_resimEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // tb_yemekFiyat
            // 
            this.tb_yemekFiyat.Location = new System.Drawing.Point(455, 107);
            this.tb_yemekFiyat.Name = "tb_yemekFiyat";
            this.tb_yemekFiyat.Size = new System.Drawing.Size(122, 20);
            this.tb_yemekFiyat.TabIndex = 52;
            // 
            // tb_yemekAd
            // 
            this.tb_yemekAd.Location = new System.Drawing.Point(455, 33);
            this.tb_yemekAd.Name = "tb_yemekAd";
            this.tb_yemekAd.Size = new System.Drawing.Size(122, 20);
            this.tb_yemekAd.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Kategori:";
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(455, 75);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(121, 21);
            this.cb_kategori.TabIndex = 73;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.cb_kategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_yemekMaliyet);
            this.Controls.Add(this.tb_resimYol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_anaMenu);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_düzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_resimSil);
            this.Controls.Add(this.btn_resimEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_yemekFiyat);
            this.Controls.Add(this.tb_yemekAd);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_yemekMaliyet;
        private System.Windows.Forms.TextBox tb_resimYol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_anaMenu;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_düzenle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_resimSil;
        private System.Windows.Forms.Button btn_resimEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_yemekFiyat;
        private System.Windows.Forms.TextBox tb_yemekAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}