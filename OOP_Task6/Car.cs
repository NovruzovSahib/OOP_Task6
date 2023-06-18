using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task6
{
    internal class Car : BaseVehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
        public override void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
}
