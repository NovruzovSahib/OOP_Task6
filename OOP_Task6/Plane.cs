using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task6
{
    internal class Plane : BaseVehicle, IFlyable
    {
        public override void Go()
        {
            Console.WriteLine("Plane is moving");
        }
        public override void Stop()
        {
            Console.WriteLine("Plane is stopping");
        }
        public void Fly()
        {
            Console.WriteLine("Plane is a flyable vehicle");
        }
    }
}
