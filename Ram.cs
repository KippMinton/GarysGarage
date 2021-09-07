using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; } = 0.00;

        public void RefuelTank()
        {
          CurrentTankPercentage = 100.00;
        }

        public override void Drive()
        {
          Console.WriteLine($"The {MainColor} Ram slowly grinds by and almost breaks down. Cuh-Clank Cuh-Clank!");
        }
        
        public override void Turn(string direction)
        {
          Console.WriteLine($"The {MainColor} Ram barely makes the {direction} turn and almost breaks an axle.");
        }

        public override void Stop()
        {
          Console.WriteLine($"The {MainColor} Ram's brakes squeal loudly as it comes to a stop.");
        }
    }
}
