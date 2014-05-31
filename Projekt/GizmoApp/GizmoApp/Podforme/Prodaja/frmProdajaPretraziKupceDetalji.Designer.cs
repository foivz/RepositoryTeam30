namespace GizmoApp.Podforme.Prodaja
{
    partial class frmProdajaPretraziKupceDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaPretraziKupceDetalji));
            this.gbxKontakt = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.gbxOsobneinformacije = new System.Windows.Forms.GroupBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblNazivVrijednost = new System.Windows.Forms.Label();
            this.lblAdresaVrijednost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailVrijednost = new System.Windows.Forms.Label();
            this.lblTelefonVrijednost = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbxKontakt.SuspendLayout();
            this.gbxOsobneinformacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKontakt
            // 
            this.gbxKontakt.Controls.Add(this.lblTelefonVrijednost);
            this.gbxKontakt.Controls.Add(this.lblEmailVrijednost);
            this.gbxKontakt.Controls.Add(this.lblEmail);
            this.gbxKontakt.Controls.Add(this.lblTelefon);
            this.gbxKontakt.Location = new System.Drawing.Point(23, 147);
            this.gbxKontakt.Name = "gbxKontakt";
            this.gbxKontakt.Size = new System.Drawing.Size(294, 104);
            this.gbxKontakt.TabIndex = 47;
            this.gbxKontakt.TabStop = false;
            this.gbxKontakt.Text = "Kontakt";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(25, 68);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 32;
            this.lblTelefon.Text = "Telefon: ";
            // 
            // gbxOsobneinformacije
            // 
            this.gbxOsobneinformacije.Controls.Add(this.label1);
            this.gbxOsobneinformacije.Controls.Add(this.lblAdresaVrijednost);
            this.gbxOsobneinformacije.Controls.Add(this.lblNazivVrijednost);
            this.gbxOsobneinformacije.Controls.Add(this.lblNaziv);
            this.gbxOsobneinformacije.Controls.Add(this.lblAdresa);
            this.gbxOsobneinformacije.Controls.Add(this.lblOIB);
            this.gbxOsobneinformacije.Location = new System.Drawing.Point(23, 12);
            this.gbxOsobneinformacije.Name = "gbxOsobneinformacije";
            this.gbxOsobneinformacije.Size = new System.Drawing.Size(294, 129);
            this.gbxOsobneinformacije.TabIndex = 46;
            this.gbxOsobneinformacije.TabStop = false;
            this.gbxOsobneinformacije.Text = "Osobne informacije";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(25, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 27;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(25, 60);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(46, 13);
            this.lblAdresa.TabIndex = 28;
            this.lblAdresa.Text = "Adresa: ";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(25, 97);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(31, 13);
            this.lblOIB.TabIndex = 30;
            this.lblOIB.Text = "OIB: ";
            // 
            // lblNazivVrijednost
            // 
            this.lblNazivVrijednost.AutoSize = true;
            this.lblNazivVrijednost.Location = new System.Drawing.Point(71, 28);
            this.lblNazivVrijednost.Name = "lblNazivVrijednost";
            this.lblNazivVrijednost.Size = new System.Drawing.Size(128, 13);
            this.lblNazivVrijednost.TabIndex = 31;
            this.lblNazivVrijednost.Text = "<naziv iz baze podataka>";
            // 
            // lblAdresaVrijednost
            // 
            this.lblAdresaVrijednost.AutoSize = true;
            this.lblAdresaVrijednost.Location = new System.Drawing.Point(71, 60);
            this.lblAdresaVrijednost.Name = "lblAdresaVrijednost";
            this.lblAdresaVrijednost.Size = new System.Drawing.Size(135, 13);
            this.lblAdresaVrijednost.TabIndex = 32;
            this.lblAdresaVrijednost.Text = "<adresa iz baze podataka>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "<adresa iz baze podataka>";
            // 
            // lblEmailVrijednost
            // 
            this.lblEmailVrijednost.AutoSize = true;
            this.lblEmailVrijednost.Location = new System.Drawing.Point(71, 30);
            this.lblEmailVrijednost.Name = "lblEmailVrijednost";
            this.lblEmailVrijednost.Size = new System.Drawing.Size(121, 13);
            this.lblEmailVrijednost.TabIndex = 34;
            this.lblEmailVrijednost.Text = "<mail iz baze podataka>";
            // 
            // lblTelefonVrijednost
            // 
            this.lblTelefonVrijednost.AutoSize = true;
            this.lblTelefonVrijednost.Location = new System.Drawing.Point(71, 68);
            this.lblTelefonVrijednost.Name = "lblTelefonVrijednost";
            this.lblTelefonVrijednost.Size = new System.Drawing.Size(135, 13);
            this.lblTelefonVrijednost.TabIndex = 35;
            this.lblTelefonVrijednost.Text = "<telefon iz baze podataka>";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(132, 287);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(83, 24);
            this.btnZatvori.TabIndex = 48;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmProdajaPretraziKupceDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 323);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.gbxKontakt);
            this.Controls.Add(this.gbxOsobneinformacije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaPretraziKupceDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži kupce - Detalji";
            this.gbxKontakt.ResumeLayout(false);
            this.gbxKontakt.PerformLayout();
            this.gbxOsobneinformacije.ResumeLayout(false);
            this.gbxOsobneinformacije.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKontakt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.GroupBox gbxOsobneinformacije;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblTelefonVrijednost;
        private System.Windows.Forms.Label lblEmailVrijednost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdresaVrijednost;
        private System.Windows.Forms.Label lblNazivVrijednost;
        private System.Windows.Forms.Button btnZatvori;
    }
}