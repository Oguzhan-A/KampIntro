using System;

namespace _2101262300OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            //iptal ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //iptal tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //iptal konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
        }
    }
}
