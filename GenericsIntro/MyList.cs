using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; // class ın bütün operasyonları erişebilir.
        public MyList()// class ile aynı isim
        {
            items = new T[0];// constructor  - new lediğimiz zaman ilk olarak burası çalışır.
        }
        public void Add(T item)
        {
            // ben sana T olarak ne verirsem istediğim elemanın da tipi odur
            T[] tempArray = items; // geçici dizinin referansı items ın referansı. referans numaraları kaybolmasın diye başka diziye tutturuyoruz.
            items = new T[items.Length+1]; // dizinin eleman sayısını bir arttırıyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // geçici değerleri geri alıyoruz.
            }
            items[items.Length - 1] = item; // aslında eklenmek istenilen elemanı şimdi ekledik.
        }
    }
}
