using System.Collections.Generic;
using System.Web.Mvc;

namespace WebAppFxMvc.Controllers
{
    public class ValuesController : Controller
    {
        // GET: Values
        public ActionResult Index()
        {
            return View();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            //using (var sqlConn = new SqlConnection(@"Data Source=(localdb)\\mssqllocaldb;Connect Timeout=30;Integrated Security=SSPI"))
            //{
            //    sqlConn.Open();

            //    //System.Threading.Thread.Sleep(5000);

            //    return new string[] { "value1", "value2" };
            //}

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }


        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}