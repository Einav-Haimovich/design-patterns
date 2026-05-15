using Bridge.RealWorld;

namespace Bridge.RealWorld;

public abstract class ClothingView(IClothingFormatter clothingFormatter)
{
    protected IClothingFormatter ClothingFormatter { get; init; } = clothingFormatter;

    public abstract void Display();
}