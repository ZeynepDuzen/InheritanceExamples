using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class FutbolTakimi : Takim
    {
        public string TeknikDirektorAdi { get; set; }
        public string KaleciAdi { get; set; }
        public string DefansOyunculariAdlari { get; set; }
        public string OrtaSahaOyunculari { get; set; }
        public string ForvetOyunculari {get;set;}
        public string OyunSistemi { get; set; }

        public string KadroGetir()
        {
            return $"TeknikDirektor : {TeknikDirektorAdi}\nKaleci : {KaleciAdi}\nDefans : {DefansOyunculariAdlari}\n" +
                $"OrtaSaha : {OrtaSahaOyunculari}\nForvet : {ForvetOyunculari}";
        }
    }
}
