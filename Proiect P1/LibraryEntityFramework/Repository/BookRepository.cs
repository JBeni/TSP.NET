using System.Collections.Generic;
using System.Linq;
using System;
using System.Data.Entity.Migrations;
using LibraryEntityFramework.Context;

namespace LibraryEntityFramework.Repository
{
    public class BookRepository
    {
        public List<CARTE> VerifyBookByTitle(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(x => x.Titlu.Trim() == titluCarte.Trim()).ToList();
            }
        }

        public List<CARTE> GetAllBooks()
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.ToList();
            }
        }

        public int GetNumberOfExistingBooksByTitle(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(x => x.Titlu.Trim() == titluCarte.Trim()).Count();
            }
        }

        public int GetNumberOfBorrowedBooksByTitle(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                DateTime restituire = new DateTime(1900, 1, 1);
                return context.IMPRUMUTs.Where(x => x.CarteId == x.CARTE.CarteId && x.CARTE.Titlu.Trim() == titluCarte.Trim() && x.DataRestituire == restituire).Count();
            }
        }

        public DateTime ShowDateToBorrowBook(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                var queryDataMinimaCarte = context.CARTEs
                    .Join(context.IMPRUMUTs, carte => carte.CarteId,
                    imprumut => imprumut.CarteId,
                    (carte, imprumut) => new { dataScadenta = imprumut.DataScadenta, titlu = carte.Titlu })
                    .Where(s => s.titlu.Trim() == titluCarte.Trim()).OrderBy(t => t.dataScadenta).ToList();

                return queryDataMinimaCarte[0].dataScadenta;
            }
        }

        public List<CARTE> GetBookById(int carteId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(t => t.CarteId == carteId).ToList();
            }
        }

        public List<CARTE> GetBookIdByTitle(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(t => t.Titlu.Trim() == titluCarte.Trim()).ToList();
            }
        }

        public List<CARTE> GetAllBooksByGen(string genCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(t => t.GEN.Descriere.Trim() == genCarte.Trim()).Distinct().ToList();
            }
        }

        public List<CARTE> GetAllBooksByAuthor(string numeAutor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(t => (t.AUTOR.Nume.Trim() + " " + t.AUTOR.Prenume.Trim()) == numeAutor.Trim()).Distinct().ToList();
            }
        }

        public List<CARTE> GetBookByTitle(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(x => x.Titlu.Trim() == titluCarte.Trim()).Distinct().ToList();
            }
        }

        public List<CARTE> GetBooksByAuthorTitle(string numeAutor, string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(x => (x.AUTOR.Nume.Trim() + " " + x.AUTOR.Prenume.Trim()) == numeAutor.Trim() && x.Titlu.Trim() == titluCarte.Trim()).Distinct().ToList();
            }
        }

        public List<CARTE> GetBooksByGenreAuthorTitle(string numeGen, string numeAutor, string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CARTEs.Where(x => x.GEN.Descriere.Trim() == numeGen.Trim() && (x.AUTOR.Nume.Trim() + " " + x.AUTOR.Prenume.Trim()) == numeAutor.Trim() && x.Titlu.Trim() == titluCarte.Trim()).Distinct().ToList();
            }
        }

        public CARTE InsertBook(CARTE carte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.CARTEs.Add(carte);
                context.SaveChanges();
                return carte;
            }
        }

        public CARTE UpdateBook(CARTE carte)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.CARTEs.AddOrUpdate(carte);
                context.SaveChanges();
                return carte;
            }
        }

        public void DeleteBook(CARTE carte)
        {
            try
            {
                using (var context = new ModelDatabaseFirst())
                {
                    context.CARTEs.Remove(carte);
                    context.SaveChanges();
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
