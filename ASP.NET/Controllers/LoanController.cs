using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Controllers
{
    public class LoanController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult AfisareImprumuturi()
        {
            var loans = new LoanViewModel
            {
                IMPRUMUTs = repository.GetAllLoansAsync().Result.ToList()
            };

            return View(loans);
        }

        [HttpGet]
        public IActionResult InsertLoan()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertLoan(LoanViewModel view)
        {
            int cititorId = 0, carteId = 0;

            var exista_cititor = repository.VerifyReaderByNameAsync(view.CITITOR.Nume.Trim() + " " + view.CITITOR.Prenume.Trim()).Result.ToList();
            if (exista_cititor.LongCount() > 0)
            {
                var queryReader = repository.GetReaderAsync(exista_cititor[0].CititorId).Result;
                cititorId = queryReader.CititorId;

                int nrCartiDupaTitluCARTE = repository.GetNumberOfExistingBooksByTitleAsync(view.CARTE.Titlu.Trim()).Result;
                int nrCartiImprumutateDupaTitlu = repository.GetNumberOfBorrowedBooksByTitleAsync(view.CARTE.Titlu.Trim()).Result;

                if (nrCartiImprumutateDupaTitlu == nrCartiDupaTitluCARTE)
                {
                    var queryDataToLoan = repository.ShowDateToBorrowBookAsync(view.CARTE.Titlu.Trim()).Result;
                }
            }
            else
            {
                return RedirectToAction("NotPossible", "Home", view);
            }

            var exista_carte = repository.VerifyBookByTitleAsync(view.CARTE.Titlu.Trim()).Result.ToList();
            if (exista_carte.LongCount() > 0)
            {
                carteId = exista_carte[0].CarteId;
            }
            else
            {
                return RedirectToAction("NotPossible", "Home", view);
            }

            DateTime dataImprumut = DateTime.Now;
            DateTime dataScadenta = dataImprumut.AddDays(15);
            DateTime restituire = new DateTime(1900, 1, 1);

            IMPRUMUT loan = new IMPRUMUT
            {
                CarteId = carteId,
                CititorId = cititorId,
                DataImprumut = dataImprumut,
                DataScadenta = dataScadenta,
                DataRestituire = restituire,
            };

            view.IMPRUMUT = loan;
            await repository.InsertLoanAsync(view.IMPRUMUT);

            return RedirectToAction("AfisareImprumuturi", "Loan", view);
        }

        [HttpGet]
        public IActionResult UpdateLoan()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateLoan(LoanViewModel view)
        {
            await repository.UpdateLoanAsync(view.IMPRUMUT);
            return RedirectToAction("AfisareImprumuturi", "Loan", view);
        }

        [HttpGet]
        public IActionResult DeleteLoan()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLoan(LoanViewModel view)
        {
            await repository.DeleteLoanAsync(view.IMPRUMUT);
            return RedirectToAction("AfisareImprumuturi", "Loan", view);
        }

    }
}
