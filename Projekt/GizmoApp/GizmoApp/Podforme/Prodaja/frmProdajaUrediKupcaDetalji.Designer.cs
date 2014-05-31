namespace GizmoApp.Podforme.Prodaja
{
    partial class frmProdajaUrediKupcaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaUrediKupcaDetalji));
            this.lblIdVrijednost = new System.Windows.Forms.Label();
            this.lblIdOznaka = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.gbxOsobneinformacije = new System.Windows.Forms.GroupBox();
            this.gbxKontakt = new System.Windows.Forms.GroupBox();
            this.gbxOsobneinformacije.SuspendLayout();
            this.gbxKontakt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdVrijednost
            // 
            this.lblIdVrijednost.AutoSize = true;
            this.lblIdVrijednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdVrijednost.Location = new System.Drawing.Point(52, 18);
            this.lblIdVrijednost.Name = "lblIdVrijednost";
            this.lblIdVrijednost.Size = new System.Drawing.Size(85, 15);
            this.lblIdVrijednost.TabIndex = 39;
            this.lblIdVrijednost.Text = "<id iz baze>";
            // 
            // lblIdOznaka
            // 
            this.lblIdOznaka.AutoSize = true;
            this.lblIdOznaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdOznaka.Location = new System.Drawing.Point(17, 18);
            this.lblIdOznaka.Name = "lblIdOznaka";
            this.lblIdOznaka.Size = new System.Drawing.Size(29, 15);
            this.lblIdOznaka.TabIndex = 38;
            this.lblIdOznaka.Text = "ID: ";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(200, 307);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(89, 30);
            this.btnOdustani.TabIndex = 37;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(28, 307);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 30);
            this.btnSpremi.TabIndex = 36;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(77, 65);
            this.txtTelefon.MaxLength = 45;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(117, 20);
            this.txtTelefon.TabIndex = 35;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 27);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(77, 97);
            this.txtOIB.MaxLength = 11;
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(117, 20);
            this.txtOIB.TabIndex = 33;
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail: ";
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
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(77, 60);
            this.txtAdresa.MaxLength = 45;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(192, 20);
            this.txtAdresa.TabIndex = 29;
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
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(25, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 27;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(77, 25);
            this.txtNaziv.MaxLength = 45;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(192, 20);
            this.txtNaziv.TabIndex = 26;
            // 
            // gbxOsobneinformacije
            // 
            this.gbxOsobneinformacije.Controls.Add(this.txtAdresa);
            this.gbxOsobneinformacije.Controls.Add(this.txtNaziv);
            this.gbxOsobneinformacije.Controls.Add(this.lblNaziv);
            this.gbxOsobneinformacije.Controls.Add(this.lblAdresa);
            this.gbxOsobneinformacije.Controls.Add(this.lblOIB);
            this.gbxOsobneinformacije.Controls.Add(this.txtOIB);
            this.gbxOsobneinformacije.Location = new System.Drawing.Point(20, 48);
            this.gbxOsobneinformacije.Name = "gbxOsobneinformacije";
            this.gbxOsobneinformacije.Size = new System.Drawing.Size(294, 129);
            this.gbxOsobneinformacije.TabIndex = 40;
            this.gbxOsobneinformacije.TabStop = false;
            this.gbxOsobneinformacije.Text = "Osobne informacije";
            // 
            // gbxKontakt
            // 
            this.gbxKontakt.Controls.Add(this.txtTelefon);
            this.gbxKontakt.Controls.Add(this.lblEmail);
            this.gbxKontakt.Controls.Add(this.lblTelefon);
            this.gbxKontakt.Controls.Add(this.txtEmail);
            this.gbxKontakt.Location = new System.Drawing.Point(20, 183);
            this.gbxKontakt.Name = "gbxKontakt";
            this.gbxKontakt.Size = new System.Drawing.Size(294, 104);
            this.gbxKontakt.TabIndex = 41;
            this.gbxKontakt.TabStop = false;
            this.gbxKontakt.Text = "Kontakt";
            // 
            // frmProdajaUrediKupcaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 353);
            this.Controls.Add(this.gbxKontakt);
            this.Controls.Add(this.gbxOsobneinformacije);
            this.Controls.Add(this.lblIdVrijednost);
            this.Controls.Add(this.lblIdOznaka);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaUrediKupcaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi kupca - detalji";
            this.gbxOsobneinformacije.ResumeLayout(false);
            this.gbxOsobneinformacije.PerformLayout();
            this.gbxKontakt.ResumeLayout(false);
            this.gbxKontakt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdVrijednost;
        private System.Windows.Forms.Label lblIdOznaka;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.GroupBox gbxOsobneinformacije;
        private System.Windows.Forms.GroupBox gbxKontakt;
    }
}