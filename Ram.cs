namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
                public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram went blubblubblubblubblubblubblubblub!");
        }
    }
}