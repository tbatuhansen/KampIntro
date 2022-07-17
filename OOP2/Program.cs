using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri()
            {
                Id = 1,
                MusteriNo = "12345",
                TcNo = "11111111111",
                Adi = "Engin",
                Soyadi = "Demiroğ"
            };

            TuzelMusteri musteri1 = new TuzelMusteri()
            {
                Id = 2,
                MusteriNo = "54321",
                SirketAdi = "Kodlama.io",
                VergiNo = "1234567890"
            };

            Musteri musteri2 = new GercekMusteri()
            {
            };

            Musteri musteri3 = new TuzelMusteri()
            {
            };
        }
    }
}
