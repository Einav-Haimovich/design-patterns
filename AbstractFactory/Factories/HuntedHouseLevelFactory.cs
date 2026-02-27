using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class HuntedHouseLevelFactory : ILevel
    {
        public IEnemy CreateEnemy()
        {
            return new Ghost();
        }

        public IPower CreatePower()
        {
            return new Orb();
        }

        public IWeapon CreateWeapon()
        {
            return new Staff();
        }
    }
}
