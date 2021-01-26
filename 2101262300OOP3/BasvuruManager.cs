using System;
using System.Collections.Generic;
using System.Text;

namespace _2101262300OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Basvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
        }
    }
}
