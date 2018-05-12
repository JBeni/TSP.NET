using AutoMapper;
using Library.Data.Entities;
using Library.Data.Context;
using Library.Data.Repository;
using System;
using System.Collections.Generic;
using Library.Services.Models;


namespace Library.Services.Repository
{
    public class BookServices
    {
        private static BookRepository _bookRepository = new BookRepository(new ModelServicesContainer());
        
        public BookServices()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Data.Entities.AUTOR, Services.Entities.AUTOR>().ReverseMap();
                config.CreateMap<Data.Entities.GEN, Services.Entities.GEN>().ReverseMap();
                config.CreateMap<Data.Entities.CARTE, Services.Entities.CARTE>().ReverseMap();
                config.CreateMap<Data.Entities.IMPRUMUT, Services.Entities.IMPRUMUT>().ReverseMap();
                config.CreateMap<Data.Entities.CITITOR, Services.Entities.CITITOR>().ReverseMap();
                config.CreateMap<Data.Entities.REVIEW, Services.Entities.REVIEW>().ReverseMap();
            });
        }


        public Response InsertGenre(GEN gen)
        {
            var response = new Response();
            var mapped = Mapper.Map<GEN, Data.Entities.GEN>(gen);
            var reply = _bookRepository.InsertGenre(mapped);
            if (reply == "")
            {
                response.Messages.Add("The genre has been successfully added!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response InsertAuthor(AUTOR autor)
        {
            var response = new Response();
            var mapped = Mapper.Map<AUTOR, Data.Entities.AUTOR>(autor);
            var reply = _bookRepository.InsertAuthor(mapped);
            if (reply == "")
            {
                response.Messages.Add("The author has been successfully added!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response InsertBook(CARTE carte)
        {
            var response = new Response();
            var mapped = Mapper.Map<CARTE, Data.Entities.CARTE>(carte);
            var reply = _bookRepository.InsertBook(mapped);
            if (reply == "")
            {
                response.Messages.Add("The book has been successfully added!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response InsertLoan(IMPRUMUT imprumut)
        {
            var response = new Response();
            var mapped = Mapper.Map<IMPRUMUT, Data.Entities.IMPRUMUT>(imprumut);
            var reply = _bookRepository.InsertLoan(mapped);
            if (reply == "")
            {
                response.Messages.Add("The loan has been successfully added!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response InsertReader(CITITOR cititor)
        {
            var response = new Response();
            var mapped = Mapper.Map<CITITOR, Data.Entities.CITITOR>(cititor);
            var reply = _bookRepository.InsertReader(mapped);
            if (reply == "")
            {
                response.Messages.Add("The reader has been successfully added!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response InsertReview(REVIEW review)
        {
            var response = new Response();
            var mapped = Mapper.Map<REVIEW, Data.Entities.REVIEW>(review);
            var reply = _bookRepository.InsertReview(mapped);
            if (reply == "")
            {
                response.Messages.Add("The review has been successfully added!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }


        public Response UpdateGenre(GEN gen)
        {
            var response = new Response();
            var mapped = Mapper.Map<GEN, Data.Entities.GEN>(gen);
            var reply = _bookRepository.UpdateGenre(mapped);
            if (reply == "")
            {
                response.Messages.Add("The genre has been successfully updated!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response UpdateAuthor(AUTOR autor)
        {
            var response = new Response();
            var mapped = Mapper.Map<AUTOR, Data.Entities.AUTOR>(autor);
            var reply = _bookRepository.UpdateAuthor(mapped);
            if (reply == "")
            {
                response.Messages.Add("The author has been successfully updated!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response UpdateBook(CARTE carte)
        {
            var response = new Response();
            var mapped = Mapper.Map<CARTE, Data.Entities.CARTE>(carte);
            var reply = _bookRepository.UpdateBook(mapped);
            if (reply == "")
            {
                response.Messages.Add("The book has been successfully updated!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response UpdateLoan(IMPRUMUT imprumut)
        {
            var response = new Response();
            var mapped = Mapper.Map<IMPRUMUT, Data.Entities.IMPRUMUT>(imprumut);
            var reply = _bookRepository.UpdateLoan(mapped);
            if (reply == "")
            {
                response.Messages.Add("The loan has been successfully updated!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response UpdateReader(CITITOR cititor)
        {
            var response = new Response();
            var mapped = Mapper.Map<CITITOR, Data.Entities.CITITOR>(cititor);
            var reply = _bookRepository.UpdateReader(mapped);
            if (reply == "")
            {
                response.Messages.Add("The reader has been successfully updated!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response UpdateReview(REVIEW review)
        {
            var response = new Response();
            var mapped = Mapper.Map<REVIEW, Data.Entities.REVIEW>(review);
            var reply = _bookRepository.UpdateReview(mapped);
            if (reply == "")
            {
                response.Messages.Add("The review has been successfully updated!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        
        public Response DeleteGenre(GEN gen)
        {
            var response = new Response();
            var mapped = Mapper.Map<GEN, Data.Entities.GEN>(gen);
            var reply = _bookRepository.DeleteGenre(mapped);
            if (reply == "")
            {
                response.Messages.Add("The genre has been successfully deleted!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response DeleteAuthor(AUTOR autor)
        {
            var response = new Response();
            var mapped = Mapper.Map<AUTOR, Data.Entities.AUTOR>(autor);
            var reply = _bookRepository.DeleteAuthor(mapped);
            if (reply == "")
            {
                response.Messages.Add("The author has been successfully deleted!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response DeleteBook(CARTE carte)
        {
            var response = new Response();
            var mapped = Mapper.Map<CARTE, Data.Entities.CARTE>(carte);
            var reply = _bookRepository.DeleteBook(mapped);
            if (reply == "")
            {
                response.Messages.Add("The book has been successfully deleted!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response DeleteLoan(IMPRUMUT imprumut)
        {
            var response = new Response();
            var mapped = Mapper.Map<IMPRUMUT, Data.Entities.IMPRUMUT>(imprumut);
            var reply = _bookRepository.DeleteLoan(mapped);
            if (reply == "")
            {
                response.Messages.Add("The loan has been successfully deleted!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response DeleteReader(CITITOR cititor)
        {
            var response = new Response();
            var mapped = Mapper.Map<CITITOR, Data.Entities.CITITOR>(cititor);
            var reply = _bookRepository.DeleteReader(mapped);
            if (reply == "")
            {
                response.Messages.Add("The reader has been successfully deleted!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        public Response DeleteReview(REVIEW review)
        {
            var response = new Response();
            var mapped = Mapper.Map<REVIEW, Data.Entities.REVIEW>(review);
            var reply = _bookRepository.DeleteReview(mapped);
            if (reply == "")
            {
                response.Messages.Add("The review has been successfully deleted!");
            }
            else
            {
                response.Error = true;
                response.Messages.Add(reply);
            }

            return response;
        }

        
        public GEN GetGenre(int id)
        {
            var unmapped = _bookRepository.GetGenre(id);
            var result = Mapper.Map<Data.Entities.GEN, GEN>(unmapped);
            return result;
        }

        public AUTOR GetAuthor(int id)
        {
            var unmapped = _bookRepository.GetAuthor(id);
            var result = Mapper.Map<Data.Entities.AUTOR, AUTOR>(unmapped);
            return result;
        }

        public CARTE GetBook(int id)
        {
            var unmapped = _bookRepository.GetBook(id);
            var result = Mapper.Map<Data.Entities.CARTE, CARTE>(unmapped);
            return result;
        }

        public IMPRUMUT GetLoan(int id)
        {
            var unmapped = _bookRepository.GetLoan(id);
            var result = Mapper.Map<Data.Entities.IMPRUMUT, IMPRUMUT>(unmapped);
            return result;
        }

        public CITITOR GetReader(int id)
        {
            var unmapped = _bookRepository.GetReader(id);
            var result = Mapper.Map<Data.Entities.CITITOR, CITITOR>(unmapped);
            return result;
        }

        public REVIEW GetReview(int id)
        {
            var unmapped = _bookRepository.GetReview(id);
            var result = Mapper.Map<Data.Entities.REVIEW, REVIEW>(unmapped);
            return result;
        }


        public List<GEN> VerifyGenreByDescription(string numeGen)
        {
            var unmapped = _bookRepository.VerifyGenreByDescription(numeGen);
            var result = Mapper.Map<List<Data.Entities.GEN>, List<GEN>>(unmapped);
            return result;
        }

        public List<AUTOR> VerifyAuthorByName(string numeAutor)
        {
            var unmapped = _bookRepository.VerifyAuthorByName(numeAutor);
            var result = Mapper.Map<List<Data.Entities.AUTOR>, List<AUTOR>>(unmapped);
            return result;
        }

        public List<CARTE> VerifyBookByTitle(string titluCarte)
        {
            var unmapped = _bookRepository.VerifyBookByTitle(titluCarte);
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }

        public List<CITITOR> VerifyReaderByName(string numeCititor)
        {
            var unmapped = _bookRepository.VerifyReaderByName(numeCititor);
            var result = Mapper.Map<List<Data.Entities.CITITOR>, List<CITITOR>>(unmapped);
            return result;
        }


        public List<GEN> GetAllGenres()
        {
            var unmapped = _bookRepository.GetAllGenres();
            var result = Mapper.Map<List<Data.Entities.GEN>, List<GEN>>(unmapped);
            return result;
        }

        public List<AUTOR> GetAllAuthors()
        {
            var unmapped = _bookRepository.GetAllAuthors();
            var result = Mapper.Map<List<Data.Entities.AUTOR>, List<AUTOR>>(unmapped);
            return result;
        }

        public List<CARTE> GetAllBooks()
        {
            var unmapped = _bookRepository.GetAllBooks();
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }

        public List<IMPRUMUT> GetAllLoans()
        {
            var unmapped = _bookRepository.GetAllLoans();
            var result = Mapper.Map<List<Data.Entities.IMPRUMUT>, List<IMPRUMUT>>(unmapped);
            return result;
        }

        public List<CITITOR> GetAllReaders()
        {
            var unmapped = _bookRepository.GetAllReaders();
            var result = Mapper.Map<List<Data.Entities.CITITOR>, List<CITITOR>>(unmapped);
            return result;
        }

        public List<REVIEW> GetAllReviews()
        {
            var unmapped = _bookRepository.GetAllReviews();
            var result = Mapper.Map<List<Data.Entities.REVIEW>, List<REVIEW>>(unmapped);
            return result;
        }


        public List<CARTE> GetBookByTitle(string titluCarte)
        {
            var unmapped = _bookRepository.GetBookByTitle(titluCarte);
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }

        public List<CARTE> GetAllBooksByGen(string genCarte)
        {
            var unmapped = _bookRepository.GetAllBooksByGen(genCarte);
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }

        public List<CARTE> GetAllBooksByAuthor(string numeAutor)
        {
            var unmapped = _bookRepository.GetAllBooksByAuthor(numeAutor);
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }
        
        public List<CARTE> GetBooksByAuthorTitle(string numeAutor, string titluCarte)
        {
            var unmapped = _bookRepository.GetBooksByAuthorTitle(numeAutor, titluCarte);
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }

        public List<CARTE> GetBooksByGenreAuthorTitle(string numeGen, string numeAutor, string titluCarte)
        {
            var unmapped = _bookRepository.GetBooksByGenreAuthorTitle(numeGen, numeAutor, titluCarte);
            var result = Mapper.Map<List<Data.Entities.CARTE>, List<CARTE>>(unmapped);
            return result;
        }


        public List<IMPRUMUT> GetLoanByBookTitleReaderId(string titluCarte, int cititorId)
        {
            var unmapped = _bookRepository.GetLoanByBookTitleReaderId(titluCarte, cititorId);
            var result = Mapper.Map<List<Data.Entities.IMPRUMUT>, List<IMPRUMUT>>(unmapped);
            return result;
        }

        public List<IMPRUMUT> GetLoanByBookId(int carteId)
        {
            var unmapped = _bookRepository.GetLoanByBookId(carteId);
            var result = Mapper.Map<List<Data.Entities.IMPRUMUT>, List<IMPRUMUT>>(unmapped);
            return result;
        }


        public int GetNumberOfExistingBooksByTitle(string titluCarte)
        {
            return _bookRepository.GetNumberOfExistingBooksByTitle(titluCarte);
        }

        public int GetNumberOfBorrowedBooksByTitle(string titluCarte)
        {
            return _bookRepository.GetNumberOfBorrowedBooksByTitle(titluCarte);
        }

        public DateTime ShowDateToBorrowBook(string titluCarte)
        {
            return _bookRepository.ShowDateToBorrowBook(titluCarte);
        }


        // 1. Numarul de cititori si care sunt acestia intr-o perioada de timp aleasa.
        public List<string> GetAllReadersByPeriodTime(DateTime dataStart, DateTime dataStop)
        {
            return _bookRepository.GetAllReadersByPeriodTime(dataStart, dataStop);
        }

        // 2. Cele mai solicitate carti.
        public List<string> GetAllRequestedBooks()
        {
            return _bookRepository.GetAllRequestedBooks();
        }

        // 3. Autorii cei mai cautati.
        public List<string> GetAllWantedAuthors()
        {
            return _bookRepository.GetAllWantedAuthors();
        }

        // 4. Genurile cele mai solicitate.
        public List<string> GetAllRequestedGenres()
        {
            return _bookRepository.GetAllRequestedGenres();
        }

        // 5. Review-urile pentru o anumita carte.
        public List<string> GetReviewByBookTitle(string titluCarte)
        {
            return _bookRepository.GetReviewByBookTitle(titluCarte);
        }

    }
}
