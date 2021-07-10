
namespace AracKiralama2Ödev4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAracEkle = new System.Windows.Forms.ToolStripButton();
            this.btnAracDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnAracSil = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbPlaka = new System.Windows.Forms.ComboBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.cbÖdeme = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnYeniKiralama = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnKiralamaİptal = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKiralama,
            this.toolStripButton1,
            this.toolStripButton2,
            this.btnKiralamaİptal,
            this.toolStripSeparator1,
            this.btnAracEkle,
            this.btnAracDüzenle,
            this.btnAracSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(59, 22);
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracDüzenle
            // 
            this.btnAracDüzenle.Image = global::AracKiralama2Ödev4.Properties.Resources.Actions_edit_redo_icon;
            this.btnAracDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracDüzenle.Name = "btnAracDüzenle";
            this.btnAracDüzenle.Size = new System.Drawing.Size(134, 22);
            this.btnAracDüzenle.Text = "Araç Bilgisi Güncelle";
            // 
            // btnAracSil
            // 
            this.btnAracSil.Image = global::AracKiralama2Ödev4.Properties.Resources.car_delete_icon;
            this.btnAracSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(66, 22);
            this.btnAracSil.Text = "Araç Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 279);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbPlaka
            // 
            this.cbPlaka.FormattingEnabled = true;
            this.cbPlaka.Items.AddRange(new object[] {
            "06 B 4525"});
            this.cbPlaka.Location = new System.Drawing.Point(337, 140);
            this.cbPlaka.Name = "cbPlaka";
            this.cbPlaka.Size = new System.Drawing.Size(133, 21);
            this.cbPlaka.TabIndex = 72;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(91, 136);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(133, 20);
            this.mtxtTel.TabIndex = 69;
            // 
            // cbÖdeme
            // 
            this.cbÖdeme.FormattingEnabled = true;
            this.cbÖdeme.Items.AddRange(new object[] {
            "Visa",
            "Nakit"});
            this.cbÖdeme.Location = new System.Drawing.Point(612, 40);
            this.cbÖdeme.Name = "cbÖdeme";
            this.cbÖdeme.Size = new System.Drawing.Size(99, 21);
            this.cbÖdeme.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Ödeme Türü:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(336, 67);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(134, 64);
            this.txtAdres.TabIndex = 64;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(336, 37);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(133, 20);
            this.txtMail.TabIndex = 63;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(91, 103);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(133, 20);
            this.txtTc.TabIndex = 62;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(91, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(133, 20);
            this.txtSoyad.TabIndex = 61;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(91, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(133, 20);
            this.txtAd.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Plaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Telefon:";
            // 
            // txtArama
            // 
            this.txtArama.AutoSize = true;
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(515, 148);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(71, 15);
            this.txtArama.TabIndex = 79;
            this.txtArama.Text = "Tc İle Ara:";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 80;
            // 
            // btnYeniKiralama
            // 
            this.btnYeniKiralama.Image = global::AracKiralama2Ödev4.Properties.Resources.bmw_mini_icon;
            this.btnYeniKiralama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniKiralama.Name = "btnYeniKiralama";
            this.btnYeniKiralama.Size = new System.Drawing.Size(56, 22);
            this.btnYeniKiralama.Text = "Kirala";
            this.btnYeniKiralama.Click += new System.EventHandler(this.btnYeniKiralama_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::AracKiralama2Ödev4.Properties.Resources.Actions_edit_redo_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(122, 22);
            this.toolStripButton1.Text = "Kiralama Güncelle";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton2.Text = "Kiralama Listele";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnKiralamaİptal
            // 
            this.btnKiralamaİptal.Image = global::AracKiralama2Ödev4.Properties.Resources.car_delete_icon;
            this.btnKiralamaİptal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKiralamaİptal.Name = "btnKiralamaİptal";
            this.btnKiralamaİptal.Size = new System.Drawing.Size(99, 22);
            this.btnKiralamaİptal.Text = "Kiralama İptal";
            this.btnKiralamaİptal.Click += new System.EventHandler(this.btnKiralamaİptal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(723, 455);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPlaka);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.cbÖdeme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnYeniKiralama;
        private System.Windows.Forms.ToolStripButton btnKiralamaİptal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAracEkle;
        private System.Windows.Forms.ToolStripButton btnAracDüzenle;
        private System.Windows.Forms.ToolStripButton btnAracSil;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbPlaka;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.ComboBox cbÖdeme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtArama;
        private System.Windows.Forms.TextBox textBox1;
    }
}

