using System;
using System.Collections.Generic;
using System.Text;

namespace _2101262300OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //birden fazla loglama yapacağımız için List istedik, yoksa tekil de yolllanabilir
        {
            //Basvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }
            
             
        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
