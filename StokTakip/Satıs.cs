using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakip
{
    public partial class Satıs : Form
    {
        public Satıs()
        {
            InitializeComponent();
        }
        StokTakipEntities db = new StokTakipEntities();
        private void button6_Click(object sender, EventArgs e)
        {
            Satislar kaydet = new Satislar();
            kaydet.TC = Convert.ToInt32(textBox8.Text);
            kaydet.AdSoyad =textBox6.Text;
            kaydet.Telefon = Convert.ToInt32(textBox3.Text);
            kaydet.UrunAdi = textBox4.Text;
            kaydet.Miktar = Convert.ToInt32(textBox5.Text);
            kaydet.SatisFiyati = Convert.ToInt32(textBox7.Text);
            kaydet.ToplamFiyat = Convert.ToInt32(textBox2.Text);
            kaydet.BarkodNo = Convert.ToInt32(textBox1.Text);
            db.Ekle1(kaydet.TC,kaydet.AdSoyad,kaydet.Telefon, kaydet.UrunAdi, kaydet.Miktar, kaydet.SatisFiyati,kaydet.ToplamFiyat, kaydet.BarkodNo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Listele1().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ToplamTutar, Miktar, SatisFiyati;
            Miktar = int.Parse(textBox5.Text);
            SatisFiyati= int.Parse(textBox7.Text);
            ToplamTutar = Miktar * SatisFiyati;
            textBox2.Text = ToplamTutar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Satislar kaydet = new Satislar();
            kaydet.SatisNo = Convert.ToInt32(textBox9.Text);
            kaydet.TC = Convert.ToInt32(textBox8.Text);
            kaydet.AdSoyad = textBox6.Text;
            kaydet.Telefon = Convert.ToInt32(textBox3.Text);
            kaydet.UrunAdi = textBox4.Text;
            kaydet.Miktar = Convert.ToInt32(textBox5.Text);
            kaydet.SatisFiyati = Convert.ToInt32(textBox7.Text);
            kaydet.ToplamFiyat = Convert.ToInt32(textBox2.Text);
            kaydet.BarkodNo = Convert.ToInt32(textBox1.Text);
            db.Yenile1(kaydet.SatisNo,kaydet.TC, kaydet.AdSoyad, kaydet.Telefon, kaydet.UrunAdi, kaydet.Miktar, kaydet.SatisFiyati, kaydet.ToplamFiyat, kaydet.BarkodNo);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Satislar kaydet = new Satislar();
            kaydet.SatisNo = Convert.ToInt32(textBox9.Text);
            db.Sil1(kaydet.SatisNo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Satislar kaydet = new Satislar();
            kaydet.TC = Convert.ToInt32(textBox8.Text);
            dataGridView1.DataSource = db.Ara1(kaydet.TC).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox9.Tag = satir.Cells["SatisNo"].Value.ToString();
            textBox8.Text = satir.Cells["TC"].Value.ToString();
            textBox6.Text = satir.Cells["AdSoyad"].Value.ToString();
            textBox3.Text = satir.Cells["Telefon"].Value.ToString();
            textBox4.Text = satir.Cells["UrunAdi"].Value.ToString();
            textBox5.Text = satir.Cells["Miktar"].Value.ToString();
            textBox7.Text = satir.Cells["SatisFiyati"].Value.ToString();
            textBox2.Text = satir.Cells["ToplamFiyat"].Value.ToString();
            textBox1.Text = satir.Cells["BarkodNo"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }
    }
}
