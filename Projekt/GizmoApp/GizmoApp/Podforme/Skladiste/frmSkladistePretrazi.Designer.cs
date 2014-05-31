namespace GizmoApp.Podforme.Skladiste
{
    partial class frmSkladistePretrazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladistePretrazi));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKriterij = new System.Windows.Forms.ComboBox();
            this.lblKriterij = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dupli klik na jedan zapis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pretraga: ";
            // 
            // cmbKriterij
            // 
            this.cmbKriterij.FormattingEnabled = true;
            this.cmbKriterij.Location = new System.Drawing.Point(94, 57);
            this.cmbKriterij.Name = "cmbKriterij";
            this.cmbKriterij.Size = new System.Drawing.Size(121, 21);
            this.cmbKriterij.TabIndex = 9;
            // 
            // lblKriterij
            // 
            this.lblKriterij.AutoSize = true;
            this.lblKriterij.Location = new System.Drawing.Point(47, 61);
            this.lblKriterij.Name = "lblKriterij";
            this.lblKriterij.Size = new System.Drawing.Size(41, 13);
            this.lblKriterij.TabIndex = 8;
            this.lblKriterij.Text = "Kriterij: ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(300, 57);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(147, 20);
            this.txtPretraga.TabIndex = 7;
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(231, 100);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.Size = new System.Drawing.Size(960, 255);
            this.dgvPopis.TabIndex = 6;
            // 
            // frmSkladistePretrazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKriterij);
            this.Controls.Add(this.lblKriterij);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvPopis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSkladistePretrazi";
            this.Text = "Pretraži skladište";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKriterij;
        private System.Windows.Forms.Label lblKriterij;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPopis;

    }
}