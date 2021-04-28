using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL5.Models
{
    public class StockListViewModel
    {
        public List<SQL5.UsedCarMasterEntity> CarList { get; set; }
        public List<SQL5.CountryEntity> CountryList { get; set; }
        public List<SQL5.PortEntity> PortList { get; set; }
        public string InventoryLocation { get; set; }
        public string StockSpecial { get; set; }
        public string ErrorMsg { get; set; }
        public string LoginCountry { get; set; }
        public string LoginPort { get; set; }
        public string LoginCurrency { get; set; }
        public string isLogin { get; set; }
        public float WeeklyRate { get; set; }
        public string Insurance_disabled { get; set; }
        public string need_inspection { get; set; }
        public string LoginUserName { get; set; }
        public string LoginUserEmail { get; set; }
        public string LoginUserTel { get; set; }
        public float WeeklyRateNZ { get; set; }
        public string IPcountry { get; set; }
        public string CountryDefaultSorting { get; set; }
    }
}