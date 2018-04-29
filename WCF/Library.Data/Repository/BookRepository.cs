using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Context;


namespace Library.Data.Repository
{
    public class BookRepository
    {
        private static ModelServicesContainer context = new ModelServicesContainer();
        
        public BookRepository(ModelServicesContainer _context)
        {
        }


        public string InsertGenre(GEN gen)
        {
            try
            {
                context.GENs.Add(gen);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "";
        }

        public string InsertAuthor(AUTOR autor)
        {
            try
            {
                context.AUTORs.Add(autor);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string InsertBook(CARTE carte)
        {
            try
            {
                context.CARTEs.Add(carte);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string InsertLoan(IMPRUMUT imprumut)
        {
            try
            {
                context.IMPRUMUTs.Add(imprumut);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string InsertReader(CITITOR cititor)
        {
            try
            {
                context.CITITORs.Add(cititor);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string InsertReview(REVIEW review)
        {
            try
            {
                context.REVIEWs.Add(review);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string UpdateGenre(GEN gen)
        {
            var message = "";
            try
            {
                context.GENs.AddOrUpdate(gen);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public string UpdateAuthor(AUTOR autor)
        {
            var message = "";
            try
            {
                context.AUTORs.AddOrUpdate(autor);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public string UpdateBook(CARTE carte)
        {
            var message = "";
            try
            {
                context.CARTEs.AddOrUpdate(carte);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public string UpdateLoan(IMPRUMUT imprumut)
        {
            var message = "";
            try
            {
                context.IMPRUMUTs.AddOrUpdate(imprumut);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public string UpdateReader(CITITOR cititor)
        {
            var message = "";
            try
            {
                context.CITITORs.AddOrUpdate(cititor);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public string UpdateReview(REVIEW review)
        {
            var message = "";
            try
            {
                context.REVIEWs.AddOrUpdate(review);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }

        public string DeleteGenre(GEN gen)
        {
            var message = "";

            try
            {
                var toDelete = new GEN();
                toDelete = gen.GenId == 0 ? context.GENs.FirstOrDefault(t => t.GenId == gen.GenId) : context.GENs.FirstOrDefault(t => t.GenId == gen.GenId);

                if (toDelete != null)
                {
                    context.GENs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    message = "This genre does not exist or has already been deleted!";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

        public string DeleteAuthor(AUTOR autor)
        {
            var message = "";

            try
            {
                var toDelete = new AUTOR();
                toDelete = autor.AutorId == 0 ? context.AUTORs.FirstOrDefault(t => t.AutorId == autor.AutorId) : context.AUTORs.FirstOrDefault(t => t.AutorId == autor.AutorId);

                if (toDelete != null)
                {
                    context.AUTORs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    message = "This author does not exist or has already been deleted!";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

        public string DeleteBook(CARTE carte)
        {
            var message = "";

            try
            {
                var toDelete = new CARTE();
                toDelete = carte.CarteId == 0 ? context.CARTEs.FirstOrDefault(t => t.CarteId == carte.CarteId) : context.CARTEs.FirstOrDefault(t => t.CarteId == carte.CarteId);

                if (toDelete != null)
                {
                    context.CARTEs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    message = "This book does not exist or has already been deleted!";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

        public string DeleteLoan(IMPRUMUT imprumut)
        {
            var message = "";

            try
            {
                var toDelete = new IMPRUMUT();
                toDelete = imprumut.ImprumutId == 0 ? context.IMPRUMUTs.FirstOrDefault(t => t.ImprumutId == imprumut.ImprumutId) : context.IMPRUMUTs.FirstOrDefault(t => t.ImprumutId == imprumut.ImprumutId);

                if (toDelete != null)
                {
                    context.IMPRUMUTs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    message = "This loan does not exist or has already been deleted!";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

        public string DeleteReader(CITITOR cititor)
        {
            var message = "";

            try
            {
                var toDelete = new CITITOR();
                toDelete = cititor.CititorId == 0 ? context.CITITORs.FirstOrDefault(t => t.CititorId == cititor.CititorId) : context.CITITORs.FirstOrDefault(t => t.CititorId == cititor.CititorId);

                if (toDelete != null)
                {
                    context.CITITORs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    message = "This reader does not exist or has already been deleted!";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

        public string DeleteReview(REVIEW review)
        {
            var message = "";

            try
            {
                var toDelete = new REVIEW();

                toDelete = review.ReviewId == 0 ? context.REVIEWs.FirstOrDefault(t => t.ReviewId == review.ReviewId) : context.REVIEWs.FirstOrDefault(t => t.ReviewId == review.ReviewId);

                if (toDelete != null)
                {
                    context.REVIEWs.Remove(toDelete);
                    context.SaveChanges();
                }
                else
                {
                    message = "This review does not exist or has already been deleted!";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }


        public List<AUTOR> VerifyAuthorByName(string numeAutor)
        {
            return context.AUTORs.Where(t => (t.Nume.Trim() + " " + t.Prenume.Trim()) == numeAutor.Trim()).ToList();
        }

        public List<CARTE> VerifyBookByTitle(string titluCarte)
        {
            return context.CARTEs.Where(t => t.Titlu.Trim() == titluCarte.Trim()).ToList();
        }

        public List<GEN> VerifyGenreByDescription(string numeGen)
        {
            return context.GENs.Where(x => x.Descriere.Trim() == numeGen.Trim()).ToList();
        }

        public List<CITITOR> VerifyReaderByName(string numeCititor)
        {
            return context.CITITORs.Where(x => (x.Nume.Trim() + " " + x.Prenume.Trim()) == numeCititor.Trim()).ToList();
        }


        public GEN GetGenre(int genId)
        {
            return context.GENs.FirstOrDefault(x => x.GenId == genId);
        }

        public AUTOR GetAuthor(int autorId)
        {
            return context.AUTORs.FirstOrDefault(x => x.AutorId == autorId);
        }

        public CARTE GetBook(int carteId)
        {
            return context.CARTEs.Include("GEN").Include("AUTOR").FirstOrDefault(x => x.CarteId == carteId);
        }

        public IMPRUMUT GetLoan(int imprumutId)
        {
            return context.IMPRUMUTs.Include("CARTE").Include("CITITOR").FirstOrDefault(x => x.ImprumutId == imprumutId);
        }

        public CITITOR GetReader(int cititorId)
        {
            return context.CITITORs.FirstOrDefault(x => x.CititorId == cititorId);
        }

        public REVIEW GetReview(int reviewId)
        {
            return context.REVIEWs.FirstOrDefault(x => x.ReviewId == reviewId);
        }


        public List<GEN> GetAllGenres()
        {
            return context.GENs.ToList();
        }

        public List<AUTOR> GetAllAuthors()
        {
            return context.AUTORs.ToList();
        }

        public List<CARTE> GetAllBooks()
        {
            return context.CARTEs.ToList();
        }

        public List<IMPRUMUT> GetAllLoans()
        {
            return context.IMPRUMUTs.ToList();
        }

        public List<CITITOR> GetAllReaders()
        {
            return context.CITITORs.ToList();
        }

        public List<REVIEW> GetAllReviews()
        {
            return context.REVIEWs.ToList();
        }



        public int GetNumberOfExistingBooksByTitle(string titluCarte)
        {
            return context.CARTEs.Where(x => x.Titlu.Trim() == titluCarte.Trim()).Count();
        }

        public int GetNumberOfBorrowedBooksByTitle(string titluCarte)
        {
            DateTime restituire = new DateTime(1900, 1, 1);
            return context.IMPRUMUTs.Where(x => x.CarteId == x.CARTE.CarteId && x.CARTE.Titlu.Trim() == titluCarte.Trim() && x.DataRestituire == restituire).Count();
        }

        public DateTime ShowDateToBorrowBook(string titluCarte)
        {
            var queryDataMinimaCarte = context.IMPRUMUTs.Include("CARTE")
                .Where(s => s.CARTE.Titlu.Trim() == titluCarte.Trim()).OrderBy(t => t.DataScadenta).ToList();

            return queryDataMinimaCarte[0].DataScadenta;
        }


        public List<CARTE> GetAllBooksByGen(string genCarte)
        {
            return context.CARTEs.Where(t => t.GEN.Descriere.Trim() == genCarte.Trim()).Distinct().ToList();
        }

        public List<CARTE> GetAllBooksByAuthor(string numeAutor)
        {
            return context.CARTEs.Where(t => (t.AUTOR.Nume.Trim() + " " + t.AUTOR.Prenume.Trim()) == numeAutor.Trim()).Distinct().ToList();
        }

        public List<CARTE> GetBookByTitle(string titluCarte)
        {
            return context.CARTEs.Where(x => x.Titlu.Trim() == titluCarte.Trim()).Distinct().ToList();
        }

        public List<CARTE> GetBooksByAuthorTitle(string numeAutor, string titluCarte)
        {
            return context.CARTEs.Where(x => (x.AUTOR.Nume.Trim() + " " + x.AUTOR.Prenume.Trim()) == numeAutor.Trim() && x.Titlu.Trim() == titluCarte.Trim()).Distinct().ToList();
        }

        public List<CARTE> GetBooksByGenreAuthorTitle(string numeGen, string numeAutor, string titluCarte)
        {
            return context.CARTEs.Where(x => x.GEN.Descriere.Trim() == numeGen.Trim() && (x.AUTOR.Nume.Trim() + " " + x.AUTOR.Prenume.Trim()) == numeAutor.Trim() && x.Titlu.Trim() == titluCarte.Trim()).Distinct().ToList();
        }


        public List<IMPRUMUT> GetLoanByBookTitleReaderId(string titluCarte, int cititorId)
        {
           return context.IMPRUMUTs.Include("CARTE").Include("CITITOR").Where(t => t.CARTE.Titlu.Trim() == titluCarte.Trim() && t.CititorId == cititorId).ToList();
        }

        public List<IMPRUMUT> GetLoanByBookId(int carteId)
        {
            return context.IMPRUMUTs.Where(t => t.CarteId == carteId).ToList();
        }



        // 1. Numarul de cititori si care sunt acestia intr-o perioada de timp aleasa.
        public List<string> GetAllReadersByPeriodTime(DateTime dataStart, DateTime dataStop)
        {
            List<string> list = new List<string>();
            var queryCitiorImprumut = context.IMPRUMUTs.Include("CITITOR").Where(x => dataStart <= x.DataImprumut && x.DataImprumut <= dataStop).Distinct().ToList();

            for (int i = 0; i < queryCitiorImprumut.LongCount(); i++)
            {
                list.Add(queryCitiorImprumut[i].CITITOR.Nume.Trim() + " " + queryCitiorImprumut[i].CITITOR.Prenume.Trim());
            }

            return list;
        }

        // 2. Cele mai solicitate carti.
        public List<string> GetAllRequestedBooks()
        {
            List<string> list = new List<string>();
            var queryCarteImprumut = context.CARTEs
                .Join(context.IMPRUMUTs, carte => carte.CarteId,
                imprumut => imprumut.CarteId,
                (carte, imprumut) => new { carte.Titlu })
                .Distinct().ToList();

            for (int i = 0; i < queryCarteImprumut.LongCount(); i++)
            {
                list.Add(queryCarteImprumut[i].Titlu.Trim());
            }

            return list;
        }

        // 3. Autorii cei mai cautati.
        public List<string> GetAllWantedAuthors()
        {
            List<string> list = new List<string>();

            var queryAutorImprumut = context.AUTORs
                    .Join(context.CARTEs, autor => autor.AutorId,
                    carte => carte.AutorId,
                    (autor, carte) => new { autor.AutorId, carte.CarteId, autor.Nume, autor.Prenume })
                    .Join(context.IMPRUMUTs, combined => combined.CarteId,
                    imprumut => imprumut.CarteId,
                    (combined, gen) => new { combined.Nume, combined.Prenume })
                    .Distinct().ToList();

            for (int i = 0; i < queryAutorImprumut.LongCount(); i++)
            {
                list.Add(queryAutorImprumut[i].Nume.Trim() + " " + queryAutorImprumut[i].Prenume.Trim());
            }

            return list;
        }

        // 4. Genurile cele mai solicitate.
        public List<string> GetAllRequestedGenres()
        {
            List<string> list = new List<string>();

            var queryAutorImprumut = context.GENs
                    .Join(context.CARTEs, gen => gen.GenId,
                    carte => carte.GenId,
                    (gen, carte) => new { gen.GenId, gen.Descriere, carte.CarteId })
                    .Join(context.IMPRUMUTs, combined => combined.CarteId,
                    imprumut => imprumut.CarteId,
                    (combined, gen) => new { combined.Descriere })
                    .Distinct().ToList();

            for (int i = 0; i < queryAutorImprumut.LongCount(); i++)
            {
                list.Add(queryAutorImprumut[i].Descriere.Trim());
            }

            return list;
        }

        // 5. Review-urile pentru o anumita carte.
        public List<string> GetReviewByBookTitle(string titluCarte)
        {
            List<string> list = new List<string>();

            var queryReviewBook = context.REVIEWs
                    .Join(context.IMPRUMUTs, review => review.ImprumutId,
                    imprumut => imprumut.ImprumutId,
                    (review, imprumut) => new { imprumut.ImprumutId, imprumut.CarteId, review.Text })
                    .Join(context.CARTEs, combined => combined.CarteId,
                    carte => carte.CarteId,
                    (combined, carte) => new { carte.Titlu, combined.Text })
                    .Where(x => x.Titlu.Trim() == titluCarte.Trim())
                    .ToList();

            for (int i = 0; i < queryReviewBook.LongCount(); i++)
            {
                list.Add(queryReviewBook[i].Text.Trim());
            }

            return list;
        }


    }
}
