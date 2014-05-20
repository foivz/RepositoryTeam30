namespace GizmoApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtboxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtboxLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(89, 97);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(93, 13);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(89, 128);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(55, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // txtboxKorisnickoIme
            // 
            this.txtboxKorisnickoIme.Location = new System.Drawing.Point(183, 94);
            this.txtboxKorisnickoIme.Name = "txtboxKorisnickoIme";
            this.txtboxKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtboxKorisnickoIme.TabIndex = 3;
            this.txtboxKorisnickoIme.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxKorisnickoIme_KeyUp);
            // 
            // txtboxLozinka
            // 
            this.txtboxLozinka.Location = new System.Drawing.Point(183, 125);
            this.txtboxLozinka.Name = "txtboxLozinka";
            this.txtboxLozinka.PasswordChar = '*';
            this.txtboxLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtboxLozinka.TabIndex = 4;
            this.txtboxLozinka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxLozinka_KeyUp);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijaviSe.Location = new System.Drawing.Point(183, 195);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(100, 30);
            this.btnPrijaviSe.TabIndex = 5;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPrijaviSe_MouseUp);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(407, 300);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtboxLozinka);
            this.Controls.Add(this.txtboxKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gizmo App";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtboxKorisnickoIme;
        private System.Windows.Forms.TextBox txtboxLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
    }
}

