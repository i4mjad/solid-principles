namespace SolidPinciples.Single_Responsibility;

public class ViolationDataProcessor
{
    public void ProcessData()
    {
        // Processing data from sensors
        Console.WriteLine("Processing data...");

        // Logging data (added more complexity)
        Console.WriteLine("Logging data to file...");
        Console.WriteLine("Logging data to database...");
    }
}