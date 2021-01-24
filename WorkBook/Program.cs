using System;

namespace WorkBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int gun = (int)DateTime.Now.DayOfWeek;
            switch(gun)
            {
                case 1:
                    Console.WriteLine("Bugün Pazartesi");
                    break;

                case 2:
                    Console.WriteLine("Bugün Salı");
                    break;

                case 6:
                    Console.WriteLine("Bugün Cumartesi");
                    break;

            }

            string[] isimler = new string[] { "ali", "ahmet", " ayşe", "hakan", "selim", "yasar" };

            foreach (var isim in isimler)
            {

                if (isim == "hakan")
                    Console.WriteLine(isim);

            }

            for (int i = 1; i < 10; i=i+2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
