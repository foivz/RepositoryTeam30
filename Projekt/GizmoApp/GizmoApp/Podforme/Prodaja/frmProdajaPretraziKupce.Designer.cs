namespace GizmoApp.Podforme.Prodaja
{
    partial class frmProdajaPretraziKupce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaPretraziKupce));
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblKriterij = new System.Windows.Forms.Label();
            this.cmbKriterij = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(215, 103);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.Size = new System.Drawing.Size(960, 255);
            this.dgvPopis.TabIndex = 0;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(284, 60);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(147, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // lblKriterij
            // 
            this.lblKriterij.AutoSize = true;
            this.lblKriterij.Location = new System.Drawing.Point(31, 64);
            this.lblKriterij.Name = "lblKriterij";
            this.lblKriterij.Size = new System.Drawing.Size(41, 13);
            this.lblKriterij.TabIndex = 2;
            this.lblKriterij.Text = "Kriterij: ";
            // 
            // cmbKriterij
            // 
            this.cmbKriterij.FormattingEnabled = true;
            this.cmbKriterij.Location = new System.Drawing.Point(78, 60);
            this.cmbKriterij.Name = "cmbKriterij";
            this.cmbKriterij.Size = new System.Drawing.Size(121, 21);
            this.cmbKriterij.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraga: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dupli klik na jedan zapis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProdajaPretraziKupce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1265, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKriterij);
            this.Controls.Add(this.lblKriterij);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvPopis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaPretraziKupce";
            this.Text = "Pretraga kupaca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopis;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblKriterij;
        private System.Windows.Forms.ComboBox cmbKriterij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}