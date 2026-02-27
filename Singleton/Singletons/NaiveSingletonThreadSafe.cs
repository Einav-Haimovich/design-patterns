namespace Singleton.Models;

public sealed class NaiveSingletonThreadSafe {
    private static NaiveSingletonThreadSafe _instance = default!;
    private static readonly object _lock = new();
    
    public static NaiveSingletonThreadSafe Instance
    {
        get
        {
            // Double-checked locking to ensure thread safety
            if (_instance is not null)
            {
                lock (_lock)
                {
                    Console.WriteLine("Locking");
                    
                    if (_instance is null)
                    {
                        _instance = new NaiveSingletonThreadSafe();
                    }
                }
            }
            return _instance;
        }
    }
    
    private NaiveSingletonThreadSafe()
    {
        // Private constructor to prevent instantiation
        Console.WriteLine("NaiveSingletonThreadSafe instance created.");
    }
}