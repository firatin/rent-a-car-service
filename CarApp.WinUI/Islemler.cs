using CarApp.Depo;
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
    public partial class Islemler : Form
    {
   
        public Islemler()
        {
     
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void rezervasyonlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervasyonGoruntule kg = new RezervasyonGoruntule();
            kg.MdiParent = this;
            kg.Show();
        }



        private void yeniRezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kiralama k = new Kiralama();
            k.Show();
        }

        private void yeniGiderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tümGiderleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderListesi gl = new GiderListesi();
            gl.Show();
        }

        private void yeniAraçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracEkle ae = new AracEkle();
            ae.Show();
        }

        private void araçlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracGoruntule ag = new AracGoruntule();
            ag.Show();
          
            
        }
        SqlConnection conn = new SqlConnection(Tools.ConnString);
        List<string> Hatirlatmalar = new List<string>();
       
        private void Islemler_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
            //hatırlatmalar
            HatirlatmalarDoldur();

            timer1.Enabled = true;
            label1.Text = "Çağlar Sarıbıyık Fun Clup :)  ";

        }

        private void HatirlatmalarDoldur()
        {
       
            SqlCommand cmd = new SqlCommand("select Plaka,  datediff(day,dateadd(month,6,SigortaTarihi),getdate()) as d from Araclar  where datediff(day,SigortaTarihi,getdate())>60", conn);
            SqlCommand cmd2 = new SqlCommand("", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Hatirlatmalar.Add(dr.GetString(0) + " plakalı arabanın sigortasının bitmesine" + dr["d"].ToString() + " gün kaldı");
            }
            conn.Close();
            foreach (string item in Hatirlatmalar)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //seçileni sil
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            }     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hatırlatmalar sekmesini kapa
            groupBox1.Visible = false;
        }
     

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim i = new Iletisim();
            i.MdiParent = this;
            i.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
      
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracEkle arc = new AracEkle();
            arc.MdiParent = this;
            arc.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracGiderleri ag = new AracGiderleri();
            ag.MdiParent = this;
            ag.Show();
        }

        private void rezervasyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kiralama kr = new Kiralama();
            kr.MdiParent = this;
            kr.Show();
        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervasyonGoruntule kyt = new RezervasyonGoruntule();
            kyt.MdiParent = this;
            kyt.Show();
        }

        private void araçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracGoruntule arc = new AracGoruntule();
            arc.MdiParent = this;
            arc.Show();
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderListesi ag = new GiderListesi();
            ag.MdiParent = this;
            ag.Show();
        }

        private void iletişimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Iletisim ilt = new Iletisim();
            ilt.MdiParent = this;
            ilt.Show();
        }

      

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriADD mad = new MusteriADD();
            mad.MdiParent = this;
            mad.Show();
        }

        private void şöförEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforADD sfr = new SoforADD();
            sfr.MdiParent = this;
            sfr.Show();
        }

        private void şubeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubeADD sb = new SubeADD();
            sb.MdiParent = this;
            sb.Show();
        }

        private void hataBildirimleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HataBildirimleri hb = new HataBildirimleri();
            hb.MdiParent = this;
            hb.Show();
        }
    }
}
