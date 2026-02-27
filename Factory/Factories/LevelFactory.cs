using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public static class LevelFactory
    {
        public static Level CreateLevel(int levelNum)
        {
            return levelNum switch
            {
                1 => new CaveLevel(),
                2 => new GhostHouseLevel(),
                _ => throw new ArgumentException("Invalid level number")
            };
        }
    }
}
