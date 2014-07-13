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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladistePretrazi));
            this.lblKolicinaNaSektoru = new System.Windows.Forms.Label();
            this.lblKapacitetSektora = new System.Windows.Forms.Label();
            this.txtbxKolicinaNaSektoru = new System.Windows.Forms.TextBox();
            this.sektor_skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.dgvSektorSkladista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKnjigaHasSektorSkladista = new System.Windows.Forms.DataGridView();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektor_skladistaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.txtbxKapacitetSektora = new System.Windows.Forms.TextBox();
            this.lblSlobodno = new System.Windows.Forms.Label();
            this.txtbxSlobodno = new System.Windows.Forms.TextBox();
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            this.knjiga_has_Sektor_skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiga_has_Sektor_skladistaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Knjiga_has_Sektor_skladistaTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.knjigaidKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumzaprimanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektorSkladista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasSektorSkladista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_Sektor_skladistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKolicinaNaSektoru
            // 
            this.lblKolicinaNaSektoru.AutoSize = true;
            this.lblKolicinaNaSektoru.Location = new System.Drawing.Point(338, 129);
            this.lblKolicinaNaSektoru.Name = "lblKolicinaNaSektoru";
            this.lblKolicinaNaSektoru.Size = new System.Drawing.Size(103, 13);
            this.lblKolicinaNaSektoru.TabIndex = 10;
            this.lblKolicinaNaSektoru.Text = "Količina na sektoru: ";
            // 
            // lblKapacitetSektora
            // 
            this.lblKapacitetSektora.AutoSize = true;
            this.lblKapacitetSektora.Location = new System.Drawing.Point(338, 90);
            this.lblKapacitetSektora.Name = "lblKapacitetSektora";
            this.lblKapacitetSektora.Size = new System.Drawing.Size(93, 13);
            this.lblKapacitetSektora.TabIndex = 8;
            this.lblKapacitetSektora.Text = "Kapacitet sektora:";
            // 
            // txtbxKolicinaNaSektoru
            // 
            this.txtbxKolicinaNaSektoru.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxKolicinaNaSektoru.Location = new System.Drawing.Point(375, 145);
            this.txtbxKolicinaNaSektoru.Name = "txtbxKolicinaNaSektoru";
            this.txtbxKolicinaNaSektoru.ReadOnly = true;
            this.txtbxKolicinaNaSektoru.Size = new System.Drawing.Size(99, 20);
            this.txtbxKolicinaNaSektoru.TabIndex = 7;
            this.txtbxKolicinaNaSektoru.TabStop = false;
            // 
            // sektor_skladistaBindingSource
            // 
            this.sektor_skladistaBindingSource.DataMember = "Sektor_skladista";
            this.sektor_skladistaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSektorSkladista
            // 
            this.dgvSektorSkladista.AllowUserToAddRows = false;
            this.dgvSektorSkladista.AllowUserToDeleteRows = false;
            this.dgvSektorSkladista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSektorSkladista.AutoGenerateColumns = false;
            this.dgvSektorSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSektorSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvSektorSkladista.DataSource = this.sektor_skladistaBindingSource;
            this.dgvSektorSkladista.Location = new System.Drawing.Point(27, 90);
            this.dgvSektorSkladista.MultiSelect = false;
            this.dgvSektorSkladista.Name = "dgvSektorSkladista";
            this.dgvSektorSkladista.ReadOnly = true;
            this.dgvSektorSkladista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSektorSkladista.Size = new System.Drawing.Size(306, 220);
            this.dgvSektorSkladista.TabIndex = 12;
            this.dgvSektorSkladista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSektorSkladista_CellDoubleClick);
            this.dgvSektorSkladista.SelectionChanged += new System.EventHandler(this.dgvSektorSkladista_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSektor_skladista";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Sektora skladišta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kapacitet";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kapacitet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvKnjigaHasSektorSkladista
            // 
            this.dgvKnjigaHasSektorSkladista.AllowUserToAddRows = false;
            this.dgvKnjigaHasSektorSkladista.AllowUserToDeleteRows = false;
            this.dgvKnjigaHasSektorSkladista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKnjigaHasSektorSkladista.AutoGenerateColumns = false;
            this.dgvKnjigaHasSektorSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjigaHasSektorSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaidKnjigaDataGridViewTextBoxColumn,
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.datumzaprimanjaDataGridViewTextBoxColumn,
            this.idZaposlenikDataGridViewTextBoxColumn});
            this.dgvKnjigaHasSektorSkladista.DataSource = this.knjiga_has_Sektor_skladistaBindingSource;
            this.dgvKnjigaHasSektorSkladista.Location = new System.Drawing.Point(27, 331);
            this.dgvKnjigaHasSektorSkladista.MultiSelect = false;
            this.dgvKnjigaHasSektorSkladista.Name = "dgvKnjigaHasSektorSkladista";
            this.dgvKnjigaHasSektorSkladista.ReadOnly = true;
            this.dgvKnjigaHasSektorSkladista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjigaHasSektorSkladista.Size = new System.Drawing.Size(464, 220);
            this.dgvKnjigaHasSektorSkladista.TabIndex = 12;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.gizmoDBDataSet;
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
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = this.sektor_skladistaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // txtbxKapacitetSektora
            // 
            this.txtbxKapacitetSektora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxKapacitetSektora.Location = new System.Drawing.Point(375, 106);
            this.txtbxKapacitetSektora.Name = "txtbxKapacitetSektora";
            this.txtbxKapacitetSektora.ReadOnly = true;
            this.txtbxKapacitetSektora.Size = new System.Drawing.Size(100, 20);
            this.txtbxKapacitetSektora.TabIndex = 13;
            this.txtbxKapacitetSektora.TabStop = false;
            // 
            // lblSlobodno
            // 
            this.lblSlobodno.AutoSize = true;
            this.lblSlobodno.Location = new System.Drawing.Point(338, 221);
            this.lblSlobodno.Name = "lblSlobodno";
            this.lblSlobodno.Size = new System.Drawing.Size(58, 13);
            this.lblSlobodno.TabIndex = 14;
            this.lblSlobodno.Text = "Slobodno: ";
            // 
            // txtbxSlobodno
            // 
            this.txtbxSlobodno.BackColor = System.Drawing.SystemColors.Control;
            this.txtbxSlobodno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxSlobodno.ForeColor = System.Drawing.Color.Black;
            this.txtbxSlobodno.Location = new System.Drawing.Point(402, 218);
            this.txtbxSlobodno.Name = "txtbxSlobodno";
            this.txtbxSlobodno.ReadOnly = true;
            this.txtbxSlobodno.Size = new System.Drawing.Size(72, 20);
            this.txtbxSlobodno.TabIndex = 15;
            this.txtbxSlobodno.TabStop = false;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // knjiga_has_Sektor_skladistaBindingSource
            // 
            this.knjiga_has_Sektor_skladistaBindingSource.DataMember = "Knjiga_has_Sektor_skladista";
            this.knjiga_has_Sektor_skladistaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // knjiga_has_Sektor_skladistaTableAdapter
            // 
            this.knjiga_has_Sektor_skladistaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // knjigaidKnjigaDataGridViewTextBoxColumn
            // 
            this.knjigaidKnjigaDataGridViewTextBoxColumn.DataPropertyName = "Knjiga_idKnjiga";
            this.knjigaidKnjigaDataGridViewTextBoxColumn.DataSource = this.knjigaBindingSource;
            this.knjigaidKnjigaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.knjigaidKnjigaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.knjigaidKnjigaDataGridViewTextBoxColumn.HeaderText = "Knjiga";
            this.knjigaidKnjigaDataGridViewTextBoxColumn.Name = "knjigaidKnjigaDataGridViewTextBoxColumn";
            this.knjigaidKnjigaDataGridViewTextBoxColumn.ReadOnly = true;
            this.knjigaidKnjigaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.knjigaidKnjigaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.knjigaidKnjigaDataGridViewTextBoxColumn.ValueMember = "idKnjiga";
            // 
            // sektorskladistaidSektorskladistaDataGridViewTextBoxColumn
            // 
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn.DataPropertyName = "Sektor_skladista_idSektor_skladista";
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn.HeaderText = "Sektor_skladista_idSektor_skladista";
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn.Name = "sektorskladistaidSektorskladistaDataGridViewTextBoxColumn";
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sektorskladistaidSektorskladistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // datumzaprimanjaDataGridViewTextBoxColumn
            // 
            this.datumzaprimanjaDataGridViewTextBoxColumn.DataPropertyName = "Datum_zaprimanja";
            this.datumzaprimanjaDataGridViewTextBoxColumn.HeaderText = "Datum zaprimanja";
            this.datumzaprimanjaDataGridViewTextBoxColumn.Name = "datumzaprimanjaDataGridViewTextBoxColumn";
            this.datumzaprimanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idZaposlenikDataGridViewTextBoxColumn
            // 
            this.idZaposlenikDataGridViewTextBoxColumn.DataPropertyName = "idZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.idZaposlenikDataGridViewTextBoxColumn.DisplayMember = "Korisnicko_ime";
            this.idZaposlenikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idZaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.Name = "idZaposlenikDataGridViewTextBoxColumn";
            this.idZaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idZaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idZaposlenikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idZaposlenikDataGridViewTextBoxColumn.ValueMember = "idZaposlenik";
            // 
            // frmSkladistePretrazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 564);
            this.Controls.Add(this.txtbxSlobodno);
            this.Controls.Add(this.lblSlobodno);
            this.Controls.Add(this.txtbxKapacitetSektora);
            this.Controls.Add(this.dgvKnjigaHasSektorSkladista);
            this.Controls.Add(this.dgvSektorSkladista);
            this.Controls.Add(this.lblKolicinaNaSektoru);
            this.Controls.Add(this.lblKapacitetSektora);
            this.Controls.Add(this.txtbxKolicinaNaSektoru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSkladistePretrazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži skladište";
            this.Load += new System.EventHandler(this.frmSkladistePretrazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektorSkladista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasSektorSkladista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_Sektor_skladistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKolicinaNaSektoru;
        private System.Windows.Forms.Label lblKapacitetSektora;
        private System.Windows.Forms.TextBox txtbxKolicinaNaSektoru;
        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource sektor_skladistaBindingSource;
        private GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter sektor_skladistaTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvSektorSkladista;
        private System.Windows.Forms.DataGridView dgvKnjigaHasSektorSkladista;
        private System.Windows.Forms.TextBox txtbxKapacitetSektora;
        private System.Windows.Forms.Label lblSlobodno;
        private System.Windows.Forms.TextBox txtbxSlobodno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.BindingSource knjiga_has_Sektor_skladistaBindingSource;
        private GizmoDBDataSetTableAdapters.Knjiga_has_Sektor_skladistaTableAdapter knjiga_has_Sektor_skladistaTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn knjigaidKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sektorskladistaidSektorskladistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzaprimanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idZaposlenikDataGridViewTextBoxColumn;

    }
}