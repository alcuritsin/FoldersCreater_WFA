using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersCreater_WFA.DataBase.Locations
{
    public class ObjectLocation
    {
        public String LocationName { get; set; }
        public String StreetName { get; set; }
        public String HouseNumber { get; set; }

        public ObjectLocation()
        {
            this.LocationName = string.Empty;
            this.StreetName = string.Empty;
            this.HouseNumber = string.Empty;
        }

        public ObjectLocation(String _locationName, String _streetName, String _houseNumber)
        {
            this.LocationName = _locationName;
            this.StreetName = _streetName;
            this.HouseNumber = _houseNumber;
        }
    }
}
