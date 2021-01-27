using System;
using System.Collections.Generic;
using System.Text;

namespace _2101262300OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
