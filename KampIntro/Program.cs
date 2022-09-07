using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string katgoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azaldı");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Arttı");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }



            if (sistemeGirisYapisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(katgoriEtiketi);
        }
    }
}