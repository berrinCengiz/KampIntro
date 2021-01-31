using System;

namespace Constroctors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Engin", LastName="Demiroğ", City="Ankara"}; // new dediğimiz anda constroctor çalışır
            Customer customer2 = new Customer(2,"Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }
        static void Method(int Id, string FirstName, string LastName, string City)
        {

        }
    }
    class Customer
    {
        public Customer()
        {
            //customer1 de çalışır.
        }
        public Customer(int id, string firstName, string lastName, string city) //bir metot gibi çalışır. default constroctor. yazmasak da arka planda olan çalışır
        {
            // metot mantığı ile çalışırlar.
            //customer2 de çalışır
            //Console.WriteLine("Yapıcı blok çalıştı");

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
