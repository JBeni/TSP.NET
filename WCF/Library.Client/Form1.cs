using Library.Data.Entities;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Library.Client
{
    public partial class Form1 : Form
    {
        private readonly LibraryServicesClient service = new LibraryServicesClient();

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);

        public Form1()
        {
            InitializeComponent();
        }


        private void InsertCarte_Click(object sender, EventArgs e)
        {
            int genId = 0; int autorId = 0;

            var queryGen = service.VerifyGenreByDescription(boxNumeGenInsertCarte.Text.Trim());
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
                service.InsertGenre(gen);
                genId = gen.GenId;
            }

            var queryAutor = service.VerifyAuthorByName(boxNumeAutorInsertCarte.Text.Trim());
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
                service.InsertAuthor(autor);
                autorId = autor.AutorId;
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

                service.InsertBook(carte);
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
            var exista_cititor = service.VerifyReaderByName(boxNumeCititorInsertReview.Text.Trim());
            var queryCititorId = service.GetReader(exista_cititor[0].CititorId);

            var queryCarteImprumut = service.GetLoanByBookTitleReaderId(boxTitluCarteInsertReview.Text.Trim(), queryCititorId.CititorId);
            var queryCarteId = service.GetBook(queryCarteImprumut[0].CarteId);

            if (queryCarteId.CarteId > 0)
            {
                int idCarte = queryCarteId.CarteId;

                var queryDateCarteImprumutata = service.GetLoan(queryCarteImprumut[0].ImprumutId);
                queryDateCarteImprumutata.DataRestituire = DateTime.Now;
                service.UpdateLoan(queryDateCarteImprumutata);

                // issues, I think
                var queryDateImprumut = service.GetLoan(idCarte);
                var queryCititorImprumut = service.GetLoan(idCarte);

                if (queryDateImprumut.DataRestituire > queryDateImprumut.DataScadenta)
                {
                    var queryStareCititor = service.GetReader(queryCititorImprumut.CititorId);
                    queryStareCititor.Stare = 1;
                    service.UpdateReader(queryStareCititor);
                }

                REVIEW rev = new REVIEW()
                {
                    Text = boxTextReviewInsertReview.Text.Trim(),
                    ImprumutId = queryDateImprumut.ImprumutId,
                };

                service.InsertReview(rev);
                MessageBox((IntPtr)0, "\nInsert Operation Completed", "Message Box", 0);
            }
            else
            {
                MessageBox((IntPtr)0, "\nCartea nu exista/este imprumutata", "Message Box", 0);
            }

            boxTitluCarteInsertReview.Text = "";
            boxNumeCititorInsertReview.Text = "";
            boxTextReviewInsertReview.Text = "";
        }

        private void InsertCititor_Click(object sender, EventArgs e)
        {
            string[] splited = boxNumeCititorInsertCititor.Text.Trim().Split(' ');

            var ctx = service.VerifyReaderByName(boxNumeCititorInsertCititor.Text.Trim());
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

                service.InsertReader(cititor);
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
            var ctx = service.VerifyBookByTitle(boxTitluCarteVerificareCarte.Text.Trim());
            int nrCartiInregistrate = service.GetNumberOfExistingBooksByTitle(boxTitluCarteVerificareCarte.Text.Trim());

            if (ctx.LongCount() == 0)
            {
                MessageBox((IntPtr)0, "Cartea nu exista in biblioteca.", "Message Box", 0);
            }
            else
            {
                int nrCartiImprumutate = service.GetNumberOfBorrowedBooksByTitle(boxTitluCarteVerificareCarte.Text.Trim());

                string content = "";
                if (nrCartiInregistrate == nrCartiImprumutate)
                {
                    DateTime dataScadenta = service.ShowDateToBorrowBook(boxTitluCarteVerificareCarte.Text.Trim());

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
            var ctx = service.VerifyReaderByName(boxNumeCititorVerificareCititor.Text.Trim());
            
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
            if (boxNumeGenAfiseazaPreferinte.Text.Length > 0 && boxNumeAutorAfiseazaPreferinte.Text.Length == 0 && boxNumeCarteAfiseazaPreferinte.Text.Length == 0)
            {
                var queris = service.GetAllBooksByGen(boxNumeGenAfiseazaPreferinte.Text.Trim());

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
                var queris = service.GetAllBooksByAuthor(boxNumeAutorAfiseazaPreferinte.Text.Trim());

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
                // POSIBLE, ANOTHER ISSUE
                var queris = service.GetBookByTitle(boxNumeCarteAfiseazaPreferinte.Text.Trim());

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
                var queris = service.GetBooksByAuthorTitle(boxNumeAutorAfiseazaPreferinte.Text.Trim(), boxNumeCarteAfiseazaPreferinte.Text.Trim());
                
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
                var queris = service.GetBooksByGenreAuthorTitle(boxNumeGenAfiseazaPreferinte.Text.Trim(), boxNumeAutorAfiseazaPreferinte.Text.Trim(), boxNumeCarteAfiseazaPreferinte.Text.Trim());

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
            DateTime startData = new DateTime(2018, 2, 4);
            DateTime stopData = new DateTime(2018, 3, 24);
            var ctx = service.GetAllReadersByPeriodTime(startData, stopData);

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
            var ctx = service.GetAllRequestedBooks();

            string content = "Carti cele mai solicitate \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tTitlu " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void AutoriCautati_Click(object sender, EventArgs e)
        {
            var ctx = service.GetAllWantedAuthors();

            string content = "Autorii cei mai cautati \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tAutor " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void GenuriSolicitate_Click(object sender, EventArgs e)
        {
            var ctx = service.GetAllRequestedGenres();

            string content = "Genurile cele mai solicitate \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tGen " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
        }

        private void Review_uriCarte_Click(object sender, EventArgs e)
        {
            var ctx = service.GetReviewByBookTitle(boxTitluCarteStatistica.Text.Trim());

            string content = "Review-uri pentru o carte \n";
            for (int index = 0; index < ctx.LongCount(); index++)
            {
                content += "\tReview " + (index + 1) + ": " + ctx[index] + "\n";
            }

            MessageBox((IntPtr)0, content, "Message Box", 0);
            boxTitluCarteStatistica.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }


    }
}
