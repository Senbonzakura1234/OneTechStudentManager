using System.Web.Mvc;
using OneTechStudentManager.Models;

namespace OneTechStudentManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bsc = new StudentClientService();
            ViewBag.listStudents = bsc.GetAllStudents();
            return View(bsc.GetAllStudents());
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