using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples1
{
    internal class FutbolTakimi : Takim 
    {
        public string TeknikDirektorAdi { get; set; }
        public string KaleciAdi { get; set; }
        public string DefansOyunculari { get; set;}
        public string OrtaSahaOyunculari { get; set; }
        public string ForvetOyuncuAdlari { get; set; }
        public string OyunSistemi { get; set; }

        public string KadroGetir()
        {
            return TeknikDirektorAdi + KaleciAdi + DefansOyunculari + OrtaSahaOyunculari + ForvetOyuncuAdlari;
        }
    }
}
