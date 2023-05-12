using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class CargoBay
    {
        private int capacity;
        public List<Parcel>? parcel;

        public CargoBay(int capacity)
        {
            this.capacity = capacity;
            parcel = new List<Parcel>();
            
        }
        public void putIn(Parcel p)
        {
            if (capacity > 0)
            {
                parcel.Add(p);
                capacity--;
            }

        }

        public Parcel takeOut(Parcel p)
        {
            parcel.Remove(p);
            capacity++;
            return p;
        }

        public bool isEnoughSpace()
        {

            return capacity > 0 ? true : false;
                        
        }

        public bool isEmpty()
        {
            return parcel.Count() == 0 ? true : false;
        }

        public Parcel choose()
        {
            int last = parcel.Count() - 1;
            Parcel p = parcel[last];
            parcel.RemoveAt(last);

            return p;
        }
    }
}
