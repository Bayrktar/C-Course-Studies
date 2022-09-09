using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>                                         // Type(tip)in T^sini verdik. String verirsek sadece string, int verirsek sadece int değeri alırdı//arka planda sürekli dizi tutmyaı sağlayan bir generic
    {
        T[] items;
        public MyList()                                     //class her newlendiğinde arkaplanda 0 elemanlı bir dizi oluşturuyor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;                          //diziyi newleyip eleman eklemeden önce; dizideki elemanlar kaybolmasın diye geçici diziye (tempArray) tutturduk
            items = new T[items.Length + 1];                //diziye her yeni eleman eklendiğinde dizinin eleman sayısını 1 arttırıyor
            for (int i = 0; i < tempArray.Length; i++)      //geçici diziye tutturulan elemanlar asıl diziye aktarıldı.
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;                   //dizinin eleman sayısı-1 o dizinin son elemanını verir. Add ile oluşan boşluğa da son eleman olan item eklenir
        }
    }
}
