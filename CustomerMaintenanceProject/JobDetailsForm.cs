namespace CustomerMaintenanceSystem
{
    using System;
    using System.Windows.Forms;

    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            this.InitializeComponent();
        }

        private void JobDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool canSave = this.ValidateJobDetailsFormFields() && this.Validate();

            if (canSave)
            {
                try
                {
                    this.jobDetailsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.customerMaintenanceSystemDatabaseDataSet);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateJobDetailsFormFields()
        {
            bool areValid = true;

            if (string.IsNullOrWhiteSpace(this.carNoTextBox.Text))
            {
                this.errorProvider.SetError(this.carNoTextBox, Messages.JobDetailsCarNoTextBoxValidationErrorMessage);
                areValid = false;
            }
            else
            {
                this.errorProvider.SetError(this.carNoTextBox, string.Empty);
            }

            if (!(this.jobDateDateTimePicker.Value <= DateTime.Now))
            {
                this.errorProvider.SetError(this.jobDateDateTimePicker, Messages.JobDetailsJobDateDateTimePickerValidationErrorMessage);
                areValid = false;
            }
            else
            {
                this.errorProvider.SetError(this.jobDateDateTimePicker, string.Empty);
            }

            if (this.workerIdNumericUpDown.Value < 1)
            {
                this.errorProvider.SetError(this.workerIdNumericUpDown, Messages.JobDetailsJobWorkerIdNumericUpDownValidationErrorMessage);
                areValid = false;
            }
            else
            {
                this.errorProvider.SetError(this.workerIdNumericUpDown, string.Empty);
            }

            return areValid;
        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.carNoTextBox, string.Empty);
            this.errorProvider.SetError(this.jobDateDateTimePicker, string.Empty);
            this.errorProvider.SetError(this.workerIdNumericUpDown, string.Empty);

            this.jobDetailsTableAdapter.Fill(this.customerMaintenanceSystemDatabaseDataSet.JobDetails);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}