using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 58;
            gercekMusteri.MusteriNo = "54348";
            gercekMusteri.Adi = "Tamer Batuhan";
            gercekMusteri.Soyadi = "ŞEN";
            gercekMusteri.TcNo = "12345678975";



            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 1;
            tuzelMusteri.MusteriNo = "454326";
            tuzelMusteri.SirketAdi = "AlacahanSoft";
            tuzelMusteri.VergiNo = "4825479522";


            Musteri musteri = new GercekMusteri();
            Musteri musteri1 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri1);

        }
    }
}
