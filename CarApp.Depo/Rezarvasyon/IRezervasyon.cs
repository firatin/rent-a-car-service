using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Rezarvasyon
{
    public interface IRezervasyon<T> : IDepo<T> where T : class
    {
        List<T> TumRezervasyonlariGetir();
        T IdYeGoreRezervasyonGetir(int id);
        List<T> AlisTarihineGoreSirala();
        List<T> TeslimTarihineGoreSirala();


        object CmbAracDoldur();

        object CmbSoforDoldur();

        object CmbSubeDoldur();

        object CmbMusteriDoldur();

        void SoforsuzRezEkle(Varliklar.Varliklar.RezervasyonVarlik rv);
    }
}
