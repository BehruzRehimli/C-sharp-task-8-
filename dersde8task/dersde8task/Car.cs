using System;
using System.Collections.Generic;
using System.Text;

namespace dersde8task
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(int fuel)
        {
            if (CurrentFuel+fuel>=FuelCapacity)
            {
                CurrentFuel += fuel;
            }
        }
    }
}
