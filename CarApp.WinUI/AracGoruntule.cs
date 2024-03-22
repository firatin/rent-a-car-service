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

namespace CarApp.WinUI
{
    public partial class AracGoruntule : Form
    {
        IArac<AracVarlik> arac;
        public AracGoruntule()
        {
            arac = new Arac();
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void AracGoruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = arac.AracGetir();         
         
        }    

        AracVarlik av;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                av = new AracVarlik();
                av.Kilometre = Convert.ToInt32(txtKilometre.Text);
                av.Durum = cmbDurum.SelectedValue.ToString();
                av.Ucret = Convert.ToDecimal(txtUcret.Text);
                av.AracId = Convert.ToInt32(lblId.Text);
                av.SigortaTarihi = dtpTarih.Value;
                arac.Update(av);
                dataGridView1.DataSource = arac.AracGetir();
                mrMuscle();
            }
            catch (Exception ex)
            {
                hataMesajlari hm = new hataMesajlari();
                hm.hataekle(ex.Message);
            }
        }
        public enum AracDurumlari
        {
            Bos, Dolu, Bakimda
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                cmbDurum.DataSource = Enum.GetValues(typeof(AracDurumlari));
                av = new AracVarlik();

                cmbDurum.SelectedIndex = -1;
                cmbDurum.Text = dataGridView1.CurrentRow.Cells["Durum"].Value.ToString();
                lblId.Text = dataGridView1.CurrentRow.Cells["AracID"].Value.ToString();
                txtUcret.Text = dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString();
                txtKilometre.Text = dataGridView1.CurrentRow.Cells["Kilometre"].Value.ToString();
                dtpTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["SigortaTarihi"].Value);
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
                if (item is TextBox) item.Text = string.Empty;
                else if (item is NumericUpDown) (item as NumericUpDown).Value = 0;
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
            }
        }
    }
}
