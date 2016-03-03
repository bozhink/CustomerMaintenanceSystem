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

        private void MonthlyConsumableReportRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            var form = new ConsumableForm();
            form.ShowDialog(this);
        }
    }
}