using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Park
    {
        public string namePark { get; set; }
        public string location { get; set; }

        public Park(string namePark, string location)
        {
            this.namePark = namePark;
            this.location = location;
        }
    }
}
