using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.RealWorld
{
    public abstract class AbstractFactory
    {
        public abstract ILevel CreateLevel(int levelNumber);
    }
}
