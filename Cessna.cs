using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; } = 0.00;

        public void RefuelTank()
        {
          CurrentTankPercentage = 100.00;
        }

        public override void Drive()
        {
          Console.WriteLine($"The {MainColor} Cessna flies by. Zoooooom!");
        }

        public override void Turn(string direction)
        {
          Console.WriteLine($"The {MainColor} Cessna gracefully banks {direction}.");
        }

        public override void Stop()
        {
          Console.WriteLine($"The {MainColor} Cessna lands gracefully and gently rolls to a stop.");
        }
    }
}
