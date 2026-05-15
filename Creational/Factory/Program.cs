using Factory.Theoretical;
using Factory.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

Creator creator = new ConcreteCreator();
Product product = creator.CreateProduct();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

Level level1 = LevelFactory.CreateLevel(1);
level1.EncounterEnemy();

Level level2 = LevelFactory.CreateLevel(2);
level2.EncounterEnemy();
