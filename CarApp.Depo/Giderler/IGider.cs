using CarApp.Varliklar.Varliklar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Giderler
{
    public interface IGider<T> : IDepo<T> where T : class
    {
       // T TumGiderleriGetir(GiderVarlik ent);
        T IdyeGoreGiderGetir(int id);
        object SubeGetir();
        object PlakaGetir();
        object GiderGetir();
    }
}
