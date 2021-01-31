using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(123, "Berrin Cengiz");
            Ogrenci.Add(456, "Ali Cengiz");
            Console.WriteLine(Ogrenci.Keys.Count);
            Console.WriteLine(Ogrenci.Values);
            // key ve value ya nasıl ulaşacağız???
          
        }
    }
}
