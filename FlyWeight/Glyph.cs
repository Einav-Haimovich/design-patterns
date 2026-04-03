
namespace FlyWeight;

public class Glyph : IGlyph
{
    private readonly char character;
    private readonly string fontFamily;

    public Glyph(char character, string fontFamily)
    {
        this.character = character;
        this.fontFamily = fontFamily;

        Console.WriteLine($"Creating new glyph: '{character}' with font {fontFamily}");
    }

    public void Render(int x, int y, int size, string color)
    {
        // uses both extrinsic state and the intrinsic state
        Console.WriteLine($"Rendering glyph '{character}', at {x}, {y} with size {size} and color {color}.");

        // In a real application, this is where we'd render
        // the glyph, using the extrinsic and intrinsic state
    }
}
