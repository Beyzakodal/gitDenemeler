using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama2Ödev4
{
    public partial class frmKiralama : Form
    {
        DL Kirala = new DL();
        public frmKiralama()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
         
            
            string sql = "insert into kiralama ( Plaka,Tc, Ad, Soyad, Telefon, Mail, Adres, ÖdemeTürü) "  + 
            "values( @Plaka, @Tc, @Ad, @Soyad, @Telefon, @Mail, @Adres, @ÖdemeTürü)";
            MySqlCommand command2 = new MySqlCommand();
            
            command2.Parameters.AddWithValue("@Plaka", cbPlaka.Text);
            command2.Parameters.AddWithValue("@Tc", txtTc.Text);
            command2.Parameters.AddWithValue("@Ad", txtAd.Text);
            command2.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            command2.Parameters.AddWithValue("@Telefon", mtxtTel.Text);
            command2.Parameters.AddWithValue("@Mail", txtMail.Text);
            command2.Parameters.AddWithValue("@Adres", txtAdres.Text);
            command2.Parameters.AddWithValue("@ÖdemeTürü", cbÖdeme.Text);
            Kirala.InsertUpdateDele(command2, sql);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKiralama_Load(object sender, EventArgs e)
        {

        }
    }
}
