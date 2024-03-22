using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Soforler
{
    public interface ISoforler<T> : IDepo<T> where T : class
    {
        List<T> TumSoforleriGetir();
        T IdyeGoreSoforGetir(int id);
    }
}
