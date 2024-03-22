using CarApp.Depo.Musteriler;
using CarApp.Varliklar.Varliklar;
using CarApp.Depo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarApp.WinUI
{
    public partial class MusteriADD : Form
    {
        
        public MusteriADD()
        {
            musteri = new Musteriler();
            InitializeComponent();
        }
        IMusteriler<MusteriVarlik> musteri;
        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = true;
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Text=="") durum = false;
                }
                MusteriVarlik mv = new MusteriVarlik();
                mv.MusAdi = txtAd.Text;
                mv.MusSoyadi = txtSoyad.Text;
                mv.MusAdres = txtAdres.Text;
                mv.MusTc = txtTC.Text;
                mv.MusTel = txtTel.Text;
                if (durum)
                {
                    lblUyari.Text = "Müşteri Eklendi!";
                    musteri.Add(mv);
                    mrMuscle();
                }
               else lblUyari.Text = "Lütfen Bilgilerinizi Eksiksiz Giriniz!";
              
            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
                lblUyari.Text = ex.Message;
            }
        }
        public void mrMuscle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = string.Empty;
                else if (item is NumericUpDown) (item as NumericUpDown).Value = 0;
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
            }
        }
    }
}
