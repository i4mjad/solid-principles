namespace SolidPinciples.Dependency_Inversion;

public class EmailNotifier
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class NotificationService
{
    private readonly EmailNotifier _emailNotifier;

    public NotificationService()
    {
        _emailNotifier = new EmailNotifier();
    }

    public void Notify(string message)
    {
        _emailNotifier.SendEmail(message);
    }
}
