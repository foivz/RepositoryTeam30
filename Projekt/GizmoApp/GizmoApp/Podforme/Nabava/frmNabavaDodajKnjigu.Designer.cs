namespace GizmoApp.Podforme.Nabava
{
    partial class frmNabavaDodajKnjigu
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
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            System.Windows.Forms.Label lblKategorija;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaDodajKnjigu));
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.kategorija_has_KnjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Kategorija_has_KnjigaTableAdapter();
            this.kategorijaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KategorijaTableAdapter();
            this.txtbxNaziv = new System.Windows.Forms.TextBox();
            this.txbxJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.kategorija_has_KnjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbxKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblKn = new System.Windows.Forms.Label();
            lblNaziv = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            lblKategorija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija_has_KnjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new System.Drawing.Point(23, 24);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new System.Drawing.Size(37, 13);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(23, 58);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 2;
            jedinicna_cijenaLabel.Text = "Jedinična cijena:";
            // 
            // lblKategorija
            // 
            lblKategorija.AutoSize = true;
            lblKategorija.Location = new System.Drawing.Point(23, 101);
            lblKategorija.Name = "lblKategorija";
            lblKategorija.Size = new System.Drawing.Size(60, 13);
            lblKategorija.TabIndex = 4;
            lblKategorija.Text = "Kategorija: ";
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = null;
            this.tableAdapterManager.Kategorija_has_KnjigaTableAdapter = this.kategorija_has_KnjigaTableAdapter;
            this.tableAdapterManager.KategorijaTableAdapter = this.kategorijaTableAdapter;
            this.tableAdapterManager.Knjiga_has_DobavljaciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_KupciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = this.knjigaTableAdapter;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // kategorija_has_KnjigaTableAdapter
            // 
            this.kategorija_has_KnjigaTableAdapter.ClearBeforeFill = true;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // txtbxNaziv
            // 
            this.txtbxNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "Naziv", true));
            this.txtbxNaziv.Location = new System.Drawing.Point(115, 17);
            this.txtbxNaziv.Name = "txtbxNaziv";
            this.txtbxNaziv.Size = new System.Drawing.Size(162, 20);
            this.txtbxNaziv.TabIndex = 2;
            // 
            // txbxJedinicnaCijena
            // 
            this.txbxJedinicnaCijena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "Jedinicna_cijena", true));
            this.txbxJedinicnaCijena.Location = new System.Drawing.Point(115, 55);
            this.txbxJedinicnaCijena.Name = "txbxJedinicnaCijena";
            this.txbxJedinicnaCijena.Size = new System.Drawing.Size(87, 20);
            this.txbxJedinicnaCijena.TabIndex = 3;
            // 
            // kategorija_has_KnjigaBindingSource
            // 
            this.kategorija_has_KnjigaBindingSource.DataMember = "FK_Kategorija_has_Knjiga_Knjiga";
            this.kategorija_has_KnjigaBindingSource.DataSource = this.knjigaBindingSource;
            // 
            // cmbxKategorija
            // 
            this.cmbxKategorija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorija_has_KnjigaBindingSource, "Kategorija_idKategorija", true));
            this.cmbxKategorija.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategorijaBindingSource, "idKategorija", true));
            this.cmbxKategorija.DataSource = this.kategorijaBindingSource;
            this.cmbxKategorija.DisplayMember = "Naziv";
            this.cmbxKategorija.FormattingEnabled = true;
            this.cmbxKategorija.Location = new System.Drawing.Point(115, 98);
            this.cmbxKategorija.Name = "cmbxKategorija";
            this.cmbxKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbxKategorija.TabIndex = 5;
            this.cmbxKategorija.ValueMember = "idKategorija";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(37, 153);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(193, 153);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblKn
            // 
            this.lblKn.AutoSize = true;
            this.lblKn.Location = new System.Drawing.Point(208, 58);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(20, 13);
            this.lblKn.TabIndex = 8;
            this.lblKn.Text = "Kn";
            // 
            // frmNabavaDodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 199);
            this.Controls.Add(this.lblKn);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(lblKategorija);
            this.Controls.Add(this.cmbxKategorija);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.txbxJedinicnaCijena);
            this.Controls.Add(lblNaziv);
            this.Controls.Add(this.txtbxNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaDodajKnjigu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj knjigu";
            this.Load += new System.EventHandler(this.frmNabavaDodajKnjigu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija_has_KnjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxNaziv;
        private GizmoDBDataSetTableAdapters.Kategorija_has_KnjigaTableAdapter kategorija_has_KnjigaTableAdapter;
        private System.Windows.Forms.TextBox txbxJedinicnaCijena;
        private System.Windows.Forms.BindingSource kategorija_has_KnjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.ComboBox cmbxKategorija;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblKn;
    }
}