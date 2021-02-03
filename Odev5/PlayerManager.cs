using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class PlayerManager : IPlayerService
    {
        public void Add()
        {
            Console.WriteLine("oyuncu kaydedildi");
        }

        public void Delete()
        {
            Console.WriteLine("oyuncu silindi");
        }

        public void Update()
        {
            Console.WriteLine("oyuncu güncellendi");
        }
        public void Verification()
        {
            Console.WriteLine("oyuncu doğrulandı");
        }
    }
}
}
