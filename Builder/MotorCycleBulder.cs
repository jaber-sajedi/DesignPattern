using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class MotorCycleBulder:VehicleBuilder
    {
        public MotorCycleBulder()
        {
            NewVehicle = new Vehicle(VehicleType.MotorCycle);
        }

        public override void BuildDoor()
        {
            NewVehicle.door = Door.Door_0;
        }

        public override void BuildEngine()
        {
            NewVehicle.engine = Engine.MotorCycle_Engine_50cc;
        }

        public override void BuildFrame()
        {
            NewVehicle.frame = Frame.MotorCycle_Frame;
        }

        public override void BuildWheels()
        {
            NewVehicle.wheels = Wheels.Wheels_2;
        }
    }
}
