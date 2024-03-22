using CarApp.Depo;
using CarApp.Depo.Subeler;
using CarApp.Varliklar.Varliklar;
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
    public partial class SubeADD : Form
    {
        public SubeADD()
        {
            sube = new Sube();
            InitializeComponent();
        }
        ISube<SubeVarlik> sube;
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                bool durum = true;
                foreach (Control item in this.Controls)
                {
                    if (item.Text == "") durum = false;
                }

                SubeVarlik sb = new SubeVarlik();
                sb.SubeAdi = txtAd.Text;
                sb.SubeYetkili = txtYetkili.Text;
                sb.SubeTel = txtTel.Text;
                sb.SubeAdres = txtAdres.Text;
                sb.Subeilce = txtIlce.Text;
                sb.Sifre = txtSifre.Text;
                if (durum)
                {
                    lblUyari.Text = "Şube Eklendi!";
                    sube.Add(sb);
                    mrMuscle(); 
                }
                else lblUyari.Text = "Lütfen Bilgileri Eksiksiz Giriniz!";
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
                if (item is TextBox) item.Text = string.Empty;//Empty readonly'dir sadece okur değer veremiyoruz.Araştır**
                else if (item is NumericUpDown) (item as NumericUpDown).Value = 0;
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
            }
        }
    }
}
