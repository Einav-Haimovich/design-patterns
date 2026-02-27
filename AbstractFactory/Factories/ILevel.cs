using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public interface ILevel
    {
        IWeapon CreateWeapon();
        IPower CreatePower();
        IEnemy CreateEnemy();

        void PlayLevel()
        {
            var weapon = CreateWeapon();
            var power = CreatePower();
            var enemy = CreateEnemy();
            Console.WriteLine($"Playing level with {weapon.GetType().Name}, {power.GetType().Name}, and {enemy.GetType().Name}.");
        }

    }
}
