using Library.Web.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Web.Controllers
{
    public class ReaderController : Controller
    {
        private readonly LibraryServicesClient repository = new LibraryServicesClient();


        public IActionResult AfisareCititori()
        {
            var readers = new ReaderViewModel
            {
                CITITORs = repository.GetAllReadersAsync().Result.ToList()
            };

            return View(readers);
        }

        public IActionResult VerificaCititor(ReaderViewModel view)
        {
            var ctx = repository.VerifyReaderByNameAsync(view.CITITOR.Nume.Trim() + " " + view.CITITOR.Prenume.Trim()).Result.ToList();

            if (ctx.LongCount() == 0)
            {
                ;
				//MessageBox((IntPtr)0, "Nu sunteti inregistrati in baza de date. \n Va rugam completati formularul \n de la 'Inregistrare Cititor'", "Message Box", 0);
            }
            else if (ctx.LongCount() == 1)
            {
                int stare = ctx[0].Stare;

                string content = "Stare Cititor: " + stare + "\n";
				//content += "Id Cititor: " + ctx[0].CititorId + "\n";
				//MessageBox((IntPtr)0, content, "Message Box", 0);
            }

            return View();
        }

        [HttpGet]
        public IActionResult InsertReader()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> InsertReader(ReaderViewModel view)
        {
            await repository.InsertReaderAsync(view.CITITOR);
            return RedirectToAction("AfisareCititori", "Listare", view);
        }

        [HttpGet]
        public IActionResult UpdateReader()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateReader(ReaderViewModel view)
        {
            await repository.UpdateReaderAsync(view.CITITOR);
            return RedirectToAction("AfisareCititori", "Reader", view);
        }

        [HttpGet]
        public IActionResult DeleteReader()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReader(ReaderViewModel view)
        {
            await repository.DeleteReaderAsync(view.CITITOR);
            return RedirectToAction("AfisareCititori", "Reader", view);
        }

    }
}
