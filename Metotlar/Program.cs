using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma ";
            urun1.fiyati = 15;
            urun1.aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz ";
            urun2.fiyati = 20;
            urun2.aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("------------------------");


            }


            Console.WriteLine();
            Console.WriteLine("---------------METOTLAR-----------------");
            SepetManager SepetManager = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);



        }
    }
}
