using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Library.Web.Models;
using Library.Web.Models.EntityModels;
using ServiceReference;
using System.Linq;


namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listari()
        {
            return View();
        }

        public IActionResult NotPossible()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
