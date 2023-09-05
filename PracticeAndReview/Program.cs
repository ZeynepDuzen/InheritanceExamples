using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
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

                TeknikDirektorAdi = "Ahmet",
                KaleciAdi = "Mehmet",
                DefansOyunculariAdlari = "Ali,Osman,Burak",
                OrtaSahaOyunculari = "Berkecan,Alican,Emircan",
                ForvetOyunculari = "Berk,Oytun",
                OyunSistemi = "4-3-3"
            };

            Console.WriteLine(futbolTakimi1.BilgiGetir());
            Console.WriteLine(futbolTakimi1.KadroGetir());
            Console.WriteLine("Oyunsistemi : " + futbolTakimi1.OyunSistemi);
            Console.WriteLine();

            FutbolTakimi futbolTakimi2 = new FutbolTakimi()
            {
                Adi = "Galatasaray",
                KurulusYili = 1905,
                Sehir = "Istanbul",

                TeknikDirektorAdi = "Murat",
                KaleciAdi = "Mesut",
                DefansOyunculariAdlari = "Ali,Berke,Muratcan",
                OrtaSahaOyunculari = "Yavuz,Koray",
                ForvetOyunculari = "Temel,Toprak",
                OyunSistemi = "4-3-3"
            };

            Console.WriteLine(futbolTakimi2.BilgiGetir());
            Console.WriteLine(futbolTakimi2.KadroGetir());
            Console.WriteLine("OyunSistemi : " + futbolTakimi2.OyunSistemi);
            Console.WriteLine();

            Takim takim3 = new FutbolTakimi()
            {
                Adi = "Besiktas",
                KurulusYili = 1903,
                Sehir = "Istanbul",

                TeknikDirektorAdi = "Mehmet",
                KaleciAdi = "Osman",
                DefansOyunculariAdlari = "Ai,Veli,Arda",
                OrtaSahaOyunculari = "Semih,Fatih,Hakan",
                ForvetOyunculari = "Bayram,Ulaş,Ugur",
                OyunSistemi = "4-3-3"
            };

            Console.WriteLine(takim3.BilgiGetir());
            FutbolTakimi futbolTakimi3 = takim3 as FutbolTakimi;

            Console.WriteLine(futbolTakimi3.KadroGetir());
            Console.WriteLine("OyunSistemi : " + futbolTakimi3.OyunSistemi);
            Console.WriteLine();


            BasketbolTakimi basketbolTakimi1 = new BasketbolTakimi()
            {
                Adi = "Besiktas",
                KurulusYili = 1903,
                Sehir = "Istanbul",

                BasAntrenorAdi = "Ugur",
                GeriSahaOyunculari = "Sarp,Ismail,Sergen",
                OnSahaOyunculari = "Alpay,Neo,Leo"
            };

            Console.WriteLine(basketbolTakimi1.BilgiGetir());
            Console.WriteLine("BasAntrenor : " + basketbolTakimi1.BasAntrenorAdi);
            Console.WriteLine("Geri Saha : " + basketbolTakimi1.GeriSahaOyunculari);
            Console.WriteLine("OnSaha : " + basketbolTakimi1.OnSahaOyunculari);
            
            Takim takim2 = new BasketbolTakimi();
            BasketbolTakimi basketbolTakimi2 = takim2 as BasketbolTakimi;
            basketbolTakimi2.Adi = "Fenerbahce";
            basketbolTakimi2.KurulusYili = 1907;
            basketbolTakimi2.Sehir = "Istanbul";
            Console.WriteLine();

            Console.WriteLine(basketbolTakimi2.BilgiGetir());



            

            Console.Read();
        }
    }
}
