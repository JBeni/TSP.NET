using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Web.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult Index()
        {
            return View();
        }

        // 1. Numarul de cititori si care sunt acestia intr-o perioada de timp aleasa.
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Statistica1(StatisticsViewModel view)
        {
            var sta = new StatisticsViewModel()
            {
                ArrayReader = repository.GetAllReadersByPeriodTimeAsync(view.StartDate, view.StopDate).Result
            };
            
            return View(sta);
        }

        // 2. Cele mai solicitate carti.
        public IActionResult Statistica2()
        {
            var view = new StatisticsViewModel()
            { 
                ArrayBook = repository.GetAllRequestedBooksAsync().Result
            };

            return View(view);
        }

        // 3. Autorii cei mai cautati.
        public IActionResult Statistica3()
        {
            var view = new StatisticsViewModel()
            {
                ArrayAuthor = repository.GetAllWantedAuthorsAsync().Result
            };

            return View(view);
        }

        // 4. Genurile cele mai solicitate.
        public IActionResult Statistica4()
        {
            var view = new StatisticsViewModel()
            {
                ArrayGen = repository.GetAllRequestedGenresAsync().Result
            };

            return View(view);
        }

        // 5. Review-urile pentru o anumita carte.
        public IActionResult Statistica5()
        {
            var view = new StatisticsViewModel()
            {
                ArrayReview = repository.GetReviewByBookTitleAsync("Regele in Galben").Result
            };

            return View(view);
        }


    }
}
