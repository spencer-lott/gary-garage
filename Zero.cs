namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
                public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero went Vmmmmmmmmmmmmm!");
        }
    }
}