using Composite.Theoretical;
using Composite.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

Composite.Theoretical.Component root = new Composite.Theoretical.Composite();
Composite.Theoretical.Component leafA = new Leaf();

root.Add(leafA);

Composite.Theoretical.Component childComposite = new Composite.Theoretical.Composite();
Composite.Theoretical.Component leafB = new Leaf();
Composite.Theoretical.Component leafC = new Leaf();

childComposite.Add(leafB);
childComposite.Add(leafC);

root.Add(childComposite);

root.Operation();
leafA.Operation();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

LearningResource bundleRoot = new Bundle(name: "Zero to Hero: Clean Architecture");

LearningResource courseA = new Course(
    name: "Getting Started: Clean Architecture",
    duration: TimeSpan.FromHours(3),
    price: 100);

LearningResource courseB = new Course(
    name: "Deep Dive: Clean Architecture",
    duration: TimeSpan.FromHours(4),
    price: 110);

bundleRoot.Add(courseA);
bundleRoot.Add(courseB);

Console.WriteLine(bundleRoot.GetPrice());
