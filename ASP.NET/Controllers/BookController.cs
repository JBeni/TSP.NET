using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult AfisareCarti()
        {
            var books = new BookViewModel
            {
                CARTEs = repository.GetAllBooksAsync().Result.ToList(),
                AUTORs = repository.GetAllAuthorsAsync().Result.ToList(),
                GENs = repository.GetAllGenresAsync().Result.ToList()
            };

            return View(books);
        }

        public IActionResult VerificaCarte(BookViewModel view)
        {
            var ctx = repository.VerifyBookByTitleAsync(view.CARTE.Titlu.Trim()).Result.ToList();
            int nrCartiInregistrate = repository.GetNumberOfExistingBooksByTitleAsync(view.CARTE.Titlu.Trim()).Result;

            if (ctx.LongCount() == 0)
            {
                ;
				//MessageBox((IntPtr)0, "Cartea nu exista in biblioteca.", "Message Box", 0);
            }
            else
            {
                int nrCartiImprumutate = repository.GetNumberOfBorrowedBooksByTitleAsync(view.CARTE.Titlu.Trim()).Result;

                if (nrCartiInregistrate == nrCartiImprumutate)
                {
                    DateTime dataScadenta = repository.ShowDateToBorrowBookAsync(view.CARTE.Titlu.Trim()).Result;
                }
                else if (nrCartiInregistrate > nrCartiImprumutate)
                {
                    ;
					//content = "Cartea exista in biblioteca.\nVa rugam sa completati formularul 'Imprumuta Carte' \n";
                }

				//MessageBox((IntPtr)0, content, "Message Box", 0);
            }

            return View(view);
        }

        [HttpGet]
        public IActionResult InsertBook()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertBook(BookViewModel view)
        {
            int genId = 0, autorId = 0;

            var author = repository.VerifyAuthorByNameAsync(view.AUTOR.Nume.Trim() + " " + view.AUTOR.Prenume.Trim()).Result.ToList();
            if (author.LongCount() > 0)
            {
                autorId = author[0].AutorId;
            }
            else
            {
                await repository.InsertAuthorAsync(view.AUTOR);
                autorId = view.AUTOR.AutorId;
            }
            view.CARTE.AutorId = autorId;

            var genre = repository.VerifyGenreByDescriptionAsync(view.GEN.Descriere.Trim()).Result.ToList();
            if (genre.LongCount() > 0)
            {
                genId = genre[0].GenId;
            }
            else
            {
                await repository.InsertGenreAsync(view.GEN);
                genId = view.GEN.GenId;
            }
            view.CARTE.GenId = genId;

            for (var it = 0; it < view.numarCarti; ++it)
            {
                await repository.InsertBookAsync(view.CARTE);
            }

            return RedirectToAction("AfisareCarti", "Book", view);
        }

        [HttpGet]
        public IActionResult UpdateBook()
        {
            return View();
        }
        
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateBook(BookViewModel view)
        {
            await repository.UpdateBookAsync(view.CARTE);
            return RedirectToAction("AfisareCarti", "Book", view);
        }

        [HttpGet]
        public IActionResult DeleteBook()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBook(BookViewModel view)
        {
            await repository.DeleteBookAsync(view.CARTE);
            return RedirectToAction("AfisareCarti", "Book", view);
        }

    }
}
