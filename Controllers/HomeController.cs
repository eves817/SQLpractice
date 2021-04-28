using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;

namespace SQL5.Controllers
{


    public class HomeController : Controller
    {
        public ActionResult Index()
        {      
            
            return View(); 
    }
        [HttpPost]
        public ActionResult Index(long id)  //丟現有資料   回傳是尋求的資料
        {


            long carID = 0;         carID = id;
            
         
            string maker, cars, model,photo;
            int yy, mm;
            NikkyoSQLDataAccess corpDAL = new NikkyoSQLDataAccess();
            try
            {
                corpDAL.OpenNikkyoSQLConnection();
                DataTable _dt = corpDAL.GetNikkyoStockCarDetail(carID);
                DataTable dtPhotoList = corpDAL.GetUsedCarPhotoList(carID);
                if (_dt == null || _dt.Rows.Count == 0)
                {
                    return null;
                }
                else //if(_dt != null && _dt.Rows.Count > 0)
                {
                    //string maker, cars, model;  //放在裡面只能在裡面使用，外面傳不到
                    //int yy, mm;
                    DataRow _row = _dt.Rows[0];
                    DataRow _roww = dtPhotoList.Rows[0];

                    maker = _row["maker"].ToString();
                    cars = _row["cars"].ToString();
                    model = _row["model"].ToString();
                    yy = int.Parse(_row["yy"].ToString());
                    mm = int.Parse(_row["mm"].ToString());
                    photo = _roww["jpg_url"].ToString();

                }
            }
            finally
            { corpDAL.CloseNikkyoSQLConnection(); }
            var A=id.ToString();        
            var c="";          
            HttpContext context = System.Web.HttpContext.Current;   //当前正在处理的这个请求的一些上下文信息就保存在一个HttpContext对象里,通过HttpContext的静态属性Current得到当前这个上下文,然后去取你需要的信息,比如查询字符串等
            
            c= (string)(context.Session["stock_K_ID"]);   //讀取

           
            string str = "";
            if (c != null) {
                 str = c + "," + A;
            }
            else{
                str =  A;
            }
            

            context.Session["stock_K_ID"] = str;
            string E = "STOCKID:" + str;
           
 
        


            return Json(new { id=id , maker = maker, cars = cars, model = model, yy = yy,mm= mm,photo=photo, c = str }, JsonRequestBehavior.AllowGet);   //, User = User  //cookie對sessionstorage
        }
        public ActionResult About()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult About(string StockID)
        //{
        //    return RedirectToAction("View", new { StockID = StockID });
        //}
        public new ActionResult View(string StockID)
        {
            Models.StockDetailViewModel _view = new Models.StockDetailViewModel();
            long carID = 0;
            _view.carID = StockID;
            carID = !string.IsNullOrEmpty(StockID) ? long.Parse(StockID) : 0;

            NikkyoSQLDataAccess corpDAL = new NikkyoSQLDataAccess();

            try
            {
                corpDAL.OpenNikkyoSQLConnection();
                DataTable _dt = corpDAL.GetCarDetailMegaData(carID);
               
                //DataTable dtPhotoList = corpDAL.GetUsedCarPhotoList(carID);


                _view.Maker = _dt.Rows[0]["maker"].ToString();
                _view.Cars = _dt.Rows[0]["cars"].ToString();
                _view.Model = _dt.Rows[0]["model"].ToString();
                _view.Year = _dt.Rows[0]["yy"].ToString();
                _view.Month = _dt.Rows[0]["mm"].ToString();
                _view.PhotoUrl = _dt.Rows[0]["photo_url"].ToString();
            }
            finally {
                corpDAL.CloseNikkyoSQLConnection();
            }

            return View(_view);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class NikkyoSQLDataAccess
        {
            private string ConnStringNikkyoSQL = WebConfigurationManager.ConnectionStrings["NIKKYOSQL"].ToString();  //連接資料庫
            private SqlConnection NikkyoSQLConnection = null;
            public void OpenNikkyoSQLConnection()    //打開資料庫
            {
                if (NikkyoSQLConnection == null) NikkyoSQLConnection = new SqlConnection(ConnStringNikkyoSQL);

                if (NikkyoSQLConnection.State != ConnectionState.Open) NikkyoSQLConnection.Open();
            }
            public void CloseNikkyoSQLConnection()     //關閉資料庫
            {
                try
                {
                    if (NikkyoSQLConnection != null)
                    {
                        NikkyoSQLConnection.Close();
                    }
                }
                catch
                {
                }
            }
            public DataTable GetNikkyoStockCarDetail(long id)   //撈SQL車子資料
            {
                StringBuilder _SQL = new StringBuilder();   //在迴圈中將許多字串串連在一起時，可以使用 StringBuilder 類別來提升效能

                _SQL.AppendLine(" SELECT sh.maker, sh.cars, sh.model, sh.yy, sh.mm ");
                _SQL.AppendLine(" FROM shiire sh ");
                _SQL.AppendLine(" WHERE c_code = @CarID ");

                List<SqlParameter> paraList = new List<SqlParameter>();              
                //不採用SqlParameter，那麼當輸入的Sql語句出現歧義時，如字串中含有單引號，程式就會發生錯誤，並且他人可以輕易地通過拼接Sql語句來進行注入攻擊。
              
                paraList.Add(new SqlParameter("@CarID", id));
                return ExecuteSQLCommand(_SQL.ToString(), paraList);
            }
            public DataTable GetUsedCarPhotoList(long carID)  //撈照片
            {
                StringBuilder _SQL = new StringBuilder();
                //_SQL.Clear();
                _SQL.AppendLine(" SELECT jpg.category, jpg.url 'jpg_url' ");
                _SQL.AppendLine(" FROM stock_car_photos_main jpg ");
                _SQL.AppendLine(" WHERE jpg.c_code = @CarID  ");                

                List<SqlParameter> paraList = new List<SqlParameter>();
                paraList.Add(new SqlParameter("@CarID", carID));
                return ExecuteSQLCommand(_SQL.ToString(), paraList);
            }
            private DataTable ExecuteSQLCommand(string sql, List<SqlParameter> paraList)
            {
                var cmd = new SqlCommand(sql, NikkyoSQLConnection);

                if (paraList != null)
                    cmd.Parameters.AddRange(paraList.ToArray<SqlParameter>());
                //AddRange添加實現了接口IEnumerable<T>的一個泛型集合的所有元素到指定泛型集合末尾

                SqlDataReader dr = cmd.ExecuteReader(); //SqlCommand類別方法，行傳回(查詢、抓取)資料列(紀錄)的命令。
                DataTable _return_dt = new DataTable();
                _return_dt.Load(dr);
                dr.Close();
                cmd.Parameters.Clear();
                cmd.Dispose();    //釋放Component 所使用的資源

                return _return_dt;
            }
            //public UsedCarDetailEntity GetStockCarDetail(long carID)
            //{
            //    NikkyoSQLDataAccess corpDAL = new NikkyoSQLDataAccess();
            //    try
            //    {
            //        corpDAL.OpenNikkyoSQLConnection();
            //        DataTable _dt = corpDAL.GetNikkyoStockCarDetail(carID);
            //        if (_dt == null || _dt.Rows.Count == 0)
            //        {
            //            return null;
            //        }
            //        else //if(_dt != null && _dt.Rows.Count > 0)
            //        {
            //            string maker, cars, model;
            //            int yy, mm;
            //            DataRow _row = _dt.Rows[0];

            //            maker = _row["maker"].ToString();
            //            cars = _row["cars"].ToString();
            //            model = _row["model"].ToString();
            //            yy = int.Parse(_row["yy"].ToString());
            //            mm = int.Parse(_row["mm"].ToString());
            //        }
            //    }
            //    finally
            //    { corpDAL.CloseNikkyoSQLConnection(); }
            //    return null;
            //}
            //public DataTable GetCarDetailMegaData(long NewCarID)
            //{
            //    string _SQL;

            //    _SQL = "SELECT [c_code]" +
            //        ",  dbo.get_1st_thumb_no_category(c_code, 'b') AS 'photo_url'" +
            //        ", [maker],[cars],[model],[yy],[mm]" +
            //        "  FROM [dbo].[shiire] " +
            //        "  WHERE C_CODE = @NewCarID";

            //    List<SqlParameter> paraList = new List<SqlParameter>();
            //    paraList.Add(new SqlParameter("@NewCarID", NewCarID));

            //    //paraList.Add(new SqlParameter("@NewCarID", NewCarID));

            //    return ExecuteSQLCommand(_SQL.ToString(), paraList);

            //}         
            //public static  DataTable GetCarDetailMegaData(long NewCarID)
            //{
            //    NikkyoSQLDataAccess corpDAL = new NikkyoSQLDataAccess();
            //    try
            //    {
            //        corpDAL.OpenNikkyoSQLConnection();
            //        DataTable _dt = corpDAL.GetCarDetailMegaData(NewCarID);
            //        return _dt;
            //    }
            //    finally
            //    {
            //        corpDAL.CloseNikkyoSQLConnection();
            //    }
            //}
            public DataTable GetCarDetailMegaData(long NewCarID)
            {
                string _SQL;

                _SQL = "SELECT [c_code]" +
                    ",  dbo.get_1st_thumb_no_category(c_code, 'b') AS 'photo_url'" +
                    ", [maker],[cars],[model],[yy],[mm]" +
                    "  FROM [dbo].[shiire] " +
                    "  WHERE C_CODE = @NewCarID";

                List<SqlParameter> paraList = new List<SqlParameter>();
                paraList.Add(new SqlParameter("@NewCarID", NewCarID));
                return ExecuteSQLCommand(_SQL.ToString(), paraList);

            }
        }
        



    }
}