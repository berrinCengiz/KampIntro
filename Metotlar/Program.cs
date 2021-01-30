using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself - DRY - Clean code - Best practice - temiz kod yazma teknikleri
            // e ticaret sistemlerinde her yerde sepete ekle butonu var.
            //bu 3 bilgi üçü beraber elmanın bilgilerini veriyor bir nesneyi anlatıyor. üçü bir ürün demek
            // bu yüzden class lar oluştururuz. string gibi class lar da bir veri tipi diyebiliriz.
            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); // Urun tipinde örnek oluşturuyoruz
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması"; // bir Urun üm var urun ün adı fiyatı acıklaması urun ile ilişkilendirildi.

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (Urun urun in urunler)//Urun veri tipi, urun=alias, urunler dizinin adı
            {
                Console.WriteLine(urun.Adi); // console programcının kendi kendine bir şey gösterme şeklidir.
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--------Metotlar-----------");
            //instance- örnek
            //encapsulation ayrı ayrı yazacağın ve düzensiz olacak bir yapıyı bir düzenin içine sokuyoruz
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10); // ürünleri bu şekilde gönderebiliriz niye illa class yapıyoruz. yeni parametre ekleyince tüm sayfalar patlamasın diye

        }
    }
}
