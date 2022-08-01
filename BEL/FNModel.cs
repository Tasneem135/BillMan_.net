using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class FNModel
    {
        public int id { get; set; }
        public string flatSize { get; set; }
        public string flatNumber1 { get; set; }
        public string rentStatus { get; set; }
        public int buildingCode { get; set; }
        public string flatRenterName { get; set; }
        public string mobile { get; set; }
        public int buildingId { get; set; }

        public virtual BuildingModel building { get; set; }
    }
}
