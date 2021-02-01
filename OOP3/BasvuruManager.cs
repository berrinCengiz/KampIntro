using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection 
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // basvuru yapmak için kredi türü göndermemiz gerekir. hepsinin referansını tutabilen Ikredimanager i gönderiririz
        {
            //başvuran bilgileri değerlendirme
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); // bu şekilde dersek bütün hesaplamaları konut kredisi olarak yapar.

            krediManager.Hesapla(); // başvuruyu kredi bağımsız hale getirdik...
            loggerService.Log(); // hangi log layıcı seçilmişse onu log la.
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
