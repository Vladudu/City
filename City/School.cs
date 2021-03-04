using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class School
    {
        public string schoolName { get; set; }
        public int schoolNumber { get; set; }
        public string schoolLocation { get; set; }

        public School(string schoolName, int schoolNumber, string schoolLocation)
        {
            this.schoolName = schoolName;
            this.schoolNumber = schoolNumber;
            this.schoolLocation = schoolLocation;
        }
    }
}
