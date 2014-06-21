namespace GizmoApp.Podforme.Prodaja
{
    partial class frmProdajaDodajKupca
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
            System.Windows.Forms.Label lblNaziv;
            System.Windows.Forms.Label lblAdresa;
            System.Windows.Forms.Label lblOIB;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblTelefon;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaDodajKupca));
            this.gbxKontakt = new System.Windows.Forms.GroupBox();
            this.txtbxTelefon = new System.Windows.Forms.TextBox();
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.txtbxEmal = new System.Windows.Forms.TextBox();
            this.gbxOsobneInformacije = new System.Windows.Forms.GroupBox();
            this.txtbxNaziv = new System.Windows.Forms.TextBox();
            this.txtbxAdresa = new System.Windows.Forms.TextBox();
            this.txtbxOIB = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.kupciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KupciTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            lblNaziv = new System.Windows.Forms.Label();
            lblAdresa = new System.Windows.Forms.Label();
            lblOIB = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblTelefon = new System.Windows.Forms.Label();
            this.gbxKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            this.gbxOsobneInformacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new System.Drawing.Point(25, 29);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new System.Drawing.Size(37, 13);
            lblNaziv.TabIndex = 46;
            lblNaziv.Text = "Naziv:";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new System.Drawing.Point(19, 64);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(43, 13);
            lblAdresa.TabIndex = 47;
            lblAdresa.Text = "Adresa:";
            // 
            // lblOIB
            // 
            lblOIB.AutoSize = true;
            lblOIB.Location = new System.Drawing.Point(34, 100);
            lblOIB.Name = "lblOIB";
            lblOIB.Size = new System.Drawing.Size(28, 13);
            lblOIB.TabIndex = 48;
            lblOIB.Text = "OIB:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(27, 34);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 49;
            lblEmail.Text = "Email:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new System.Drawing.Point(16, 72);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new System.Drawing.Size(46, 13);
            lblTelefon.TabIndex = 50;
            lblTelefon.Text = "Telefon:";
            // 
            // gbxKontakt
            // 
            this.gbxKontakt.Controls.Add(this.txtbxTelefon);
            this.gbxKontakt.Controls.Add(lblTelefon);
            this.gbxKontakt.Controls.Add(this.txtbxEmal);
            this.gbxKontakt.Controls.Add(lblEmail);
            this.gbxKontakt.Location = new System.Drawing.Point(20, 149);
            this.gbxKontakt.Name = "gbxKontakt";
            this.gbxKontakt.Size = new System.Drawing.Size(294, 104);
            this.gbxKontakt.TabIndex = 45;
            this.gbxKontakt.TabStop = false;
            this.gbxKontakt.Text = "Kontakt";
            // 
            // txtbxTelefon
            // 
            this.txtbxTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "Telefon", true));
            this.txtbxTelefon.Location = new System.Drawing.Point(77, 69);
            this.txtbxTelefon.Name = "txtbxTelefon";
            this.txtbxTelefon.Size = new System.Drawing.Size(117, 20);
            this.txtbxTelefon.TabIndex = 4;
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataMember = "Kupci";
            this.kupciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbxEmal
            // 
            this.txtbxEmal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "Email", true));
            this.txtbxEmal.Location = new System.Drawing.Point(77, 31);
            this.txtbxEmal.Name = "txtbxEmal";
            this.txtbxEmal.Size = new System.Drawing.Size(192, 20);
            this.txtbxEmal.TabIndex = 3;
            // 
            // gbxOsobneInformacije
            // 
            this.gbxOsobneInformacije.Controls.Add(lblNaziv);
            this.gbxOsobneInformacije.Controls.Add(this.txtbxNaziv);
            this.gbxOsobneInformacije.Controls.Add(lblAdresa);
            this.gbxOsobneInformacije.Controls.Add(this.txtbxAdresa);
            this.gbxOsobneInformacije.Controls.Add(this.txtbxOIB);
            this.gbxOsobneInformacije.Controls.Add(lblOIB);
            this.gbxOsobneInformacije.Location = new System.Drawing.Point(20, 14);
            this.gbxOsobneInformacije.Name = "gbxOsobneInformacije";
            this.gbxOsobneInformacije.Size = new System.Drawing.Size(294, 129);
            this.gbxOsobneInformacije.TabIndex = 44;
            this.gbxOsobneInformacije.TabStop = false;
            this.gbxOsobneInformacije.Text = "Osobne informacije";
            // 
            // txtbxNaziv
            // 
            this.txtbxNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "Naziv", true));
            this.txtbxNaziv.Location = new System.Drawing.Point(77, 29);
            this.txtbxNaziv.Name = "txtbxNaziv";
            this.txtbxNaziv.Size = new System.Drawing.Size(192, 20);
            this.txtbxNaziv.TabIndex = 0;
            // 
            // txtbxAdresa
            // 
            this.txtbxAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "Adresa", true));
            this.txtbxAdresa.Location = new System.Drawing.Point(77, 61);
            this.txtbxAdresa.Name = "txtbxAdresa";
            this.txtbxAdresa.Size = new System.Drawing.Size(192, 20);
            this.txtbxAdresa.TabIndex = 1;
            // 
            // txtbxOIB
            // 
            this.txtbxOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "OIB", true));
            this.txtbxOIB.Location = new System.Drawing.Point(77, 97);
            this.txtbxOIB.Name = "txtbxOIB";
            this.txtbxOIB.Size = new System.Drawing.Size(117, 20);
            this.txtbxOIB.TabIndex = 2;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(225, 273);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(89, 30);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(20, 273);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 30);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSpremi_MouseUp);
            // 
            // kupciTableAdapter
            // 
            this.kupciTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KupciTableAdapter = this.kupciTableAdapter;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // frmProdajaDodajKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 323);
            this.Controls.Add(this.gbxKontakt);
            this.Controls.Add(this.gbxOsobneInformacije);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaDodajKupca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj kupca";
            this.Load += new System.EventHandler(this.frmProdajaDodajKupca_Load);
            this.gbxKontakt.ResumeLayout(false);
            this.gbxKontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            this.gbxOsobneInformacije.ResumeLayout(false);
            this.gbxOsobneInformacije.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKontakt;
        private System.Windows.Forms.GroupBox gbxOsobneInformacije;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private GizmoDBDataSetTableAdapters.KupciTableAdapter kupciTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxNaziv;
        private System.Windows.Forms.TextBox txtbxAdresa;
        private System.Windows.Forms.TextBox txtbxOIB;
        private System.Windows.Forms.TextBox txtbxEmal;
        private System.Windows.Forms.TextBox txtbxTelefon;


    }
}