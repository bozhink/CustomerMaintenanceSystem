namespace CustomerMaintenanceSystem
{
    using System.Windows.Forms;

    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            this.InitializeComponent();
        }

        private void ButtonExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}