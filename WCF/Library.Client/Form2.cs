using Library.Data.Entities;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Library.Client
{
    public partial class Form2 : Form
    {
        private readonly LibraryServicesClient service = new LibraryServicesClient();

        public Form2()
        {
            InitializeComponent();
        }


        private void VerificareCititor_Click(object sender, EventArgs e)
        {
            listAfiseazaRaspuns.Items.Clear();

            var ctx = service.VerifyReaderByName(boxNumeCititorVerificareCititor.Text.Trim());
            
            if (ctx.LongCount() == 0)
            {
                listAfiseazaRaspuns.Items.Add("Nu sunteti inregistrati in baza de date. \n Va rugam completati formularul \n de la 'Inregistrare Cititor'");
//                MessageBox((IntPtr)0, "Nu sunteti inregistrati in baza de date. \n Va rugam completati formularul \n de la 'Inregistrare Cititor'", "Message Box", 0);
            }
            else if (ctx.LongCount() == 1)
            {
                int stare = ctx[0].Stare;

                string content = "Stare Cititor: " + stare + "\n";
                content += "Id Cititor: " + ctx[0].CititorId + "\n";

                listAfiseazaRaspuns.Items.Add(content);
//                MessageBox((IntPtr)0, content, "Message Box", 0);
            }

            boxNumeCititorVerificareCititor.Text = "";
        }

        private void AfiseazaPreferinte_Click(object sender, EventArgs e)
        {
            listAfiseazaRaspuns.Items.Clear();

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

                    listAfiseazaRaspuns.Items.Add(content);
//                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    listAfiseazaRaspuns.Items.Add("Nu avem carti de acest gen...");
//                    MessageBox((IntPtr)0, "Nu avem carti de acest gen...", "Message Box", 0);
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

                    listAfiseazaRaspuns.Items.Add(content);
//                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    listAfiseazaRaspuns.Items.Add("Nu avem carti cu acest autor...");
//                    MessageBox((IntPtr)0, "Nu avem carti cu acest autor...", "Message Box", 0);
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

                    listAfiseazaRaspuns.Items.Add(content);
//                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    listAfiseazaRaspuns.Items.Add("Nu avem carte cu acest nume...");
//                    MessageBox((IntPtr)0, "Nu avem carte cu acest nume...", "Message Box", 0);
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

                    listAfiseazaRaspuns.Items.Add(content);
//                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    listAfiseazaRaspuns.Items.Add("Nu avem carti cu acest autor si titlu...");
//                    MessageBox((IntPtr)0, "Nu avem carti cu acest autor si titlu...", "Message Box", 0);
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

                    listAfiseazaRaspuns.Items.Add(content);
//                    MessageBox((IntPtr)0, content, "Message Box", 0);
                }
                else
                {
                    listAfiseazaRaspuns.Items.Add("Nu avem carti cu acest gen, autor si titlu...");
//                    MessageBox((IntPtr)0, "Nu avem carti cu acest gen, autor si titlu...", "Message Box", 0);
                }
            }

            boxNumeGenAfiseazaPreferinte.Text = "";
            boxNumeAutorAfiseazaPreferinte.Text = "";
            boxNumeCarteAfiseazaPreferinte.Text = "";
        }

        private void InsertImprumut_Click_1(object sender, EventArgs e)
        {
            listAfiseazaRaspuns.Items.Clear();

            var services = new LibraryServicesClient();
            int flag = 0;

            var exista_carte = services.VerifyBookByTitle(titluCarteInsertImprumut.Text.Trim());
            var exista_cititor = services.VerifyReaderByName(numeCititorInsertImprumut.Text.Trim());

            if (exista_carte.LongCount() > 0)
            {
                var queryBook1 = services.GetBookByTitle(titluCarteInsertImprumut.Text.Trim());
                int idCarte = queryBook1[0].CarteId;

                if (exista_cititor.LongCount() > 0)
                {
                    var queryReader = services.GetReader(exista_cititor[0].CititorId);
                    int idCititor = queryReader.CititorId;

                    int nrCartiDupaTitluCARTE = services.GetNumberOfExistingBooksByTitle(titluCarteInsertImprumut.Text.Trim());

                    int nrCartiImprumutateDupaTitlu = services.GetNumberOfBorrowedBooksByTitle(titluCarteInsertImprumut.Text.Trim());

                    if (nrCartiImprumutateDupaTitlu == nrCartiDupaTitluCARTE)
                    {
                        var queryDataToLoan = services.ShowDateToBorrowBook(titluCarteInsertImprumut.Text.Trim());

                        listAfiseazaRaspuns.Items.Add("Cartea nu este disponibila pentru a fi imprumutata!\n Data la care poate fi imprumutata este: " + queryDataToLoan);
//                        MessageBox((IntPtr)0, "Cartea nu este disponibila pentru a fi imprumutata!\n Data la care poate fi imprumutata este: " + queryDataToLoan + "\n", "Message Box", 0);
                    }
                    else
                    {
                        listAfiseazaRaspuns.Items.Add("Cartea este disponibila pentru a fi imprumutata!");
//                        MessageBox((IntPtr)0, "Cartea este disponibila pentru a fi imprumutata!", "Message Box", 0);
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

                        services.InsertLoan(imprumut);
                        listAfiseazaRaspuns.Items.Add("Insert Operation Completed");
//                        MessageBox((IntPtr)0, "\nInsert Operation Completed", "Message Box", 0);
                    }
                }
                else
                {
                    listAfiseazaRaspuns.Items.Add("Cititorul nu exista");
//                    MessageBox((IntPtr)0, "\nCititorul nu exista", "Message Box", 0);
                }
            }
            else
            {
                listAfiseazaRaspuns.Items.Add("Cartea nu exista");
//                MessageBox((IntPtr)0, "\nCartea nu exista", "Message Box", 0);
            }

            titluCarteInsertImprumut.Text = "";
            numeCititorInsertImprumut.Text = "";
        }


    }
}
