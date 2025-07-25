using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringAnObjectWithParentClassorInterfaceType
{
    class Animal 
    {
        public virtual void Speak() 
        {
            Animal a1 = new Dog(); 

            Console.WriteLine("Animal makes a sound");
 

        }
    }
}
