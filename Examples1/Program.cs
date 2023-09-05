using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FutbolTakimi futbolTakimi1 = new FutbolTakimi()
            {
                Adi = "Fenerbahce",
                KurulusYili = 1907,
                Sehir = "Istanbul",

                TeknikDirektorAdi = "Ismail Kartal",
                KaleciAdi = "Irfan Can Egribayat",
                DefansOyunculari = "Becao, Djiku,Ferdi,Osayi",
                OrtaSahaOyunculari = "Tadic,Szymanski,Cengiz",
                ForvetOyuncuAdlari = "Dzeko,Irfan Can,Fred",
                OyunSistemi = "4-3-3"

        };
            Console.WriteLine(futbolTakimi1.BilgiGetir());
            Console.WriteLine(futbolTakimi1.KadroGetir());
            Console.WriteLine("OyunSistemi : " + futbolTakimi1.OyunSistemi);
            Console.WriteLine("Sehir : " + futbolTakimi1.Sehir);

            Takim futbolTakimi2 = new FutbolTakimi();
            futbolTakimi2.Sehir = "Istanbul";
            futbolTakimi2.KurulusYili = 1903;
            futbolTakimi2.Adi = "Besiktas";

            Console.WriteLine(futbolTakimi2.BilgiGetir());

            futbolTakimi2 = new FutbolTakimi()
            {
                Adi = "GalataSaray",
                KurulusYili = 1905,
                Sehir = "Istanbul",
                
                DefansOyunculari = "Leo,AbdulKeri, Victor,Sacha",
                OrtaSahaOyunculari = "Berkan, Sergio, Milot, Baris",
                ForvetOyuncuAdlari = "Muhammed,Dries",
                OyunSistemi = "4-4-2",
                KaleciAdi = "Muslera",
                TeknikDirektorAdi = "Okan Buruk",
            };

            Console.WriteLine(futbolTakimi2.BilgiGetir());

            //casting
            //FutbolTakimi futbolTakimi3 = (FutbolTakimi)futbolTakimi2;
            FutbolTakimi futbolTakimi3 = futbolTakimi2 as FutbolTakimi;

            Console.WriteLine(futbolTakimi3.KadroGetir());
            Console.WriteLine("OyunSistemi : " + futbolTakimi3.OyunSistemi);

            BasketbolTakimi basketbolTakimi = new BasketbolTakimi()
            {
                Adi = "Besiktas",
                KurulusYili = 1903,
                Sehir = "Istanbul",

                BasAntrenorAdi = "Igor",
                GeriSahaOyunculari = "Yagiz,Allerik",
                OnSahaOyunculari = "David,Okben,Kerem"
            };

            Console.Read();
        }
    }
}
