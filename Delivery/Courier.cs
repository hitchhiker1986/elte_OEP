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
        public void works()
        {
            while (true)
            {
                if (vehicle.cargoBay.isEmpty())
                {
                    back();
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
            if (vehicle.check(address) != 0) 
            {

            }

        }
        private Parcel picksUp()
        {
            return new Parcel();
        }
    }
}
