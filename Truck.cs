using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4._2
{
    class Truck : TransportBase, ITransport
    {
        public string Trailer { get; }

        public Truck(string brand, string numbers, string speed, string loadCapacity, string trailer)
            : base(brand, numbers, speed, loadCapacity)
        {
            Trailer = trailer;
        }

        public double CalculateLoadCapacity()
        {
            double loadCapacity = double.Parse(LoadCapacity);
            return Trailer == "yes" ? (loadCapacity * 2) : loadCapacity;
        }

        public string Output()
        {
            return $"Truck\tBrand: {Brand}\tNumbers: {Numbers}\tSpeed: {Speed}\tLoadCapacity: {CalculateLoadCapacity()}";
        }
    }

}
