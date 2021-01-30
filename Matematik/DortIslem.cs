using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //toplama bir metot 10 sayfanın 5 inde kullanılacak bunun için metot olarak tanımlıyoruz.
        //Topla(2,3);
        public void Topla(int sayi1, int sayi2)
        {
            //toplama yapabilmek için ki tane sayıya ihtiyacı var
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam); // string ile int toplanıyor ama int i otomatik olarak string haline getiriyor.
        }
    }
}
