using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.RealWorld
{
    public class CaveLevel : Level
    {
        public override IEnemy CreateEnemy()
        {
            return new Goblin();
        }
    }
}
