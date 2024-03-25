using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Vehicle
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine:{noiseToMakeWhenStarting}");
        }
        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine:{noiseToMakeWhenStopping}");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of the Drivemethod");
        }
    }
}


    
    
