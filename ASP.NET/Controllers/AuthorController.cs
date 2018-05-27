using ServiceReference;
using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult AfisareAutori()
        {
            var authors = new AuthorViewModel
            {
                AUTORs = repository.GetAllAuthorsAsync().Result.ToList()
            };

            return View(authors);
        }

        [HttpGet]
        public IActionResult InsertAuthor()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertAuthor(AuthorViewModel view)
        {
            await repository.InsertAuthorAsync(view.AUTOR);
            return RedirectToAction("AfisareAutori", "Author", view);
        }

        [HttpGet]
        public IActionResult UpdateAuthor()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAuthor(AuthorViewModel view)
        {
            await repository.UpdateAuthorAsync(view.AUTOR);
            return RedirectToAction("AfisareAutori", "Author", view);
        }

        [HttpGet]
        public IActionResult DeleteAuthor()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAuthor(AuthorViewModel view)
        {
            await repository.DeleteAuthorAsync(view.AUTOR);
            return RedirectToAction("AfisareAutori", "Author", view);
        }

    }
}
