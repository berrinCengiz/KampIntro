using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // encapsulation - 50 tane parametre geçmek yerine tek bir nesne içinde toplayıp nesneyi yolluyoruz
        public void Add(Product product) 
        {
            // bir ürün eklenecekse bu operasyona neyi ekleyeceğimizi söylememiz lazım.
            // void - emir kipinde git ekle diyorsunuz. o işlemini yapıp bitiriyor. bu işlem sonucunda bir bilgiye ihtiyacımız yok.
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        public void Delete(Product product)
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
            // bu işlem sonucunda ortaya çıkan değeri başka bir işlemde kullanmak istiyoruz...
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
            // Topla2 sayi1 ve sayi2 yi toplayıp ekrana yazdırıyor. git yap bitir.
        }
    }
}
