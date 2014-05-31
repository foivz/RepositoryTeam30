namespace GizmoApp.Podforme.Skladiste
{
    partial class frmSkladistePretraziDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladistePretraziDetalji));
            this.gpxInformacijeOPrimitku = new System.Windows.Forms.GroupBox();
            this.lblKom = new System.Windows.Forms.Label();
            this.lblSektor = new System.Windows.Forms.Label();
            this.lblDatumPrimitka = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.gbxInformacijeOKnjizi = new System.Windows.Forms.GroupBox();
            this.lblNazivVrijednost = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.lblKategorijeVrijednost = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblSifraVrijednost = new System.Windows.Forms.Label();
            this.lblSektorVrijednost = new System.Windows.Forms.Label();
            this.lblDatumPrimitkaVrijednost = new System.Windows.Forms.Label();
            this.lblKolicinaVrijednost = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gpxInformacijeOPrimitku.SuspendLayout();
            this.gbxInformacijeOKnjizi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxInformacijeOPrimitku
            // 
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblKolicinaVrijednost);
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblDatumPrimitkaVrijednost);
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblSektorVrijednost);
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblKom);
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblSektor);
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblDatumPrimitka);
            this.gpxInformacijeOPrimitku.Controls.Add(this.lblKolicina);
            this.gpxInformacijeOPrimitku.Location = new System.Drawing.Point(13, 153);
            this.gpxInformacijeOPrimitku.Name = "gpxInformacijeOPrimitku";
            this.gpxInformacijeOPrimitku.Size = new System.Drawing.Size(234, 138);
            this.gpxInformacijeOPrimitku.TabIndex = 21;
            this.gpxInformacijeOPrimitku.TabStop = false;
            this.gpxInformacijeOPrimitku.Text = "Informacije o primitku";
            // 
            // lblKom
            // 
            this.lblKom.AutoSize = true;
            this.lblKom.Location = new System.Drawing.Point(170, 94);
            this.lblKom.Name = "lblKom";
            this.lblKom.Size = new System.Drawing.Size(27, 13);
            this.lblKom.TabIndex = 12;
            this.lblKom.Text = "kom";
            // 
            // lblSektor
            // 
            this.lblSektor.AutoSize = true;
            this.lblSektor.Location = new System.Drawing.Point(23, 33);
            this.lblSektor.Name = "lblSektor";
            this.lblSektor.Size = new System.Drawing.Size(44, 13);
            this.lblSektor.TabIndex = 6;
            this.lblSektor.Text = "Sektor: ";
            // 
            // lblDatumPrimitka
            // 
            this.lblDatumPrimitka.AutoSize = true;
            this.lblDatumPrimitka.Location = new System.Drawing.Point(23, 62);
            this.lblDatumPrimitka.Name = "lblDatumPrimitka";
            this.lblDatumPrimitka.Size = new System.Drawing.Size(80, 13);
            this.lblDatumPrimitka.TabIndex = 8;
            this.lblDatumPrimitka.Text = "Datum primitka:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(23, 94);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(50, 13);
            this.lblKolicina.TabIndex = 10;
            this.lblKolicina.Text = "Količina: ";
            // 
            // gbxInformacijeOKnjizi
            // 
            this.gbxInformacijeOKnjizi.Controls.Add(this.lblNazivVrijednost);
            this.gbxInformacijeOKnjizi.Controls.Add(this.lblNaziv);
            this.gbxInformacijeOKnjizi.Controls.Add(this.lblKategorije);
            this.gbxInformacijeOKnjizi.Controls.Add(this.lblKategorijeVrijednost);
            this.gbxInformacijeOKnjizi.Controls.Add(this.lblSifra);
            this.gbxInformacijeOKnjizi.Controls.Add(this.lblSifraVrijednost);
            this.gbxInformacijeOKnjizi.Location = new System.Drawing.Point(12, 12);
            this.gbxInformacijeOKnjizi.Name = "gbxInformacijeOKnjizi";
            this.gbxInformacijeOKnjizi.Size = new System.Drawing.Size(235, 135);
            this.gbxInformacijeOKnjizi.TabIndex = 20;
            this.gbxInformacijeOKnjizi.TabStop = false;
            this.gbxInformacijeOKnjizi.Text = "Informacije o knjizi";
            // 
            // lblNazivVrijednost
            // 
            this.lblNazivVrijednost.AutoSize = true;
            this.lblNazivVrijednost.Location = new System.Drawing.Point(70, 53);
            this.lblNazivVrijednost.Name = "lblNazivVrijednost";
            this.lblNazivVrijednost.Size = new System.Drawing.Size(111, 13);
            this.lblNazivVrijednost.TabIndex = 1;
            this.lblNazivVrijednost.Text = "<naziv knjige iz baze>";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(24, 53);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Location = new System.Drawing.Point(24, 77);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(60, 13);
            this.lblKategorije.TabIndex = 2;
            this.lblKategorije.Text = "Kategorije: ";
            // 
            // lblKategorijeVrijednost
            // 
            this.lblKategorijeVrijednost.AutoSize = true;
            this.lblKategorijeVrijednost.Location = new System.Drawing.Point(47, 99);
            this.lblKategorijeVrijednost.Name = "lblKategorijeVrijednost";
            this.lblKategorijeVrijednost.Size = new System.Drawing.Size(93, 13);
            this.lblKategorijeVrijednost.TabIndex = 3;
            this.lblKategorijeVrijednost.Text = "<popis kategorija>";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(24, 29);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(34, 13);
            this.lblSifra.TabIndex = 4;
            this.lblSifra.Text = "Šifra: ";
            // 
            // lblSifraVrijednost
            // 
            this.lblSifraVrijednost.AutoSize = true;
            this.lblSifraVrijednost.Location = new System.Drawing.Point(70, 29);
            this.lblSifraVrijednost.Name = "lblSifraVrijednost";
            this.lblSifraVrijednost.Size = new System.Drawing.Size(94, 13);
            this.lblSifraVrijednost.TabIndex = 5;
            this.lblSifraVrijednost.Text = "<id knjige iz baze>";
            // 
            // lblSektorVrijednost
            // 
            this.lblSektorVrijednost.AutoSize = true;
            this.lblSektorVrijednost.Location = new System.Drawing.Point(106, 33);
            this.lblSektorVrijednost.Name = "lblSektorVrijednost";
            this.lblSektorVrijednost.Size = new System.Drawing.Size(84, 13);
            this.lblSektorVrijednost.TabIndex = 6;
            this.lblSektorVrijednost.Text = "<sektor iz baze>";
            // 
            // lblDatumPrimitkaVrijednost
            // 
            this.lblDatumPrimitkaVrijednost.AutoSize = true;
            this.lblDatumPrimitkaVrijednost.Location = new System.Drawing.Point(106, 62);
            this.lblDatumPrimitkaVrijednost.Name = "lblDatumPrimitkaVrijednost";
            this.lblDatumPrimitkaVrijednost.Size = new System.Drawing.Size(84, 13);
            this.lblDatumPrimitkaVrijednost.TabIndex = 13;
            this.lblDatumPrimitkaVrijednost.Text = "<datum iz baze>";
            // 
            // lblKolicinaVrijednost
            // 
            this.lblKolicinaVrijednost.AutoSize = true;
            this.lblKolicinaVrijednost.Location = new System.Drawing.Point(106, 94);
            this.lblKolicinaVrijednost.Name = "lblKolicinaVrijednost";
            this.lblKolicinaVrijednost.Size = new System.Drawing.Size(55, 13);
            this.lblKolicinaVrijednost.TabIndex = 14;
            this.lblKolicinaVrijednost.Text = "<kolicina>";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(99, 321);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 22;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmSkladistePretraziDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 355);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.gpxInformacijeOPrimitku);
            this.Controls.Add(this.gbxInformacijeOKnjizi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSkladistePretraziDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o knjizi";
            this.gpxInformacijeOPrimitku.ResumeLayout(false);
            this.gpxInformacijeOPrimitku.PerformLayout();
            this.gbxInformacijeOKnjizi.ResumeLayout(false);
            this.gbxInformacijeOKnjizi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxInformacijeOPrimitku;
        private System.Windows.Forms.Label lblKolicinaVrijednost;
        private System.Windows.Forms.Label lblDatumPrimitkaVrijednost;
        private System.Windows.Forms.Label lblSektorVrijednost;
        private System.Windows.Forms.Label lblKom;
        private System.Windows.Forms.Label lblSektor;
        private System.Windows.Forms.Label lblDatumPrimitka;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.GroupBox gbxInformacijeOKnjizi;
        private System.Windows.Forms.Label lblNazivVrijednost;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.Label lblKategorijeVrijednost;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblSifraVrijednost;
        private System.Windows.Forms.Button btnZatvori;
    }
}