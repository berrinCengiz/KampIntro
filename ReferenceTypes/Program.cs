using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi1 : " + sayi1); //20. Değer tip - int, decimal, float, enum, bool - Value Types
            // sayi1 in değeri eşittir 10
            //sayi1 in değeri eşittir sayi2 nin değeri. atama yaptıktan sonra bağlantı kopar.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayilar1[0] : " + sayilar1[0]);
            
            //Referans Tip - arrays,class,interface...
            // new dediğimiz zaman heap te veri oluşuyor bir de adres değeri oluşturuyor.
            // sayilar1 in adresi eşittir sayilar2 nin adresi

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin"; 

            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer; // customer bir person olduğu için atama yapılabilir . miras alındığı için - person tipinden olduğu için creditcardnumber görülmez
            customer.FirstName = "Ahmet";
            Console.WriteLine(((Customer)person3).CreditCardNumber);//boxing yapıldı
            Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            
        }
    }
    //base class :person
    class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public  void Add (Person person) // aynı kodu farklı nesneler için çalıştırmamızı sağlıyor.
        {
            // veri tabanı programlama da veri tabanı değişirse onların kendi nesneleri oluşturulup istenilen nesne çalıştırılabilir.
            Console.WriteLine(person.FirstName);
        }
    }
}
