using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 58, FirstName = "Tamer Batuhan", LastName = "ŞEN", City = "Sivas" };
            Customer customer1 = new Customer() { Id = 34, FirstName = "Ali", LastName = "Veli", City = "İst" };
            Customer customer2 = new Customer(2, "ad", "soyad", "şehir");
            
        }
        class Customer
        {
            //default constructor
            public Customer()
            {
                Console.WriteLine("diğeri de çalıştı");
            }
            public Customer(int id, string firstName, string lastName, string city)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                City = city;
            }
            
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
