using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }
        StokTakipEntities db = new StokTakipEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Listele().ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler kaydet=new Urunler();
            kaydet.Kategori = comboBox1.Text;
            kaydet.Marka = comboBox2.Text;
            kaydet.UrunAdi = textBox2.Text;
            kaydet.Miktar = Convert.ToInt32(textBox3.Text);
            kaydet.AlisFiyati = Convert.ToInt32(textBox4.Text);
            kaydet.SatisFiyati= Convert.ToInt32(textBox4.Text);
            db.Ekle(kaydet.Kategori, kaydet.Marka, kaydet.UrunAdi, kaydet.Miktar, kaydet.AlisFiyati, kaydet.SatisFiyati);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Urunler kaydet = new Urunler();
            kaydet.BarkodNo = Convert.ToInt32(textBox1.Text);
            kaydet.Kategori = comboBox1.Text;
            kaydet.Marka = comboBox2.Text;
            kaydet.UrunAdi = textBox2.Text;
            kaydet.Miktar = Convert.ToInt32(textBox3.Text);
            kaydet.AlisFiyati = Convert.ToInt32(textBox4.Text);
            kaydet.SatisFiyati = Convert.ToInt32(textBox4.Text);
            db.Yenile(kaydet.BarkodNo,kaydet.Kategori, kaydet.Marka, kaydet.UrunAdi, kaydet.Miktar, kaydet.AlisFiyati, kaydet.SatisFiyati);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Urunler kaydet = new Urunler();
            kaydet.BarkodNo= Convert.ToInt32(textBox1.Text);
            db.Sil(kaydet.BarkodNo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Urunler kaydet = new Urunler();
            kaydet.UrunAdi = textBox2.Text;
            dataGridView1.DataSource = db.Ara(kaydet.UrunAdi).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["BarkodNo"].Value.ToString();
            comboBox1.Text = satir.Cells["Kategori"].Value.ToString();
            comboBox2.Text = satir.Cells["Marka"].Value.ToString();
            textBox2.Text = satir.Cells["UrunAdi"].Value.ToString();
            textBox3.Text = satir.Cells["Miktar"].Value.ToString();
            textBox4.Text = satir.Cells["AlisFiyati"].Value.ToString();
            textBox5.Text = satir.Cells["SatisFiyati"].Value.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Anasayfa sec = new Anasayfa();
            sec.Show();
            this.Hide();
        }

    }
}
