namespace CustomerMaintenanceSystem
{
    using System.Windows.Forms;

    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            this.InitializeComponent();
        }

        private void ButtonExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}