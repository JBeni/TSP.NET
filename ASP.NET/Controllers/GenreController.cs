using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Web.Controllers
{
    public class GenreController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult AfisareGenuri()
        {
            var genres = new GenreViewModel
            {
                GENs = repository.GetAllGenresAsync().Result.ToList()
            };

            return View(genres);
        }

        [HttpGet]
        public IActionResult InsertGenre()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertGenre(GenreViewModel view)
        {
            await repository.InsertGenreAsync(view.GEN);
            return RedirectToAction("AfisareGenuri", "Listari", view);
        }

        [HttpGet]
        public IActionResult UpdateGenre()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateGenre(GenreViewModel view)
        {
            await repository.UpdateGenreAsync(view.GEN);
            return RedirectToAction("AfisareGenuri", "Genre", view);
        }

        [HttpGet]
        public IActionResult DeleteGenre()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteGenre(GenreViewModel view)
        {
            await repository.DeleteGenreAsync(view.GEN);
            return RedirectToAction("AfisareGenuri", "Genre", view);
        }

    }
}
