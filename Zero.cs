namespace Garage
{
    public class Zero : Vehicle, IElectricalVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public string CurrentChargePercentage { get; set;} = default!;

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = "100";
            Console.WriteLine($"Charge is back to {CurrentChargePercentage}%");
        }
                public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero went Vmmmmmmmmmmmmm!");
        }
    }
}