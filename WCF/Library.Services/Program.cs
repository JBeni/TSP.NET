using Library.Data.Context;
using Library.Data.Repository;
using System;
using System.Linq;


namespace Library.Services
{
    public class Program
    {
        //private static BookRepository book = new BookRepository(new ModelServicesContainer());
        private static LibraryServices book = new LibraryServices();

        public static void Main(string[] args)
        {
            //var t = book.GetAllWantedAuthors();
            //var t = book.GetAllRequestedBooks();
            var t = book.GetAllAuthors();
            Console.WriteLine(t.Count);

            foreach (var item in t)
            {
                Console.WriteLine("\t " + item.Nume.Trim() + " " + item.Prenume.Trim());
            }




            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }


    }
}
