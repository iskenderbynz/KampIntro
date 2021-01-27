using System;

namespace BesGunTekrar
{
    class Program
    {
        static void Main(string[] args)
        {


            IKredilerManager ihtiyacKredisi = new IhtiyacKredisiManager();

            IKredilerManager konutKredisi = new KonutKredisiManager();

            IKredilerManager tasitKredisi = new TasitKredisiManager();

            tasitKredisi.Hesapla();
           
        }
    }
}
