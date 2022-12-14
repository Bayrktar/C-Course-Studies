using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("------------- Metotlar -------------");
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            //Alttaki örnek ekstra bir parametre eklenmek istendiğinde (örneğin stok adedi) büyük sıkıntı çıkarır
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);
        }
    }
}