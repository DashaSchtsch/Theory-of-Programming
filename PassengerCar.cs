using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб4._2
{
    class PassengerCar : TransportBase, ITransport
    {
        public PassengerCar(string brand, string numbers, string speed, string loadCapacity) : base(brand, numbers, speed, loadCapacity) { }

        double ITransport.CalculateLoadCapacity()
        {
            return double.Parse(LoadCapacity);
        }

        string ITransport.Output()
        {
            return $"PassengerCar\tBrand: {Brand}\tNumbers: {Numbers}\tSpeed: {Speed}\tLoadCapacity: {LoadCapacity}";
        }
    }
}
