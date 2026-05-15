namespace Adapter.RealWorld;

class LegacyRectangleAdapter(LegacyRectangle legacyRectangle) : IRectangle
{
    public long GetArea()
    {
        return legacyRectangle.CalculateArea();
    }

    public long GetPerimeter()
    {
        return legacyRectangle.CalculatePerimeter();
    }

    public void Move(long dx, long dy)
    {
        legacyRectangle.Shift(
            horizontal: Convert.ToInt32(dx),
            vertical: Convert.ToInt32(dy));
    }
}
