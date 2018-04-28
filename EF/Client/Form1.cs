using LibraryEntityFramework.Context;
using LibraryEntityFramework.Repository;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryWindowsForm
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);


        public Form1()
        {
            InitializeComponent();
        }


        private void InsertImprumut_Click(object sender, EventArgs e)
        {
            var book = new BookRepository();
            var loan = new LoanRepository();
            var reader = new ReaderRepository();
            int flag = 0;
            
            var exista_carte = book.VerifyBookByTitle(boxNumeCarteInsertImprumut.Text.Trim());
            var exista_cititor = reader.VerifyReaderByName(boxNumeCititorInsertImprumut.Text.Trim());

            if (exista_carte.LongCount() > 0)
            {
                var queryBook1 = book.GetBookIdByTitle(boxNumeCarteInsertImprumut.Text.Trim());
                int idCarte = queryBook1[0].CarteId;

                if (exista_cititor.LongCount() > 0)
                {
                    var queryReader = reader.GetReaderIdByName(boxNumeCititorInsertImprumut.Text.Trim());
                    int idCititor = queryReader[0].CititorId;

                    int nrCartiDupaTitluCARTE = book.GetNumberOfExistingBooksByTitle(boxNumeCarteInsertImprumut.Text.Trim());

                    int nrCartiImprumutateDupaTitlu = book.GetNumberOfBorrowedBooksByTitle(boxNumeCarteInsertImprumut.Text.Trim());

                    if (nrCartiImprumutateDupaTitlu == nrCartiDupaTitluCARTE)
                    {
                        var queryDataToLoan = book.ShowDateToBorrowBook(boxNumeCarteInsertImprumut.Text.Trim());

                        MessageBox((IntPtr)0, "Cartea nu este disponibila pentru a fi imprumutata!\n Data la care poate fi imprumutata este: " + queryDataToLoan + "\n", "Message Box", 0);
                    }
                    else
                    {
                        MessageBox((IntPtr)0, "Cartea este disponibila pentru a fi imprumutata!", "Message Box", 0);
                        flag = 1;
                    }

                    if (flag == 1)
                    {
                        DateTime dataImprumut = DateTime.Now;
                        DateTime dataScadenta = dataImprumut.AddDays(15);
                        DateTime restituire = new DateTime(1900, 1, 1);

                        IMPRUMUT imprumut = new IMPRUMUT()
                        {
                            CarteId = idCarte,
                            CititorId = idCititor,
                            DataImprumut = dataImprumut,
                            DataScadenta = dataScadenta,
                            DataRestituire = restituire,
                        };

                        loan.InsertLoan(imprumut);
                        MessageBox((IntPtr)0, "\nInsert Operation Completed", "Message Box", 0);
                    }
                }
                else
                {
                    MessageBox((IntPtr)0, "\nCititorul nu exista", "Message Box", 0);
                }
            }
            else
            {
                MessageBox((IntPtr)0, "\nCartea nu exista", "Message Box", 0);
            }

            boxNumeCarteInsertImprumut.Text = "";
            boxNumeCititorInsertImprumut.Text = "";
        }

        private void InsertCarte_Click(object sender, EventArgs e)
        {
            var genre = new GenreRepository();
            var author = new AuthorRepository();
            var book = new BookRepository();
            int genId = 0; int autorId = 0;

            var queryGen = genre.VerifyGenreByDescription(boxNumeGenInsertCarte.Text.Trim());
            if (queryGen.LongCount() > 0)
            {
                genId = queryGen[0].GenId;
            }
            else if (queryGen.LongCount() == 0)
            {
                GEN gen = new GEN()
                {
                    Descriere = boxNumeGenInsertCarte.Text.Trim(),
                };
                genId = genre.InsertGenre(gen).GenId;
            }

            var queryAutor = author.VerifyAuthorByName(boxNumeAutorInsertCarte.Text.Trim());
            if (queryAutor.LongCount() > 0)
            {
                autorId = queryAutor[0].AutorId;
            }
            else if (queryAutor.LongCount() == 0)
            {
                string[] splited = boxNumeAutorInsertCarte.Text.Trim().Split(' ');

                AUTOR autor = new AUTOR()
                {
                    Nume = splited[0].Trim(),
                    Prenume = splited[1].Trim(),
                };
                autorId = author.InsertAuthor(autor).AutorId;
            }

            int nrExemplare = Convert.ToInt32(Math.Round(boxNrExemplareInsertCarte.Value, 0));
            int count_introduse = 0;
            while (count_introduse < nrExemplare)
            {
                CARTE carte = new CARTE()
                {
                    AutorId = autorId,
                    Titlu = boxTitluCarteInsertCarte.Text.Trim(),
                    GenId = genId,
                };

                book.InsertBook(carte);
                count_introduse += 1;
            }

            MessageBox((IntPtr)0, "\nInsert Operation Completed", "Message Box", 0);

            boxNumeGenInsertCarte.Text = "";
            boxTitluCarteInsertCarte.Text = "";
            boxNumeAutorInsertCarte.Text = "";
            boxNrExemplareInsertCarte.Value = 0;
        }

        private void InsertReview_Click(object sender, EventArgs e)
        {
            var book = new BookRepository();
            var reader = new ReaderRepository();
            var review = new ReviewRepository();
            var loan = new LoanRepository();

            var queryCarteId = book.GetBookIdByTitle(boxTitluCarteInsertReview.Text.Trim());
            if (queryCarteId.LongCount() > 0)
            {
                int idCarte = queryCarteId[0].CarteId;

                var queryDateCarteImprumutata = loan.GetLoanIdByBookId(idCarte);
                queryDateCarteImprumutata[0].DataRestituire = DateTime.Now;
                loan.UpdateLoan(queryDateCarteImprumutata[0]);

                var queryDateImprumut = loan.GetLoanIdByBookId(idCarte);
                var queryCititorImprumut = loan.GetLoanIdByBookId(idCarte);

                if (queryDateImprumut[0].DataRestituire > queryDateImprumut[0].DataScadenta)
                {
                    var queryStareCititor = reader.GetReaderById(queryCititorImprumut[0].CititorId);
                    queryStareCititor[0].Stare = 1;
                    reader.UpdateReader(queryStareCititor[0]);
                }

                REVIEW rev = new REVIEW()
                {
                    Text = boxTextReviewInsertReview.Text.Trim(),
                    ImprumutId = queryDateImprumut[0].ImprumutId,
                };

                review.InsertReview(rev);
                MessageBox((IntPtr)0, "\nInsert Operation Completed", "Message Box", 0);
            }
            else
            {
                MessageBox((IntPtr)0, "\nCartea nu exista/este imprumutata", "Message Box", 0);
            }

            boxTitluCarteInsertReview.Text = "";
            boxTextReviewInsertReview.Text = "";
        }

        private void InsertCititor_Click(object sender, EventArgs e)
        {
            var reader = new ReaderRepository();
            string[] splited = boxNumeCititorInsertCititor.Text.Trim().Split(' ');

            var ctx = reader.VerifyReaderByName(boxNumeCititorInsertCititor.Text.Trim());
            if (ctx.LongCount() == 0)
            {
                CITITOR cititor = new CITITOR()
                {
                    Nume = splited[0].Trim(),
                    Prenume = splited[1].Trim(),
                    Adresa = boxAdresaCititorInsertCititor.Text.Trim(),
                    Email = boxEmailCititorInsertCititor.Text.Trim(),
                    Stare = 0,
                };

                reader.InsertReader(cititor);
                MessageBox((IntPtr)0, "\nInsert Operation Completed", "Message Box", 0);
            }
            else
            {
                MessageBox((IntPtr)0, "\nExista acest utilizator...", "Message Box", 0);
            }

            boxNumeCititorInsertCititor.Text = "";
            boxAdresaCititorInsertCititor.Text = "";
            boxEmailCititorInsertCititor.Text = "";
        }

        private void VerificareCarte_Click(object sender, EventArgs e)
        {
            var book = new BookRepository();
            var ctx = book.VerifyBookByTitle(boxTitluCarteVerificareCarte.Text.Trim());
            int nrCartiInregistrate = book.GetNumberOfExistingBooksByTitle(boxTitluCarteVerificareCarte.Text.Trim());

            if (ctx.LongCount() == 0)
            {
                MessageBox((IntPtr)0, "Cartea nu exista in biblioteca.", "Message Box", 0);
            }
            else
            {
                int nrCartiImprumutate = book.GetNumberOfBorrowedBooksByTitle(boxTitluCarteVerificareCarte.Text.Trim());

                string content = "";
                if (nrCartiInregistrate == nrCartiImprumutate)
                {
                    DateTime dataScadenta = book.ShowDateToBorrowBook(boxTitluCarteVerificareCarte.Text.Trim());

                    content += "\t" + dataScadenta + "\n";
                }
                else if (nrCartiInregistrate > nrCartiImprumutate)
                {
                    content = "Cartea exista in biblioteca.\nVa rugam sa completati formularul 'Imprumuta Carte' \n";
                }

                MessageBox((IntPtr)0, content, "Message Box", 0);
            }

            boxTitluCarteVerificareCarte.Text = "";
        }

        private void VerificareCititor_Click(object sender, EventArgs e)
        {
            var reader = new ReaderRepository();
            var ctx = reader.VerifyReaderByName(boxNumeCititorVerificareCititor.Text.Trim());
            
            if (ctx.LongCount() == 0)
            {
                MessageBox((IntPtr)0, "Nu sunteti inregistrati in baza de date. \n Va rugam completati formularul \n de la 'Inregistrare Cititor'", "Message Box", 0);
            }
            else if (ctx.LongCount() == 1)
            {
                int stare = ctx[0].Stare;

                string content = "Stare Cititor: " + stare + "\n";
                content += "Id Cititor: " + ctx[0].CititorId + "\n";
                MessageBox((IntPtr)0, content, "Message Box", 0);
            }

            boxNumeCititorVerificareCititor.Text = "";
        }

        private void AfiseazaPreferinte_Click(object sender, EventArgs e)
        {
            var book = new BookRepository();

            if (boxNumeGenAfiseazaPreferinte.Text.Length > 0 && boxNumeAutorAfiseazaPreferinte.Text.Length == 0 && boxNumeCarteAfiseazaPreferinte.Text.Length == 0)
            {
                var queris = book.GetAllBooksByGen(boxNumeGenAfiseazaPreferinte.Text.Trim());

                if (queris.LongCount() > 0)
                {
                    string content = "Carti dupa Genul: " + boxNumeGenAfiseazaPreferinte.Text.Trim() + "\n";
                    for (int i = 0; i < queris.LongCount(); i++)
                    {
                        content += "\t" + queris[i].Titlu + "\n";
                    }

                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    MessageBox((IntPtr)0, "Nu avem carti de acest gen...", "Message Box", 0);
                }
            }
            else if (boxNumeGenAfiseazaPreferinte.Text.Length == 0 && boxNumeAutorAfiseazaPreferinte.Text.Length > 0 && boxNumeCarteAfiseazaPreferinte.Text.Length == 0)
            {
                var queris = book.GetAllBooksByAuthor(boxNumeAutorAfiseazaPreferinte.Text.Trim());

                if (queris.LongCount() > 0)
                { 
                    string content = "Carti dupa Autorul: " + boxNumeAutorAfiseazaPreferinte.Text.Trim() + "\n";
                    for (int i = 0; i < queris.LongCount(); i++)
                    {
                        content += "\t" + queris[i].Titlu + "\n";
                    }

                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    MessageBox((IntPtr)0, "Nu avem carti cu acest autor...", "Message Box", 0);
                }
            }
            else if (boxNumeGenAfiseazaPreferinte.Text.Length == 0 && boxNumeAutorAfiseazaPreferinte.Text.Length == 0 && boxNumeCarteAfiseazaPreferinte.Text.Length > 0)
            {
                var queris = book.GetBookByTitle(boxNumeCarteAfiseazaPreferinte.Text.Trim());
                
                if (queris.LongCount() > 0)
                { 
                    string content = "Carti dupa Titlu \n";
                    for (int i = 0; i < queris.LongCount(); i++)
                    {
                        content += "\t" + queris[i].Titlu + "\n";
                    }

                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    MessageBox((IntPtr)0, "Nu avem carte cu acest nume...", "Message Box", 0);
                }
            }
            else if (boxNumeGenAfiseazaPreferinte.Text.Length == 0 && boxNumeAutorAfiseazaPreferinte.Text.Length > 0 && boxNumeCarteAfiseazaPreferinte.Text.Length > 0)
            {
                var queris = book.GetBooksByAuthorTitle(boxNumeAutorAfiseazaPreferinte.Text.Trim(), boxNumeCarteAfiseazaPreferinte.Text.Trim());
                
                if (queris.LongCount() > 0)
                { 
                    string content = "Carti dupa Autor & Titlu \n";
                    content += "Nume Autor: " + boxNumeAutorAfiseazaPreferinte.Text.Trim() + "\n";
                    for (int i = 0; i < queris.LongCount(); i++)
                    {
                        content += "\t" + queris[i].Titlu + "\n";
                    }

                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    MessageBox((IntPtr)0, "Nu avem carti cu acest autor si titlu...", "Message Box", 0);
                }
            }
            else if (boxNumeGenAfiseazaPreferinte.Text.Length > 0 && boxNumeAutorAfiseazaPreferinte.Text.Length > 0 && boxNumeCarteAfiseazaPreferinte.Text.Length > 0)
            {
                var queris = book.GetBooksByGenreAuthorTitle(boxNumeGenAfiseazaPreferinte.Text.Trim(), boxNumeAutorAfiseazaPreferinte.Text.Trim(), boxNumeCarteAfiseazaPreferinte.Text.Trim());

                if (queris.LongCount() > 0)
                {
                    string content = "Carti dupa Gen, Autor, Titlu \n";
                    content += "Nume Autor: " + boxNumeAutorAfiseazaPreferinte.Text.Trim() + "\n";
                    content += "Descriere Gen: " + boxNumeGenAfiseazaPreferinte.Text.Trim() + "\n";
                    for (int i = 0; i < queris.LongCount(); i++)
                    {
                        content += "\t" + queris[i].Titlu + "\n";
                    }

                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    MessageBox((IntPtr)0, "Nu avem carti cu acest gen, autor si titlu...", "Message Box", 0);
                }
            }

            boxNumeGenAfiseazaPreferinte.Text = "";
            boxNumeAutorAfiseazaPreferinte.Text = "";
            boxNumeCarteAfiseazaPreferinte.Text = "";
        }

        // Statistici ...
        private void NrNumeCititori_Click(object sender, EventArgs e)
        {
            var statistics = new StatisticsRepository();
            DateTime startData = new DateTime(2018, 2, 4);
            DateTime stopData = new DateTime(2018, 3, 24);
            var ctx = statistics.GetAllReadersByPeriodTime(startData, stopData);

            string content = "Nr de Cititor intr-o perioada de timp\n";
            content += "Nr Cititor: " + ctx.LongCount() + "\n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tNume Cititor " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void CartiSolicitate_Click(object sender, EventArgs e)
        {
            var statistics = new StatisticsRepository();
            var ctx = statistics.GetAllRequestedBooks();

            string content = "Carti cele mai solicitate \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tTitlu " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void AutoriCautati_Click(object sender, EventArgs e)
        {
            var statistics = new StatisticsRepository();
            var ctx = statistics.GetAllWantedAuthors();

            string content = "Autorii cei mai cautati \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tAutor " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void GenuriSolicitate_Click(object sender, EventArgs e)
        {
            var statistics = new StatisticsRepository();
            var ctx = statistics.GetAllRequestedGenres();

            string content = "Genurile cele mai solicitate \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tGen " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void Review_uriCarte_Click(object sender, EventArgs e)
        {
            var statistics = new StatisticsRepository();
            var ctx = statistics.GetReviewByBookTitle(boxTitluCarteStatistica.Text.Trim());

            string content = "Review-uri pentru o carte \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tReview " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
            boxTitluCarteStatistica.Text = "";
        }


    }
}
