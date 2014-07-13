namespace GizmoApp.Podforme.Nabava
{
    partial class frmNabavaPretraziDobavljace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNabavaPretraziDobavljace));
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.DobavljaciTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            this.dobavljaciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKnjigaHasDobavljaci = new System.Windows.Forms.DataGridView();
            this.knjiga_has_DobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiga_has_DobavljaciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Knjiga_has_DobavljaciTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.knjigaidKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnarudzbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingNavigator)).BeginInit();
            this.dobavljaciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasDobavljaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_DobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "Dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = this.dobavljaciTableAdapter;
            this.tableAdapterManager.Kategorija_has_KnjigaTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_KupciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = this.knjigaTableAdapter;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // dobavljaciBindingNavigator
            // 
            this.dobavljaciBindingNavigator.AddNewItem = null;
            this.dobavljaciBindingNavigator.BindingSource = this.dobavljaciBindingSource;
            this.dobavljaciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dobavljaciBindingNavigator.DeleteItem = null;
            this.dobavljaciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.dobavljaciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dobavljaciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dobavljaciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dobavljaciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dobavljaciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dobavljaciBindingNavigator.Name = "dobavljaciBindingNavigator";
            this.dobavljaciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dobavljaciBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.dobavljaciBindingNavigator.TabIndex = 0;
            this.dobavljaciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.AutoGenerateColumns = false;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvDobavljaci.DataSource = this.dobavljaciBindingSource;
            this.dgvDobavljaci.Location = new System.Drawing.Point(12, 40);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.ReadOnly = true;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(645, 220);
            this.dgvDobavljaci.TabIndex = 1;
            this.dgvDobavljaci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDobavljaci_CellDoubleClick);
            this.dgvDobavljaci.SelectionChanged += new System.EventHandler(this.dgvDobavljaci_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDobavljaci";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OIB";
            this.dataGridViewTextBoxColumn4.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // dgvKnjigaHasDobavljaci
            // 
            this.dgvKnjigaHasDobavljaci.AllowUserToAddRows = false;
            this.dgvKnjigaHasDobavljaci.AllowUserToDeleteRows = false;
            this.dgvKnjigaHasDobavljaci.AutoGenerateColumns = false;
            this.dgvKnjigaHasDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjigaHasDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knjigaidKnjigaDataGridViewTextBoxColumn,
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.datumnarudzbeDataGridViewTextBoxColumn,
            this.idZaposlenikDataGridViewTextBoxColumn});
            this.dgvKnjigaHasDobavljaci.DataSource = this.knjiga_has_DobavljaciBindingSource;
            this.dgvKnjigaHasDobavljaci.Location = new System.Drawing.Point(162, 285);
            this.dgvKnjigaHasDobavljaci.Name = "dgvKnjigaHasDobavljaci";
            this.dgvKnjigaHasDobavljaci.ReadOnly = true;
            this.dgvKnjigaHasDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjigaHasDobavljaci.Size = new System.Drawing.Size(495, 220);
            this.dgvKnjigaHasDobavljaci.TabIndex = 2;
            // 
            // knjiga_has_DobavljaciBindingSource
            // 
            this.knjiga_has_DobavljaciBindingSource.DataMember = "Knjiga_has_Dobavljaci";
            this.knjiga_has_DobavljaciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // knjiga_has_DobavljaciTableAdapter
            // 
            this.knjiga_has_DobavljaciTableAdapter.ClearBeforeFill = true;
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
            // dobavljaciidDobavljaciDataGridViewTextBoxColumn
            // 
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn.DataPropertyName = "Dobavljaci_idDobavljaci";
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn.HeaderText = "Dobavljaci_idDobavljaci";
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn.Name = "dobavljaciidDobavljaciDataGridViewTextBoxColumn";
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobavljaciidDobavljaciDataGridViewTextBoxColumn.Visible = false;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumnarudzbeDataGridViewTextBoxColumn
            // 
            this.datumnarudzbeDataGridViewTextBoxColumn.DataPropertyName = "Datum_narudzbe";
            this.datumnarudzbeDataGridViewTextBoxColumn.HeaderText = "Datum narudžbe";
            this.datumnarudzbeDataGridViewTextBoxColumn.Name = "datumnarudzbeDataGridViewTextBoxColumn";
            this.datumnarudzbeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmNabavaPretraziDobavljace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 548);
            this.Controls.Add(this.dgvKnjigaHasDobavljaci);
            this.Controls.Add(this.dgvDobavljaci);
            this.Controls.Add(this.dobavljaciBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNabavaPretraziDobavljace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga dobavljača";
            this.Load += new System.EventHandler(this.frmNabavaPretraziDobavljace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingNavigator)).EndInit();
            this.dobavljaciBindingNavigator.ResumeLayout(false);
            this.dobavljaciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasDobavljaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_DobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private GizmoDBDataSetTableAdapters.DobavljaciTableAdapter dobavljaciTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dobavljaciBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private GizmoDBDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private System.Windows.Forms.DataGridView dgvKnjigaHasDobavljaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource knjiga_has_DobavljaciBindingSource;
        private GizmoDBDataSetTableAdapters.Knjiga_has_DobavljaciTableAdapter knjiga_has_DobavljaciTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn knjigaidKnjigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciidDobavljaciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnarudzbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idZaposlenikDataGridViewTextBoxColumn;


    }
}