using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c.animal
{
    abstract class AbstractAnimal
    {
        public abstract void animalSound(); // Abstract method (does not have a body)
        public void sleep()      // Regular method
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class GoldPig : AbstractAnimal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The GoldPig says: Gold wee");
        }
    }




}


