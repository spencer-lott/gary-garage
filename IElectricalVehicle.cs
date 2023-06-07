

public interface IElectricalVehicle
{
    string CurrentChargePercentage { get; set; }

    void ChargeBattery();
}