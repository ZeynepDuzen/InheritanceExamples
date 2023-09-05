using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Daire : YuvarlakSekil,IHesapla
    {
         public double AlanHesapla()
        {
            return YariCap * YariCap * Pİ;
        }

        public double CevreHesapla()
        {
            return 2 * Pİ * YariCap;
        }
    }
}
