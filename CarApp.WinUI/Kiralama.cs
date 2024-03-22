using CarApp.Depo;
using CarApp.Depo.Rezarvasyon;
using CarApp.Varliklar.Varliklar;
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

namespace CarApp.WinUI
{
    public partial class Kiralama : Form
    {
        IRezervasyon<RezervasyonVarlik> rez;
        public Kiralama()
        {
            rez = new Rezervasyon();
            InitializeComponent();
        }
        RezervasyonVarlik rv;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rv = new RezervasyonVarlik();
                rv.MusId = Convert.ToInt32(cmbMusId.SelectedValue);

                rv.IlkYakitDurum = Convert.ToInt16(nmrIlk.Value);
                rv.SonYakitDurum = Convert.ToInt16(nmrSon.Value);
                rv.AracId = Convert.ToInt32(cmbArac.SelectedValue);
                rv.AldigiSubeId = Convert.ToInt32(cmbAldigiSube.SelectedValue);
                rv.BiraktigiSubeId = Convert.ToInt32(cmbBiraktigiSube.SelectedValue);
                rv.AlisTarihi = dtpAlim.Value;
                rv.TeslimTarihi = dtpTeslim.Value;
                rv.OdemeTip = true;

                if (checkBox1.Checked)
                {
                    rez.SoforsuzRezEkle(rv);
                }
                else
                {
                    rv.SoforId = Convert.ToInt32(cmbSofor.SelectedValue);
                    rez.Add(rv);
                }
                mrMuscle();

            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
            }
        }
  
        private void Kiralama_Load(object sender, EventArgs e)
        {
            try
            {
                cmbAldigiSube.DataSource = rez.CmbSubeDoldur();
                cmbBiraktigiSube.DataSource = rez.CmbSubeDoldur();
                cmbMusId.DataSource = rez.CmbMusteriDoldur();
                cmbSofor.DataSource = rez.CmbSoforDoldur();

                cmbArac.DisplayMember = "Plaka";
                cmbArac.ValueMember = "AracID";
                cmbArac.SelectedIndex = -1;
                cmbArac.Text = "Seçiniz";
                cmbArac.DataSource = rez.CmbAracDoldur();

                cmbSofor.DisplayMember = "SoforAd";
                cmbSofor.ValueMember = "SoforID";
                cmbSofor.SelectedIndex = -1;
                cmbSofor.Text = "Seçiniz";

                cmbAldigiSube.DisplayMember = "SubeAdi";
                cmbAldigiSube.ValueMember = "SubeID";
                cmbAldigiSube.SelectedIndex = -1;
                cmbAldigiSube.Text = "Seçiniz";

                cmbBiraktigiSube.DisplayMember = "SubeAdi";
                cmbBiraktigiSube.ValueMember = "SubeID";
                cmbBiraktigiSube.SelectedIndex = -1;
                cmbBiraktigiSube.Text = "Seçiniz";

                cmbMusId.DisplayMember = "MusAdi";
                cmbMusId.ValueMember = "MusId";
                cmbMusId.SelectedIndex = -1;
                cmbMusId.Text = "Seçiniz";

                cmbOdeme.SelectedIndex = -1;
                cmbOdeme.Text = "Seçiniz";
                cmbOdeme.Items.Add("Nakit");
                cmbOdeme.ValueMember = "0";
                cmbOdeme.Items.Add("Kredi Kartı");
                cmbOdeme.ValueMember = "1";
            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
            }
            

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbSofor.SelectedIndex = -1;
                cmbSofor.Enabled = false;

            }
            else
            {
                cmbSofor.SelectedIndex = -1;
                cmbSofor.Text = "Seçiniz";
                cmbSofor.Enabled = true;
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
