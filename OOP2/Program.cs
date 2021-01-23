﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //İskender Boynuz

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "İskender";
            musteri1.Soyadi = "Boynuz";
            musteri1.TcNo = "22222222222";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678910";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
