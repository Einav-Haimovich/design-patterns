

namespace FlyWeight;

public class DocumentEditor(GlyphFactory glyphFactory)
{
    private readonly GlyphFactory _glyphFactory = glyphFactory;
    private readonly List<(IGlyph glyph, int x, int y, int size, string color)> _characters = [];

    public void InsertCharacter(
        char character,
        string fontFamily,
        int x,
        int y,
        int size,
        string color)
    {
        Console.WriteLine($"Inserting '{character}' at ({x}, {y})");

        var glyph = _glyphFactory.GetGlyph(character, fontFamily);
        _characters.Add((glyph, x, y, size, color));
    }

    public void Render()
    {
        Console.WriteLine("Rending document:");

        foreach (var glyphCar in _characters)
        {
            glyphCar.glyph.Render(
                glyphCar.x,
                glyphCar.y,
                glyphCar.size,
                glyphCar.color);
        }
    }
}