using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention - isimlendirme kuralı
        public void Ekle(Urun urun) // norml parantez görürseniz orada bir metot çalışıyor demektir. Bana ne ekleyeceğimi söyle
        { 
            // metotlar reusubility sağlar.
            //parametre metota ne ekleyeceğimiz
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            // birden fazla metot olabilir.
            //stokAdedi ni eklediğimiz zaman tüm sayfalar hata verir
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
