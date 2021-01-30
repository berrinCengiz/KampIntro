using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Urun
    {
        //public erişim belirteci
        //bir ürünün ürün olabilmesi için çeşitli özellikleri barındırması lazım
        // prop tab tab - snipped
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }// bu şekilde eklediğimiz zaman hiçbir sayfa patlamaz buna encapsulation denir

        //e ticaret sisteminde alt alta ürünler listelenir.
    }
}
