using AbstractFactory.Factories;

GameEngine gameEngine = new GameEngine();

ILevel level1 = gameEngine.CreateLevel(1);
level1.PlayLevel();

ILevel level2 = gameEngine.CreateLevel(2);
level2.PlayLevel();