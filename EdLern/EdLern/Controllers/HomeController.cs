using EdLern.Models;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace EdLern.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            //Add Records into generic list
            List<City> obj = new List<City>()
            {
               new City {Text="Latur",Value=1,IsChecked=false },
               new City {Text="Mumbai",Value=2,IsChecked=true },
               new City {Text="Pune",Value=2,IsChecked=false },
               new City {Text="Noida",Value=2,IsChecked=false },
            };
            CityList objBind = new CityList();
            objBind.Cities = obj;
            return View(objBind);
        }

        //Post and get checkbox checked records
        [HttpPost]
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

        public ActionResult Locations()
        {

            return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}