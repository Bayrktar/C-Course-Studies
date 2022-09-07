using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kaç olur? (30) => int, decimal, float, bool değer tiptir. Stack-heap mantığında değer tiplerin işlemi stackte gerçekleşir ve yeni değer atandığında eski değerle olan bağlantı kesilir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0] kaç olur? (999) => array, class, interface referans tiptir. Referans tipler heap'te bir adres tutar ve sayılar1=sayılar iki dediğimizde sayılar1, sayılar2 ile aynı adresi tutar ve ilk adreste tuttuğu veriler ile bağlantısı kesilir. 
        }
    }
}