using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task6
{
    internal class Ship : BaseVehicle, ISwinable
    {
        public override void Go()
        {
            Console.WriteLine("Ship is moving");
        }

        public override void Stop()
        {
            Console.WriteLine("Ship is stopping");
        }

        public void Swim()
        {
            Console.WriteLine("Ship is a swimmable vehicle");
        }
    }
}
