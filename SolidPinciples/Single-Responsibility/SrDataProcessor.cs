namespace SolidPinciples.Single_Responsibility;



public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}


public class SrDataProcessor
{
    private readonly ILogger _logger;

    public SrDataProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessData()
    {
        // Processing data from sensors
        Console.WriteLine("Processing data...");
        _logger.Log("Data processed successfully.");
    }
}