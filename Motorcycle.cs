using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4._2
{
    class Motorcycle : TransportBase, ITransport
    {
        public string Sidecar { get; }

        public Motorcycle(string brand, string numbers, string speed, string sidecar) : base(brand, numbers, speed, null)
        {
            Sidecar = sidecar;
        }

        public double CalculateLoadCapacity()
        {
            return Sidecar == "yes" ? 200 : 0;
        }

        public string Output()
        {
            return $"Motorcycle\tBrand: {Brand}\tNumbers: {Numbers}\tSpeed: {Speed}\tLoadCapacity: {CalculateLoadCapacity()}";
        }
    }

}
