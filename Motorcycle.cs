using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringAnObjectWithParentClassorInterfaceType
{
    class Motorcycle : IVehicle
    {
        public void Start() => Console.WriteLine("Motorcycle is starting..."); // Implementation of the Start method from the IVehicle interface
    }
}
