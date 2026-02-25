using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
