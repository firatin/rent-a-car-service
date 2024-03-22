using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Araclar
{
    public interface IArac<T> : IDepo<T> where T : class
    {
        List<T> TumAraclariGetir();
        T IdyeGoreAracGetir(int id);

        object CbAracDoldur();

        object AracGetir();
    }
}
