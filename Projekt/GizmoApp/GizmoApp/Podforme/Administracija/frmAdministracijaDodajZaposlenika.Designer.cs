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
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblTelefon;
            System.Windows.Forms.Label lblKorisnickoIme;
            System.Windows.Forms.Label lblLozinka;
            System.Windows.Forms.Label lblIme;
            System.Windows.Forms.Label lblPrezime;
            System.Windows.Forms.Label lblOIB;
            System.Windows.Forms.Label lblAdresa;
            System.Windows.Forms.Label odjel_idOdjelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracijaDodajZaposlenika));
            this.txtbxTelefon = new System.Windows.Forms.TextBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxLozinka = new System.Windows.Forms.TextBox();
            this.txtbxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtbxIme = new System.Windows.Forms.TextBox();
            this.txtbxPrezime = new System.Windows.Forms.TextBox();
            this.txtbxOIB = new System.Windows.Forms.TextBox();
            this.txtbxAdresa = new System.Windows.Forms.TextBox();
            this.zaposlenikTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.odjelTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.OdjelTableAdapter();
            this.txtOdjel = new System.Windows.Forms.TextBox();
            this.gbxOdjeli = new System.Windows.Forms.GroupBox();
            this.lblOdjel1 = new System.Windows.Forms.Label();
            this.lblOdjel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblTelefon = new System.Windows.Forms.Label();
            lblKorisnickoIme = new System.Windows.Forms.Label();
            lblLozinka = new System.Windows.Forms.Label();
            lblIme = new System.Windows.Forms.Label();
            lblPrezime = new System.Windows.Forms.Label();
            lblOIB = new System.Windows.Forms.Label();
            lblAdresa = new System.Windows.Forms.Label();
            odjel_idOdjelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            this.gbxOdjeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(354, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new System.Drawing.Point(354, 69);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new System.Drawing.Size(46, 13);
            lblTelefon.TabIndex = 5;
            lblTelefon.Text = "Telefon:";
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize = true;
            lblKorisnickoIme.Location = new System.Drawing.Point(354, 123);
            lblKorisnickoIme.Name = "lblKorisnickoIme";
            lblKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            lblKorisnickoIme.TabIndex = 5;
            lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Location = new System.Drawing.Point(354, 154);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new System.Drawing.Size(47, 13);
            lblLozinka.TabIndex = 5;
            lblLozinka.Text = "Lozinka:";
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new System.Drawing.Point(32, 65);
            lblIme.Name = "lblIme";
            lblIme.Size = new System.Drawing.Size(27, 13);
            lblIme.TabIndex = 6;
            lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new System.Drawing.Point(31, 95);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new System.Drawing.Size(47, 13);
            lblPrezime.TabIndex = 5;
            lblPrezime.Text = "Prezime:";
            // 
            // lblOIB
            // 
            lblOIB.AutoSize = true;
            lblOIB.Location = new System.Drawing.Point(32, 126);
            lblOIB.Name = "lblOIB";
            lblOIB.Size = new System.Drawing.Size(28, 13);
            lblOIB.TabIndex = 5;
            lblOIB.Text = "OIB:";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new System.Drawing.Point(31, 162);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(43, 13);
            lblAdresa.TabIndex = 5;
            lblAdresa.Text = "Adresa:";
            // 
            // odjel_idOdjelLabel
            // 
            odjel_idOdjelLabel.AutoSize = true;
            odjel_idOdjelLabel.Location = new System.Drawing.Point(354, 190);
            odjel_idOdjelLabel.Name = "odjel_idOdjelLabel";
            odjel_idOdjelLabel.Size = new System.Drawing.Size(37, 13);
            odjel_idOdjelLabel.TabIndex = 18;
            odjel_idOdjelLabel.Text = "Odjel: ";
            // 
            // txtbxTelefon
            // 
            this.txtbxTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Telefon", true));
            this.txtbxTelefon.Location = new System.Drawing.Point(441, 65);
            this.txtbxTelefon.MaxLength = 7;
            this.txtbxTelefon.Name = "txtbxTelefon";
            this.txtbxTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtbxTelefon.TabIndex = 5;
            this.txtbxTelefon.TextChanged += new System.EventHandler(this.txtbxTelefon_TextChanged);
            this.txtbxTelefon.Leave += new System.EventHandler(this.txtbxTelefon_Leave);
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
            // txtbxEmail
            // 
            this.txtbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Email", true));
            this.txtbxEmail.Location = new System.Drawing.Point(439, 29);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(159, 20);
            this.txtbxEmail.TabIndex = 4;
            this.txtbxEmail.Leave += new System.EventHandler(this.txtbxEmail_Leave);
            // 
            // txtbxLozinka
            // 
            this.txtbxLozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.txtbxLozinka.Location = new System.Drawing.Point(441, 151);
            this.txtbxLozinka.Name = "txtbxLozinka";
            this.txtbxLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtbxLozinka.TabIndex = 7;
            // 
            // txtbxKorisnickoIme
            // 
            this.txtbxKorisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Korisnicko_ime", true));
            this.txtbxKorisnickoIme.Location = new System.Drawing.Point(441, 121);
            this.txtbxKorisnickoIme.Name = "txtbxKorisnickoIme";
            this.txtbxKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtbxKorisnickoIme.TabIndex = 6;
            this.txtbxKorisnickoIme.Leave += new System.EventHandler(this.txtbxKorisnickoIme_Leave);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(211, 234);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSpremi_MouseUp);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(347, 234);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtbxIme
            // 
            this.txtbxIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true));
            this.txtbxIme.Location = new System.Drawing.Point(96, 62);
            this.txtbxIme.Name = "txtbxIme";
            this.txtbxIme.Size = new System.Drawing.Size(127, 20);
            this.txtbxIme.TabIndex = 0;
            this.txtbxIme.Leave += new System.EventHandler(this.txtbxIme_Leave);
            // 
            // txtbxPrezime
            // 
            this.txtbxPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.txtbxPrezime.Location = new System.Drawing.Point(96, 92);
            this.txtbxPrezime.Name = "txtbxPrezime";
            this.txtbxPrezime.Size = new System.Drawing.Size(127, 20);
            this.txtbxPrezime.TabIndex = 1;
            this.txtbxPrezime.Leave += new System.EventHandler(this.txtbxPrezime_Leave);
            // 
            // txtbxOIB
            // 
            this.txtbxOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "OIB", true));
            this.txtbxOIB.Location = new System.Drawing.Point(96, 123);
            this.txtbxOIB.MaxLength = 11;
            this.txtbxOIB.Name = "txtbxOIB";
            this.txtbxOIB.Size = new System.Drawing.Size(100, 20);
            this.txtbxOIB.TabIndex = 2;
            this.txtbxOIB.Leave += new System.EventHandler(this.txtbxOIB_Leave);
            // 
            // txtbxAdresa
            // 
            this.txtbxAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.txtbxAdresa.Location = new System.Drawing.Point(96, 159);
            this.txtbxAdresa.Name = "txtbxAdresa";
            this.txtbxAdresa.Size = new System.Drawing.Size(216, 20);
            this.txtbxAdresa.TabIndex = 3;
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
            // txtOdjel
            // 
            this.txtOdjel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Odjel_idOdjel", true));
            this.txtOdjel.Location = new System.Drawing.Point(441, 187);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(100, 20);
            this.txtOdjel.TabIndex = 19;
            // 
            // gbxOdjeli
            // 
            this.gbxOdjeli.Controls.Add(this.label3);
            this.gbxOdjeli.Controls.Add(this.label2);
            this.gbxOdjeli.Controls.Add(this.lblOdjel2);
            this.gbxOdjeli.Controls.Add(this.lblOdjel1);
            this.gbxOdjeli.Location = new System.Drawing.Point(577, 159);
            this.gbxOdjeli.Name = "gbxOdjeli";
            this.gbxOdjeli.Size = new System.Drawing.Size(134, 112);
            this.gbxOdjeli.TabIndex = 20;
            this.gbxOdjeli.TabStop = false;
            this.gbxOdjeli.Text = "Odjeli";
            // 
            // lblOdjel1
            // 
            this.lblOdjel1.AutoSize = true;
            this.lblOdjel1.Location = new System.Drawing.Point(6, 19);
            this.lblOdjel1.Name = "lblOdjel1";
            this.lblOdjel1.Size = new System.Drawing.Size(104, 13);
            this.lblOdjel1.TabIndex = 0;
            this.lblOdjel1.Text = "1 - Odjel skladištenja";
            // 
            // lblOdjel2
            // 
            this.lblOdjel2.AutoSize = true;
            this.lblOdjel2.Location = new System.Drawing.Point(6, 44);
            this.lblOdjel2.Name = "lblOdjel2";
            this.lblOdjel2.Size = new System.Drawing.Size(85, 13);
            this.lblOdjel2.TabIndex = 1;
            this.lblOdjel2.Text = "2 - Odjel nabave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "3 - Odjel prodaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "4 - Odjel administracije";
            // 
            // frmAdministracijaDodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 283);
            this.Controls.Add(this.gbxOdjeli);
            this.Controls.Add(odjel_idOdjelLabel);
            this.Controls.Add(this.txtOdjel);
            this.Controls.Add(this.txtbxTelefon);
            this.Controls.Add(this.txtbxAdresa);
            this.Controls.Add(this.txtbxLozinka);
            this.Controls.Add(lblLozinka);
            this.Controls.Add(lblTelefon);
            this.Controls.Add(this.txtbxKorisnickoIme);
            this.Controls.Add(lblAdresa);
            this.Controls.Add(lblKorisnickoIme);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtbxOIB);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(lblOIB);
            this.Controls.Add(this.txtbxPrezime);
            this.Controls.Add(lblPrezime);
            this.Controls.Add(this.txtbxIme);
            this.Controls.Add(lblIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministracijaDodajZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zaposlenika";
            this.Load += new System.EventHandler(this.frmAdministracijaDodajZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            this.gbxOdjeli.ResumeLayout(false);
            this.gbxOdjeli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxTelefon;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxLozinka;
        private System.Windows.Forms.TextBox txtbxKorisnickoIme;
        private GizmoDBDataSetTableAdapters.OdjelTableAdapter odjelTableAdapter;
        private System.Windows.Forms.TextBox txtbxIme;
        private System.Windows.Forms.TextBox txtbxPrezime;
        private System.Windows.Forms.TextBox txtbxOIB;
        private System.Windows.Forms.TextBox txtbxAdresa;
        private System.Windows.Forms.TextBox txtOdjel;
        private System.Windows.Forms.GroupBox gbxOdjeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOdjel2;
        private System.Windows.Forms.Label lblOdjel1;

    }
}