using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SUModel
    {
        public int id { get; set; }
        public int colonyId { get; set; }
        public int buildingId { get; set; }
        public string flatNumber { get; set; }
        public string mobile { get; set; }
        public string usertype { get; set; }

        public virtual BuildingModel building { get; set; }
        public virtual ColonyModel colony { get; set; }
    }
}
