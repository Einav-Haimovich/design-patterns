namespace Singleton.Models;

public sealed class NaiveSingleton
{
    public static NaiveSingleton Instance { get; } = new NaiveSingleton();
    private NaiveSingleton()
    {
        // Private constructor to prevent instantiation
    }
}