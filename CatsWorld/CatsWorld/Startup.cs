namespace CatsWorld;

public class Startup
{
    public static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("Hello, Cats!");
    }
}
