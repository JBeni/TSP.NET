using LibraryEntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace LibraryEntityFramework.Repository
{
    public class ReaderRepository
    {
        public List<CITITOR> VerifyReaderByName(string numeCititor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CITITORs.Where(x => (x.Nume.Trim() + " " + x.Prenume.Trim()) == numeCititor.Trim()).ToList();
            }
        }

        public List<CITITOR> GetAllReaders()
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CITITORs.ToList();
            }
        }

        public List<CITITOR> GetReaderById(int cititorId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CITITORs.Where(t => t.CititorId == cititorId).ToList();
            }
        }

        public List<CITITOR> GetReaderIdByName(string numeCititor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CITITORs.Where(t => (t.Nume.Trim() + " " + t.Prenume.Trim()) == numeCititor.Trim()).ToList();
            }
        }

        public List<CITITOR> GetReaderByName(string nameCititor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.CITITORs.Where(t => (t.Nume + " " + t.Prenume) == nameCititor).ToList();
            }
        }

        public CITITOR InsertReader(CITITOR cititor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.CITITORs.Add(cititor);
                context.SaveChanges();
                return cititor;
            }
        }

        public CITITOR UpdateReader(CITITOR cititor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.CITITORs.AddOrUpdate(cititor);
                context.SaveChanges();
                return cititor;
            }
        }

        public void DeleteReader(CITITOR cititor)
        {
            try
            {
                using (var context = new ModelDatabaseFirst())
                {
                    context.CITITORs.Remove(cititor);
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
