using LibraryEntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace LibraryEntityFramework.Repository
{
    public class AuthorRepository
    {
        public List<AUTOR> VerifyAuthorByName(string numeAutor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.AUTORs.Where(x => (x.Nume.Trim() + " " + x.Prenume.Trim()) == numeAutor.Trim()).ToList();
            }
        }

        public List<AUTOR> GetAllAuthors()
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.AUTORs.ToList();
            }
        }

        public List<AUTOR> GetAuthorById(int autorId)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.AUTORs.Where(t => t.AutorId == autorId).ToList();
            }
        }

        public List<AUTOR> GetAuthorByName(string numeAutor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                return context.AUTORs.Where(x => (x.Nume.Trim() + " " + x.Prenume.Trim()) == numeAutor.Trim()).ToList();
            }
        }

        public AUTOR InsertAuthor(AUTOR autor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.AUTORs.Add(autor);
                context.SaveChanges();
                return autor;
            }
        }

        public AUTOR UpdateAuthor(AUTOR autor)
        {
            using (var context = new ModelDatabaseFirst())
            {
                context.AUTORs.AddOrUpdate(autor);
                context.SaveChanges();
                return autor;
            }
        }

        public void DeleteAuthor(AUTOR autor)
        {
            try
            {
                using (var context = new ModelDatabaseFirst())
                {
                    context.AUTORs.Remove(autor);
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
