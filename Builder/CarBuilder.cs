using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
     class CarBuilder:VehicleBuilder
    {
        public CarBuilder()
        {
           NewVehicle = new Vehicle(VehicleType.Car);
        }

        public override void BuildDoor()
        {
            NewVehicle.door = Door.Door_4;
        }

        public override void BuildFrame()
        {
            NewVehicle.frame = Frame.Car_Frame;
        }

        public override void BuildWheels()
        {
            NewVehicle.wheels = Wheels.Wheels_4;
        }

        public override void BuildEngine()
        {
            NewVehicle.engine = Engine.Car_Engine_2500cc;
        }
    }
}
