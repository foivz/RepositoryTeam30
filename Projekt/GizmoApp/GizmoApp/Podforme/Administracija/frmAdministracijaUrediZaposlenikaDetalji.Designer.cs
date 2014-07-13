namespace GizmoApp.Podforme.Administracija
{
    partial class frmAdministracijaUrediZaposlenikaDetalji
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label odjel_idOdjelLabel;
            this.gpxPoslovneInformacije = new System.Windows.Forms.GroupBox();
            this.txtbxOdjel = new System.Windows.Forms.TextBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.txtbxLozinka = new System.Windows.Forms.TextBox();
            this.txtbxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.odjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpxKontakt = new System.Windows.Forms.GroupBox();
            this.txtbxTelefon = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxAdresa = new System.Windows.Forms.TextBox();
            this.txtbxOIB = new System.Windows.Forms.TextBox();
            this.txtbxPrezime = new System.Windows.Forms.TextBox();
            this.txtbxIme = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.zaposlenikTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.odjelTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.OdjelTableAdapter();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            odjel_idOdjelLabel = new System.Windows.Forms.Label();
            this.gpxPoslovneInformacije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).BeginInit();
            this.gpxKontakt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(21, 31);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 7;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(21, 67);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 8;
            prezimeLabel.Text = "Prezime:";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(21, 99);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(28, 13);
            oIBLabel.TabIndex = 9;
            oIBLabel.Text = "OIB:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(25, 133);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 10;
            adresaLabel.Text = "Adresa:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 22);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(21, 54);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Telefon:";
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(21, 29);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(78, 13);
            korisnicko_imeLabel.TabIndex = 12;
            korisnicko_imeLabel.Text = "Korisničko ime:";
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.Location = new System.Drawing.Point(21, 63);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            lozinkaLabel.TabIndex = 13;
            lozinkaLabel.Text = "Lozinka:";
            // 
            // odjel_idOdjelLabel
            // 
            odjel_idOdjelLabel.AutoSize = true;
            odjel_idOdjelLabel.Location = new System.Drawing.Point(21, 98);
            odjel_idOdjelLabel.Name = "odjel_idOdjelLabel";
            odjel_idOdjelLabel.Size = new System.Drawing.Size(37, 13);
            odjel_idOdjelLabel.TabIndex = 14;
            odjel_idOdjelLabel.Text = "Odjel: ";
            // 
            // gpxPoslovneInformacije
            // 
            this.gpxPoslovneInformacije.Controls.Add(odjel_idOdjelLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.txtbxOdjel);
            this.gpxPoslovneInformacije.Controls.Add(lozinkaLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.txtbxLozinka);
            this.gpxPoslovneInformacije.Controls.Add(korisnicko_imeLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.txtbxKorisnickoIme);
            this.gpxPoslovneInformacije.Location = new System.Drawing.Point(326, 118);
            this.gpxPoslovneInformacije.Name = "gpxPoslovneInformacije";
            this.gpxPoslovneInformacije.Size = new System.Drawing.Size(272, 135);
            this.gpxPoslovneInformacije.TabIndex = 5;
            this.gpxPoslovneInformacije.TabStop = false;
            this.gpxPoslovneInformacije.Text = "Poslovne informacije";
            // 
            // txtbxOdjel
            // 
            this.txtbxOdjel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Odjel_idOdjel", true));
            this.txtbxOdjel.Location = new System.Drawing.Point(108, 95);
            this.txtbxOdjel.Name = "txtbxOdjel";
            this.txtbxOdjel.Size = new System.Drawing.Size(100, 20);
            this.txtbxOdjel.TabIndex = 16;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbxLozinka
            // 
            this.txtbxLozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.txtbxLozinka.Location = new System.Drawing.Point(108, 60);
            this.txtbxLozinka.Name = "txtbxLozinka";
            this.txtbxLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtbxLozinka.TabIndex = 15;
            // 
            // txtbxKorisnickoIme
            // 
            this.txtbxKorisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Korisnicko_ime", true));
            this.txtbxKorisnickoIme.Location = new System.Drawing.Point(108, 26);
            this.txtbxKorisnickoIme.Name = "txtbxKorisnickoIme";
            this.txtbxKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtbxKorisnickoIme.TabIndex = 14;
            // 
            // odjelBindingSource
            // 
            this.odjelBindingSource.DataMember = "Odjel";
            this.odjelBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gpxKontakt
            // 
            this.gpxKontakt.Controls.Add(telefonLabel);
            this.gpxKontakt.Controls.Add(this.txtbxTelefon);
            this.gpxKontakt.Controls.Add(emailLabel);
            this.gpxKontakt.Controls.Add(this.txtbxEmail);
            this.gpxKontakt.Location = new System.Drawing.Point(326, 12);
            this.gpxKontakt.Name = "gpxKontakt";
            this.gpxKontakt.Size = new System.Drawing.Size(272, 100);
            this.gpxKontakt.TabIndex = 4;
            this.gpxKontakt.TabStop = false;
            this.gpxKontakt.Text = "Kontakt";
            // 
            // txtbxTelefon
            // 
            this.txtbxTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Telefon", true));
            this.txtbxTelefon.Location = new System.Drawing.Point(85, 51);
            this.txtbxTelefon.Name = "txtbxTelefon";
            this.txtbxTelefon.Size = new System.Drawing.Size(123, 20);
            this.txtbxTelefon.TabIndex = 13;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Email", true));
            this.txtbxEmail.Location = new System.Drawing.Point(85, 19);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(123, 20);
            this.txtbxEmail.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(adresaLabel);
            this.groupBox1.Controls.Add(this.txtbxAdresa);
            this.groupBox1.Controls.Add(oIBLabel);
            this.groupBox1.Controls.Add(this.txtbxOIB);
            this.groupBox1.Controls.Add(prezimeLabel);
            this.groupBox1.Controls.Add(this.txtbxPrezime);
            this.groupBox1.Controls.Add(imeLabel);
            this.groupBox1.Controls.Add(this.txtbxIme);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobne informacije";
            // 
            // txtbxAdresa
            // 
            this.txtbxAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.txtbxAdresa.Location = new System.Drawing.Point(85, 133);
            this.txtbxAdresa.Name = "txtbxAdresa";
            this.txtbxAdresa.Size = new System.Drawing.Size(216, 20);
            this.txtbxAdresa.TabIndex = 11;
            // 
            // txtbxOIB
            // 
            this.txtbxOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "OIB", true));
            this.txtbxOIB.Location = new System.Drawing.Point(84, 99);
            this.txtbxOIB.Name = "txtbxOIB";
            this.txtbxOIB.Size = new System.Drawing.Size(100, 20);
            this.txtbxOIB.TabIndex = 10;
            // 
            // txtbxPrezime
            // 
            this.txtbxPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.txtbxPrezime.Location = new System.Drawing.Point(84, 64);
            this.txtbxPrezime.Name = "txtbxPrezime";
            this.txtbxPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtbxPrezime.TabIndex = 9;
            // 
            // txtbxIme
            // 
            this.txtbxIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true));
            this.txtbxIme.Location = new System.Drawing.Point(85, 27);
            this.txtbxIme.Name = "txtbxIme";
            this.txtbxIme.Size = new System.Drawing.Size(100, 20);
            this.txtbxIme.TabIndex = 8;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(330, 269);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 18;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(194, 269);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 17;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = null;
            this.tableAdapterManager.Kategorija_has_KnjigaTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_DobavljaciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_KupciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = this.odjelTableAdapter;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = this.zaposlenikTableAdapter;
            // 
            // odjelTableAdapter
            // 
            this.odjelTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdministracijaUrediZaposlenikaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 327);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gpxPoslovneInformacije);
            this.Controls.Add(this.gpxKontakt);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdministracijaUrediZaposlenikaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji zaposlenika";
            this.Load += new System.EventHandler(this.frmAdministracijaUrediZaposlenikaDetalji_Load);
            this.gpxPoslovneInformacije.ResumeLayout(false);
            this.gpxPoslovneInformacije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjelBindingSource)).EndInit();
            this.gpxKontakt.ResumeLayout(false);
            this.gpxKontakt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxPoslovneInformacije;
        private System.Windows.Forms.GroupBox gpxKontakt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GizmoDBDataSetTableAdapters.OdjelTableAdapter odjelTableAdapter;
        private System.Windows.Forms.BindingSource odjelBindingSource;
        private System.Windows.Forms.TextBox txtbxLozinka;
        private System.Windows.Forms.TextBox txtbxKorisnickoIme;
        private System.Windows.Forms.TextBox txtbxTelefon;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxAdresa;
        private System.Windows.Forms.TextBox txtbxOIB;
        private System.Windows.Forms.TextBox txtbxPrezime;
        private System.Windows.Forms.TextBox txtbxIme;
        private System.Windows.Forms.TextBox txtbxOdjel;
    }
}