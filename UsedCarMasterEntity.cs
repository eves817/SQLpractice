using System;

namespace SQL5
{

    public class CountryEntity
    {
        public string country { get; set; }
        public string region_nk { get; set; }
    }
    public class UsedCarMasterEntity
    {
        /// <summary>
        /// Used car id
        /// </summary>
        public long C_Code { get; set; }

        /// <summary>
        /// Used car maker, e.g. TOYOTA
        /// </summary>
        public string Maker { get; set; }

        /// <summary>
        /// Used car name, e.g. AURIS
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// Used car model number, e.g. ZRE152H
        /// </summary>
        public string ModelNumber { get; set; }

        /// <summary>
        /// Used car first register year
        /// </summary>
        public int FirstRegisterYear { get; set; }

        /// <summary>
        /// Used car main photo url
        /// </summary>
        public string MainPhotoURL { get; set; }

        /// <summary>
        /// Used car current mileage in KM unit
        /// </summary>
        public int MileageKM { get; set; }

        /// <summary>
        /// Used car's shape
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// Used car's chassis number
        /// </summary>
        public string ChassisNumber { get; set; }

        /// <summary>
        /// Used car's first register month
        /// </summary>
        public int FirstRegisterMonth { get; set; }

        /// <summary>
        /// Used car's color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Used car's Grade
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// Used car's 
        /// </summary>
        public string Trans { get; set; }

        /// <summary>
        /// Used car's 
        /// </summary>
        public string WD { get; set; }

        /// <summary>
        /// Used car's capacity in CC
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Used car's 
        /// </summary>
        public string IsShowMile { get; set; }

        /// <summary>
        /// Used car's length
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Used car's width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Used car's height
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Used car's weight
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Used car's Gweight
        /// </summary>
        public int Gweight { get; set; }

        /// <summary>
        /// Used car's engine model
        /// </summary>
        public string EngineModel { get; set; }

        /// <summary>
        /// Used car's engine no
        /// </summary>
        public string EngineNo { get; set; }
        /// <summary>
        /// Japan automatic identification Number (dbo.shirre.kiseiki)
        /// The detail explanation please refer to https://www.totokyo.or.jp/management/topics/file/kindaikayuushi/h29/sikibetubangou.pdf
        /// </summary>
        public string JapanAutomaticIdentificationNumber { get; set; }

        /// <summary>
        /// Used car's certification type (dbo.shirre.katashiki)
        /// 型式指定, Certification type, 
        /// </summary>
        public string CertificationType { get; set; }

        /// <summary>
        /// Used car's classification (dbo.shirre.ruiji)
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SeatbeltYear { get; set; }

        /// <summary>
        /// The flag is to control the visibility of the attributes Capacity and Seats (dbo.shirre.KenkiFlag)
        /// </summary>
        public bool KenkiFlag { get; set; }

        /// <summary>
        /// The flag is for the recommend country calculation (dbo.shiire.MKSFlag1)
        /// </summary>
        public int RecommendCountryFlag { get; set; }

        public string RecommendCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OriginalCond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int int_point { get; set; }

        /// <summary>
        /// Vehicle unit price (discounted price)
        /// </summary>
        public int UnitPrice { get; set; }
        public int UnitPriceB { get; set; }
        public int UnitPriceC { get; set; }
        public int UnitPriceD { get; set; }

        /// <summary>
        /// Vehicle list price (default price)
        /// </summary>
        public int ListPrice { get; set; }

        /// <summary>
        /// Length * Width * Height
        /// </summary>
        public float m3 { get; set; }

        /// <summary>
        /// My favorite car
        /// </summary>
        public bool favorite { get; set; }

        public string PDF { get; set; }

        public int Manufacture_Year { get; set; }

        public int reserved_c_code { get; set; }
        public int reserved_k_code { get; set; }
       // public DateTime reserved_endTime { get; set; }
        public int wish_c_code { get; set; }
        public int USD_Freight { get; set; }
        public int JPY_Freight { get; set; }
        public int Insurance { get; set; }
        public int Inspection { get; set; }
        public string LAS_country { get; set; }
        public string z_flg { get; set; }
        public string Location { get; set; }
        public int rate_flg { get; set; }
        public string Show_Mile { get; set; }
     //   public DateTime Max_date { get; set; }
        ///// <summary>
        ///// Object Initializer
        ///// </summary>
        //public UsedCarEntity()
        //{
        //    this.PricingCondition = new UsedCarPriceConditionEntity();
        //}

    }


    /// <summary>
    /// 
    /// </summary>
    public class UsedCarDetailEntity : UsedCarMasterEntity
    {

        ///// <summary>
        ///// Used car's shape
        ///// </summary>
        //public string Shape { get; set; }

        ///// <summary>
        ///// Used car's chassis number
        ///// </summary>
        //public string ChassisNumber { get; set; }

        ///// <summary>
        ///// Used car's first register month
        ///// </summary>
        //public int FirstRegisterMonth { get; set; }

        ///// <summary>
        ///// Used car's color
        ///// </summary>
        //public string Color { get; set; }

        ///// <summary>
        ///// Used car's Grade
        ///// </summary>
        //public string Grade { get; set; }

        ///// <summary>
        ///// Used car's 
        ///// </summary>
        //public string Trans { get; set; }

        ///// <summary>
        ///// Used car's 
        ///// </summary>
        //public string WD { get; set; }

        ///// <summary>
        ///// Used car's capacity in CC
        ///// </summary>
        //public int Capacity { get; set; }

        ///// <summary>
        ///// Used car's 
        ///// </summary>
        //public string IsShowMile { get; set; }

        ///// <summary>
        ///// Used car's length
        ///// </summary>
        //public int Length { get; set; }

        ///// <summary>
        ///// Used car's width
        ///// </summary>
        //public int Width { get; set; }        

        ///// <summary>
        ///// Used car's height
        ///// </summary>
        //public int Height { get; set; }

        ///// <summary>
        ///// Used car's weight
        ///// </summary>
        //public int Weight { get; set; }

        ///// <summary>
        ///// Used car's Gweight
        ///// </summary>
        //public int Gweight { get; set; }

        ///// <summary>
        ///// Used car's engine model
        ///// </summary>
        //public string EngineModel { get; set; }

        ///// <summary>
        ///// Japan automatic identification Number (dbo.shirre.kiseiki)
        ///// The detail explanation please refer to https://www.totokyo.or.jp/management/topics/file/kindaikayuushi/h29/sikibetubangou.pdf
        ///// </summary>
        //public string JapanAutomaticIdentificationNumber { get; set; }

        ///// <summary>
        ///// Used car's certification type (dbo.shirre.katashiki)
        ///// 型式指定, Certification type, 
        ///// </summary>
        //public string CertificationType { get; set; }

        ///// <summary>
        ///// Used car's classification (dbo.shirre.ruiji)
        ///// </summary>
        //public string Classification { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public int SeatbeltYear { get; set; }

        ///// <summary>
        ///// The flag is to control the visibility of the attributes Capacity and Seats (dbo.shirre.KenkiFlag)
        ///// </summary>
        //public bool KenkiFlag { get; set; }

        ///// <summary>
        ///// The flag is for the recommend country calculation (dbo.shiire.MKSFlag1)
        ///// </summary>
        //public int RecommendCountryFlag { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public string OriginalCond { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public int int_point { get; set; }

        public string Fuel { get; set; }
        public string Seats { get; set; }

        public string Tire_Life { get; set; }
        public string ftire { get; set; }
        public string rtire { get; set; }
        public string Kenki_fork_size { get; set; }
        public string Kenki_fork_height { get; set; }
        public string Kenki_capacity { get; set; }
        public string Kenki_workinghour { get; set; }
        public string Tire_Wheel_Size_F { get; set; }
        public string Tire_Wheel_Size_R { get; set; }
        public string Ext_Color_Code { get; set; }
        public string Int_Color_Code { get; set; }

        public string TireLift_FR { get; set; }
        public string TireLift_FL { get; set; }
        public string TireLift_RR { get; set; }
        public string TireLift_RL { get; set; }
      //  public List<string> Inspection_Sheet_path1 { get; set; }
        public string Inspection_Sheet_path2 { get; set; }
        public int stop_buy { get; set; }
        public string engine_type { get; set; }
        public string z_other { get; set; }
        public string z_int { get; set; }
        public string z_ext { get; set; }
        public int PaidPrice_JPY_FOB { get; set; }
        public int PaidPrice_JPY_Freight { get; set; }
        public int PaidPrice_JPY_Insurance { get; set; }
        public int PaidPrice_JPY_Inspection { get; set; }
        public int PaidPrice_USD_FOB { get; set; }
        public int PaidPrice_USD_Freight { get; set; }
        public int PaidPrice_USD_Insurance { get; set; }
        public int PaidPrice_USD_Inspection { get; set; }
        /// <summary>
        /// Used car photos
        /// </summary>
      //  public List<UsedCarPhoto> Photos { get; set; }

        /// <summary>
        /// Used car options
        /// </summary>

        public int directport { get; set; }

        //Dealer需要的欄位
        public string aucnet_inquiry_no { get; set; }
        public int seller_price { get; set; }
        public string body_type { get; set; }
        public string car_cert { get; set; }
        public string place { get; set; }
        public string auction_pt { get; set; }
        public int transfee { get; set; }
        public int nk_fee { get; set; }
        public string data_create { get; set; }
        public int otherPhotoCount { get; set; }

        internal static UsedCarDetailEntity GetStockCarDetail(long carID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Object Initializer
        /// </summary>

    }

    /// <summary>
    /// 
    /// </summary>


    /// <summary>
    /// 
    /// </summary>
    public class UsedCarPhoto
    {
        public string Category { get; set; }

        public string PhotoJPGURL { get; set; }

        public string PhotoGIFURL { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>


    /// <summary>
    /// Used car's functionality inspection results
    /// </summary>

    /// <summary>
    /// Search Car Input Parameter Entity
    /// </summary>

    /// <summary>
    /// Maker Entity
    /// </summary>
    public class MakerEntity
    {
        /// <summary>
        /// Maker Name
        /// </summary>
        public string Maker { get; set; }

        /// <summary>
        /// Stock number of the maker in Nikkyo
        /// </summary>
        public int RecordCount { get; set; }
    }

    /// <summary>
    /// Car Model Name Entity
    /// </summary>
    public class CarModelNameEntity : MakerEntity
    {
        /// <summary>
        /// Car Model Name
        /// </summary>
        public string CarModelName { get; set; }

    }

    /// <summary>
    /// Best Selling Model Entity
    /// </summary>
    public class BestSellingModelEntity : CarModelNameEntity
    {
        /// <summary>
        /// Photo URL
        /// </summary>
        public string PhotoURL { get; set; }
    }
}