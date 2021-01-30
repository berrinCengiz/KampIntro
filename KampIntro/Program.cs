using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği için değişken tipi yazılmak zorunda...
            // python da type safety bir dil ancak c# ve java daka katı kurallara sahip
            // metinsel ifadelerde tek tırnak kullanılmaz!!!
            /* java da S büyük yazılır.
             * String kategoriEtiketi="Kategori;
             * System.out.println(kategoriEtiketi);
             */

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000; //belli sınırları var
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; // iki değer alabilir. gerçek hayatta bu değerler bir veri kaynağından gelir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun) // ternary operatöerle de yazılabilir.
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                // blok yapısı var. Python da indentation ile yapılır.
                Console.WriteLine("Kullanıcı ayarları butonu"); // gelen veriye göre oluşacak kısım.
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi); // dinamik yapılar için değişkenler önemli...
            //kategori yerine kategoriler yazılmak istense her yerdekini değiştirmek gerekir.bunun için değişkende tutmak gerekir.
            //-----------Do Not Repeat Yourself------------
            

            

        }
    }
}
