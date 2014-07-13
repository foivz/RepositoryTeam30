namespace GizmoApp
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.msIzbornik = new System.Windows.Forms.MenuStrip();
            this.miAplikacija = new System.Windows.Forms.ToolStripMenuItem();
            this.miAplikacijaIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miSkladiste = new System.Windows.Forms.ToolStripMenuItem();
            this.miSkladisteDodajSektor = new System.Windows.Forms.ToolStripMenuItem();
            this.miSkladistePretrazi = new System.Windows.Forms.ToolStripMenuItem();
            this.miProdaja = new System.Windows.Forms.ToolStripMenuItem();
            this.miProdajaDodajKupca = new System.Windows.Forms.ToolStripMenuItem();
            this.miProdajaPretraziKupce = new System.Windows.Forms.ToolStripMenuItem();
            this.miProdajaKreirajOtpremnicu = new System.Windows.Forms.ToolStripMenuItem();
            this.miNabava = new System.Windows.Forms.ToolStripMenuItem();
            this.miNabavaDodajDobavljaca = new System.Windows.Forms.ToolStripMenuItem();
            this.miNabavaPretraziDobavljace = new System.Windows.Forms.ToolStripMenuItem();
            this.miNabavaKreirajNarudzbenicu = new System.Windows.Forms.ToolStripMenuItem();
            this.miNabavaDodajKnjigu = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracija = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracijaDodajZaposlenika = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdministracijaUrediZaposlenika = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzvjesca = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzvjescaPopisZaposlenika = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocFAQ = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocKontakt = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomocOGizmoApp = new System.Windows.Forms.ToolStripMenuItem();
            this.odjel_has_PogledTableAdapter1 = new GizmoApp.GizmoDBDataSetTableAdapters.Odjel_has_PogledTableAdapter();
            this.miPomocKorisnickaDokumentacija = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.SystemColors.Window;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(12, 33);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKorisnickoIme.Size = new System.Drawing.Size(45, 13);
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Korime";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msIzbornik
            // 
            this.msIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAplikacija,
            this.miSkladiste,
            this.miProdaja,
            this.miNabava,
            this.miAdministracija,
            this.miIzvjesca,
            this.miPomoc});
            this.msIzbornik.Location = new System.Drawing.Point(0, 0);
            this.msIzbornik.Name = "msIzbornik";
            this.msIzbornik.Size = new System.Drawing.Size(739, 24);
            this.msIzbornik.TabIndex = 6;
            this.msIzbornik.Text = "menuStrip1";
            // 
            // miAplikacija
            // 
            this.miAplikacija.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAplikacijaIzlaz});
            this.miAplikacija.Name = "miAplikacija";
            this.miAplikacija.Size = new System.Drawing.Size(70, 20);
            this.miAplikacija.Text = "Aplikacija";
            // 
            // miAplikacijaIzlaz
            // 
            this.miAplikacijaIzlaz.Name = "miAplikacijaIzlaz";
            this.miAplikacijaIzlaz.Size = new System.Drawing.Size(96, 22);
            this.miAplikacijaIzlaz.Text = "Izlaz";
            this.miAplikacijaIzlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miAplikacijaIzlaz_MouseUp);
            // 
            // miSkladiste
            // 
            this.miSkladiste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSkladisteDodajSektor,
            this.miSkladistePretrazi});
            this.miSkladiste.Name = "miSkladiste";
            this.miSkladiste.Size = new System.Drawing.Size(65, 20);
            this.miSkladiste.Text = "Skladište";
            // 
            // miSkladisteDodajSektor
            // 
            this.miSkladisteDodajSektor.Name = "miSkladisteDodajSektor";
            this.miSkladisteDodajSektor.Size = new System.Drawing.Size(140, 22);
            this.miSkladisteDodajSektor.Text = "Dodaj sektor";
            this.miSkladisteDodajSektor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSkladisteDodajSektor_MouseUp);
            // 
            // miSkladistePretrazi
            // 
            this.miSkladistePretrazi.Name = "miSkladistePretrazi";
            this.miSkladistePretrazi.Size = new System.Drawing.Size(140, 22);
            this.miSkladistePretrazi.Text = "Pretraži";
            this.miSkladistePretrazi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSkladistePretrazi_MouseUp);
            // 
            // miProdaja
            // 
            this.miProdaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProdajaDodajKupca,
            this.miProdajaPretraziKupce,
            this.miProdajaKreirajOtpremnicu});
            this.miProdaja.Name = "miProdaja";
            this.miProdaja.Size = new System.Drawing.Size(59, 20);
            this.miProdaja.Text = "Prodaja";
            // 
            // miProdajaDodajKupca
            // 
            this.miProdajaDodajKupca.Name = "miProdajaDodajKupca";
            this.miProdajaDodajKupca.Size = new System.Drawing.Size(172, 22);
            this.miProdajaDodajKupca.Text = "Dodaj kupca";
            this.miProdajaDodajKupca.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miProdajaDodajKupca_MouseUp);
            // 
            // miProdajaPretraziKupce
            // 
            this.miProdajaPretraziKupce.Name = "miProdajaPretraziKupce";
            this.miProdajaPretraziKupce.Size = new System.Drawing.Size(172, 22);
            this.miProdajaPretraziKupce.Text = "Pretraži kupce";
            this.miProdajaPretraziKupce.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miProdajaPretraziKupce_MouseUp);
            // 
            // miProdajaKreirajOtpremnicu
            // 
            this.miProdajaKreirajOtpremnicu.Name = "miProdajaKreirajOtpremnicu";
            this.miProdajaKreirajOtpremnicu.Size = new System.Drawing.Size(172, 22);
            this.miProdajaKreirajOtpremnicu.Text = "Kreiraj otpremnicu";
            this.miProdajaKreirajOtpremnicu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miProdajaKreirajOtpremnicu_MouseUp);
            // 
            // miNabava
            // 
            this.miNabava.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNabavaDodajDobavljaca,
            this.miNabavaPretraziDobavljace,
            this.miNabavaKreirajNarudzbenicu,
            this.miNabavaDodajKnjigu});
            this.miNabava.Name = "miNabava";
            this.miNabava.Size = new System.Drawing.Size(59, 20);
            this.miNabava.Text = "Nabava";
            // 
            // miNabavaDodajDobavljaca
            // 
            this.miNabavaDodajDobavljaca.Name = "miNabavaDodajDobavljaca";
            this.miNabavaDodajDobavljaca.Size = new System.Drawing.Size(182, 22);
            this.miNabavaDodajDobavljaca.Text = "Dodaj dobavljača";
            this.miNabavaDodajDobavljaca.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miNabavaDodajDobavljaca_MouseUp);
            // 
            // miNabavaPretraziDobavljace
            // 
            this.miNabavaPretraziDobavljace.Name = "miNabavaPretraziDobavljace";
            this.miNabavaPretraziDobavljace.Size = new System.Drawing.Size(182, 22);
            this.miNabavaPretraziDobavljace.Text = "Pretraži dobavljače";
            this.miNabavaPretraziDobavljace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miNabavaPretraziDobavljace_MouseUp);
            // 
            // miNabavaKreirajNarudzbenicu
            // 
            this.miNabavaKreirajNarudzbenicu.Name = "miNabavaKreirajNarudzbenicu";
            this.miNabavaKreirajNarudzbenicu.Size = new System.Drawing.Size(182, 22);
            this.miNabavaKreirajNarudzbenicu.Text = "Kreiraj narudžbenicu";
            this.miNabavaKreirajNarudzbenicu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miNabavaKreirajNarudzbenicu_MouseUp);
            // 
            // miNabavaDodajKnjigu
            // 
            this.miNabavaDodajKnjigu.Name = "miNabavaDodajKnjigu";
            this.miNabavaDodajKnjigu.Size = new System.Drawing.Size(182, 22);
            this.miNabavaDodajKnjigu.Text = "Dodaj knjigu";
            this.miNabavaDodajKnjigu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miNabavaDodajKnjigu_MouseUp);
            // 
            // miAdministracija
            // 
            this.miAdministracija.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdministracijaDodajZaposlenika,
            this.miAdministracijaUrediZaposlenika});
            this.miAdministracija.Name = "miAdministracija";
            this.miAdministracija.Size = new System.Drawing.Size(95, 20);
            this.miAdministracija.Text = "Administracija";
            // 
            // miAdministracijaDodajZaposlenika
            // 
            this.miAdministracijaDodajZaposlenika.Name = "miAdministracijaDodajZaposlenika";
            this.miAdministracijaDodajZaposlenika.Size = new System.Drawing.Size(169, 22);
            this.miAdministracijaDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.miAdministracijaDodajZaposlenika.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miAdministracijaDodajZaposlenika_MouseUp);
            // 
            // miAdministracijaUrediZaposlenika
            // 
            this.miAdministracijaUrediZaposlenika.Name = "miAdministracijaUrediZaposlenika";
            this.miAdministracijaUrediZaposlenika.Size = new System.Drawing.Size(169, 22);
            this.miAdministracijaUrediZaposlenika.Text = "Uredi zaposlenika";
            this.miAdministracijaUrediZaposlenika.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miAdministracijaUrediZaposlenika_MouseUp);
            // 
            // miIzvjesca
            // 
            this.miIzvjesca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIzvjescaPopisZaposlenika});
            this.miIzvjesca.Name = "miIzvjesca";
            this.miIzvjesca.Size = new System.Drawing.Size(59, 20);
            this.miIzvjesca.Text = "Izvješća";
            // 
            // miIzvjescaPopisZaposlenika
            // 
            this.miIzvjescaPopisZaposlenika.Name = "miIzvjescaPopisZaposlenika";
            this.miIzvjescaPopisZaposlenika.Size = new System.Drawing.Size(167, 22);
            this.miIzvjescaPopisZaposlenika.Text = "Popis zaposlenika";
            this.miIzvjescaPopisZaposlenika.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miIzvjescaPopisZaposlenika_MouseUp);
            // 
            // miPomoc
            // 
            this.miPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPomocFAQ,
            this.miPomocKontakt,
            this.miPomocOGizmoApp,
            this.miPomocKorisnickaDokumentacija});
            this.miPomoc.Name = "miPomoc";
            this.miPomoc.Size = new System.Drawing.Size(57, 20);
            this.miPomoc.Text = "Pomoć";
            // 
            // miPomocFAQ
            // 
            this.miPomocFAQ.Name = "miPomocFAQ";
            this.miPomocFAQ.Size = new System.Drawing.Size(210, 22);
            this.miPomocFAQ.Text = "FAQ";
            this.miPomocFAQ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miPomocFAQ_MouseUp);
            // 
            // miPomocKontakt
            // 
            this.miPomocKontakt.Name = "miPomocKontakt";
            this.miPomocKontakt.Size = new System.Drawing.Size(210, 22);
            this.miPomocKontakt.Text = "Kontakt";
            this.miPomocKontakt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miPomocKontakt_MouseUp);
            // 
            // miPomocOGizmoApp
            // 
            this.miPomocOGizmoApp.Name = "miPomocOGizmoApp";
            this.miPomocOGizmoApp.Size = new System.Drawing.Size(210, 22);
            this.miPomocOGizmoApp.Text = "O Gizmo App";
            this.miPomocOGizmoApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miPomocOGizmoApp_MouseUp);
            // 
            // odjel_has_PogledTableAdapter1
            // 
            this.odjel_has_PogledTableAdapter1.ClearBeforeFill = true;
            // 
            // miPomocKorisnickaDokumentacija
            // 
            this.miPomocKorisnickaDokumentacija.Name = "miPomocKorisnickaDokumentacija";
            this.miPomocKorisnickaDokumentacija.Size = new System.Drawing.Size(210, 22);
            this.miPomocKorisnickaDokumentacija.Text = "Korisnička dokumentacija";
            this.miPomocKorisnickaDokumentacija.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miPomocKorisnickaDokumentacija_MouseUp);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GizmoApp.Properties.Resources.gizmo_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 396);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.msIzbornik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIzbornik;
            this.Name = "frmGlavna";
            this.Text = "Gizmo App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmGlavna_MdiChildActivate);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmGlavna_HelpRequested);
            this.msIzbornik.ResumeLayout(false);
            this.msIzbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.MenuStrip msIzbornik;
        private System.Windows.Forms.ToolStripMenuItem miAplikacija;
        private System.Windows.Forms.ToolStripMenuItem miAplikacijaIzlaz;
        private System.Windows.Forms.ToolStripMenuItem miSkladiste;
        private System.Windows.Forms.ToolStripMenuItem miSkladistePretrazi;
        private System.Windows.Forms.ToolStripMenuItem miProdaja;
        private System.Windows.Forms.ToolStripMenuItem miNabava;
        private System.Windows.Forms.ToolStripMenuItem miAdministracija;
        private System.Windows.Forms.ToolStripMenuItem miIzvjesca;
        private System.Windows.Forms.ToolStripMenuItem miPomoc;
        private System.Windows.Forms.ToolStripMenuItem miProdajaDodajKupca;
        private System.Windows.Forms.ToolStripMenuItem miProdajaPretraziKupce;
        private System.Windows.Forms.ToolStripMenuItem miProdajaKreirajOtpremnicu;
        private System.Windows.Forms.ToolStripMenuItem miNabavaDodajDobavljaca;
        private System.Windows.Forms.ToolStripMenuItem miNabavaPretraziDobavljace;
        private System.Windows.Forms.ToolStripMenuItem miNabavaKreirajNarudzbenicu;
        private System.Windows.Forms.ToolStripMenuItem miAdministracijaDodajZaposlenika;
        private System.Windows.Forms.ToolStripMenuItem miAdministracijaUrediZaposlenika;
        private System.Windows.Forms.ToolStripMenuItem miIzvjescaPopisZaposlenika;
        private System.Windows.Forms.ToolStripMenuItem miPomocOGizmoApp;
        private System.Windows.Forms.ToolStripMenuItem miSkladisteDodajSektor;
        private System.Windows.Forms.ToolStripMenuItem miNabavaDodajKnjigu;
        private System.Windows.Forms.ToolStripMenuItem miPomocFAQ;
        private System.Windows.Forms.ToolStripMenuItem miPomocKontakt;
        private GizmoDBDataSetTableAdapters.Odjel_has_PogledTableAdapter odjel_has_PogledTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem miPomocKorisnickaDokumentacija;
    }
}