namespace proyecto_cine.views.reportes.ReporteFecha
{
    partial class MostrarReporteFecha
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
            this.reporteFechaTableAdapter1 = new proyecto_cine.views.reportes.ReporteFecha.DataSet1TableAdapters.reporteFechaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new proyecto_cine.views.reportes.ReporteFecha.DataSet1();
            this.reporteFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteFechaTableAdapter = new proyecto_cine.views.reportes.ReporteFecha.DataSet1TableAdapters.reporteFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteFechaTableAdapter1
            // 
            this.reporteFechaTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_cine.views.reportes.ReporteFecha.InterfazReporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteFechaBindingSource
            // 
            this.reporteFechaBindingSource.DataMember = "reporteFecha";
            this.reporteFechaBindingSource.DataSource = this.DataSet1;
            // 
            // reporteFechaTableAdapter
            // 
            this.reporteFechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFecha";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReporteFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteFechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1TableAdapters.reporteFechaTableAdapter reporteFechaTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteFechaBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.reporteFechaTableAdapter reporteFechaTableAdapter;
    }
}