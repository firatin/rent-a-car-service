using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Varliklar.Varliklar
{
    public class RezervasyonVarlik
    {

        public int RezId { get; set; }
        public int MusId { get; set; }
        public int AracId { get; set; }
        public int? SoforId { get; set; }
        public int AldigiSubeId { get; set; }
        public int BiraktigiSubeId { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool OdemeTip { get; set; }
        public short Taksit { get; set; }
        public short IlkYakitDurum { get; set; }
        public short SonYakitDurum { get; set; }

        // Silinecek Alan
        public string MusteriAdi { get; set; }
        public string MusSoyadi { get; set; }
        public string SoforAdi { get; set; }
        public string SubeAdi { get; set; }
        public string Model { get; set; }
        public string PlakaAd { get; set; }


    }
}
