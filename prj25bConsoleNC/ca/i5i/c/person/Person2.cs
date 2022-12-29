using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c.person
{
    class PersonShortHand
    {//C# also provides short-hand / automatic properties, where you do not have to define the field for the property
        public string Name  // property
        { get; set; }
    }
}

//Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)