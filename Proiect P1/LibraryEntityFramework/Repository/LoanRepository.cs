using LibraryEntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace LibraryEntityFramework.Repository
{
    public class LoanRepository
    {
        public List<IMPRUMUT> GetAllLoans()
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.IMPRUMUTs.ToList();
            }
        }

        public List<IMPRUMUT> GetLoanById(int imprumutId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.IMPRUMUTs.Where(t => t.ImprumutId == imprumutId).ToList();
            }
        }

        public List<IMPRUMUT> GetLoanIdByBookId(int carteId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.IMPRUMUTs.Where(t => t.CarteId == carteId).ToList();
            }
        }

        public List<IMPRUMUT> GetLoanByBookId(int carteId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.IMPRUMUTs.Where(t => t.CarteId == carteId).ToList();
            }
        }

        public IMPRUMUT InsertLoan(IMPRUMUT imprumut)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.IMPRUMUTs.Add(imprumut);
                context.SaveChanges();
                return imprumut;
            }
        }

        public IMPRUMUT UpdateLoan(IMPRUMUT imprumut)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.IMPRUMUTs.AddOrUpdate(imprumut);
                context.SaveChanges();
                return imprumut;
            }
        }

        public void DeleteLoan(IMPRUMUT imprumut)
        {
            try
            {
                using (var context = new ModelDatabaseFirst())
                {
                    context.IMPRUMUTs.Remove(imprumut);
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
