namespace Bridge.RealWorld;

public record PoloShirt(
    string Size,
    string Color,
    string Material,
    bool HasPocket = false,
    string Brand = "Generic");