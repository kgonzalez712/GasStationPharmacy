using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderPhoneNo { get; set; }
        public DateTime OrderTime { get; set; }
        public string OrderBranch { get; set; }
        public string OrderClient { get; set; }
        public string OrderUrl { get; set; }
        public string OrderMeds { get; set; }

    }
}