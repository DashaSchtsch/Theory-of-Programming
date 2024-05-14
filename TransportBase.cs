using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4._2
{
    public abstract class TransportBase
    {
        protected string Brand;
        protected string Numbers;
        protected string Speed;
        protected string LoadCapacity;

        protected TransportBase(string brand, string numbers, string speed, string loadCapacity)
        {
            Brand = brand;
            Numbers = numbers;
            Speed = speed;
            LoadCapacity = loadCapacity;
        }
    }
}
