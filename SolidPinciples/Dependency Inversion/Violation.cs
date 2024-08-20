namespace SolidPinciples.Dependency_Inversion;

public class SmsNotifier
{
    public void SendSms(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class ViolationNotificationService
{
    private readonly SmsNotifier _smsNotifier;

    public ViolationNotificationService()
    {
        _smsNotifier = new SmsNotifier();
    }

    public void Notify(string message)
    {
        _smsNotifier.SendSms(message);
    }
}
