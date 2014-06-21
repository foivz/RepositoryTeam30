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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            System.Windows.Forms.Label kategorija_idKategorijaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaDodajKnjigu));
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.kategorija_has_KnjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Kategorija_has_KnjigaTableAdapter();
            this.kategorijaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KategorijaTableAdapter();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.jedinicna_cijenaTextBox = new System.Windows.Forms.TextBox();
            this.kategorija_has_KnjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorija_idKategorijaComboBox = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            kategorija_idKategorijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorija_has_KnjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(23, 67);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 1;
            nazivLabel.Text = "Naziv:";
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(23, 101);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 2;
            jedinicna_cijenaLabel.Text = "Jedinicna cijena:";
            // 
            // kategorija_idKategorijaLabel
            // 
            kategorija_idKategorijaLabel.AutoSize = true;
            kategorija_idKategorijaLabel.Location = new System.Drawing.Point(12, 147);
            kategorija_idKategorijaLabel.Name = "kategorija_idKategorijaLabel";
            kategorija_idKategorijaLabel.Size = new System.Drawing.Size(118, 13);
            kategorija_idKategorijaLabel.TabIndex = 4;
            kategorija_idKategorijaLabel.Text = "Kategorija id Kategorija:";
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
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(133, 60);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 2;
            // 
            // jedinicna_cijenaTextBox
            // 
            this.jedinicna_cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knjigaBindingSource, "Jedinicna_cijena", true));
            this.jedinicna_cijenaTextBox.Location = new System.Drawing.Point(133, 98);
            this.jedinicna_cijenaTextBox.Name = "jedinicna_cijenaTextBox";
            this.jedinicna_cijenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinicna_cijenaTextBox.TabIndex = 3;
            // 
            // kategorija_has_KnjigaBindingSource
            // 
            this.kategorija_has_KnjigaBindingSource.DataMember = "FK_Kategorija_has_Knjiga_Knjiga";
            this.kategorija_has_KnjigaBindingSource.DataSource = this.knjigaBindingSource;
            // 
            // kategorija_idKategorijaComboBox
            // 
            this.kategorija_idKategorijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorija_has_KnjigaBindingSource, "Kategorija_idKategorija", true));
            this.kategorija_idKategorijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategorijaBindingSource, "idKategorija", true));
            this.kategorija_idKategorijaComboBox.DataSource = this.kategorijaBindingSource;
            this.kategorija_idKategorijaComboBox.DisplayMember = "Naziv";
            this.kategorija_idKategorijaComboBox.FormattingEnabled = true;
            this.kategorija_idKategorijaComboBox.Location = new System.Drawing.Point(136, 144);
            this.kategorija_idKategorijaComboBox.Name = "kategorija_idKategorijaComboBox";
            this.kategorija_idKategorijaComboBox.Size = new System.Drawing.Size(121, 21);
            this.kategorija_idKategorijaComboBox.TabIndex = 5;
            this.kategorija_idKategorijaComboBox.ValueMember = "idKategorija";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(26, 201);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(182, 201);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmNabavaDodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(kategorija_idKategorijaLabel);
            this.Controls.Add(this.kategorija_idKategorijaComboBox);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.jedinicna_cijenaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaDodajKnjigu";
            this.Text = "frmNabavaDodajKnjigu";
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
        private System.Windows.Forms.TextBox nazivTextBox;
        private GizmoDBDataSetTableAdapters.Kategorija_has_KnjigaTableAdapter kategorija_has_KnjigaTableAdapter;
        private System.Windows.Forms.TextBox jedinicna_cijenaTextBox;
        private System.Windows.Forms.BindingSource kategorija_has_KnjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.ComboBox kategorija_idKategorijaComboBox;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}