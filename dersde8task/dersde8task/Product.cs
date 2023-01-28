using System;
using System.Collections.Generic;
using System.Text;

namespace dersde8task
{
    internal class Product
    {
        public Product(string name,double price)
        {
            Name= name;
            Price= price;
        }
        public string Name;
        public double Price;
        public void ShowInfo()
        {
            Console.WriteLine($"Name - {Name} Price -{Price }");
        }
    }
}
