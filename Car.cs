using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringAnObjectWithParentClassorInterfaceType
{
    class Car : IVehicle // This class implements the IVehicle interface
    {
        public void Start() => Console.WriteLine("Car is starting..."); // Implementation of the Start method from the IVehicle interface
    }
}
