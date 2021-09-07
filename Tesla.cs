using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; } = 0.00;

        public void ChargeBattery()
        {
          CurrentChargePercentage = 100.00;
        }

        public override void Drive()
        {
          Console.WriteLine($"The {MainColor} Tesla rolls by in style. Weee!");
        }

        public override void Turn(string direction)
        {
          Console.WriteLine($"The {MainColor} Tesla negotiates a sharp {direction} turn with ease.");
        }

        public override void Stop()
        {
          Console.WriteLine($"The {MainColor} Tesla silently comes to a stop.");
        }
    }
}
