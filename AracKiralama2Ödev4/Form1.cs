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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKiralama_Click(object sender, EventArgs e)
        {
            frmKiralama yeniKiralama = new frmKiralama();
            yeniKiralama.ShowDialog();
        }

        DL Listeleme = new DL();

        private void SqlIslem()
        {
            string sql = "select * from kiralama";
            MySqlDataAdapter da = new MySqlDataAdapter();
            dataGridView1.DataSource = Listeleme.MtdListele(da, sql);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnKiralamaİptal_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string Sql = "delete from kiralama where tc= '" + row.Cells["Tc"].Value.ToString() + "'";
            MySqlCommand command = new MySqlCommand();
            Listeleme.InsertUpdateDele(command, Sql);
            foreach (Control item in Controls)
                if (item is TextBox) item.Text = "";
            SqlIslem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            cbPlaka.Text = row.Cells[0].Value.ToString();
            txtTc.Text = row.Cells[1].Value.ToString();
            txtAd.Text = row.Cells[2].Value.ToString();
            txtSoyad.Text = row.Cells[3].Value.ToString();
            mtxtTel.Text = row.Cells[4].Value.ToString();
            txtMail.Text = row.Cells[5].Value.ToString();
            txtAdres.Text = row.Cells[6].Value.ToString();
            cbÖdeme.Text = row.Cells[7].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlIslem();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sql = "update kiralama set Tc=@tc, Ad=@ad, Soyad=@soyad, Telefon=@telefon, Mail=@mail, Adres=@adres where Tc=@tc";
            MySqlCommand command = new MySqlCommand();
            command.Parameters.AddWithValue("@tc", txtTc.Text);
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@telefon", mtxtTel.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            command.Parameters.AddWithValue("@adres", txtAdres.Text);
            Listeleme.InsertUpdateDele(command, sql);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            SqlIslem();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from kiralama where Tc like '%" + txtArama.Text + "%' ";
            MySqlDataAdapter ad = new MySqlDataAdapter();
            dataGridView1.DataSource = Listeleme.MtdListele(ad, sql);
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            frmAracEkle ekle = new frmAracEkle();
            ekle.ShowDialog();
        }
    }
}
