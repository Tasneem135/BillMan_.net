using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CBModel
    {
        public int id { get; set; }
        public int buildingCode { get; set; }
        public string flatNumber { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string unitAmount { get; set; }
        public string totalAmount { get; set; }
        public string status { get; set; }
        public int buildingId { get; set; }

        public virtual BuildingModel building { get; set; }
    }
}
