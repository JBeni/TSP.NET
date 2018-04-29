using Library.Data.Entities;
using Library.Services.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;


namespace Library.Services
{
    [ServiceContract]
    public interface ILibraryServices
    {
        [OperationContract]  GEN       GetGenre(int id);
        [OperationContract]  AUTOR     GetAuthor(int id);
        [OperationContract]  CARTE     GetBook(int id);
        [OperationContract]  IMPRUMUT  GetLoan(int id);
        [OperationContract]  CITITOR   GetReader(int id);
        [OperationContract]  REVIEW    GetReview(int id);

        [OperationContract]  List<GEN>      VerifyGenreByDescription(string numeGen);
        [OperationContract]  List<AUTOR>    VerifyAuthorByName(string numeAutor);
        [OperationContract]  List<CARTE>    VerifyBookByTitle(string titluCarte);
        [OperationContract]  List<CITITOR>  VerifyReaderByName(string numeCititor);

        [OperationContract]  List<GEN>       GetAllGenres();
        [OperationContract]  List<AUTOR>     GetAllAuthors();
        [OperationContract]  List<CARTE>     GetAllBooks();
        [OperationContract]  List<IMPRUMUT>  GetAllLoans();
        [OperationContract]  List<CITITOR>   GetAllReaders();
        [OperationContract]  List<REVIEW>    GetAllReviews();

        [OperationContract]  List<CARTE>  GetBookByTitle(string titluCarte);
        [OperationContract]  List<CARTE>  GetAllBooksByGen(string genCarte);
        [OperationContract]  List<CARTE>  GetAllBooksByAuthor(string numeAutor);
        [OperationContract]  List<CARTE>  GetBooksByAuthorTitle(string numeAutor, string titluCarte);
        [OperationContract]  List<CARTE>  GetBooksByGenreAuthorTitle(string numeGen, string numeAutor, string titluCarte);

        [OperationContract]  List<IMPRUMUT>  GetLoanByBookTitleReaderId(string titluCarte, int cititorId);
        [OperationContract]  List<IMPRUMUT>  GetLoanByBookId(int carteId);

        [OperationContract]  int       GetNumberOfExistingBooksByTitle(string titluCarte);
        [OperationContract]  int       GetNumberOfBorrowedBooksByTitle(string titluCarte);
        [OperationContract]  DateTime  ShowDateToBorrowBook(string titluCarte);

        // Statistics
        [OperationContract]  List<string>  GetAllReadersByPeriodTime(DateTime dataStart, DateTime dataStop);
        [OperationContract]  List<string>    GetAllRequestedBooks();
        [OperationContract]  List<string>    GetAllWantedAuthors();
        [OperationContract]  List<string>    GetAllRequestedGenres();
        [OperationContract]  List<string>    GetReviewByBookTitle(string titluCarte);

        // Insert, Update, Delete
        [OperationContract]  Response  InsertGenre(GEN gen);
        [OperationContract]  Response  InsertAuthor(AUTOR autor);
        [OperationContract]  Response  InsertBook(CARTE carte);
        [OperationContract]  Response  InsertLoan(IMPRUMUT imprumut);
        [OperationContract]  Response  InsertReader(CITITOR cititor);
        [OperationContract]  Response  InsertReview(REVIEW review);

        [OperationContract]  Response  UpdateGenre(GEN gen);
        [OperationContract]  Response  UpdateAuthor(AUTOR autor);
        [OperationContract]  Response  UpdateBook(CARTE carte);
        [OperationContract]  Response  UpdateLoan(IMPRUMUT imprumut);
        [OperationContract]  Response  UpdateReader(CITITOR cititor);
        [OperationContract]  Response  UpdateReview(REVIEW review);

        [OperationContract]  Response  DeleteGenre(GEN gen);
        [OperationContract]  Response  DeleteAuthor(AUTOR autor);
        [OperationContract]  Response  DeleteBook(CARTE carte);
        [OperationContract]  Response  DeleteLoan(IMPRUMUT imprumut);
        [OperationContract]  Response  DeleteReader(CITITOR cititor);
        [OperationContract]  Response  DeleteReview(REVIEW review);

    }
}
