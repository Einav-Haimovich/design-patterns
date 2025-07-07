namespace Singleton.Models;

public sealed class SingletonCoolImplement
{
    public static string ClassName => "SingletonCoolImplement";
    public static SingletonCoolImplement Instance => Nested.Instance;

    private class Nested
    {
        internal static SingletonCoolImplement Instance { get; }= new();
        
        static Nested()
        {
            
        }
    }
    private SingletonCoolImplement()
    {
        // Private constructor to prevent instantiation
    }
    
    static SingletonCoolImplement()
    {
        // Static constructor to ensure the instance is created only once
    }
}