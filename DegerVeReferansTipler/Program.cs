using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10; // sayi1 in değeri 10 diye okuruz
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 in değeri eşittir sayi2 nin değeri. değeri kopyalayınca işi bitiyor...
            sayi2 = 65;
            Console.WriteLine(sayi1); // değer tipi olduğu için sadece değer aktarılır. değeri aktardıktan sonra sayi2 ile olan irtibatı koparır.

            int[] sayilar1 = new int[] {10,20,30}; // new= sayilar1 için heap te yeni bir alan oluştur ve değerleri oraya yaz.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // sayilar1 in referans numarası eşittir sayilar2 nin referans numarası
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //referans tipi olduğu için 
            // bellekte stack ve heap diye iki tane alan var
            //değer tip olanlar tamamen stack te gerçekleşiyor.
            //referans tiplerde sayilar1 stack te tutulur. değerleri Heap te tutulur. sayilar1 oranın adresini işaret eder.
        }
    }
}
