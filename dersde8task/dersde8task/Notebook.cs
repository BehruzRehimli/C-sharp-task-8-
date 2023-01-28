using System;
using System.Collections.Generic;
using System.Text;

namespace dersde8task
{
    internal class Notebook:Product
    {
        public Notebook(string name, double price):base(name,price)
        {

        }
        public int Ram;
        public int Storage;
    }
}
