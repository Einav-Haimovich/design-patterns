using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.RealWorld
{
    public abstract class Level
    {
        public abstract IEnemy CreateEnemy();

        public void EncounterEnemy()
        {
            IEnemy enemy = CreateEnemy();
            enemy.Scream();
            enemy.Attack();

        }
    }
}
