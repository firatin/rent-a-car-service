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
    public partial class GiderListesi : Form
    {
        public GiderListesi()
        {
            InitializeComponent();
            gider = new Gider();
        }
        SqlConnection conn = new SqlConnection(Tools.ConnString);
        IGider<GiderVarlik> gider;
    
        private void GiderListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=gider.GiderGetir();
    
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderVarlik gd = new GiderVarlik();
            gd.GiderId =Convert.ToInt32( dataGridView1.CurrentRow.Cells["GiderId"].Value.ToString());
            int id = gd.GiderId;
            gider.Delete(id);            
        }
    }
}
