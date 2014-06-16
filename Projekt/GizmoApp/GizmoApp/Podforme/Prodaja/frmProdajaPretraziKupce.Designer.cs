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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdajaPretraziKupce));
            this.kupciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvKupci = new System.Windows.Forms.DataGridView();
            this.dgvKnjigaHasKupci = new System.Windows.Forms.DataGridView();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.knjiga_has_KupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kupciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KupciTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.knjiga_has_KupciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Knjiga_has_KupciTableAdapter();
            this.knjigahasDobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiga_has_DobavljaciTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Knjiga_has_DobavljaciTableAdapter();
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingNavigator)).BeginInit();
            this.kupciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_KupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigahasDobavljaciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kupciBindingNavigator
            // 
            this.kupciBindingNavigator.AddNewItem = null;
            this.kupciBindingNavigator.BindingSource = this.kupciBindingSource;
            this.kupciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kupciBindingNavigator.DeleteItem = null;
            this.kupciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.kupciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kupciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kupciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kupciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kupciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kupciBindingNavigator.Name = "kupciBindingNavigator";
            this.kupciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kupciBindingNavigator.Size = new System.Drawing.Size(682, 25);
            this.kupciBindingNavigator.TabIndex = 0;
            this.kupciBindingNavigator.Text = "bindingNavigator1";
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
            // dgvKupci
            // 
            this.dgvKupci.AllowUserToAddRows = false;
            this.dgvKupci.AllowUserToDeleteRows = false;
            this.dgvKupci.AutoGenerateColumns = false;
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvKupci.DataSource = this.kupciBindingSource;
            this.dgvKupci.Location = new System.Drawing.Point(12, 41);
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.Size = new System.Drawing.Size(649, 212);
            this.dgvKupci.TabIndex = 1;
            this.dgvKupci.SelectionChanged += new System.EventHandler(this.kupciDataGridView_SelectionChanged);
            // 
            // dgvKnjigaHasKupci
            // 
            this.dgvKnjigaHasKupci.AllowUserToAddRows = false;
            this.dgvKnjigaHasKupci.AllowUserToDeleteRows = false;
            this.dgvKnjigaHasKupci.AutoGenerateColumns = false;
            this.dgvKnjigaHasKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjigaHasKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvKnjigaHasKupci.DataSource = this.knjiga_has_KupciBindingSource;
            this.dgvKnjigaHasKupci.Location = new System.Drawing.Point(304, 273);
            this.dgvKnjigaHasKupci.Name = "dgvKnjigaHasKupci";
            this.dgvKnjigaHasKupci.Size = new System.Drawing.Size(357, 220);
            this.dgvKnjigaHasKupci.TabIndex = 2;
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // gizmoDBDataSet
            // 
            this.gizmoDBDataSet.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjiga_has_KupciBindingSource
            // 
            this.knjiga_has_KupciBindingSource.DataMember = "Knjiga_has_Kupci";
            this.knjiga_has_KupciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idKupci";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID kupca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OIB";
            this.dataGridViewTextBoxColumn4.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataMember = "Kupci";
            this.kupciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // kupciTableAdapter
            // 
            this.kupciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DobavljaciTableAdapter = null;
            this.tableAdapterManager.Kategorija_has_KnjigaTableAdapter = null;
            this.tableAdapterManager.KategorijaTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_DobavljaciTableAdapter = null;
            this.tableAdapterManager.Knjiga_has_KupciTableAdapter = this.knjiga_has_KupciTableAdapter;
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = this.kupciTableAdapter;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // knjiga_has_KupciTableAdapter
            // 
            this.knjiga_has_KupciTableAdapter.ClearBeforeFill = true;
            // 
            // knjigahasDobavljaciBindingSource
            // 
            this.knjigahasDobavljaciBindingSource.DataMember = "Knjiga_has_Dobavljaci";
            this.knjigahasDobavljaciBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // knjiga_has_DobavljaciTableAdapter
            // 
            this.knjiga_has_DobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Kupci_idKupci";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID kupca";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Knjiga_idKnjiga";
            this.dataGridViewTextBoxColumn7.DataSource = this.knjigaBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Naziv";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn7.HeaderText = "Knjiga";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "idKnjiga";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn9.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Datum_prodaje";
            this.dataGridViewTextBoxColumn10.HeaderText = "Datum prodaje";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // frmProdajaPretraziKupce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 511);
            this.Controls.Add(this.dgvKnjigaHasKupci);
            this.Controls.Add(this.dgvKupci);
            this.Controls.Add(this.kupciBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdajaPretraziKupce";
            this.Text = "Pretraga kupaca";
            this.Load += new System.EventHandler(this.frmProdajaPretraziKupce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingNavigator)).EndInit();
            this.kupciBindingNavigator.ResumeLayout(false);
            this.kupciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_KupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigahasDobavljaciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GizmoDBDataSet gizmoDBDataSet;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private GizmoDBDataSetTableAdapters.KupciTableAdapter kupciTableAdapter;
        private GizmoDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kupciBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private GizmoDBDataSetTableAdapters.Knjiga_has_KupciTableAdapter knjiga_has_KupciTableAdapter;
        private System.Windows.Forms.DataGridView dgvKupci;
        private System.Windows.Forms.BindingSource knjiga_has_KupciBindingSource;
        private System.Windows.Forms.DataGridView dgvKnjigaHasKupci;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource knjigahasDobavljaciBindingSource;
        private GizmoDBDataSetTableAdapters.Knjiga_has_DobavljaciTableAdapter knjiga_has_DobavljaciTableAdapter;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;


    }
}