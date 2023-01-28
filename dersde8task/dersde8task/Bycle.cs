using System;
using System.Collections.Generic;
using System.Text;

namespace dersde8task
{
    internal class Bycle
    {
        public string Brand;
        public string Model;
        public double Millage;

        public void Drive(int km) 
        {
            Millage += km;
        }
    }
}
