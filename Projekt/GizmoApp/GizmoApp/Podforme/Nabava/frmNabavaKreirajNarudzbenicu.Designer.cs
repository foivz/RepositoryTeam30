namespace GizmoApp.Podforme.Nabava
{
    partial class frmNabavaKreirajNarudzbenicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaKreirajNarudzbenicu));
            this.dgPopisNarudzbi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajNarudzbu = new System.Windows.Forms.Button();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKreirajNarudzbenicu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisNarudzbi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPopisNarudzbi
            // 
            this.dgPopisNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPopisNarudzbi.Location = new System.Drawing.Point(12, 89);
            this.dgPopisNarudzbi.Name = "dgPopisNarudzbi";
            this.dgPopisNarudzbi.Size = new System.Drawing.Size(471, 151);
            this.dgPopisNarudzbi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis narudžbi za <datum>";
            // 
            // btnDodajNarudzbu
            // 
            this.btnDodajNarudzbu.Location = new System.Drawing.Point(12, 255);
            this.btnDodajNarudzbu.Name = "btnDodajNarudzbu";
            this.btnDodajNarudzbu.Size = new System.Drawing.Size(112, 23);
            this.btnDodajNarudzbu.TabIndex = 2;
            this.btnDodajNarudzbu.Text = "Dodaj narudžbu";
            this.btnDodajNarudzbu.UseVisualStyleBackColor = true;
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(85, 53);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(121, 21);
            this.cmbDobavljac.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dobavljač: ";
            // 
            // btnKreirajNarudzbenicu
            // 
            this.btnKreirajNarudzbenicu.Location = new System.Drawing.Point(165, 328);
            this.btnKreirajNarudzbenicu.Name = "btnKreirajNarudzbenicu";
            this.btnKreirajNarudzbenicu.Size = new System.Drawing.Size(146, 30);
            this.btnKreirajNarudzbenicu.TabIndex = 7;
            this.btnKreirajNarudzbenicu.Text = "Kreiraj narudžbenicu";
            this.btnKreirajNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnKreirajNarudzbenicu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKreirajNarudzbenicu_MouseClick);
            // 
            // frmNabavaKreirajNarudzbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 403);
            this.Controls.Add(this.btnKreirajNarudzbenicu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.btnDodajNarudzbu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPopisNarudzbi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaKreirajNarudzbenicu";
            this.Text = "Kreiraj narudžbenicu";
            ((System.ComponentModel.ISupportInitialize)(this.dgPopisNarudzbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPopisNarudzbi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajNarudzbu;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKreirajNarudzbenicu;

    }
}