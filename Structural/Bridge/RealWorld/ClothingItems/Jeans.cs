namespace Bridge.RealWorld;

public record Jeans(
    string WaistSize,
    int Length,
    string Wash,
    string Fit = "Regular",
    bool HasStretch = false);