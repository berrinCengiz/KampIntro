using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); // gerçek hayatta böyle tek tek yazılmıyor alanlar. web uygulamasıyla mobil uygulamayla birleştirince ekranda kullanıcıdan alırız.
            product1.Id = 1;
            product1.CategoryId = 2; // mobilya demek
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            //PascalCase - kelimelerin ilk harfi büyük yazılır. camelCase - ilk harf küçük sonraki kelimelerin ilk harfi büyük
            //case sensitive
            ProductManager productManager = new ProductManager(); //instance creation string isim="Engin"; gibi bir şey 
            // sol taraf stack - sağ taraf heap
            productManager.Add(product1); // şu ürünü ekledim - parametre

            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3, 6);


        }
    }
}
