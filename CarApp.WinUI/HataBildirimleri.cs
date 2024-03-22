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
    public partial class HataBildirimleri : Form
    {
        public HataBildirimleri()
        {
            InitializeComponent();
        }

        private void HataBildirimleri_Load(object sender, EventArgs e)
        {
            hataMesajlari hm = new hataMesajlari();

            dataGridView1.DataSource = hm.HataBildirimleriniListele();
        }
    }
}
