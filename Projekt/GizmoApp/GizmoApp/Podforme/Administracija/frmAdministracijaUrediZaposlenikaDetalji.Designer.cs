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
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.odjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpxKontakt = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.zaposlenikTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.odjelTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.OdjelTableAdapter();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtOdjel = new System.Windows.Forms.TextBox();
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
            // gpxPoslovneInformacije
            // 
            this.gpxPoslovneInformacije.Controls.Add(odjel_idOdjelLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.txtOdjel);
            this.gpxPoslovneInformacije.Controls.Add(lozinkaLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.txtLozinka);
            this.gpxPoslovneInformacije.Controls.Add(korisnicko_imeLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.txtKorisnickoIme);
            this.gpxPoslovneInformacije.Location = new System.Drawing.Point(326, 118);
            this.gpxPoslovneInformacije.Name = "gpxPoslovneInformacije";
            this.gpxPoslovneInformacije.Size = new System.Drawing.Size(272, 145);
            this.gpxPoslovneInformacije.TabIndex = 5;
            this.gpxPoslovneInformacije.TabStop = false;
            this.gpxPoslovneInformacije.Text = "Poslovne informacije";
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
            // odjelBindingSource
            // 
            this.odjelBindingSource.DataMember = "Odjel";
            this.odjelBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gpxKontakt
            // 
            this.gpxKontakt.Controls.Add(telefonLabel);
            this.gpxKontakt.Controls.Add(this.txtTelefon);
            this.gpxKontakt.Controls.Add(emailLabel);
            this.gpxKontakt.Controls.Add(this.txtEmail);
            this.gpxKontakt.Location = new System.Drawing.Point(326, 12);
            this.gpxKontakt.Name = "gpxKontakt";
            this.gpxKontakt.Size = new System.Drawing.Size(272, 100);
            this.gpxKontakt.TabIndex = 4;
            this.gpxKontakt.TabStop = false;
            this.gpxKontakt.Text = "Kontakt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(adresaLabel);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(oIBLabel);
            this.groupBox1.Controls.Add(this.txtOIB);
            this.groupBox1.Controls.Add(prezimeLabel);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(imeLabel);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobne informacije";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(330, 269);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(194, 269);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
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
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(21, 31);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 7;
            imeLabel.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true));
            this.txtIme.Location = new System.Drawing.Point(85, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 8;
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
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.txtPrezime.Location = new System.Drawing.Point(84, 64);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 9;
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
            // txtOIB
            // 
            this.txtOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "OIB", true));
            this.txtOIB.Location = new System.Drawing.Point(84, 99);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(100, 20);
            this.txtOIB.TabIndex = 10;
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
            // txtAdresa
            // 
            this.txtAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.txtAdresa.Location = new System.Drawing.Point(85, 133);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(216, 20);
            this.txtAdresa.TabIndex = 11;
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
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(85, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 12;
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
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Telefon", true));
            this.txtTelefon.Location = new System.Drawing.Point(85, 51);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(123, 20);
            this.txtTelefon.TabIndex = 13;
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
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Korisnicko_ime", true));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(108, 26);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnickoIme.TabIndex = 13;
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
            // txtLozinka
            // 
            this.txtLozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.txtLozinka.Location = new System.Drawing.Point(108, 60);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 14;
            // 
            // odjel_idOdjelLabel
            // 
            odjel_idOdjelLabel.AutoSize = true;
            odjel_idOdjelLabel.Location = new System.Drawing.Point(21, 100);
            odjel_idOdjelLabel.Name = "odjel_idOdjelLabel";
            odjel_idOdjelLabel.Size = new System.Drawing.Size(37, 13);
            odjel_idOdjelLabel.TabIndex = 14;
            odjel_idOdjelLabel.Text = "Odjel: ";
            // 
            // txtOdjel
            // 
            this.txtOdjel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Odjel_idOdjel", true));
            this.txtOdjel.Location = new System.Drawing.Point(108, 97);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(158, 20);
            this.txtOdjel.TabIndex = 15;
            // 
            // frmAdministracijaUrediZaposlenikaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 312);
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
        private System.Windows.Forms.TextBox txtOdjel;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
    }
}