using Adapter.Theoretical;
using Adapter.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

ITarget target = new MyAdapter(new Adaptee());
target.Reuest();

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

void CenterRectangle(IRectangle rectangle)
{
    Console.WriteLine($"Centering rectangle: {rectangle}");
}

LegacyRectangle legacyRectangle = new(
    left: 0,
    top: 0,
    right: 100,
    bottom: 50);

IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);
CenterRectangle(rectangle);
