using Library.Data.Context;
using Library.Data.Repository;
using System;


namespace Library.Data
{
    public class Program
    {
        private static BookRepository book = new BookRepository(new ModelServicesContainer());

        public static void Main(string[] args)
        {
            //var t = book.GetAllWantedAuthors();
            var t = book.GetAllRequestedBooks();
            Console.WriteLine(t.Count);

            foreach (var item in t)
            {
                Console.WriteLine("\t " + item);
            }




            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


    }
}
