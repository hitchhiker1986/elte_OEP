using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class Vehicle
    {
        private double consumption;
        public Tank tank;
        public CargoBay cargoBay;

        public Vehicle(double consumption, Tank tank, CargoBay cargoBay)
        {
            this.consumption = consumption;
            this.tank = tank;
            this.cargoBay = cargoBay;
        }

        public uint check(string address)
        {
            uint liter = (uint)distance(address) * consumption);

            return liter - tank.getFuelLevel() > 0 ? liter - tank.getFuelLevel() : 0;
            
        }

        public void refuel(int liter)
        {
            tank.charge(liter);
        }
        public void drive(string address)
        {

        }

        private int distance(string address)
        {
            return address.Length;
        }
        
    }
}
