using Checkout.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Checkout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TransUID(string transactionUid, string guid)
        {
            if (!(guid.Equals(ConfigurationManager.AppSettings.Get("SecurityKey"))))
            {
                throw new System.Web.HttpException(401, "Unauthorized Access");
            }
            IList<TransData> transaction = new List<TransData>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CheckoutDB"].ConnectionString))
            {
                conn.Open();
                transaction = conn.Query<TransData>("TransUIDSproc", new { TransactionUid = transactionUid }, commandType: CommandType.StoredProcedure).ToList();
                conn.Close();
            }
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AssocIdandDates(string associationId, string start, string end, string guid)
        {
            if (!(guid.Equals(ConfigurationManager.AppSettings.Get("SecurityKey"))))
            {
                throw new System.Web.HttpException(401, "Unauthorized Access");
            }
            IList<TransData> transaction = new List<TransData>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CheckoutDB"].ConnectionString))
            {
                conn.Open();
                transaction = conn.Query<TransData>("AssocIdandDatesSproc", new { AssocID = associationId, Start = start, End = end }, commandType: CommandType.StoredProcedure).ToList();
                conn.Close();
            }
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UserKey(string userkey, string guid)
        {
            if (!(guid.Equals(ConfigurationManager.AppSettings.Get("SecurityKey"))))
            {
                throw new System.Web.HttpException(401, "Unauthorized Access");
            }
            IList<TransData> transaction = new List<TransData>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CheckoutDB"].ConnectionString))
            {
                conn.Open();
                transaction = conn.Query<TransData>("UserKeySproc", new { UserKey = userkey }, commandType: CommandType.StoredProcedure).ToList();
                conn.Close();
            }
            return Json(transaction, JsonRequestBehavior.AllowGet);
        }
    }
}