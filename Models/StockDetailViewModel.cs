using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL5.Models
{
    public class StockDetailViewModel
    {
        public string carID { get; set; }
        public string C_Code { get; set; }
        public string Maker { get; set; }
        public string Cars { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string PhotoUrl { get; set; }
        //public string history { get; set; }
        //public string in_from { get; set; }
        //public string Customer_PSI_type { get; set; }
    }
}