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

        private void ButtonExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void JobDetailsForm_Load(object sender, System.EventArgs e)
        {
            this.errorProviderJobDetailsForm.SetError(this.textBoxCarNo, string.Empty);
            this.errorProviderJobDetailsForm.SetError(this.dateTimePickerJobDate, string.Empty);
        }

        private bool ValidateFields()
        {
            bool areValid = true;

            if (string.IsNullOrWhiteSpace(this.textBoxCarNo.Text))
            {
                this.errorProviderJobDetailsForm.SetError(this.textBoxCarNo, Messages.JobDetailsCarNoTextBoxValidationErrorMessage);
                areValid = false;
            }
            else
            {
                this.errorProviderJobDetailsForm.SetError(this.textBoxCarNo, string.Empty);
                areValid &= true;
            }

            if (this.dateTimePickerJobDate.Value > DateTime.Now)
            {
                this.errorProviderJobDetailsForm.SetError(this.dateTimePickerJobDate, Messages.JobDetailsJobDateDateTimePickerValidationErrorMessage);
                areValid = false;
            }
            else
            {
                this.errorProviderJobDetailsForm.SetError(this.dateTimePickerJobDate, string.Empty);
                areValid &= true;
            }

            return areValid;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            bool canAdd = this.ValidateFields();

            if (canAdd)
            {
                // TODO: db add logic here.
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            bool canUpdate = this.ValidateFields();

            if (canUpdate)
            {
                // TODO: db update logic here.
            }
        }
    }
}