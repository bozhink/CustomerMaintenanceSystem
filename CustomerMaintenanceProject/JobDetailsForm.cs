namespace CustomerMaintenanceSystem
{
    using System.Windows.Forms;

    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            this.InitializeComponent();
        }

        private void ButtonExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}