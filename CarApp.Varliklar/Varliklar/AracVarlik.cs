using System;

namespace CarApp.Varliklar.Varliklar
{
    public class AracVarlik
    {
        public int AracId { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime ModelYili { get; set; }
        public int Kilometre { get; set; }
        public DateTime SigortaTarihi { get; set; }
        public decimal Ucret { get; set; }
        public string Durum { get; set; }
    }
}