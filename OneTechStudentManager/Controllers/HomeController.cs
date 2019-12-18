using System.Web.Mvc;
using OneTechStudentManager.Models;

namespace OneTechStudentManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bsc = new StudentClientService();
            var data = bsc.GetAllStudents();
            if (data != null)
            {
                return View(data);
            }
            else
            {
                ViewBag.Message = "List is empty or service offline";
                return View();
            }
        }

    }
}