using CarApp.Depo;
using CarApp.Depo.Araclar;
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

using CarApp.Depo.Giderler;

namespace CarApp.WinUI
{
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            arac = new Arac();
            InitializeComponent();
        }
        IArac<AracVarlik> arac;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        SqlConnection conn = new SqlConnection(Tools.ConnString);

        private void AracEkle_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1990; i <= 2016; i++)
                {
                    cmbModelYili.Items.Add(i.ToString());
                }
                cmbModelYili.Text = "Seçiniz";
                cmbModelYili.SelectedIndex = -1;

                cmbParaBirimi.SelectedIndex = -1;
                cmbParaBirimi.Text = "Seçiniz";
                cmbParaBirimi.DataSource = Enum.GetValues(typeof(Para));
                cmbParaBirimi.Text = "TL";

                cmbSube.DataSource = arac.CbAracDoldur();
                cmbSube.DisplayMember = "SubeAdi";
                cmbSube.ValueMember = "SubeID";
                cmbSube.SelectedIndex = -1;
                cmbSube.Text = "Seçiniz";
                mrMuscle();
            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //kaydet
            try
            {
                AracVarlik av = new AracVarlik();
                av.Plaka = txtPlaka.Text;
                av.Marka = txtMarka.Text;
                av.Model = txtModel.Text;
                av.ModelYili = Convert.ToDateTime(cmbModelYili.SelectedValue + ",01,01");
                av.Kilometre = Convert.ToInt32(nmrKilometre.Value);
                av.Durum = "Boş";
                av.SigortaTarihi = dtpTarih.Value;
                av.Ucret = Convert.ToDecimal(txtUcret.Text);

                arac.Add(av);
            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
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
