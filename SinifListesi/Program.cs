using System;

namespace KampIntro
{

    class Program
    {

        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrenciAdi = "Abdülkadir Bayraktar";
            ogrenci1.OgrenciNo = 61;
            ogrenci1.OgrenciCinsiyet = "Erkek";
            
            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrenciAdi = "Ayşenur Bayraktar";
            ogrenci2.OgrenciNo = 62;
            ogrenci2.OgrenciCinsiyet = "Kız";

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.OgrenciAdi = "Selahaddin Bayraktar";
            ogrenci3.OgrenciNo = 63;
            ogrenci3.OgrenciCinsiyet = "Erkek";

            Ogrenci ogrenci4 = new Ogrenci();
            ogrenci4.OgrenciAdi = "Hava Bayraktar";
            ogrenci4.OgrenciNo = 64;
            ogrenci4.OgrenciCinsiyet = "Kız";

            Ogrenci ogrenci5 = new Ogrenci();
            ogrenci5.OgrenciAdi = "Abdullah Bayraktar";
            ogrenci5.OgrenciNo = 65;
            ogrenci5.OgrenciCinsiyet = "Erkek";

            Ogrenci ogrenci6 = new Ogrenci();
            ogrenci6.OgrenciAdi = "Tomris Bayraktar";
            ogrenci6.OgrenciNo = 66;
            ogrenci6.OgrenciCinsiyet = "Kız";


            Ogrenci[] ogrenciler = new Ogrenci[] { ogrenci1, ogrenci2, ogrenci3, ogrenci4, ogrenci5, ogrenci6 };

            foreach (Ogrenci ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci.OgrenciAdi + " .......... " + ogrenci.OgrenciNo + " .......... " + ogrenci.OgrenciCinsiyet );
            }
        }
    }

    class Ogrenci
    {
        public string OgrenciAdi { get; set; }
        public int OgrenciNo { get; set; } 
        public string OgrenciCinsiyet { get; set; }
        
    }

}