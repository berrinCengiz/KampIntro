using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////isimler[4] = "İlker";  index out of range 4 elemanlı diziye 5. elemanı ekleyemezsin
            //// array ler oluşturulan sınırların dışına çıkarılamazlar
            //isimler = new string[5]; // boş dizi oluşturmuş olduk bambaşka bir adres verdik
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);// ilk değer boş olarak gelir.
            //// dizilere yeni bir şey ekleyeceğimiz zaman patlıyoruz. bunun için koleksiyonları kullanırız.
            
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil"}; // list bir Class
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            isimler2.
        }
    }
}
