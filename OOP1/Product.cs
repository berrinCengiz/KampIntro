using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Entity gibi isimler de veriliyormuş ----- bu tür class larda sadece özellik olur.
    {
        public int Id { get; set; } // primary key
        public int CategoryId { get; set; } // foreign key - referans alanları 2. sıraya yazılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; } // stok adedi


    }
}
