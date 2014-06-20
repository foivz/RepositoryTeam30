namespace GizmoApp.Podforme.Nabava
{
    partial class frmNabavaDodajDobavljaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaDodajDobavljaca));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.gpxOsobneInformacije = new System.Windows.Forms.GroupBox();
            this.gpxKontakt = new System.Windows.Forms.GroupBox();
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.DobavljaciTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.txtbxNaziv = new System.Windows.Forms.TextBox();
            this.txtbxAdresa = new System.Windows.Forms.TextBox();
            this.txtbxOIB = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxTelefon = new System.Windows.Forms.TextBox();
            lblNaziv = new System.Windows.Forms.Label();
            lblAdresa = new System.Windows.Forms.Label();
            lblOIB = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblTelefon = new System.Windows.Forms.Label();
            this.gpxOsobneInformacije.SuspendLayout();
            this.gpxKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(202, 292);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(89, 30);
            this.btnOdustani.TabIndex = 37;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(22, 292);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 30);
            this.btnSpremi.TabIndex = 36;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSpremi_MouseUp);
            // 
            // gpxOsobneInformacije
            // 
            this.gpxOsobneInformacije.Controls.Add(lblNaziv);
            this.gpxOsobneInformacije.Controls.Add(this.txtbxNaziv);
            this.gpxOsobneInformacije.Controls.Add(lblAdresa);
            this.gpxOsobneInformacije.Controls.Add(lblOIB);
            this.gpxOsobneInformacije.Controls.Add(this.txtbxOIB);
            this.gpxOsobneInformacije.Controls.Add(this.txtbxAdresa);
            this.gpxOsobneInformacije.Location = new System.Drawing.Point(12, 12);
            this.gpxOsobneInformacije.Name = "gpxOsobneInformacije";
            this.gpxOsobneInformacije.Size = new System.Drawing.Size(299, 133);
            this.gpxOsobneInformacije.TabIndex = 38;
            this.gpxOsobneInformacije.TabStop = false;
            this.gpxOsobneInformacije.Text = "Osobne inofrmacije";
            // 
            // gpxKontakt
            // 
            this.gpxKontakt.Controls.Add(this.txtbxTelefon);
            this.gpxKontakt.Controls.Add(lblTelefon);
            this.gpxKontakt.Controls.Add(this.txtbxEmail);
            this.gpxKontakt.Controls.Add(lblEmail);
            this.gpxKontakt.Location = new System.Drawing.Point(12, 151);
            this.gpxKontakt.Name = "gpxKontakt";
            this.gpxKontakt.Size = new System.Drawing.Size(299, 111);
            this.gpxKontakt.TabIndex = 39;
            this.gpxKontakt.TabStop = false;
            this.gpxKontakt.Text = "Kontakt";
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "Dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = this.dobavljaciTableAdapter;
            this.tableAdapterManager.Kategorija_has_KnjigaTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_DobavljaciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_KupciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new System.Drawing.Point(27, 25);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new System.Drawing.Size(37, 13);
            lblNaziv.TabIndex = 40;
            lblNaziv.Text = "Naziv:";
            // 
            // txtbxNaziv
            // 
            this.txtbxNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Naziv", true));
            this.txtbxNaziv.Location = new System.Drawing.Point(87, 22);
            this.txtbxNaziv.Name = "txtbxNaziv";
            this.txtbxNaziv.Size = new System.Drawing.Size(192, 20);
            this.txtbxNaziv.TabIndex = 41;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new System.Drawing.Point(27, 60);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(43, 13);
            lblAdresa.TabIndex = 41;
            lblAdresa.Text = "Adresa:";
            // 
            // txtbxAdresa
            // 
            this.txtbxAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Adresa", true));
            this.txtbxAdresa.Location = new System.Drawing.Point(87, 57);
            this.txtbxAdresa.Name = "txtbxAdresa";
            this.txtbxAdresa.Size = new System.Drawing.Size(192, 20);
            this.txtbxAdresa.TabIndex = 42;
            // 
            // lblOIB
            // 
            lblOIB.AutoSize = true;
            lblOIB.Location = new System.Drawing.Point(36, 97);
            lblOIB.Name = "lblOIB";
            lblOIB.Size = new System.Drawing.Size(28, 13);
            lblOIB.TabIndex = 42;
            lblOIB.Text = "OIB:";
            // 
            // txtbxOIB
            // 
            this.txtbxOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "OIB", true));
            this.txtbxOIB.Location = new System.Drawing.Point(87, 94);
            this.txtbxOIB.Name = "txtbxOIB";
            this.txtbxOIB.Size = new System.Drawing.Size(117, 20);
            this.txtbxOIB.TabIndex = 43;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(35, 28);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "Email:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Email", true));
            this.txtbxEmail.Location = new System.Drawing.Point(87, 25);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(192, 20);
            this.txtbxEmail.TabIndex = 44;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new System.Drawing.Point(27, 66);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new System.Drawing.Size(46, 13);
            lblTelefon.TabIndex = 44;
            lblTelefon.Text = "Telefon:";
            // 
            // txtbxTelefon
            // 
            this.txtbxTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Telefon", true));
            this.txtbxTelefon.Location = new System.Drawing.Point(87, 63);
            this.txtbxTelefon.Name = "txtbxTelefon";
            this.txtbxTelefon.Size = new System.Drawing.Size(117, 20);
            this.txtbxTelefon.TabIndex = 45;
            // 
            // frmNabavaDodajDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 342);
            this.Controls.Add(this.gpxKontakt);
            this.Controls.Add(this.gpxOsobneInformacije);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaDodajDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj dobavljača";
            this.Load += new System.EventHandler(this.frmNabavaDodajDobavljaca_Load);
            this.gpxOsobneInformacije.ResumeLayout(false);
            this.gpxOsobneInformacije.PerformLayout();
            this.gpxKontakt.ResumeLayout(false);
            this.gpxKontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.GroupBox gpxOsobneInformacije;
        private System.Windows.Forms.GroupBox gpxKontakt;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private GizmoDBDataSetTableAdapters.DobavljaciTableAdapter dobavljaciTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxNaziv;
        private System.Windows.Forms.TextBox txtbxOIB;
        private System.Windows.Forms.TextBox txtbxAdresa;
        private System.Windows.Forms.TextBox txtbxTelefon;
        private System.Windows.Forms.TextBox txtbxEmail;

    }
}