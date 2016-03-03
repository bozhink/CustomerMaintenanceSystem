namespace CustomerMaintenanceSystem
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm();
            workerForm.ShowDialog(this);
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////CustomerForm customerForm = new CustomerForm();
            ////customerForm.ShowDialog(this);
        }

        private void JobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDetailsForm jobDetailsForm = new JobDetailsForm();
            jobDetailsForm.ShowDialog(this);
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog(this);
        }
    }
}