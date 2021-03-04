using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Building
    {
        public string buildingName { get; set; }
        public string buildingType { get; set; }

        public Building(string buildingName, string buildingType)
        {
            this.buildingName = buildingName;
            this.buildingType = buildingType;
        }
    }
}
