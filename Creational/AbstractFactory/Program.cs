using AbstractFactory.Theoretical;
using AbstractFactory.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

AbstractFactory.Theoretical.AbstractFactory abstractFactory = new ConcreteFactory();
Product1 product1 = abstractFactory.CreateProduct1();
Product2 product2 = abstractFactory.CreateProduct2();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

GameEngine gameEngine = new GameEngine();

ILevel level1 = gameEngine.CreateLevel(1);
level1.PlayLevel();

ILevel level2 = gameEngine.CreateLevel(2);
level2.PlayLevel();
