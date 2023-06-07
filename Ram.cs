namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
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
            Console.WriteLine($"The {MainColor} Ram went blubblubblubblubblubblubblubblub!");
        }
    }
}