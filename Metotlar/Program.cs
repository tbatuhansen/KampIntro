using System;
using System.Collections.Generic;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun()
            {
                Adi = "Elma",
                Fiyati = 15,
                Aciklama = "Amasya elması"
            };

            Urun urun2 = new Urun()
            {
                Adi = "Karpuz",
                Fiyati = 80,
                Aciklama = "Diyarbakır karpuzu"
            };

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------------Metotlar-------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Amasya elması", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}
