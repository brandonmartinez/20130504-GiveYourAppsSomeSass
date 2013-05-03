using System.Web.Mvc;

namespace DoDN_MVC.Controllers
{
    public class HomeController : Controller
    {
        #region public

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to FVNUG Day of .NET!";

            return View();
        }

        #endregion
    }
}