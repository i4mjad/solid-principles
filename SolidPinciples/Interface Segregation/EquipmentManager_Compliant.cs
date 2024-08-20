namespace SolidPinciples.Interface_Segregation;

public interface IOperationManager
{
    void StartEquipment();
    void StopEquipment();
}

public interface IMaintenanceManager
{
    void ScheduleMaintenance();
}

public interface ICalibrationManager
{
    void CalibrateEquipment();
}

public class EquipmentManager : IOperationManager, IMaintenanceManager
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
}
