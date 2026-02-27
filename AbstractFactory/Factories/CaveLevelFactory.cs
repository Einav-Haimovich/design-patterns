using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class CaveLevelFactory : ILevel
    {
        public IEnemy CreateEnemy()
        {
            return new Goblin();
        }

        public IPower CreatePower()
        {
            return new Crystal();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
