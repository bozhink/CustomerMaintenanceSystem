namespace CustomerMaintenanceSystem
{
    using System;
    using System.Windows.Forms;

    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            this.InitializeComponent();
        }

        private void CustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bool canSave = this.ValidateFormFields() && this.Validate();

            if (canSave)
            {
                try
                {
                    this.customerBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.customerMaintenanceSystemDatabaseDataSet);
                    MessageBox.Show(Messages.CustomerTableIsUpdatedMessage);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.carNoTextBox, string.Empty);
            this.errorProvider.SetError(this.nameTextBox, string.Empty);
            this.errorProvider.SetError(this.addressTextBox, string.Empty);
            this.errorProvider.SetError(this.makeTextBox, string.Empty);

            this.customerMaintenanceSystemDatabaseDataSet.Customer.Clear();
            this.customerTableAdapter.Fill(this.customerMaintenanceSystemDatabaseDataSet.Customer);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFormFields()
        {
            bool areValid = true;

            areValid &= this.ValidateTextBoxContent(this.carNoTextBox, Messages.CustomerCarNoTextBoxValidationErrorMessage);

            areValid &= this.ValidateTextBoxContent(this.nameTextBox, Messages.CustomerNameTextBoxValidationErrorMessage);

            areValid &= this.ValidateTextBoxContent(this.addressTextBox, Messages.CustomerAddressTextBoxValidationErrorMessage);

            areValid &= this.ValidateTextBoxContent(this.makeTextBox, Messages.CustomerMakeTextBoxValidationErrorMessage);

            return areValid;
        }

        private bool ValidateTextBoxContent(TextBox textBox, string errorMessage)
        {
            bool contentIsValid = true;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                this.errorProvider.SetError(textBox, errorMessage);
                contentIsValid = false;
            }

            return contentIsValid;
        }
    }
}