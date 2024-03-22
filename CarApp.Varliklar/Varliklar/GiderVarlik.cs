using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Varliklar.Varliklar
{
    public class GiderVarlik
    {
        public int GiderId { get; set; }
        public int AracId { get; set; }
        public int SubeId { get; set; }
        public string GiderTip { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string Plaka { get; set; }
    }
}
