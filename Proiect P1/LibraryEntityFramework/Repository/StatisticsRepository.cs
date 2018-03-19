using LibraryEntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryEntityFramework.Repository
{
    public class StatisticsRepository
    {
        // 1. Numarul de cititori si care sunt acestia intr-o perioada de timp aleasa.
        public List<string> GetAllReadersByPeriodTime(DateTime dataStart, DateTime dataStop)
        {
            using (var context = new ModelDatabaseFirst())
            {
                List<string> list = new List<string>();
                var queryCitiorImprumut = context.IMPRUMUTs.Where(x => dataStart <= x.DataImprumut && x.DataImprumut <= dataStop).Distinct().ToList();

                for (int i = 0; i < queryCitiorImprumut.LongCount(); i++)
                {
                    list.Add(queryCitiorImprumut[i].CITITOR.Nume.Trim() + " " + queryCitiorImprumut[i].CITITOR.Prenume.Trim());
                }

                return list;
            }
        }

        // 2. Cele mai solicitate carti.
        public List<string> GetAllRequestedBooks()
        {
            using (var context = new ModelDatabaseFirst())
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
        }

        // 3. Autorii cei mai cautati.
        public List<string> GetAllWantedAuthors()
        {
            using (var context = new ModelDatabaseFirst())
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
        }

        // 4. Genurile cele mai solicitate.
        public List<string> GetAllRequestedGenres()
        {
            using (var context = new ModelDatabaseFirst())
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
        }

        // 5. Review-urile pentru o anumita carte.
        public List<string> GetReviewByBookTitle(string titluCarte)
        {
            using (var context = new ModelDatabaseFirst())
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
}
