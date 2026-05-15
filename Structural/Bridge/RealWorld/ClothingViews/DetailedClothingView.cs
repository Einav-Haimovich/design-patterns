
using Bridge.RealWorld;

namespace Bridge.RealWorld;

public class DetailedClothingView(IClothingFormatter clothingFormatter) : ClothingView(clothingFormatter)
{
    public override void Display()
    {
        Console.WriteLine($"Detailed View:");
        Console.WriteLine($"Image: {ClothingFormatter.FormatImageUrl()}");
        Console.WriteLine($"Title: {ClothingFormatter.FormatTitle()}");
        Console.WriteLine($"Description: {ClothingFormatter.FormatDescription()}");
    }
}
