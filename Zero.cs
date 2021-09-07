using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; } = 0.00;

        public void ChargeBattery()
        {
          CurrentChargePercentage = 100.00;
        }
        public override void Drive()
        {
          Console.WriteLine($"The {MainColor} Zero speeds by. Zip!");
        }
    }
}
