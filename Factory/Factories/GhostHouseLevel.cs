using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public sealed class GhostHouseLevel : Level
    {
        public override IEnemy CreateEnemy()
        {
            return new Ghost();
        }
    }
}
