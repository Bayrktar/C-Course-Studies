using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici Kampı", "Java Kursu", "HTML Kursu"  };
             

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}