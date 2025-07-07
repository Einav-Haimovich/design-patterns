namespace Singleton.Models;

public sealed class ProperLazyAndSafety
{
    private static readonly Lazy<ProperLazyAndSafety> _lazyInstance = new(() => new ProperLazyAndSafety());
    
    public static ProperLazyAndSafety LazyInstance => _lazyInstance.Value;
    
    private ProperLazyAndSafety()
    {
        // Private constructor to prevent instantiation
        Console.WriteLine("ProperLazyAndSafety instance created.");
    }
}