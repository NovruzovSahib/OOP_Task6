using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task6
{
    public abstract class BaseVehicle : IVehicle
    {
        public abstract void Go();
        public abstract void Stop();
    }
}
