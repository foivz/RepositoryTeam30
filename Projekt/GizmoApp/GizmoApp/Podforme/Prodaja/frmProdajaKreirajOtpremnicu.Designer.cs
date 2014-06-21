namespace GizmoApp.Podforme.Prodaja
{
    partial class frmProdajaKreirajOtpremnicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaKreirajOtpremnicu));
            this.btnKreirajOtpremnicu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNarucitelj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOtpremnica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtpremnica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKreirajOtpremnicu
            // 
            this.btnKreirajOtpremnicu.Location = new System.Drawing.Point(347, 321);
            this.btnKreirajOtpremnicu.Name = "btnKreirajOtpremnicu";
            this.btnKreirajOtpremnicu.Size = new System.Drawing.Size(146, 23);
            this.btnKreirajOtpremnicu.TabIndex = 15;
            this.btnKreirajOtpremnicu.Text = "Kreiraj otpremnicu";
            this.btnKreirajOtpremnicu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naručitelj: ";
            // 
            // cmbNarucitelj
            // 
            this.cmbNarucitelj.FormattingEnabled = true;
            this.cmbNarucitelj.Location = new System.Drawing.Point(100, 55);
            this.cmbNarucitelj.Name = "cmbNarucitelj";
            this.cmbNarucitelj.Size = new System.Drawing.Size(121, 21);
            this.cmbNarucitelj.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Otpremnica za <datum>";
            // 
            // dgOtpremnica
            // 
            this.dgOtpremnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOtpremnica.Location = new System.Drawing.Point(27, 91);
            this.dgOtpremnica.Name = "dgOtpremnica";
            this.dgOtpremnica.Size = new System.Drawing.Size(781, 151);
            this.dgOtpremnica.TabIndex = 8;
            // 
            // frmProdajaKreirajOtpremnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 396);
            this.Controls.Add(this.btnKreirajOtpremnicu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNarucitelj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgOtpremnica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaKreirajOtpremnicu";
            this.Text = "Kreiraj otpremnicu";
            ((System.ComponentModel.ISupportInitialize)(this.dgOtpremnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreirajOtpremnicu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNarucitelj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOtpremnica;

    }
}