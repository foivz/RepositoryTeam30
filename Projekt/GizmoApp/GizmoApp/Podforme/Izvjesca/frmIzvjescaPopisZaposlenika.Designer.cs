namespace GizmoApp.Podforme.Izvjesca
{
    partial class frmIzvjescaPopisZaposlenika
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvjescaPopisZaposlenika));
            this.zaposlenikTableAdapter1 = new GizmoApp.GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter();
            this.gizmoDBDataSet1 = new GizmoApp.GizmoDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenikTableAdapter1
            // 
            this.zaposlenikTableAdapter1.ClearBeforeFill = true;
            // 
            // gizmoDBDataSet1
            // 
            this.gizmoDBDataSet1.DataSetName = "GizmoDBDataSet";
            this.gizmoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Popis_zaposlenika";
            reportDataSource1.Value = this.zaposlenikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GizmoApp.Podforme.Izvjesca.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 311);
            this.reportViewer1.TabIndex = 0;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.gizmoDBDataSet1;
            // 
            // frmIzvjescaKreirajIzvjesce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 311);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIzvjescaKreirajIzvjesce";
            this.Text = "frmIzvjescaKreirajIzvjesce";
            this.Load += new System.EventHandler(this.frmIzvjescaKreirajIzvjesce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gizmoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GizmoDBDataSetTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter1;
        private GizmoDBDataSet gizmoDBDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;

    }
}