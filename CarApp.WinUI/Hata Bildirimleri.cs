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
    public partial class Hata_Bildirimleri : Form
    {
        public Hata_Bildirimleri()
        {
            InitializeComponent();
        }

        private void Hata_Bildirimleri_Load(object sender, EventArgs e)
        {
            hataMesajlari hm = new hataMesajlari();

            dataGridView1.DataSource = hm.HataBildirimleriniListele();
        }
    }
}
