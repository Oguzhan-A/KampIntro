using System;

namespace Workbook2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); 
            customer1.Age = 23;

            Person person1 = customer1; //Customer customer1 = person1 YAPILAMAZ! 
            //çünkü Customer:Person (Person asıl diğerleri destekleyici class)

            Console.WriteLine(person1.Age);

            customer1.Age = 35;
            Console.WriteLine(person1.Age);
            


            
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    }

    class Customer:Person
    {
        public int Id { get; set; }

    }

    class Employee:Person
    {
        public int EmpId { get; set; }
    }

 
}
