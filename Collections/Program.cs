using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Abdülkadir", "Selahaddin", "Hava", "Abdullah" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];        //burada, yukarıdaki diziye yeni bir eleman eklenmedi. 5 elemanlı yeni bir dizi oluşturuldu. Aşğıdaki listeye ekleme gibi bir özellik yok
            //isimler[4] = "Tomris";          //burada da oluştural boş dizinin 5. elemanı atandı
            //Console.WriteLine(isimler[4]);  //burada ekrana Tomris yazdırılır
            //Console.WriteLine(isimler[0]);  // fakata burada ekrana bir şey yazdırılmaz çünkü dizinin o elemanı boş


            List<string> isimler2 = new List<string> {"Abdülkadir", "Selahaddin", "Hava", "Abdullah"};

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Tomris");             //burada, yukarıda oluşturulan listeye yeni bir eleman eklendi
            Console.WriteLine(isimler2[4]);     //oluşturulan yeni eleman ekrana yazdırıldı
            Console.WriteLine(isimler2[0]);     //listenin zaten elemanı olan Abdülkadir yazdırıldı

        }
    }
}