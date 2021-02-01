using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri //miras - inheritance gerçek müşteri bir müşteridir.
    { 
        //sadece gerçek müşteriye ait özellikler
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
