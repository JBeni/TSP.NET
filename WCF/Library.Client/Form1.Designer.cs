namespace Library.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertCarte = new System.Windows.Forms.Button();
            this.TitluCarte = new System.Windows.Forms.Label();
            this.boxNrExemplareInsertCarte = new System.Windows.Forms.NumericUpDown();
            this.NumeAutor = new System.Windows.Forms.Label();
            this.boxNumeGenInsertCarte = new System.Windows.Forms.TextBox();
            this.NumeGen = new System.Windows.Forms.Label();
            this.boxNumeAutorInsertCarte = new System.Windows.Forms.TextBox();
            this.boxTitluCarteInsertCarte = new System.Windows.Forms.TextBox();
            this.NrExemplare = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNumeCititorInsertReview = new System.Windows.Forms.TextBox();
            this.boxTextReviewInsertReview = new System.Windows.Forms.RichTextBox();
            this.InsertReview = new System.Windows.Forms.Button();
            this.boxTitluCarteInsertReview = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.InsertCititor = new System.Windows.Forms.Button();
            this.boxEmailCititorInsertCititor = new System.Windows.Forms.TextBox();
            this.boxAdresaCititorInsertCititor = new System.Windows.Forms.TextBox();
            this.boxNumeCititorInsertCititor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.boxTitluCarteVerificareCarte = new System.Windows.Forms.TextBox();
            this.TitluCarteVerificare = new System.Windows.Forms.Label();
            this.VerificareCarte = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.boxNumeCititorVerificareCititor = new System.Windows.Forms.TextBox();
            this.VerificareCititor = new System.Windows.Forms.Button();
            this.NumeCititorVerificare = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.boxNumeCarteAfiseazaPreferinte = new System.Windows.Forms.TextBox();
            this.boxNumeAutorAfiseazaPreferinte = new System.Windows.Forms.TextBox();
            this.boxNumeGenAfiseazaPreferinte = new System.Windows.Forms.TextBox();
            this.AfiseazaPreferinte = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.boxTitluCarteStatistica = new System.Windows.Forms.TextBox();
            this.Review_uriCarte = new System.Windows.Forms.Button();
            this.GenuriSolicitate = new System.Windows.Forms.Button();
            this.AutoriCautati = new System.Windows.Forms.Button();
            this.CartiSolicitate = new System.Windows.Forms.Button();
            this.NrNumeCititori = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxNrExemplareInsertCarte)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achizitie Carte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InsertCarte);
            this.groupBox2.Controls.Add(this.TitluCarte);
            this.groupBox2.Controls.Add(this.boxNrExemplareInsertCarte);
            this.groupBox2.Controls.Add(this.NumeAutor);
            this.groupBox2.Controls.Add(this.boxNumeGenInsertCarte);
            this.groupBox2.Controls.Add(this.NumeGen);
            this.groupBox2.Controls.Add(this.boxNumeAutorInsertCarte);
            this.groupBox2.Controls.Add(this.boxTitluCarteInsertCarte);
            this.groupBox2.Controls.Add(this.NrExemplare);
            this.groupBox2.Location = new System.Drawing.Point(11, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inregistrare Carte";
            // 
            // InsertCarte
            // 
            this.InsertCarte.Location = new System.Drawing.Point(48, 123);
            this.InsertCarte.Name = "InsertCarte";
            this.InsertCarte.Size = new System.Drawing.Size(81, 23);
            this.InsertCarte.TabIndex = 9;
            this.InsertCarte.Text = "Insert Carte";
            this.InsertCarte.UseVisualStyleBackColor = true;
            this.InsertCarte.Click += new System.EventHandler(this.InsertCarte_Click);
            // 
            // TitluCarte
            // 
            this.TitluCarte.AutoSize = true;
            this.TitluCarte.Location = new System.Drawing.Point(6, 26);
            this.TitluCarte.Name = "TitluCarte";
            this.TitluCarte.Size = new System.Drawing.Size(55, 13);
            this.TitluCarte.TabIndex = 0;
            this.TitluCarte.Text = "Titlu Carte";
            // 
            // boxNrExemplareInsertCarte
            // 
            this.boxNrExemplareInsertCarte.Location = new System.Drawing.Point(78, 97);
            this.boxNrExemplareInsertCarte.Name = "boxNrExemplareInsertCarte";
            this.boxNrExemplareInsertCarte.Size = new System.Drawing.Size(100, 20);
            this.boxNrExemplareInsertCarte.TabIndex = 8;
            // 
            // NumeAutor
            // 
            this.NumeAutor.AutoSize = true;
            this.NumeAutor.Location = new System.Drawing.Point(6, 52);
            this.NumeAutor.Name = "NumeAutor";
            this.NumeAutor.Size = new System.Drawing.Size(63, 13);
            this.NumeAutor.TabIndex = 1;
            this.NumeAutor.Text = "Nume Autor";
            // 
            // boxNumeGenInsertCarte
            // 
            this.boxNumeGenInsertCarte.Location = new System.Drawing.Point(78, 71);
            this.boxNumeGenInsertCarte.Name = "boxNumeGenInsertCarte";
            this.boxNumeGenInsertCarte.Size = new System.Drawing.Size(100, 20);
            this.boxNumeGenInsertCarte.TabIndex = 6;
            // 
            // NumeGen
            // 
            this.NumeGen.AutoSize = true;
            this.NumeGen.Location = new System.Drawing.Point(6, 78);
            this.NumeGen.Name = "NumeGen";
            this.NumeGen.Size = new System.Drawing.Size(58, 13);
            this.NumeGen.TabIndex = 2;
            this.NumeGen.Text = "Nume Gen";
            // 
            // boxNumeAutorInsertCarte
            // 
            this.boxNumeAutorInsertCarte.Location = new System.Drawing.Point(78, 45);
            this.boxNumeAutorInsertCarte.Name = "boxNumeAutorInsertCarte";
            this.boxNumeAutorInsertCarte.Size = new System.Drawing.Size(100, 20);
            this.boxNumeAutorInsertCarte.TabIndex = 4;
            // 
            // boxTitluCarteInsertCarte
            // 
            this.boxTitluCarteInsertCarte.Location = new System.Drawing.Point(78, 19);
            this.boxTitluCarteInsertCarte.Name = "boxTitluCarteInsertCarte";
            this.boxTitluCarteInsertCarte.Size = new System.Drawing.Size(100, 20);
            this.boxTitluCarteInsertCarte.TabIndex = 5;
            // 
            // NrExemplare
            // 
            this.NrExemplare.AutoSize = true;
            this.NrExemplare.Location = new System.Drawing.Point(6, 99);
            this.NrExemplare.Name = "NrExemplare";
            this.NrExemplare.Size = new System.Drawing.Size(70, 13);
            this.NrExemplare.TabIndex = 3;
            this.NrExemplare.Text = "Nr Exemplare";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.boxNumeCititorInsertReview);
            this.groupBox5.Controls.Add(this.boxTextReviewInsertReview);
            this.groupBox5.Controls.Add(this.InsertReview);
            this.groupBox5.Controls.Add(this.boxTitluCarteInsertReview);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(32, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 168);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Restituire Carte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume Cititor";
            // 
            // boxNumeCititorInsertReview
            // 
            this.boxNumeCititorInsertReview.Location = new System.Drawing.Point(78, 45);
            this.boxNumeCititorInsertReview.Name = "boxNumeCititorInsertReview";
            this.boxNumeCititorInsertReview.Size = new System.Drawing.Size(135, 20);
            this.boxNumeCititorInsertReview.TabIndex = 4;
            // 
            // boxTextReviewInsertReview
            // 
            this.boxTextReviewInsertReview.Location = new System.Drawing.Point(78, 71);
            this.boxTextReviewInsertReview.Name = "boxTextReviewInsertReview";
            this.boxTextReviewInsertReview.Size = new System.Drawing.Size(135, 60);
            this.boxTextReviewInsertReview.TabIndex = 3;
            this.boxTextReviewInsertReview.Text = "";
            // 
            // InsertReview
            // 
            this.InsertReview.Location = new System.Drawing.Point(52, 137);
            this.InsertReview.Name = "InsertReview";
            this.InsertReview.Size = new System.Drawing.Size(100, 23);
            this.InsertReview.TabIndex = 3;
            this.InsertReview.Text = "Insert Review";
            this.InsertReview.UseVisualStyleBackColor = true;
            this.InsertReview.Click += new System.EventHandler(this.InsertReview_Click);
            // 
            // boxTitluCarteInsertReview
            // 
            this.boxTitluCarteInsertReview.Location = new System.Drawing.Point(78, 19);
            this.boxTitluCarteInsertReview.Name = "boxTitluCarteInsertReview";
            this.boxTitluCarteInsertReview.Size = new System.Drawing.Size(135, 20);
            this.boxTitluCarteInsertReview.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Text Review";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Titlu Carte";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.InsertCititor);
            this.groupBox6.Controls.Add(this.boxEmailCititorInsertCititor);
            this.groupBox6.Controls.Add(this.boxAdresaCititorInsertCititor);
            this.groupBox6.Controls.Add(this.boxNumeCititorInsertCititor);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(282, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 128);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inregistrare Cititor";
            // 
            // InsertCititor
            // 
            this.InsertCititor.Location = new System.Drawing.Point(41, 94);
            this.InsertCititor.Name = "InsertCititor";
            this.InsertCititor.Size = new System.Drawing.Size(100, 23);
            this.InsertCititor.TabIndex = 6;
            this.InsertCititor.Text = "Insert Cititor";
            this.InsertCititor.UseVisualStyleBackColor = true;
            this.InsertCititor.Click += new System.EventHandler(this.InsertCititor_Click);
            // 
            // boxEmailCititorInsertCititor
            // 
            this.boxEmailCititorInsertCititor.Location = new System.Drawing.Point(78, 68);
            this.boxEmailCititorInsertCititor.Name = "boxEmailCititorInsertCititor";
            this.boxEmailCititorInsertCititor.Size = new System.Drawing.Size(100, 20);
            this.boxEmailCititorInsertCititor.TabIndex = 5;
            // 
            // boxAdresaCititorInsertCititor
            // 
            this.boxAdresaCititorInsertCititor.Location = new System.Drawing.Point(78, 39);
            this.boxAdresaCititorInsertCititor.Name = "boxAdresaCititorInsertCititor";
            this.boxAdresaCititorInsertCititor.Size = new System.Drawing.Size(100, 20);
            this.boxAdresaCititorInsertCititor.TabIndex = 4;
            // 
            // boxNumeCititorInsertCititor
            // 
            this.boxNumeCititorInsertCititor.Location = new System.Drawing.Point(78, 16);
            this.boxNumeCititorInsertCititor.Name = "boxNumeCititorInsertCititor";
            this.boxNumeCititorInsertCititor.Size = new System.Drawing.Size(100, 20);
            this.boxNumeCititorInsertCititor.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Email Cititor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adresa Cititor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nume Cititor";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.boxTitluCarteVerificareCarte);
            this.groupBox7.Controls.Add(this.TitluCarteVerificare);
            this.groupBox7.Controls.Add(this.VerificareCarte);
            this.groupBox7.Location = new System.Drawing.Point(504, 49);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 77);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Verificare Carte";
            // 
            // boxTitluCarteVerificareCarte
            // 
            this.boxTitluCarteVerificareCarte.Location = new System.Drawing.Point(82, 21);
            this.boxTitluCarteVerificareCarte.Name = "boxTitluCarteVerificareCarte";
            this.boxTitluCarteVerificareCarte.Size = new System.Drawing.Size(100, 20);
            this.boxTitluCarteVerificareCarte.TabIndex = 2;
            // 
            // TitluCarteVerificare
            // 
            this.TitluCarteVerificare.AutoSize = true;
            this.TitluCarteVerificare.Location = new System.Drawing.Point(6, 24);
            this.TitluCarteVerificare.Name = "TitluCarteVerificare";
            this.TitluCarteVerificare.Size = new System.Drawing.Size(55, 13);
            this.TitluCarteVerificare.TabIndex = 1;
            this.TitluCarteVerificare.Text = "Titlu Carte";
            // 
            // VerificareCarte
            // 
            this.VerificareCarte.Location = new System.Drawing.Point(47, 47);
            this.VerificareCarte.Name = "VerificareCarte";
            this.VerificareCarte.Size = new System.Drawing.Size(92, 23);
            this.VerificareCarte.TabIndex = 0;
            this.VerificareCarte.Text = "Verificare Carte";
            this.VerificareCarte.UseVisualStyleBackColor = true;
            this.VerificareCarte.Click += new System.EventHandler(this.VerificareCarte_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.boxNumeCititorVerificareCititor);
            this.groupBox8.Controls.Add(this.VerificareCititor);
            this.groupBox8.Controls.Add(this.NumeCititorVerificare);
            this.groupBox8.Location = new System.Drawing.Point(527, 168);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(193, 78);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Verificare Cititor";
            // 
            // boxNumeCititorVerificareCititor
            // 
            this.boxNumeCititorVerificareCititor.Location = new System.Drawing.Point(83, 19);
            this.boxNumeCititorVerificareCititor.Name = "boxNumeCititorVerificareCititor";
            this.boxNumeCititorVerificareCititor.Size = new System.Drawing.Size(100, 20);
            this.boxNumeCititorVerificareCititor.TabIndex = 2;
            // 
            // VerificareCititor
            // 
            this.VerificareCititor.Location = new System.Drawing.Point(41, 45);
            this.VerificareCititor.Name = "VerificareCititor";
            this.VerificareCititor.Size = new System.Drawing.Size(98, 23);
            this.VerificareCititor.TabIndex = 1;
            this.VerificareCititor.Text = "Verificare Cititor";
            this.VerificareCititor.UseVisualStyleBackColor = true;
            this.VerificareCititor.Click += new System.EventHandler(this.VerificareCititor_Click);
            // 
            // NumeCititorVerificare
            // 
            this.NumeCititorVerificare.AutoSize = true;
            this.NumeCititorVerificare.Location = new System.Drawing.Point(6, 22);
            this.NumeCititorVerificare.Name = "NumeCititorVerificare";
            this.NumeCititorVerificare.Size = new System.Drawing.Size(64, 13);
            this.NumeCititorVerificare.TabIndex = 0;
            this.NumeCititorVerificare.Text = "Nume Cititor";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.boxNumeCarteAfiseazaPreferinte);
            this.groupBox9.Controls.Add(this.boxNumeAutorAfiseazaPreferinte);
            this.groupBox9.Controls.Add(this.boxNumeGenAfiseazaPreferinte);
            this.groupBox9.Controls.Add(this.AfiseazaPreferinte);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(527, 279);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(193, 121);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Afisare Preferinte Carti";
            // 
            // boxNumeCarteAfiseazaPreferinte
            // 
            this.boxNumeCarteAfiseazaPreferinte.Location = new System.Drawing.Point(70, 61);
            this.boxNumeCarteAfiseazaPreferinte.Name = "boxNumeCarteAfiseazaPreferinte";
            this.boxNumeCarteAfiseazaPreferinte.Size = new System.Drawing.Size(100, 20);
            this.boxNumeCarteAfiseazaPreferinte.TabIndex = 6;
            // 
            // boxNumeAutorAfiseazaPreferinte
            // 
            this.boxNumeAutorAfiseazaPreferinte.Location = new System.Drawing.Point(70, 39);
            this.boxNumeAutorAfiseazaPreferinte.Name = "boxNumeAutorAfiseazaPreferinte";
            this.boxNumeAutorAfiseazaPreferinte.Size = new System.Drawing.Size(100, 20);
            this.boxNumeAutorAfiseazaPreferinte.TabIndex = 5;
            // 
            // boxNumeGenAfiseazaPreferinte
            // 
            this.boxNumeGenAfiseazaPreferinte.Location = new System.Drawing.Point(70, 16);
            this.boxNumeGenAfiseazaPreferinte.Name = "boxNumeGenAfiseazaPreferinte";
            this.boxNumeGenAfiseazaPreferinte.Size = new System.Drawing.Size(100, 20);
            this.boxNumeGenAfiseazaPreferinte.TabIndex = 4;
            // 
            // AfiseazaPreferinte
            // 
            this.AfiseazaPreferinte.Location = new System.Drawing.Point(41, 87);
            this.AfiseazaPreferinte.Name = "AfiseazaPreferinte";
            this.AfiseazaPreferinte.Size = new System.Drawing.Size(118, 23);
            this.AfiseazaPreferinte.TabIndex = 3;
            this.AfiseazaPreferinte.Text = "Afiseaza Preferinte";
            this.AfiseazaPreferinte.UseVisualStyleBackColor = true;
            this.AfiseazaPreferinte.Click += new System.EventHandler(this.AfiseazaPreferinte_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Nume Carte";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nume Autor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nume Gen";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.boxTitluCarteStatistica);
            this.groupBox10.Controls.Add(this.Review_uriCarte);
            this.groupBox10.Controls.Add(this.GenuriSolicitate);
            this.groupBox10.Controls.Add(this.AutoriCautati);
            this.groupBox10.Controls.Add(this.CartiSolicitate);
            this.groupBox10.Controls.Add(this.NrNumeCititori);
            this.groupBox10.Location = new System.Drawing.Point(766, 70);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(132, 186);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Statistici";
            // 
            // boxTitluCarteStatistica
            // 
            this.boxTitluCarteStatistica.Location = new System.Drawing.Point(22, 129);
            this.boxTitluCarteStatistica.Name = "boxTitluCarteStatistica";
            this.boxTitluCarteStatistica.Size = new System.Drawing.Size(100, 20);
            this.boxTitluCarteStatistica.TabIndex = 5;
            // 
            // Review_uriCarte
            // 
            this.Review_uriCarte.Location = new System.Drawing.Point(22, 153);
            this.Review_uriCarte.Name = "Review_uriCarte";
            this.Review_uriCarte.Size = new System.Drawing.Size(96, 23);
            this.Review_uriCarte.TabIndex = 4;
            this.Review_uriCarte.Text = "Review-uri Carte";
            this.Review_uriCarte.UseVisualStyleBackColor = true;
            this.Review_uriCarte.Click += new System.EventHandler(this.Review_uriCarte_Click);
            // 
            // GenuriSolicitate
            // 
            this.GenuriSolicitate.Location = new System.Drawing.Point(22, 100);
            this.GenuriSolicitate.Name = "GenuriSolicitate";
            this.GenuriSolicitate.Size = new System.Drawing.Size(96, 23);
            this.GenuriSolicitate.TabIndex = 3;
            this.GenuriSolicitate.Text = "Genuri Solicitate";
            this.GenuriSolicitate.UseVisualStyleBackColor = true;
            this.GenuriSolicitate.Click += new System.EventHandler(this.GenuriSolicitate_Click);
            // 
            // AutoriCautati
            // 
            this.AutoriCautati.Location = new System.Drawing.Point(22, 74);
            this.AutoriCautati.Name = "AutoriCautati";
            this.AutoriCautati.Size = new System.Drawing.Size(96, 23);
            this.AutoriCautati.TabIndex = 2;
            this.AutoriCautati.Text = "Autori Cautati";
            this.AutoriCautati.UseVisualStyleBackColor = true;
            this.AutoriCautati.Click += new System.EventHandler(this.AutoriCautati_Click);
            // 
            // CartiSolicitate
            // 
            this.CartiSolicitate.Location = new System.Drawing.Point(22, 48);
            this.CartiSolicitate.Name = "CartiSolicitate";
            this.CartiSolicitate.Size = new System.Drawing.Size(96, 23);
            this.CartiSolicitate.TabIndex = 1;
            this.CartiSolicitate.Text = "Carti Solicitate";
            this.CartiSolicitate.UseVisualStyleBackColor = true;
            this.CartiSolicitate.Click += new System.EventHandler(this.CartiSolicitate_Click);
            // 
            // NrNumeCititori
            // 
            this.NrNumeCititori.Location = new System.Drawing.Point(22, 24);
            this.NrNumeCititori.Name = "NrNumeCititori";
            this.NrNumeCititori.Size = new System.Drawing.Size(96, 23);
            this.NrNumeCititori.TabIndex = 0;
            this.NrNumeCititori.Text = "Nr/Nume Cititori";
            this.NrNumeCititori.UseVisualStyleBackColor = true;
            this.NrNumeCititori.Click += new System.EventHandler(this.NrNumeCititori_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "ImprumutaCarte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxNrExemplareInsertCarte)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown boxNrExemplareInsertCarte;
        private System.Windows.Forms.TextBox boxNumeGenInsertCarte;
        private System.Windows.Forms.TextBox boxTitluCarteInsertCarte;
        private System.Windows.Forms.TextBox boxNumeAutorInsertCarte;
        private System.Windows.Forms.Label NrExemplare;
        private System.Windows.Forms.Label NumeGen;
        private System.Windows.Forms.Label NumeAutor;
        private System.Windows.Forms.Label TitluCarte;
        private System.Windows.Forms.Button InsertCarte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button InsertReview;
        private System.Windows.Forms.TextBox boxTitluCarteInsertReview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox boxTextReviewInsertReview;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button InsertCititor;
        private System.Windows.Forms.TextBox boxEmailCititorInsertCititor;
        private System.Windows.Forms.TextBox boxAdresaCititorInsertCititor;
        private System.Windows.Forms.TextBox boxNumeCititorInsertCititor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox boxTitluCarteVerificareCarte;
        private System.Windows.Forms.Label TitluCarteVerificare;
        private System.Windows.Forms.Button VerificareCarte;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label NumeCititorVerificare;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox boxNumeCititorVerificareCititor;
        private System.Windows.Forms.Button VerificareCititor;
        private System.Windows.Forms.TextBox boxNumeCarteAfiseazaPreferinte;
        private System.Windows.Forms.TextBox boxNumeAutorAfiseazaPreferinte;
        private System.Windows.Forms.TextBox boxNumeGenAfiseazaPreferinte;
        private System.Windows.Forms.Button AfiseazaPreferinte;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button Review_uriCarte;
        private System.Windows.Forms.Button GenuriSolicitate;
        private System.Windows.Forms.Button AutoriCautati;
        private System.Windows.Forms.Button CartiSolicitate;
        private System.Windows.Forms.Button NrNumeCititori;
        private System.Windows.Forms.TextBox boxTitluCarteStatistica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNumeCititorInsertReview;
        private System.Windows.Forms.Button button1;
    }
}

