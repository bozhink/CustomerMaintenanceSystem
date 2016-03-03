namespace CustomerMaintenanceSystem
{
    using System;
    using System.Windows.Forms;

    public partial class ConsumableForm : Form
    {
        public ConsumableForm()
        {
            this.InitializeComponent();
        }

        private void ConsumableForm_Load(object sender, EventArgs e)
        {
            this.jobDetailsTableAdapter.Fill(this.customerMaintenanceSystemDatabaseDataSet.JobDetails);

            this.reportViewer.RefreshReport();
        }
    }
}