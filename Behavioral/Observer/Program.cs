using Observer.Theoretical;
using Observer.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

ConcreteSubject subject = new();

subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));

subject.SetState("state 1");

await Task.Delay(1000);

subject.SetState("state 2");

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

Player player = new();

player.Attach(new GameOverScreen(player));
player.Attach(new ScoreUI(player));
player.Attach(new HealthBarUI(player));

player.SetState(health: 100, score: 0);
player.SetState(health: 100, score: 10);
player.SetState(health: 90, score: 20);
player.SetState(health: 80, score: 30);
player.SetState(health: 10, score: 25);
player.SetState(health: 0, score: 25);
