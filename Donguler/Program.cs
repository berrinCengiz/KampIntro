using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // hangi projenin çalışması istenirse o seçilir.
            
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3="Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //zamanla yeni kurslar eklenebilir dinamik bir yapı olmalı bu şekilde yazıldığında döngü ile gezemeyiz...
            //100 tane kurs olsa tek tek yazacak mıydık?


            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı",
                "Programlamaya başlangıç için temel kurs", "Java","Python", "C#" }; // []= dizi istediğimiz kadar kursu tek bir değişkende yutabiliriz.
            // string[] kurslar = kurslariGetir(); gerçek hayatta böyle kullanılır.

            for (int i = 0; i < kurslar.Length; i++) // şart sağlandığı sürece blok çalışır. programlama dilleri saymaya 0 dan başlar.
            {
                Console.WriteLine(kurslar[i]);//0, 1, 2 için blok bir kere çalışır. dizi uzunluğu kadar...
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)// dizi temelli yapıları tek tek dönmek için kullanılır.
            {
                Console.WriteLine(kurs); //kursları dolaş her dönüşte değerleri kurs'a at. kurs=alias
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
