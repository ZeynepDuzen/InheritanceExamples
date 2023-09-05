using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Takim
    {
        public string Adi { get; set; }
        public short KurulusYili { get; set; }
        public string Sehir { get; set; }

        public string BilgiGetir()
        {
            return $"Takim : {Adi}\nKurulus Yili : {KurulusYili}\nSehir : {Sehir}";
        }
    }
}
