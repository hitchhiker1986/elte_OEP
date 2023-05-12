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
        private string position;

        public Courier(Vehicle vehicle, string site)
        {
            this.vehicle = vehicle;
            this.site = site;
            position = site;
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
                    delivers();
                }
            }
        }
        private void back()
        {
            if (position != site)
            {
                drives(site);
            }

            while(vehicle.cargoBay.isEnoughSpace()) 
            {
                while(true) //ezt foreach-re atirni
                {
                    vehicle.cargoBay.putIn(picksUp());
                }
            }
            
        }

        private void delivers()
        {
            Parcel p = vehicle.cargoBay.choose();
            drives(p.getAddress());
            vehicle.cargoBay.takeOut(p);
        }
        private void drives(string address)
        {
            uint liter = vehicle.check(address);
            if (liter > 0) 
            {
                vehicle.refuel((uint)liter);
            }

            vehicle.drive(address);

        }
        private Parcel picksUp()
        {
            return new Parcel();
            
        }
    }
}
