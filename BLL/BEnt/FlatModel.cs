using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class FlatModel
    {
        public int id { get; set; }
        public int colonyCode { get; set; }
        public int buildingCode { get; set; }
        public string buildingName { get; set; }
        public int floorDetail { get; set; }
        public string flatNumber { get; set; }
        public string flatSize { get; set; }
        public string flatRenterName { get; set; }
        public string month { get; set; }
        public string flatRent { get; set; }
        public string wasaBill { get; set; }
        public string currentBill { get; set; }
        public string status { get; set; }
        public int colonyId { get; set; }
        public int buildingId { get; set; }

        public virtual BuildingModel building { get; set; }
        public virtual ColonyModel colony { get; set; }
    }
}
