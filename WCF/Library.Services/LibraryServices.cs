using System;
using System.Collections.Generic;
using System.ServiceModel;
using Library.Data.Entities;
using Library.Services.Models;
using Library.Services.Repository;


namespace Library.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class LibraryServices : ILibraryServices
    {
        private static BookServices _bookServices;

        public LibraryServices()
        {
            _bookServices = new BookServices();
        }


        public Response InsertAuthor(AUTOR autor)
        {
            return _bookServices.InsertAuthor(autor);
        }

        public Response InsertBook(CARTE carte)
        {
            return _bookServices.InsertBook(carte);
        }

        public Response InsertGenre(GEN gen)
        {
            return _bookServices.InsertGenre(gen);
        }

        public Response InsertLoan(IMPRUMUT imprumut)
        {
            return _bookServices.InsertLoan(imprumut);
        }

        public Response InsertReader(CITITOR cititor)
        {
            return _bookServices.InsertReader(cititor);
        }

        public Response InsertReview(REVIEW review)
        {
            return _bookServices.InsertReview(review);
        }


        public Response UpdateAuthor(AUTOR autor)
        {
            return _bookServices.UpdateAuthor(autor);
        }

        public Response UpdateBook(CARTE carte)
        {
            return _bookServices.UpdateBook(carte);
        }

        public Response UpdateGenre(GEN gen)
        {
            return _bookServices.UpdateGenre(gen);
        }

        public Response UpdateLoan(IMPRUMUT imprumut)
        {
            return _bookServices.UpdateLoan(imprumut);
        }

        public Response UpdateReader(CITITOR cititor)
        {
            return _bookServices.UpdateReader(cititor);
        }

        public Response UpdateReview(REVIEW review)
        {
            return _bookServices.UpdateReview(review);
        }


        public Response DeleteAuthor(AUTOR autor)
        {
            return _bookServices.DeleteAuthor(autor);
        }

        public Response DeleteBook(CARTE carte)
        {
            return _bookServices.DeleteBook(carte);
        }

        public Response DeleteGenre(GEN gen)
        {
            return _bookServices.DeleteGenre(gen);
        }

        public Response DeleteLoan(IMPRUMUT imprumut)
        {
            return _bookServices.DeleteLoan(imprumut);
        }

        public Response DeleteReader(CITITOR cititor)
        {
            return _bookServices.DeleteReader(cititor);
        }

        public Response DeleteReview(REVIEW review)
        {
            return _bookServices.DeleteReview(review);
        }


        public GEN GetGenre(int id)
        {
            return _bookServices.GetGenre(id);
        }
        
        public AUTOR GetAuthor(int id)
        {
            return _bookServices.GetAuthor(id);
        }

        public CARTE GetBook(int id)
        {
            return _bookServices.GetBook(id);
        }

        public IMPRUMUT GetLoan(int id)
        {
            return _bookServices.GetLoan(id);
        }

        public CITITOR GetReader(int id)
        {
            return _bookServices.GetReader(id);
        }

        public REVIEW GetReview(int id)
        {
            return _bookServices.GetReview(id);
        }


        public List<AUTOR> VerifyAuthorByName(string numeAutor)
        {
            return _bookServices.VerifyAuthorByName(numeAutor);
        }

        public List<CARTE> VerifyBookByTitle(string titluCarte)
        {
            return _bookServices.VerifyBookByTitle(titluCarte);
        }

        public List<GEN> VerifyGenreByDescription(string numeGen)
        {
            return _bookServices.VerifyGenreByDescription(numeGen);
        }

        public List<CITITOR> VerifyReaderByName(string numeCititor)
        {
            return _bookServices.VerifyReaderByName(numeCititor);
        }


        public List<AUTOR> GetAllAuthors()
        {
            return _bookServices.GetAllAuthors();
        }

        public List<CARTE> GetAllBooks()
        {
            return _bookServices.GetAllBooks();
        }

        public List<CARTE> GetAllBooksByAuthor(string numeAutor)
        {
            return _bookServices.GetAllBooksByAuthor(numeAutor);
        }

        public List<CARTE> GetAllBooksByGen(string genCarte)
        {
            return _bookServices.GetAllBooksByGen(genCarte);
        }

        public List<GEN> GetAllGenres()
        {
            return _bookServices.GetAllGenres();
        }

        public List<IMPRUMUT> GetAllLoans()
        {
            return _bookServices.GetAllLoans();
        }

        public List<CITITOR> GetAllReaders()
        {
            return _bookServices.GetAllReaders();
        }

        public List<REVIEW> GetAllReviews()
        {
            return _bookServices.GetAllReviews();
        }


        public List<CARTE> GetBookByTitle(string titluCarte)
        {
            return _bookServices.GetBookByTitle(titluCarte);
        }

        public List<CARTE> GetBooksByAuthorTitle(string numeAutor, string titluCarte)
        {
            return _bookServices.GetBooksByAuthorTitle(numeAutor, titluCarte);
        }

        public List<CARTE> GetBooksByGenreAuthorTitle(string numeGen, string numeAutor, string titluCarte)
        {
            return _bookServices.GetBooksByGenreAuthorTitle(numeGen, numeAutor, titluCarte);
        }

        public List<IMPRUMUT> GetLoanByBookId(int carteId)
        {
            return _bookServices.GetLoanByBookId(carteId);
        }

        public List<IMPRUMUT> GetLoanByBookTitleReaderId(string titluCarte, int cititorId)
        {
            return _bookServices.GetLoanByBookTitleReaderId(titluCarte, cititorId);
        }

        public List<IMPRUMUT> GetLoanIdByBookId(int carteId)
        {
            return _bookServices.GetLoanByBookId(carteId);
        }


        public int GetNumberOfExistingBooksByTitle(string titluCarte)
        {
            return _bookServices.GetNumberOfExistingBooksByTitle(titluCarte);
        }

        public int GetNumberOfBorrowedBooksByTitle(string titluCarte)
        {
            return _bookServices.GetNumberOfBorrowedBooksByTitle(titluCarte);
        }

        public DateTime ShowDateToBorrowBook(string titluCarte)
        {
            return _bookServices.ShowDateToBorrowBook(titluCarte);
        }


        // 1. Numarul de cititori si care sunt acestia intr-o perioada de timp aleasa.
        public List<string> GetAllReadersByPeriodTime(DateTime dataStart, DateTime dataStop)
        {
            return _bookServices.GetAllReadersByPeriodTime(dataStart, dataStop);
        }

        // 2. Cele mai solicitate carti.
        public List<string> GetAllRequestedBooks()
        {
            return _bookServices.GetAllRequestedBooks();
        }

        // 3. Autorii cei mai cautati.
        public List<string> GetAllWantedAuthors()
        {
            return _bookServices.GetAllWantedAuthors();
        }

        // 4. Genurile cele mai solicitate.
        public List<string> GetAllRequestedGenres()
        {
            return _bookServices.GetAllRequestedGenres();
        }

        // 5. Review-urile pentru o anumita carte.
        public List<string> GetReviewByBookTitle(string titluCarte)
        {
            return _bookServices.GetReviewByBookTitle(titluCarte);
        }

    }
}
