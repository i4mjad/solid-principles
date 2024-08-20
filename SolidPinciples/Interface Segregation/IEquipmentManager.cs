namespace SolidPinciples.Interface_Segregation;

public interface IEquipmentManager
{
    void StartEquipment();
    void StopEquipment();
    void ScheduleMaintenance();
    void CalibrateEquipment();
}