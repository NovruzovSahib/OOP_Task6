using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task6
{
    internal class Motorcycle : BaseVehicle, IRideable
    {
        public override void Go()
        {
            Console.WriteLine("Motorcycle is moving");
        }
        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping");
        }
        public void Ride()
        {
            Console.WriteLine("Motorcycle is a rideable vehicle");

        }

       
    }
}
