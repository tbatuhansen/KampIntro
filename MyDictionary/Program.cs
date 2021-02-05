using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cars = new MyDictionary<string, string>();
            cars.Add("Volkswagen", "Jetta");
            cars.Add("Renault", "Megane");
            cars.Add("Toyota", "Corolla");

            cars.List();
        }
    }
}
