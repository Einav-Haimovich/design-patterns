using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    record Person(string Name, List<string> Hobbies)
    {
        public Person ShallowClone()
        {
            return this with { };
        }

        public Person DeepClone()
        {
            return new Person(Name, [.. Hobbies]);
        }
    }
}
