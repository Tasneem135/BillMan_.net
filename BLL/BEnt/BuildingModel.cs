using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class BuildingModel
    {
        public int id { get; set; }
        public int buildingCode { get; set; }
        public string buildingName { get; set; }
        public int totalFloors { get; set; }
        public int totalFlats { get; set; }
        public string ownerName { get; set; }
        public int colonyCode { get; set; }
        public string username { get; set; }
    }
}
