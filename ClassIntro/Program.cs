using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin"; //sadece tek bir değer tutulabilir verinin türü string
            int yas = 36;

            Kurs kurs1=new Kurs(); // kurs diye bir değişken tanımlayabiliriz. sanki kendi veri tipimizi tanımlıyoruz gibi
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;
            // kur1, kurs2, kurs3 hepsi birer değişken
            // string[] string array demek içinde string tutuyorduk
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4}; // dizinin tipi kurs oldu. içinde kurs nesnesini barındıran bir array bunlar gerçekte bir veri kaynağından gelir

            foreach (Kurs kurs in kurslar) // Kurs veri tipi, kurs=alias, kurslar dizimiz
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);// her bir kursun adını ve eğitmenini yazdırıyoruz
            }
            
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        //kurs içinde 3 tane özelliği var(property) kurs objesi oluşturuyoruz.
        public string KursAdi { get; set; } // prop yaz tab tab
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
