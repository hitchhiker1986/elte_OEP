using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class Tank
    {
        private uint currentFuelLevel;
        private uint max;

        public Tank(uint currentFuelLevel, uint max)
        {
            this.currentFuelLevel = currentFuelLevel;
            this.max = max;
        }

        public uint getFuelLevel()
        {
            return currentFuelLevel;
        }

        public void fuelLoss(uint liter)
        {
            if (liter > currentFuelLevel)
            {
                Console.WriteLine("Error, distance is too long, please charge the tank first!");
            } else
            {
                currentFuelLevel -= liter;
            }
            
        }

        public void charge(uint liter)
        {

            if ((currentFuelLevel + liter) > max)
            {
                currentFuelLevel = max;
            }
            else
            {
                currentFuelLevel += liter;
            }
                       
        }
    }
}