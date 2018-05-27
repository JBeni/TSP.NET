using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Web.Controllers
{
    public class ReviewController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AfisareReview()
        {
            var reviews = new ReviewViewModel
            {
                REVIEWs = repository.GetAllReviewsAsync().Result.ToList()
            };

            return View(reviews);
        }

        [HttpGet]
        public IActionResult InsertReview()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertReview(ReviewViewModel view)
        {
            var exista_cititor = repository.VerifyReaderByNameAsync(view.CITITOR.Nume.Trim() + " " + view.CITITOR.Prenume.Trim()).Result.ToList();
            var queryCititorId = repository.GetReaderAsync(exista_cititor[0].CititorId);

            var queryCarteImprumut = repository.GetLoanByBookTitleReaderIdAsync(view.CARTE.Titlu.Trim(), queryCititorId.Result.CititorId).Result.ToList();
            if (queryCarteImprumut.LongCount() == 0)
            {
                return RedirectToAction("NotPossible", "Home", view);
            }
            var queryCarteId = repository.GetBookAsync(queryCarteImprumut[0].CarteId);

            if (queryCarteId.Result.CarteId > 0)
            {
                int idCarte = queryCarteId.Result.CarteId;

                var queryDateCarteImprumutata = repository.GetLoanAsync(queryCarteImprumut[0].ImprumutId);

                IMPRUMUT loan = new IMPRUMUT
                {
                    DataRestituire = DateTime.Now,
                    ImprumutId = queryDateCarteImprumutata.Result.ImprumutId,
                    DataImprumut = queryDateCarteImprumutata.Result.DataImprumut,
                    DataScadenta = queryDateCarteImprumutata.Result.DataScadenta,
                    CititorId = queryDateCarteImprumutata.Result.CititorId,
                    CarteId = queryDateCarteImprumutata.Result.CarteId,
                };

                view.IMPRUMUT = loan;
                await repository.UpdateLoanAsync(view.IMPRUMUT);

                // issues, I think
                var queryDateImprumut = repository.GetLoanAsync(idCarte).Result;
                var queryCititorImprumut = repository.GetLoanAsync(idCarte).Result;

                if (queryDateImprumut.DataRestituire > queryDateImprumut.DataScadenta)
                {
                    var queryStareCititor = repository.GetReaderAsync(queryCititorImprumut.CititorId);
                    view.CITITOR.CititorId = queryStareCititor.Result.CititorId;
                    view.CITITOR.Nume = queryStareCititor.Result.Nume;
                    view.CITITOR.Prenume = queryStareCititor.Result.Prenume;
                    view.CITITOR.Email = queryStareCititor.Result.Email;
                    view.CITITOR.Adresa = queryStareCititor.Result.Adresa;
                    view.CITITOR.Stare = 1;
                    await repository.UpdateReaderAsync(view.CITITOR);
                }

                REVIEW review = new REVIEW
                {
                    Text = view.REVIEW.Text,
                    ImprumutId = queryDateImprumut.ImprumutId
                };

                view.REVIEW = review;
                await repository.InsertReviewAsync(view.REVIEW);
            }

            return RedirectToAction("AfisareReview", "Review", view);
        }

        [HttpGet]
        public IActionResult UpdateReview()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateReview(ReviewViewModel view)
        {
            await repository.UpdateReviewAsync(view.REVIEW);
            return RedirectToAction("AfisareReview", "Review", view);
        }

        [HttpGet]
        public IActionResult DeleteReview()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReview(ReviewViewModel view)
        {
            await repository.DeleteReviewAsync(view.REVIEW);
            return RedirectToAction("AfisareReview", "Review", view);
        }


    }
}
