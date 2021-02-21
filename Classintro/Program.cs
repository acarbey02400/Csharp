using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            BFFBolumu BSMGrubu = new BFFBolumu();
            BSMGrubu.SinifAdi = "BSM Sinifi";
            BSMGrubu.OgrenciSayisi = 20;
            BSMGrubu.EgitmenSayisi = 7;

            BFFBolumu PGGrubu = new BFFBolumu();
            PGGrubu.SinifAdi = "PGiriş Sinifi";
            PGGrubu.OgrenciSayisi = 16;
            PGGrubu.EgitmenSayisi = 8;
            
            BFFBolumu YZGrubu = new BFFBolumu();
            YZGrubu.SinifAdi = "Yazilim Sinifi";
            YZGrubu.OgrenciSayisi = 19;
            YZGrubu.EgitmenSayisi = 6;

            BFFBolumu[] SinifVerileri= new BFFBolumu[] {BSMGrubu,PGGrubu,YZGrubu};

            foreach (var sinif in SinifVerileri)
            {
                Console.WriteLine("Sinif Adi: "+sinif.SinifAdi+"\t"+"Öğrenci Sayısı: "+sinif.OgrenciSayisi + "\t" + "Egitmen Sayisi: "+sinif.EgitmenSayisi);
            }
            
            for (int i = 0; i <3 ; i++)
             {

                 Console.Write("Sınıf Adı: "+ SinifVerileri[i].SinifAdi+"\n"+"Öğrenci Sayısı: "+SinifVerileri[i].OgrenciSayisi +
                     "\n" + "Egitmen Sayısı: "+SinifVerileri[i].EgitmenSayisi);

                 Console.WriteLine();
                 Console.WriteLine();

             }

             

            int a = 0;
            while (a<3)
            {
                Console.Write("Sınıf Adı: " + SinifVerileri[a].SinifAdi + "\n" + "Öğrenci Sayısı: " + SinifVerileri[a].OgrenciSayisi +
                    "\n" + "Egitmen Sayısı: " + SinifVerileri[a].EgitmenSayisi);

                Console.WriteLine();
                Console.WriteLine();
                a++;
            }


        }
    }

    class BFFBolumu
    {
        public string SinifAdi { get; set; }

        public int EgitmenSayisi { get; set; }

        public int OgrenciSayisi { get; set; }
    }
}
