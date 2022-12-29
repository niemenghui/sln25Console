using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c.person
{
    class FordVehicle  // base class (parent) 
    {
        public string brand = "Ford";   
        public void honk()              
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }


    class Car : FordVehicle  // derived class (child)
    {
        public string modelName = "Mustang";   
    }
}
