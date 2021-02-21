using System;

namespace VizeHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string[] ogrenciAdi = new string[] {"a öğrencisi","b öğrencisi","c öğrencisi","d öğrencisi","f öğrencisi" };

            float[] ogrenciPuanı = new float[] {50,60,60,75,95 };

            
            for (int j = 0; j < 5; j++)
            {

                if (ogrenciPuanı[j]<51&& ogrenciPuanı[j] > 45)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tDD");
                }
                else if(ogrenciPuanı[j]>0&& ogrenciPuanı[j] < 46)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tFF");
                }
                else if (ogrenciPuanı[j] > 50 && ogrenciPuanı[j] < 65)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tCD");
                }
                else if (ogrenciPuanı[j] > 64 && ogrenciPuanı[j] < 71)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tCC");
                }
                else if (ogrenciPuanı[j] > 70 && ogrenciPuanı[j] < 76)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tBC");
                }
                else if (ogrenciPuanı[j] > 70 && ogrenciPuanı[j] < 76)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tBC");
                }
                else if (ogrenciPuanı[j] > 75 && ogrenciPuanı[j] < 81)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tBB");
                }
                else if (ogrenciPuanı[j] > 80 && ogrenciPuanı[j] < 91)
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tBA");
                }
                else
                {
                    Console.Write(ogrenciAdi[j]);
                    Console.Write("\tAldığı puan: ");
                    Console.Write(ogrenciPuanı[j]);
                    Console.WriteLine("\tAA");
                }

            }



        }
    }
}
