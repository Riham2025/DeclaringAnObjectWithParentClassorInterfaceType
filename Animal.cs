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
            Animal a2 = new Cat(); 

            Console.WriteLine("Animal makes a sound");

            a1.Speak(); // Dog barks

            a2.Speak(); // Cat meows

        }
    }
}
