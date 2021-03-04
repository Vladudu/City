using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Street
    {
        public string streetName { get; set; }
        public int streetNumber { get; set; }

        public Street(string streetName, int streetNumber)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
        }
    }
}
