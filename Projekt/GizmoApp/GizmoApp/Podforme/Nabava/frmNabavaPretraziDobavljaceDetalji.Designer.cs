﻿namespace GizmoApp.Podforme.Nabava
{
    partial class frmNabavaPretraziDobavljaceDetalji
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
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaPretraziDobavljaceDetalji));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.gbxKontakt = new System.Windows.Forms.GroupBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.txtbxTelefon = new System.Windows.Forms.TextBox();
            this.gbxOsobneinformacije = new System.Windows.Forms.GroupBox();
            this.txtbxOIB = new System.Windows.Forms.TextBox();
            this.txtbxAdresa = new System.Windows.Forms.TextBox();
            this.txtbxNaziv = new System.Windows.Forms.TextBox();
            this.dobavljaciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.DobavljaciTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnSpremi = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.gbxKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            this.gbxOsobneinformacije.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(25, 32);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Naziv:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(25, 65);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 2;
            adresaLabel.Text = "Adresa:";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(25, 102);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(28, 13);
            oIBLabel.TabIndex = 4;
            oIBLabel.Text = "OIB:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(22, 34);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 0;
            telefonLabel.Text = "Telefon:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(32, 74);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(224, 303);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(83, 24);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // gbxKontakt
            // 
            this.gbxKontakt.Controls.Add(emailLabel);
            this.gbxKontakt.Controls.Add(this.txtbxEmail);
            this.gbxKontakt.Controls.Add(telefonLabel);
            this.gbxKontakt.Controls.Add(this.txtbxTelefon);
            this.gbxKontakt.Location = new System.Drawing.Point(14, 162);
            this.gbxKontakt.Name = "gbxKontakt";
            this.gbxKontakt.Size = new System.Drawing.Size(294, 116);
            this.gbxKontakt.TabIndex = 50;
            this.gbxKontakt.TabStop = false;
            this.gbxKontakt.Text = "Kontakt";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Email", true));
            this.txtbxEmail.Location = new System.Drawing.Point(73, 71);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(204, 20);
            this.txtbxEmail.TabIndex = 3;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "Dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbxTelefon
            // 
            this.txtbxTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Telefon", true));
            this.txtbxTelefon.Location = new System.Drawing.Point(74, 31);
            this.txtbxTelefon.Name = "txtbxTelefon";
            this.txtbxTelefon.Size = new System.Drawing.Size(203, 20);
            this.txtbxTelefon.TabIndex = 1;
            // 
            // gbxOsobneinformacije
            // 
            this.gbxOsobneinformacije.Controls.Add(oIBLabel);
            this.gbxOsobneinformacije.Controls.Add(this.txtbxOIB);
            this.gbxOsobneinformacije.Controls.Add(adresaLabel);
            this.gbxOsobneinformacije.Controls.Add(this.txtbxAdresa);
            this.gbxOsobneinformacije.Controls.Add(nazivLabel);
            this.gbxOsobneinformacije.Controls.Add(this.txtbxNaziv);
            this.gbxOsobneinformacije.Location = new System.Drawing.Point(13, 12);
            this.gbxOsobneinformacije.Name = "gbxOsobneinformacije";
            this.gbxOsobneinformacije.Size = new System.Drawing.Size(294, 144);
            this.gbxOsobneinformacije.TabIndex = 49;
            this.gbxOsobneinformacije.TabStop = false;
            this.gbxOsobneinformacije.Text = "Osobne informacije";
            // 
            // txtbxOIB
            // 
            this.txtbxOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "OIB", true));
            this.txtbxOIB.Location = new System.Drawing.Point(74, 99);
            this.txtbxOIB.Name = "txtbxOIB";
            this.txtbxOIB.Size = new System.Drawing.Size(204, 20);
            this.txtbxOIB.TabIndex = 5;
            // 
            // txtbxAdresa
            // 
            this.txtbxAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Adresa", true));
            this.txtbxAdresa.Location = new System.Drawing.Point(74, 65);
            this.txtbxAdresa.Name = "txtbxAdresa";
            this.txtbxAdresa.Size = new System.Drawing.Size(204, 20);
            this.txtbxAdresa.TabIndex = 3;
            // 
            // txtbxNaziv
            // 
            this.txtbxNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "Naziv", true));
            this.txtbxNaziv.Location = new System.Drawing.Point(75, 29);
            this.txtbxNaziv.Name = "txtbxNaziv";
            this.txtbxNaziv.Size = new System.Drawing.Size(203, 20);
            this.txtbxNaziv.TabIndex = 1;
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
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnSpremi);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gbxOsobneinformacije);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnOdustani);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gbxKontakt);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(319, 366);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(319, 366);
            this.toolStripContainer1.TabIndex = 54;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(14, 303);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(83, 24);
            this.btnSpremi.TabIndex = 52;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmNabavaPretraziDobavljaceDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 366);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaPretraziDobavljaceDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži dobavljače - Detalji";
            this.Load += new System.EventHandler(this.frmNabavaPretraziDobavljaceDetalji_Load);
            this.gbxKontakt.ResumeLayout(false);
            this.gbxKontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            this.gbxOsobneinformacije.ResumeLayout(false);
            this.gbxOsobneinformacije.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox gbxKontakt;
        private System.Windows.Forms.GroupBox gbxOsobneinformacije;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private GizmoDBDataSetTableAdapters.DobavljaciTableAdapter dobavljaciTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxOIB;
        private System.Windows.Forms.TextBox txtbxAdresa;
        private System.Windows.Forms.TextBox txtbxNaziv;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxTelefon;
        private System.Windows.Forms.Button btnSpremi;
    }
}