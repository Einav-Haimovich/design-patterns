namespace Singleton.Models;

public sealed class NaiveSingletonLazyLoading
{
    private static NaiveSingletonLazyLoading _instance = default!;

    public static NaiveSingletonLazyLoading Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new NaiveSingletonLazyLoading();
            }
            return _instance;
        }
    }
    
    private NaiveSingletonLazyLoading()
    {
        // Private constructor to prevent instantiation
        Console.WriteLine("NaiveSingletonLazyLoading instance created.");
    }
}