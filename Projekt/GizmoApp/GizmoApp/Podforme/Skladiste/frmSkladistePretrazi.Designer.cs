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
            this.sektor_skladistaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sektor_skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gizmoDBDataSet = new GizmoApp.GizmoDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvSektorSkladista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKnjigaHasSektorSkladista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjiga_has_Sektor_skladistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektor_skladistaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Sektor_skladistaTableAdapter();
            this.tableAdapterManager = new GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager();
            this.knjiga_has_Sektor_skladistaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.Knjiga_has_Sektor_skladistaTableAdapter();
            this.txtbxKapacitetSektora = new System.Windows.Forms.TextBox();
            this.lblSlobodno = new System.Windows.Forms.Label();
            this.txtbxSlobodno = new System.Windows.Forms.TextBox();
            this.knjigaTableAdapter = new GizmoApp.GizmoDBDataSetTableAdapters.KnjigaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingNavigator)).BeginInit();
            this.sektor_skladistaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektorSkladista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasSektorSkladista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_Sektor_skladistaBindingSource)).BeginInit();
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
            // sektor_skladistaBindingNavigator
            // 
            this.sektor_skladistaBindingNavigator.AddNewItem = null;
            this.sektor_skladistaBindingNavigator.BindingSource = this.sektor_skladistaBindingSource;
            this.sektor_skladistaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sektor_skladistaBindingNavigator.DeleteItem = null;
            this.sektor_skladistaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.sektor_skladistaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sektor_skladistaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sektor_skladistaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sektor_skladistaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sektor_skladistaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sektor_skladistaBindingNavigator.Name = "sektor_skladistaBindingNavigator";
            this.sektor_skladistaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sektor_skladistaBindingNavigator.Size = new System.Drawing.Size(503, 25);
            this.sektor_skladistaBindingNavigator.TabIndex = 12;
            this.sektor_skladistaBindingNavigator.Text = "bindingNavigator1";
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvKnjigaHasSektorSkladista.DataSource = this.knjiga_has_Sektor_skladistaBindingSource;
            this.dgvKnjigaHasSektorSkladista.Location = new System.Drawing.Point(84, 331);
            this.dgvKnjigaHasSektorSkladista.MultiSelect = false;
            this.dgvKnjigaHasSektorSkladista.Name = "dgvKnjigaHasSektorSkladista";
            this.dgvKnjigaHasSektorSkladista.Size = new System.Drawing.Size(360, 220);
            this.dgvKnjigaHasSektorSkladista.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sektor_skladista_idSektor_skladista";
            this.dataGridViewTextBoxColumn4.FillWeight = 115F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Sektor skladišta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Knjiga_idKnjiga";
            this.dataGridViewTextBoxColumn3.DataSource = this.knjigaBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Naziv";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Knjiga";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idKnjiga";
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.gizmoDBDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn5.FillWeight = 80F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Količina";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Datum_zaprimanja";
            this.dataGridViewTextBoxColumn6.FillWeight = 115F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Datum zaprimanja";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 115;
            // 
            // knjiga_has_Sektor_skladistaBindingSource
            // 
            this.knjiga_has_Sektor_skladistaBindingSource.DataMember = "Knjiga_has_Sektor_skladista";
            this.knjiga_has_Sektor_skladistaBindingSource.DataSource = this.gizmoDBDataSet;
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
            this.tableAdapterManager.Knjiga_has_Sektor_skladistaTableAdapter = this.knjiga_has_Sektor_skladistaTableAdapter;
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.KupciTableAdapter = null;
            this.tableAdapterManager.Odjel_has_PogledTableAdapter = null;
            this.tableAdapterManager.OdjelTableAdapter = null;
            this.tableAdapterManager.PogledTableAdapter = null;
            this.tableAdapterManager.Sektor_skladistaTableAdapter = this.sektor_skladistaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GizmoApp.GizmoDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // knjiga_has_Sektor_skladistaTableAdapter
            // 
            this.knjiga_has_Sektor_skladistaTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.sektor_skladistaBindingNavigator);
            this.Controls.Add(this.lblKolicinaNaSektoru);
            this.Controls.Add(this.lblKapacitetSektora);
            this.Controls.Add(this.txtbxKolicinaNaSektoru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSkladistePretrazi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži skladište";
            this.Load += new System.EventHandler(this.frmSkladistePretrazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingNavigator)).EndInit();
            this.sektor_skladistaBindingNavigator.ResumeLayout(false);
            this.sektor_skladistaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sektor_skladistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektorSkladista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigaHasSektorSkladista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiga_has_Sektor_skladistaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingNavigator sektor_skladistaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvSektorSkladista;
        private GizmoDBDataSetTableAdapters.Knjiga_has_Sektor_skladistaTableAdapter knjiga_has_Sektor_skladistaTableAdapter;
        private System.Windows.Forms.BindingSource knjiga_has_Sektor_skladistaBindingSource;
        private System.Windows.Forms.DataGridView dgvKnjigaHasSektorSkladista;
        private System.Windows.Forms.TextBox txtbxKapacitetSektora;
        private System.Windows.Forms.Label lblSlobodno;
        private System.Windows.Forms.TextBox txtbxSlobodno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private GizmoDBDataSetTableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    }
}