namespace GizmoApp.Podforme.Skladiste
{
    partial class frmSkladistePretraziDetalji
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
            System.Windows.Forms.Label kapacitetLabel;
            System.Windows.Forms.Label idSektor_skladistaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladistePretraziDetalji));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.sektor_skladistaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter();
            this.sektor_skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.idSektor_skladistaLabel1 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            kapacitetLabel = new System.Windows.Forms.Label();
            idSektor_skladistaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kapacitetLabel
            // 
            kapacitetLabel.AutoSize = true;
            kapacitetLabel.Location = new System.Drawing.Point(30, 58);
            kapacitetLabel.Name = "kapacitetLabel";
            kapacitetLabel.Size = new System.Drawing.Size(55, 13);
            kapacitetLabel.TabIndex = 23;
            kapacitetLabel.Text = "Kapacitet:";
            // 
            // idSektor_skladistaLabel
            // 
            idSektor_skladistaLabel.AutoSize = true;
            idSektor_skladistaLabel.Location = new System.Drawing.Point(30, 20);
            idSektor_skladistaLabel.Name = "idSektor_skladistaLabel";
            idSektor_skladistaLabel.Size = new System.Drawing.Size(44, 13);
            idSektor_skladistaLabel.TabIndex = 24;
            idSektor_skladistaLabel.Text = "Sektor: ";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(133, 99);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 22;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = null;
            this.tableAdapterManager.Kategorija_has_KnjigaTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_DobavljaciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_KupciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = this.knjigaTableAdapter;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = this.sektor_skladistaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // sektor_skladistaTableAdapter
            // 
            this.sektor_skladistaTableAdapter.ClearBeforeFill = true;
            // 
            // sektor_skladistaBindingSource
            // 
            this.sektor_skladistaBindingSource.DataMember = "Sektor_skladista";
            this.sektor_skladistaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sektor_skladistaBindingSource, "Kapacitet", true));
            this.txtKapacitet.Location = new System.Drawing.Point(91, 55);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(100, 20);
            this.txtKapacitet.TabIndex = 24;
            // 
            // idSektor_skladistaLabel1
            // 
            this.idSektor_skladistaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sektor_skladistaBindingSource, "idSektor_skladista", true));
            this.idSektor_skladistaLabel1.Location = new System.Drawing.Point(91, 20);
            this.idSektor_skladistaLabel1.Name = "idSektor_skladistaLabel1";
            this.idSektor_skladistaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idSektor_skladistaLabel1.TabIndex = 25;
            this.idSektor_skladistaLabel1.Text = "label1";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 99);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 26;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmSkladistePretraziDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 134);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(idSektor_skladistaLabel);
            this.Controls.Add(this.idSektor_skladistaLabel1);
            this.Controls.Add(kapacitetLabel);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.btnZatvori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSkladistePretraziDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o knjizi";
            this.Load += new System.EventHandler(this.frmSkladistePretraziDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter sektor_skladistaTableAdapter;
        private System.Windows.Forms.BindingSource sektor_skladistaBindingSource;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Label idSektor_skladistaLabel1;
        private System.Windows.Forms.Button btnSpremi;
    }
}