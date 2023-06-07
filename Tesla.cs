namespace Garage
{
    public class Tesla : Vehicle, IElectricalVehicle
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
            Console.WriteLine($"The {MainColor} Tesla went Wushhhhhhhhh!");
        }
                public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a right turn.");
        }
                public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}