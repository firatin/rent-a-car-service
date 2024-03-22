using System;

using CarApp.Varliklar.Varliklar;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarApp.Depo.Subeler;

namespace CarApp.WinUI
{
    public partial class Giris : Form
    {
      
        ISube<SubeVarlik> subeler;
        public Giris()
        {
            subeler = new Sube();
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(CarApp.Depo.Tools.ConnString);
        private void button1_Click(object sender, EventArgs e)
        {            
            Islemler i = new Islemler();

            bool durum = subeler.Dene(textBox1.Text, textBox2.Text);
            if (durum) { i.Show(); }
            else MessageBox.Show("Lütfen Bilgilerinizi kontrol ediniz");      
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bilgilerini güncelle butonu
            bool durum = subeler.Dene(textBox1.Text, textBox2.Text);
            if (durum) { groupBox1.Visible = true; }
            else MessageBox.Show("Önce giris yap");
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //databasede subelerdeki SubeYetkili ve sifreyi değiştir 

            //öncelikle textbx1 ve txtbox 2deki bilgilerin idsini çek ve sb.idye ata


            SubeVarlik sb = new SubeVarlik();
            sb.SubeId = subeler.IdGetir(textBox1.Text, textBox2.Text);

            sb.SubeYetkili = textBox3.Text;
            sb.Sifre = textBox4.Text;
   
            subeler.SubeAdSifreDegistir(sb);
        }
    }
}
