using ContosoUniversity.Models;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            //Add Records into generic list
            List<CityModel> obj = new List<CityModel>()
            {
               new CityModel {Text="Latur",Value=1,IsChecked=false },
               new CityModel {Text="Mumbai",Value=2,IsChecked=true },
               new CityModel {Text="Pune",Value=2,IsChecked=false },
               new CityModel {Text="Noida",Value=2,IsChecked=false },
            };
            CityList objBind = new CityList
            {
                Cities = obj
            };
            return View(objBind);
        }

        //Post and get checkbox checked records
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CityList Obj)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Obj.Cities)
            {
                if (item.IsChecked)
                {
                    //append each checked records into StringBuilder
                    sb.Append(item.Text + ", ");
                }
            }
            //store location into viewbag
            ViewBag.Loc = "Your preferred work locations are " + sb.ToString();
            //return location view to display checked records using viewbag
            //return View("Locations");
            TempData["Hello"] = ViewBag.Loc;
            return PartialView("_Locations", ViewBag.Loc);
        }

        [HttpGet]
        public ActionResult Locations()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}