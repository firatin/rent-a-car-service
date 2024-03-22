using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Musteriler
{
    public interface IMusteriler<T> : IDepo<T> where T : class
    {
        List<T> TumMusterileriGetir();
        T IdyeGoreMusteriGetir(int id);
        //T AdaGoreIdGetir(string ad);
    }
}
