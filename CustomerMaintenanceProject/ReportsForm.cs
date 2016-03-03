namespace CustomerMaintenanceSystem
{
    using System.Windows.Forms;

    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            this.InitializeComponent();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}