using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++) birer artar
            //for (int i = 1; i <= 10; i=i+2) ikişer artar
            //for (int i = 1; i <= 10; i += 2) üsttekinin aynısı
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python" };
            //for (int i = 0; i < 3; i++) dinamik bir kod olması için 3 ile sınırlamayıp döngü uzunluğuna eşitliyoruz
            for(int i = 0; i < kurslar.Length; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
