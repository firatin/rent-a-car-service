using CarApp.Depo;
using CarApp.Depo.Giderler;
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
   
   
    public partial class AracGiderleri : Form
    {
        public AracGiderleri()
        {
            gider = new Gider();
            InitializeComponent();
        }        

        IGider<GiderVarlik> gider;

        private void AracGiderleri_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPlaka.DataSource = gider.PlakaGetir();

                cmbPlaka.DisplayMember = "Plaka";
                cmbPlaka.ValueMember = "AracID";

                label4.Text = cmbPlaka.SelectedValue.ToString();

                cmbSube.DataSource = gider.SubeGetir();

                cmbSube.DisplayMember = "SubeAdi";
                cmbSube.ValueMember = "SubeID";
                lblSubeId.Text = cmbSube.SelectedValue.ToString();

                cmbParaBirimi.DataSource = Enum.GetValues(typeof(Para));
                cmbGiderTuru.DataSource = Enum.GetValues(typeof(GiderTipleri));
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
                GiderVarlik gv = new GiderVarlik();
                gv.Plaka = cmbPlaka.SelectedValue.ToString();


                gv.AracId = Convert.ToInt16(label4.Text);

                gv.Tarih = dtpTarih.Value;
                gv.GiderTip = cmbGiderTuru.SelectedValue.ToString();
                gv.Tutar = Convert.ToDecimal(txtTutar.Text);
                gv.Aciklama = txtAciklama.Text;
                gv.SubeId = Convert.ToInt16(lblSubeId.Text);
                gider.Add(gv);
                mrMuscle();
            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
            }

        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = cmbPlaka.SelectedValue.ToString();
        }

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSubeId .Text= cmbSube.SelectedValue.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
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
