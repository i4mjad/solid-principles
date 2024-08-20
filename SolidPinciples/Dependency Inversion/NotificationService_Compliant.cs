namespace SolidPinciples.Dependency_Inversion;

public interface INotifier
{
    void Notify(string message);
}

public class DiEmailNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class DiSmsNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class DiNotificationService
{
    private readonly INotifier _notifier;

    public DiNotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string message)
    {
        _notifier.Notify(message);
    }
}
