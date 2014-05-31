namespace GizmoApp.Podforme.Prodaja
{
    partial class frmProdajaUrediKupca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaUrediKupca));
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(173, 54);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.Size = new System.Drawing.Size(960, 255);
            this.dgvPopis.TabIndex = 1;
            this.dgvPopis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopis_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Double click na jednog kupca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProdajaUrediKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPopis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaUrediKupca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi kupca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopis;
        private System.Windows.Forms.Button button1;


    }
}