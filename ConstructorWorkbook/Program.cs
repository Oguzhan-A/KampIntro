using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Önce değişkenlerimi tanımlıyorum
            string _ad, _soyad, _dogumYil, _dogumYeri, _meslek;
            //Kullanıcıdan verileri girmesini istiyorum ve her bir veriyi ilgili değişkenime atama işlemi yapıyorum
            Console.WriteLine("Adınızı giriniz: ");
            _ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            _soyad = Console.ReadLine();
            Console.WriteLine("Doğum yılınızı giriniz: ");
            _dogumYil = Console.ReadLine();
            Console.WriteLine("Doğum yerinizi giriniz: ");
            _dogumYeri = Console.ReadLine();
            Console.WriteLine("Mesleğinizi giriniz: ");
            _meslek = Console.ReadLine();

            //Personel classından nesne oluşturuyorum ve ilgili parametrelerini belirtiyorum.
            Personel prsnl = new Personel(_ad, _soyad, _dogumYil, _dogumYeri, _meslek);

            Console.Read();
        }
    }
    class Personel
    {
        //yapıcı metotlarda metot adı ile class adı aynı olur. Burda yapıcı metot içinde ayrıca parametre tanımlaması yaptım. Tüm parametrelerim string, işlem yapmadığım için.
        public Personel(string ad, string soyad, string dogumYil, string dogumYeri, string meslek)
        {
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Doğum Yılı: " + dogumYil);
            Console.WriteLine("Doğum Yeri: " + dogumYeri);
            Console.WriteLine("Meslek: " + meslek);

        }
    }
}