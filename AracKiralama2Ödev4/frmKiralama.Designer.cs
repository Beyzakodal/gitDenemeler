
namespace AracKiralama2Ödev4
{
    partial class frmKiralama
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.cbÖdeme = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlaka = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptal.Location = new System.Drawing.Point(387, 232);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(86, 32);
            this.btnIptal.TabIndex = 51;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTamam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTamam.Location = new System.Drawing.Point(290, 232);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(86, 32);
            this.btnTamam.TabIndex = 50;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(58, 119);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(133, 20);
            this.mtxtTel.TabIndex = 49;
            // 
            // cbÖdeme
            // 
            this.cbÖdeme.FormattingEnabled = true;
            this.cbÖdeme.Items.AddRange(new object[] {
            "Visa",
            "Nakit"});
            this.cbÖdeme.Location = new System.Drawing.Point(362, 50);
            this.cbÖdeme.Name = "cbÖdeme";
            this.cbÖdeme.Size = new System.Drawing.Size(99, 21);
            this.cbÖdeme.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Ödeme Türü:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(57, 191);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(134, 64);
            this.txtAdres.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Adres:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(58, 154);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(133, 20);
            this.txtMail.TabIndex = 42;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(58, 86);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(133, 20);
            this.txtTc.TabIndex = 41;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(58, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(133, 20);
            this.txtSoyad.TabIndex = 40;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(58, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(133, 20);
            this.txtAd.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Plaka:";
            // 
            // cbPlaka
            // 
            this.cbPlaka.FormattingEnabled = true;
            this.cbPlaka.Items.AddRange(new object[] {
            "06 B 4568"});
            this.cbPlaka.Location = new System.Drawing.Point(362, 15);
            this.cbPlaka.Name = "cbPlaka";
            this.cbPlaka.Size = new System.Drawing.Size(99, 21);
            this.cbPlaka.TabIndex = 56;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "KiralamaID:";
            // 
            // frmKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 310);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPlaka);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.cbÖdeme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKiralama";
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmKiralama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.ComboBox cbÖdeme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlaka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}