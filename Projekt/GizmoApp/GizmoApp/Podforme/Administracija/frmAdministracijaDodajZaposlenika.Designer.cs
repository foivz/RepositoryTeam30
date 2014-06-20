namespace GizmoApp.Podforme.Administracija
{
    partial class frmAdministracijaDodajZaposlenika
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
            System.Windows.Forms.Label lblIme;
            System.Windows.Forms.Label lblPrezime;
            System.Windows.Forms.Label lblOIB;
            System.Windows.Forms.Label lblAdresa;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblTelefon;
            System.Windows.Forms.Label lblKorisnickoIme;
            System.Windows.Forms.Label lblLozinka;
            System.Windows.Forms.Label odjel_idOdjelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracijaDodajZaposlenika));
            this.grpbxOsobneInformacije = new System.Windows.Forms.GroupBox();
            this.txtbxAdresa = new System.Windows.Forms.TextBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtbxPrezime = new System.Windows.Forms.TextBox();
            this.txtbxIme = new System.Windows.Forms.TextBox();
            this.gpxKontakt = new System.Windows.Forms.GroupBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.gpxPoslovneInformacije = new System.Windows.Forms.GroupBox();
            this.txtbxLozinka = new System.Windows.Forms.TextBox();
            this.txtbxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.zaposlenikTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.odjelTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.OdjelTableAdapter();
            this.odjel_idOdjelTextBox = new System.Windows.Forms.TextBox();
            lblIme = new System.Windows.Forms.Label();
            lblPrezime = new System.Windows.Forms.Label();
            lblOIB = new System.Windows.Forms.Label();
            lblAdresa = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblTelefon = new System.Windows.Forms.Label();
            lblKorisnickoIme = new System.Windows.Forms.Label();
            lblLozinka = new System.Windows.Forms.Label();
            odjel_idOdjelLabel = new System.Windows.Forms.Label();
            this.grpbxOsobneInformacije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            this.gpxKontakt.SuspendLayout();
            this.gpxPoslovneInformacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new System.Drawing.Point(21, 35);
            lblIme.Name = "lblIme";
            lblIme.Size = new System.Drawing.Size(27, 13);
            lblIme.TabIndex = 6;
            lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new System.Drawing.Point(20, 65);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new System.Drawing.Size(47, 13);
            lblPrezime.TabIndex = 5;
            lblPrezime.Text = "Prezime:";
            // 
            // lblOIB
            // 
            lblOIB.AutoSize = true;
            lblOIB.Location = new System.Drawing.Point(21, 96);
            lblOIB.Name = "lblOIB";
            lblOIB.Size = new System.Drawing.Size(28, 13);
            lblOIB.TabIndex = 5;
            lblOIB.Text = "OIB:";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new System.Drawing.Point(20, 132);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(43, 13);
            lblAdresa.TabIndex = 5;
            lblAdresa.Text = "Adresa:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(35, 27);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new System.Drawing.Point(35, 63);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new System.Drawing.Size(46, 13);
            lblTelefon.TabIndex = 5;
            lblTelefon.Text = "Telefon:";
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize = true;
            lblKorisnickoIme.Location = new System.Drawing.Point(21, 25);
            lblKorisnickoIme.Name = "lblKorisnickoIme";
            lblKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            lblKorisnickoIme.TabIndex = 5;
            lblKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Location = new System.Drawing.Point(21, 56);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new System.Drawing.Size(47, 13);
            lblLozinka.TabIndex = 5;
            lblLozinka.Text = "Lozinka:";
            // 
            // grpbxOsobneInformacije
            // 
            this.grpbxOsobneInformacije.Controls.Add(this.txtbxAdresa);
            this.grpbxOsobneInformacije.Controls.Add(lblAdresa);
            this.grpbxOsobneInformacije.Controls.Add(this.txtOIB);
            this.grpbxOsobneInformacije.Controls.Add(lblOIB);
            this.grpbxOsobneInformacije.Controls.Add(this.txtbxPrezime);
            this.grpbxOsobneInformacije.Controls.Add(lblPrezime);
            this.grpbxOsobneInformacije.Controls.Add(this.txtbxIme);
            this.grpbxOsobneInformacije.Controls.Add(lblIme);
            this.grpbxOsobneInformacije.Location = new System.Drawing.Point(22, 59);
            this.grpbxOsobneInformacije.Name = "grpbxOsobneInformacije";
            this.grpbxOsobneInformacije.Size = new System.Drawing.Size(307, 165);
            this.grpbxOsobneInformacije.TabIndex = 0;
            this.grpbxOsobneInformacije.TabStop = false;
            this.grpbxOsobneInformacije.Text = "Osobne informacije";
            // 
            // txtbxAdresa
            // 
            this.txtbxAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.txtbxAdresa.Location = new System.Drawing.Point(85, 129);
            this.txtbxAdresa.Name = "txtbxAdresa";
            this.txtbxAdresa.Size = new System.Drawing.Size(216, 20);
            this.txtbxAdresa.TabIndex = 6;
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
            // txtOIB
            // 
            this.txtOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "OIB", true));
            this.txtOIB.Location = new System.Drawing.Point(85, 93);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(100, 20);
            this.txtOIB.TabIndex = 6;
            // 
            // txtbxPrezime
            // 
            this.txtbxPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.txtbxPrezime.Location = new System.Drawing.Point(85, 62);
            this.txtbxPrezime.Name = "txtbxPrezime";
            this.txtbxPrezime.Size = new System.Drawing.Size(127, 20);
            this.txtbxPrezime.TabIndex = 6;
            // 
            // txtbxIme
            // 
            this.txtbxIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true));
            this.txtbxIme.Location = new System.Drawing.Point(85, 32);
            this.txtbxIme.Name = "txtbxIme";
            this.txtbxIme.Size = new System.Drawing.Size(127, 20);
            this.txtbxIme.TabIndex = 7;
            // 
            // gpxKontakt
            // 
            this.gpxKontakt.Controls.Add(this.telefonTextBox);
            this.gpxKontakt.Controls.Add(lblTelefon);
            this.gpxKontakt.Controls.Add(this.txtbxEmail);
            this.gpxKontakt.Controls.Add(lblEmail);
            this.gpxKontakt.Location = new System.Drawing.Point(335, 23);
            this.gpxKontakt.Name = "gpxKontakt";
            this.gpxKontakt.Size = new System.Drawing.Size(250, 100);
            this.gpxKontakt.TabIndex = 1;
            this.gpxKontakt.TabStop = false;
            this.gpxKontakt.Text = "Kontakt";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(87, 60);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 6;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Email", true));
            this.txtbxEmail.Location = new System.Drawing.Point(85, 24);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(159, 20);
            this.txtbxEmail.TabIndex = 6;
            // 
            // gpxPoslovneInformacije
            // 
            this.gpxPoslovneInformacije.Controls.Add(odjel_idOdjelLabel);
            this.gpxPoslovneInformacije.Controls.Add(this.odjel_idOdjelTextBox);
            this.gpxPoslovneInformacije.Controls.Add(this.txtbxLozinka);
            this.gpxPoslovneInformacije.Controls.Add(lblLozinka);
            this.gpxPoslovneInformacije.Controls.Add(this.txtbxKorisnickoIme);
            this.gpxPoslovneInformacije.Controls.Add(lblKorisnickoIme);
            this.gpxPoslovneInformacije.Location = new System.Drawing.Point(335, 129);
            this.gpxPoslovneInformacije.Name = "gpxPoslovneInformacije";
            this.gpxPoslovneInformacije.Size = new System.Drawing.Size(265, 147);
            this.gpxPoslovneInformacije.TabIndex = 2;
            this.gpxPoslovneInformacije.TabStop = false;
            this.gpxPoslovneInformacije.Text = "Poslovne informacije";
            // 
            // txtbxLozinka
            // 
            this.txtbxLozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.txtbxLozinka.Location = new System.Drawing.Point(108, 53);
            this.txtbxLozinka.Name = "txtbxLozinka";
            this.txtbxLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtbxLozinka.TabIndex = 6;
            // 
            // txtbxKorisnickoIme
            // 
            this.txtbxKorisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Korisnicko_ime", true));
            this.txtbxKorisnickoIme.Location = new System.Drawing.Point(108, 23);
            this.txtbxKorisnickoIme.Name = "txtbxKorisnickoIme";
            this.txtbxKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtbxKorisnickoIme.TabIndex = 6;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(213, 302);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSpremi_MouseUp);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(349, 302);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
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
            // odjel_idOdjelLabel
            // 
            odjel_idOdjelLabel.AutoSize = true;
            odjel_idOdjelLabel.Location = new System.Drawing.Point(21, 93);
            odjel_idOdjelLabel.Name = "odjel_idOdjelLabel";
            odjel_idOdjelLabel.Size = new System.Drawing.Size(72, 13);
            odjel_idOdjelLabel.TabIndex = 6;
            odjel_idOdjelLabel.Text = "Odjel id Odjel:";
            // 
            // odjel_idOdjelTextBox
            // 
            this.odjel_idOdjelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Odjel_idOdjel", true));
            this.odjel_idOdjelTextBox.Location = new System.Drawing.Point(108, 90);
            this.odjel_idOdjelTextBox.Name = "odjel_idOdjelTextBox";
            this.odjel_idOdjelTextBox.Size = new System.Drawing.Size(100, 20);
            this.odjel_idOdjelTextBox.TabIndex = 7;
            // 
            // frmAdministracijaDodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 354);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gpxPoslovneInformacije);
            this.Controls.Add(this.gpxKontakt);
            this.Controls.Add(this.grpbxOsobneInformacije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministracijaDodajZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zaposlenika";
            this.Load += new System.EventHandler(this.frmAdministracijaDodajZaposlenika_Load);
            this.grpbxOsobneInformacije.ResumeLayout(false);
            this.grpbxOsobneInformacije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            this.gpxKontakt.ResumeLayout(false);
            this.gpxKontakt.PerformLayout();
            this.gpxPoslovneInformacije.ResumeLayout(false);
            this.gpxPoslovneInformacije.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxOsobneInformacije;
        private System.Windows.Forms.GroupBox gpxKontakt;
        private System.Windows.Forms.GroupBox gpxPoslovneInformacije;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxPrezime;
        private System.Windows.Forms.TextBox txtbxIme;
        private System.Windows.Forms.TextBox txtbxAdresa;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxLozinka;
        private System.Windows.Forms.TextBox txtbxKorisnickoIme;
        private GizmoDBDataSetTableAdapters.OdjelTableAdapter odjelTableAdapter;
        private System.Windows.Forms.TextBox odjel_idOdjelTextBox;

    }
}