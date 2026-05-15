
using Bridge.RealWorld;

namespace Bridge.RealWorld;

public class MiniClothingView(IClothingFormatter clothingFormatter) : ClothingView(clothingFormatter)
{
    public override void Display()
    {
        Console.WriteLine($"Mini View:");
        Console.WriteLine($"Image: {ClothingFormatter.FormatImageUrl()}");
        Console.WriteLine($"Title Overlay: {ClothingFormatter.FormatTitle()}");
    }
}
