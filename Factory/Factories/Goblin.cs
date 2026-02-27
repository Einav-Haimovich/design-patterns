using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public sealed class Goblin : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Goblin attacks with a rusty dagger!");
        }

        public void Scream()
        {
            Console.WriteLine("Goblin screams with a high-pitched cackle!");
        }
    }
}
