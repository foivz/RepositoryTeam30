﻿namespace GizmoApp.Podforme.Nabava
{
    partial class frmNabavaUrediDobavljaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaUrediDobavljaca));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Double click na jednog dobavljača";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(127, 71);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.Size = new System.Drawing.Size(960, 255);
            this.dgvPopis.TabIndex = 3;
            // 
            // frmNabavaUrediDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPopis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaUrediDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi dobavljača";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPopis;


    }
}