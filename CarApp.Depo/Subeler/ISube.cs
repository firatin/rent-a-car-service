using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Depo.Subeler
{
    public interface ISube<T> : IDepo<T> where T : class
    {
        List<T> SubeleriGetir();
        T IdyeGoreSubeGetir(int id);

        bool Dene(string p1, string p2);

        int IdGetir(string p1, string p2);

        void SubeAdSifreDegistir(Varliklar.Varliklar.SubeVarlik sb);
    }
}
