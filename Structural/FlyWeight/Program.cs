using FlyWeight.Theoretical;
using FlyWeight.RealWorld;

Console.WriteLine("=== Theoretical Example (GoF) ===");

FlyweightFactory flyweightFactory = new();
Client client = new(flyweightFactory);

client.Operation("Hello");
client.Operation("Hi");
client.Operation("World");

Console.WriteLine();
Console.WriteLine("=== Real-World Example ===");

DocumentEditor editor = new(new GlyphFactory());

string text = "Hello, Flyweight!";
int x = 10;
int y = 10;

foreach (char c in text)
{
    editor.InsertCharacter(c, "Ariel", x, y, 12, "black");
    x += 10;
}

string upperCaseText = text.ToUpper();

foreach (char c in upperCaseText)
{
    editor.InsertCharacter(c, "Times New Roman", x, y, 14, "blue");
    x += 12;
}

editor.Render();
