using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StokTakipEntities db = new StokTakipEntities();

        public bool Giris(string kadi, string sifre)
        {
           
            var login = from kullanici in db.Kullanicis where kullanici.KullaniciAdi == kadi && kullanici.Sifre == sifre select kullanici;

            if (login.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris(textBox1.Text, textBox2.Text))
            {
                Anasayfa go = new Anasayfa();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİS BASARISIZ");
                textBox1.Clear();
                textBox2.Clear();
            }
        }


    }
}
