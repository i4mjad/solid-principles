namespace SolidPinciples.Interface_Segregation;

public class EquipmentManagerViolation : IEquipmentManager
{
    public void StartEquipment()
    {
        Console.WriteLine("Starting equipment...");
    }

    public void StopEquipment()
    {
        Console.WriteLine("Stopping equipment...");
    }

    public void ScheduleMaintenance()
    {
        Console.WriteLine("Scheduling maintenance...");
    }

    public void CalibrateEquipment()
    {
        throw new NotImplementedException(); // Calibration not needed for this equipment
    }
}