using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class GameEngine : AbstractFactory
    {
        public override ILevel CreateLevel(int levelNumber)
        {
            return levelNumber switch
            {
                1 => new CaveLevelFactory(),
                2 => new HuntedHouseLevelFactory(),
                _ => throw new ArgumentException("Invalid level number")
            };
        }
    }
}
