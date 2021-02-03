using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(); //aynı class içinde olduğu için direkt kullanabiliriz.
            var result = Add2(20); // default parametreli
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(out number1, number2); // number1 artık referans tip gibi olacak ve değeri 30 olacak
            Console.WriteLine(result2);
            Console.WriteLine(number1); //20 dir. değer tip olduğu için. 

            int result3 = Multiply(2, 4);
            int result4 = Multiply(2, 4, 8);

            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.WriteLine(Add4(2,3,4,5,6));
        }
        static void Add() // static içinde static tanımlayabiliriz
        {
            Console.WriteLine("Added!");
            //void - git şunu yap demek 
        }
        static int Add2(int number1, int number2=30) // default değerleri parametrelerin en sonunda yazmalıyız
        {
            //add2 yi kullanmak için iki tane parametre göndermek zorundadır.
            return number1 + number2;
            // bir sonuç almak istiyoruz.
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30; //buradaki değer değişirse main dekinin de değişmesini istersek ref olarak gönderiyoruz.
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) //başka bir yerde 3 değeri çarpmak isteyebiliriz aynı isimde farklı parametrelerle sıkıntı olmuyor
        {
            return number1 * number2 * number3; //method overloading
        }
        static int Add4(params int[] numbers) //her seferinde farklı sayıda sayılarla toplama işlemi yapabilmek için params ve dizi kullanıyoruz. params metotun son parametresi olmak zorunda
        {
            return numbers.Sum();
        }
    }
}
