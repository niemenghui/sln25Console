using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c.animal.pet
{
    public class Dog : IPet
    {
        public string TalkToOwner() => "Woof!";
    }
}
