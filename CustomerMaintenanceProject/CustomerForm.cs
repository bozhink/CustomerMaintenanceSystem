namespace CustomerMaintenanceSystem
{
    using System.Windows.Forms;

    public partial class CustomerForm : Form
    {
        private readonly string customerTableName;

        public CustomerForm()
        {
            this.InitializeComponent();

            this.customerTableName = this.customerMaintenanceSystemDatabaseDataSet.Customer.TableName;
        }

        private BindingManagerBase BindingManager => this.BindingContext[this.customerMaintenanceSystemDatabaseDataSet, this.customerTableName];

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
            this.CurrentPosition();
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
                this.customerTableAdapter.Update(this.customerMaintenanceSystemDatabaseDataSet.Customer);
                MessageBox.Show(Messages.CustomerTableIsUpdatedMessage);
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

        private void ButtonEdit_Click(object sender, System.EventArgs e)
        {
            this.ReloadCustomerData();
        }

        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            this.ReloadCustomerData();
        }

        private void ButtonPrevious_Click(object sender, System.EventArgs e)
        {
            this.BindingManager.Position -= 1;
            this.CurrentPosition();
        }

        private void ButtonNext_Click(object sender, System.EventArgs e)
        {
            this.BindingManager.Position += 1;
            this.CurrentPosition();
        }

        private void ReloadCustomerData()
        {
            this.customerMaintenanceSystemDatabaseDataSet.Customer.Clear();
            this.customerTableAdapter.Fill(this.customerMaintenanceSystemDatabaseDataSet.Customer);
            this.CurrentPosition();
        }

        private void CurrentPosition()
        {
            int numberOfRecords = this.BindingManager.Count;

            if (numberOfRecords < 1)
            {
                this.textBoxDisplayPosition.Text = Messages.ThereAreNoRecordsInTheCustomerTableMessage;
            }
            else
            {
                int currentPostion = this.BindingManager.Position + 1;
                this.textBoxDisplayPosition.Text = $"{currentPostion} of {numberOfRecords}";
            }
        }
    }
}