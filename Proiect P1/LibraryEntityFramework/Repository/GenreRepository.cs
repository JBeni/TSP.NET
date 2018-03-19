using LibraryEntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace LibraryEntityFramework.Repository
{
    public class GenreRepository
    {
        public List<GEN> VerifyGenreByDescription(string numeGen)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.GENs.Where(x => x.Descriere.Trim() == numeGen.Trim()).ToList();
            }
        }

        public List<GEN> GetAllGenres()
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.GENs.ToList();
            }
        }

        public List<GEN> GetGenreById(int genId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.GENs.Where(t => t.GenId == genId).ToList();
            }
        }

        public List<GEN> GetGenreByName(string numeGen)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.GENs.Where(x => x.Descriere == numeGen).ToList();
            }
        }

        public GEN InsertGenre(GEN gen)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.GENs.Add(gen);
                context.SaveChanges();
                return gen;
            }
        }

        public GEN UpdateGenre(GEN gen)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.GENs.AddOrUpdate(gen);
                context.SaveChanges();
                return gen;
            }
        }

        public void DeleteGenre(GEN gen)
        {
            try
            {
                using (var context = new ModelDatabaseFirst())
                {
                    context.GENs.Remove(gen);
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
