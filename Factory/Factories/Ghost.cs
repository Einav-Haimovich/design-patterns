using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public sealed class Ghost : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Ghost attacks with a chilling touch!");
        }
        public void Scream()
        {
            Console.WriteLine("Ghost screams with an eerie wail!");
        }
    }
}
