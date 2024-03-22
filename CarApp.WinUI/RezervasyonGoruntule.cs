using CarApp.Depo.Rezarvasyon;
using CarApp.Varliklar.Varliklar;
using CarApp.WinUI;
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
using CarApp.Depo.Soforler;
using CarApp.Depo;

namespace CarApp.WinUI
{
    public partial class RezervasyonGoruntule : Form
    {       
       
        IRezervasyon<RezervasyonVarlik> rez;

        public RezervasyonGoruntule()
        {     
            rez = new Rezervasyon();
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(Tools.ConnString);
        private void KayitGoruntuleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource  = Tools.dataGridDoldur(rez.TumRezervasyonlariGetir()); 
            cbArac.SelectedItem=   Tools.dataGridDoldur(rez.TumRezervasyonlariGetir());
         
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            //Combobox dataları getirdik fakat seçili gelen null olmalı. Kullanıcı güncelleme için değişiklik yapmaz ve select geleni secerse patlar.
            cbSofor.DataSource = rez.CmbSoforDoldur();
    
            cbSofor.DisplayMember = "SoforAd";
            cbSofor.ValueMember = "SoforId";
            cbArac.DataSource = rez.CmbAracDoldur();
         
            cbArac.DisplayMember = "Plaka";
            cbArac.ValueMember = "AracID";
            cbSube.DataSource = rez.CmbSubeDoldur();
          
            cbSube.DisplayMember = "SubeAdi";
            cbSube.ValueMember = "SubeID";
        }
        RezervasyonVarlik rv;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            rv = new RezervasyonVarlik();
            rv.AracId = Convert.ToInt32(cbArac.SelectedValue);
            rv.SoforId = Convert.ToInt32(cbSofor.SelectedValue);
            rv.BiraktigiSubeId = Convert.ToInt32(cbSube.SelectedValue);
            rv.TeslimTarihi = dtpTTarih.Value;
            rv.OdemeTip = Convert.ToBoolean(cbOdeme.SelectedIndex);
            rv.Taksit = Convert.ToInt16(txtTaksit.Text);
            rv.SonYakitDurum = Convert.ToInt16(nmSYakit.Value);
            rv.RezId = Convert.ToInt32(lblID.Text);
            rez.Update(rv);
            dataGridView1.Refresh();
            dataGridView1.DataSource = Tools.dataGridDoldur(rez.TumRezervasyonlariGetir());
            mrMuscle();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            rv = new RezervasyonVarlik();
            lblID.Text = dataGridView1.CurrentRow.Cells["RezID"].Value.ToString();
            cbArac.SelectedValue = dataGridView1.CurrentRow.Cells["AracID"].Value.ToString();
            cbSofor.SelectedValue = dataGridView1.CurrentRow.Cells["SoforID"].Value.ToString();
            cbSube.SelectedValue = dataGridView1.CurrentRow.Cells["SubeID"].Value.ToString();
            txtTaksit.Text = dataGridView1.CurrentRow.Cells["Taksit"].Value.ToString();
            nmSYakit.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["SonYakitDurum"].Value.ToString());
            dtpTTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["TeslimTarihi"].Value.ToString());
            txtModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString(); ;
        }

     
      
    
        private void müşteriyeGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tools.dataMusteriyeGore(rez.TumRezervasyonlariGetir());
        }
        private void plakayaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tools.dataPlakayGore(rez.TumRezervasyonlariGetir());
        }
        private void yeniRezervasyonaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tools.dataTeslimTarihineGore(rez.TumRezervasyonlariGetir());
        }

        private void eskiRezervasyonaGöreSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tools.dataAlisTarihineGore(rez.TumRezervasyonlariGetir());
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
