namespace CustomerMaintenanceSystem
{
    public partial class ConsumableForm
    {
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource jobDetailsBindingSource;
        private CustomerMaintenanceSystemDatabaseDataSet customerMaintenanceSystemDatabaseDataSet;
        private CustomerMaintenanceSystemDatabaseDataSetTableAdapters.JobDetailsTableAdapter jobDetailsTableAdapter;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customerMaintenanceSystemDatabaseDataSet = new CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSet();
            this.jobDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDetailsTableAdapter = new CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSetTableAdapters.JobDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerMaintenanceSystemDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "JobDetailsDataSet";
            reportDataSource1.Value = this.jobDetailsBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CustomerMaintenanceSystem.Reports.ConsumableReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(419, 274);
            this.reportViewer.TabIndex = 0;
            // 
            // CustomerMaintenanceSystemDatabaseDataSet
            // 
            this.customerMaintenanceSystemDatabaseDataSet.DataSetName = "CustomerMaintenanceSystemDatabaseDataSet";
            this.customerMaintenanceSystemDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JobDetailsBindingSource
            // 
            this.jobDetailsBindingSource.DataMember = "JobDetails";
            this.jobDetailsBindingSource.DataSource = this.customerMaintenanceSystemDatabaseDataSet;
            // 
            // JobDetailsTableAdapter
            // 
            this.jobDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ConsumableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 274);
            this.Controls.Add(this.reportViewer);
            this.Name = "ConsumableForm";
            this.Text = "Consumable Report";
            this.Load += new System.EventHandler(this.ConsumableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerMaintenanceSystemDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}