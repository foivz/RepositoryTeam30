namespace GizmoApp.Podforme.Skladiste
{
    partial class frmSkladisteDodajSektor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladisteDodajSektor));
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.sektor_skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektor_skladistaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.txtbxKapacitet = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            kapacitetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kapacitetLabel
            // 
            kapacitetLabel.AutoSize = true;
            kapacitetLabel.Location = new System.Drawing.Point(38, 69);
            kapacitetLabel.Name = "kapacitetLabel";
            kapacitetLabel.Size = new System.Drawing.Size(55, 13);
            kapacitetLabel.TabIndex = 1;
            kapacitetLabel.Text = "Kapacitet:";
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sektor_skladistaBindingSource
            // 
            this.sektor_skladistaBindingSource.DataMember = "Sektor_skladista";
            this.sektor_skladistaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // sektor_skladistaTableAdapter
            // 
            this.sektor_skladistaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = this.sektor_skladistaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // txtbxKapacitet
            // 
            this.txtbxKapacitet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sektor_skladistaBindingSource, "Kapacitet", true));
            this.txtbxKapacitet.Location = new System.Drawing.Point(121, 66);
            this.txtbxKapacitet.Name = "txtbxKapacitet";
            this.txtbxKapacitet.Size = new System.Drawing.Size(100, 20);
            this.txtbxKapacitet.TabIndex = 2;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(41, 25);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(161, 13);
            this.lblNaslov.TabIndex = 3;
            this.lblNaslov.Text = "Unesite kapacitet novog sektora";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(41, 123);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(174, 123);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmSkladisteDodajSektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 182);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(kapacitetLabel);
            this.Controls.Add(this.txtbxKapacitet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSkladisteDodajSektor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj sektor";
            this.Load += new System.EventHandler(this.frmSkladisteDodajSektor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource sektor_skladistaBindingSource;
        private GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter sektor_skladistaTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbxKapacitet;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}