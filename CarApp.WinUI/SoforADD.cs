using CarApp.Depo;
using CarApp.Depo.Soforler;
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
    public partial class SoforADD : Form
    {
        public SoforADD()
        {
            sofor = new Soforler();
            InitializeComponent();
        }
        ISoforler<SoforVarlik> sofor;
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                bool durum = true;
                foreach (Control item in this.Controls)
                {
                    if (item.Text == "") durum = false;
                }

                SoforVarlik sfr = new SoforVarlik();
                sfr.SoforAd = txtAd.Text;
                sfr.SoforSoyad = txtSoyad.Text;
                sfr.SoforTC = txtTC.Text;
                sfr.SoforTel = txtTel.Text;
                if (durum)
                {
                    lblUyari.Text = "Şoför Eklendi!";
                    sofor.Add(sfr);
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
                if (item is TextBox) item.Text = string.Empty;
                else if (item is NumericUpDown) (item as NumericUpDown).Value = 0;
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
            }
        }
    }
}
