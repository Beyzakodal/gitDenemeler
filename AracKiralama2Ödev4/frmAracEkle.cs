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
    public partial class frmAracEkle : Form
    {
        DL AracEkle = new DL();
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "insert into araclar(Plaka, Marka, Model, Yakıt, Renk, Vites, KasaTipi, GünlükFiyat, Durum)" +
                "values(@Plaka, @Marka, @Model, @Yakıt, @Renk, @Vites, @KasaTipi, @GünlükFiyat, @Durum)";
            MySqlCommand command = new MySqlCommand();
            command.Parameters.AddWithValue("@Plaka", textBox1.Text);
            command.Parameters.AddWithValue("@Marka", textBox1.Text);
            command.Parameters.AddWithValue("@Model", textBox1.Text);
            command.Parameters.AddWithValue("@Yakıt", textBox1.Text);
            command.Parameters.AddWithValue("@Renk", textBox1.Text);
            command.Parameters.AddWithValue("@Vites", textBox1.Text);
            command.Parameters.AddWithValue("@KasaTipi", textBox1.Text);
            command.Parameters.AddWithValue("@GünlükFiyat", textBox1.Text);
            command.Parameters.AddWithValue("@Durum", "BOŞ");
            AracEkle.InsertUpdateDele(command, sql);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
    }
}
