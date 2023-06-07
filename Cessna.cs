namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        // public double FuelCapacity { get; set; }
        public string CurrentTankPercentage { get; set; } = default!;
        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = "100";
            Console.WriteLine($"Tank is full and back to {CurrentTankPercentage}%");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna went EEEEEEEEEIIIEIIIIEEIEIEI!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}