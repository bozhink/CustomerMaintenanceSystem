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

        private void CustomerForm_Load(object sender, System.EventArgs e)
        {
            this.errorProviderCustomersForm.SetError(this.textBoxAddress, string.Empty);
            this.errorProviderCustomersForm.SetError(this.textBoxCarNo, string.Empty);
            this.errorProviderCustomersForm.SetError(this.textBoxMake, string.Empty);
            this.errorProviderCustomersForm.SetError(this.textBoxName, string.Empty);
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            bool canSave = true;

            canSave &= this.SetErrorMessageToValidatedTextBox(this.textBoxCarNo, Messages.CustomerCarNoTextBoxValidationErrorMessage);

            canSave &= this.SetErrorMessageToValidatedTextBox(this.textBoxName, Messages.CustomerNameTextBoxValidationErrorMessage);

            canSave &= this.SetErrorMessageToValidatedTextBox(this.textBoxAddress, Messages.CustomerAddressTextBoxValidationErrorMessage);

            canSave &= this.SetErrorMessageToValidatedTextBox(this.textBoxMake, Messages.CustomerMakeTextBoxValidationErrorMessage);

            if (canSave)
            {
                // TODO: Add db save logic.
            }
        }

        private bool SetErrorMessageToValidatedTextBox(TextBox textBox, string message)
        {
            bool isvalid = true;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                this.errorProviderCustomersForm.SetError(textBox, message);
                isvalid = false;
            }
            else
            {
                this.errorProviderCustomersForm.SetError(textBox, string.Empty);
                isvalid = true;
            }

            return isvalid;
        }
    }
}