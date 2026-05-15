using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.RealWorld
{
    public sealed class GhostHouseLevel : Level
    {
        public override IEnemy CreateEnemy()
        {
            return new Ghost();
        }
    }
}
