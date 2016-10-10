using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAssignmentOct.Models;

namespace WebAssignmentOct.Controllers
{
    public class HomeController : Controller
    {
        private List<Experience> Experiences;

        public HomeController()
        {
            Experiences = new List<Experience>();
            Experiences.Add(new Experience() { Title = "Målare", Description = "Målade farfars hus", Period = "2016" });
            Experiences.Add(new Experience() { Title = "Tryckare", Description = "Tryckte tidningar", Period = "2015-" });
            Experiences.Add(new Experience() { Title = "Försäljare", Description = "Sålde postkodlotter", Period = "2015" });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(Experiences);
        }
    }
}