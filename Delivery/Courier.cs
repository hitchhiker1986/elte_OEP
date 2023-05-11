using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class Courier
    {
        public Vehicle vehicle;
        public string site;

        public Courier(Vehicle vehicle, string site)
        {
            this.vehicle = vehicle;
            this.site = site;
        }

        public void works()
        {
            while (true)
            {
                if (vehicle.cargoBay.isEmpty())
                {
                    back();
                    break;
                } else
                {
                    delivers(string address);
                }
            }
        }
        private void back()
        {
            
        }

        private void delivers(string address)
        {
            Parcel p = vehicle.cargoBay.choose();
            drives(p.getAddress());
            vehicle.cargoBay.takeOut(p);
        }
        private void drives(string address)
        {
            liter = vehicle.check(address);
            if (liter > 0) 
            {
                vehicle.refuel(liter);
            }

            vehicle.drive(address);

        }
        private Parcel picksUp()
        {
            return new Parcel();
        }
    }
}
