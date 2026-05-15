using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.RealWorld
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
