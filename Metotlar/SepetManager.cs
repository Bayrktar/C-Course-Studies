using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product) //sepete eklenecek ürünün parametreleri yazılır
        {
            Console.WriteLine("Sepete Eklendi :" + product.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi :" + urunAdi);
        }
    }
}
