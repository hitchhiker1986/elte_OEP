using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class Parcel
    {
        private string? address;

        public Parcel() { }
        public Parcel(string address)
        {
            this.address = address;
        }
        
        public string getAddress()
        {
            return address;
        }
    }
}
