using Fitness_Asp.Net_Project.Areas.Admin.Models;
using Fitness_Asp.Net_Project.DAL;
using System.Web.Mvc;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {   

        public ActionResult Index()
        {

            return View();
        }

    }
}
