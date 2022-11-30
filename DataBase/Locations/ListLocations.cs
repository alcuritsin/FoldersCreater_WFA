using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersCreater_WFA.DataBase.Locations
{
    public class ListLocations
    {
        public List<ObjectLocation> Locations { get; set; }

        public ListLocations()
        { 
            this.Locations = new List<ObjectLocation>();
        }

        public void Add(ObjectLocation obj)
        {
            Locations.Add(obj);
        }
    }
}
