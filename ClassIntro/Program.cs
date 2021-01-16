using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "İskender Boynuz";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hami Boynuz";
            kurs2.IzlenmeOrani = 90;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ahmet Boynuz";
            kurs3.IzlenmeOrani = 90;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            // switch kullanımı
            Console.WriteLine("1-5 arası bir sayı giriniz");
            string sayi = Console.ReadLine();
            switch (sayi)
            {
                case "1":
                    Console.WriteLine("1 gidiniz.");
                    break;

                case "2":
                    Console.WriteLine("2 gidiniz.");
                    break;

                case "3":
                    Console.WriteLine("3 gidiniz.");
                    break;

                case "4":
                    Console.WriteLine("4 gidiniz.");
                    break;

                case "5":
                    Console.WriteLine("5 gidiniz.");
                    break;

                default:
                    Console.WriteLine("Belirtilen aralık dısında bir değer girdiniz.");
                    break;
            }
            // while döngüsü kullanımı
            int i = 0;
            int say = 10;
            while (i < say)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }

    class Kurs 
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
