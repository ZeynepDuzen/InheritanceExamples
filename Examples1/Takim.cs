using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples1
{
    internal class Takim
    {
        public string Adi { get; set; }
        public short KurulusYili { get; set; }
        public string Sehir { get; set; }

        public string BilgiGetir()
        {
            return Adi + KurulusYili;
        }
    }

   
}
