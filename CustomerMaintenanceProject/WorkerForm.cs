namespace CustomerMaintenanceSystem
{
    using System.Windows.Forms;

    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            this.InitializeComponent();
        }

        private void WorkerForm_Load(object sender, System.EventArgs e)
        {
            this.ReloadWorkerData();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            this.ReloadWorkerData();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            this.workerTableAdapter.Update(this.customerMaintenanceSystemDatabaseDataSet.Worker);
            MessageBox.Show(Messages.WorkerTableIsUpdatedMessage);
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.ReloadWorkerData();
        }

        private void ReloadWorkerData()
        {
            this.customerMaintenanceSystemDatabaseDataSet.Worker.Clear();
            this.workerTableAdapter.Fill(this.customerMaintenanceSystemDatabaseDataSet.Worker);
        }
    }
}