using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vehicle
    {
        public Vehicle(VehicleType VType)
        {
           this.VType = VType;
        }
        public VehicleType VType;
        public Engine engine;
        public Wheels wheels;
        public Door door;
        public Frame frame;
    }
}
