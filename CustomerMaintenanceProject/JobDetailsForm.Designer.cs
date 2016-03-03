namespace CustomerMaintenanceSystem
{
    public partial class JobDetailsForm
    {
        private CustomerMaintenanceSystemDatabaseDataSet customerMaintenanceSystemDatabaseDataSet;
        private System.Windows.Forms.BindingSource jobDetailsBindingSource;
        private CustomerMaintenanceSystemDatabaseDataSetTableAdapters.JobDetailsTableAdapter jobDetailsTableAdapter;
        private CustomerMaintenanceSystemDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jobDetailsBindingNavigator;

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jobDetailsBindingNavigatorSaveItem;

        private System.Windows.Forms.ComboBox carNoComboBox;
        private System.Windows.Forms.DateTimePicker jobDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown workerIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown kmsNumericUpDown;
        private System.Windows.Forms.NumericUpDown tuningNumericUpDown;
        private System.Windows.Forms.NumericUpDown alignmentNumericUpDown;
        private System.Windows.Forms.NumericUpDown balancingNumericUpDown;
        private System.Windows.Forms.NumericUpDown tiresNumericUpDown;
        private System.Windows.Forms.NumericUpDown weightsNumericUpDown;
        private System.Windows.Forms.NumericUpDown oilChangedNumericUpDown;
        private System.Windows.Forms.NumericUpDown oilQtyNumericUpDown;
        private System.Windows.Forms.NumericUpDown oilFilterNumericUpDown;
        private System.Windows.Forms.NumericUpDown gearOilNumericUpDown;
        private System.Windows.Forms.NumericUpDown gearOilQtyNumericUpDown;
        private System.Windows.Forms.NumericUpDown pointNumericUpDown;
        private System.Windows.Forms.NumericUpDown condenserNumericUpDown;
        private System.Windows.Forms.NumericUpDown plugNumericUpDown;
        private System.Windows.Forms.NumericUpDown plugQtyNumericUpDown;
        private System.Windows.Forms.NumericUpDown fuelQtyNumericUpDown;
        private System.Windows.Forms.NumericUpDown fuelFilterNumericUpDown;
        private System.Windows.Forms.NumericUpDown airFilterNumericUpDown;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.Label kmsLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label carNoLabel;
            System.Windows.Forms.Label jobDateLabel;
            System.Windows.Forms.Label workerIdLabel;
            System.Windows.Forms.Label tuningLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label balancingLabel;
            System.Windows.Forms.Label tiresLabel;
            System.Windows.Forms.Label weightsLabel;
            System.Windows.Forms.Label oilChangedLabel;
            System.Windows.Forms.Label oilQtyLabel;
            System.Windows.Forms.Label oilFilterLabel;
            System.Windows.Forms.Label gearOilLabel;
            System.Windows.Forms.Label gearOilQtyLabel;
            System.Windows.Forms.Label condenserLabel;
            System.Windows.Forms.Label plugLabel;
            System.Windows.Forms.Label plugQtyLabel;
            System.Windows.Forms.Label fuelQtyLabel;
            System.Windows.Forms.Label fuelFilterLabel;
            System.Windows.Forms.Label airFilterLabel;
            System.Windows.Forms.Label remarksLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetailsForm));
            this.kmsLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.customerMaintenanceSystemDatabaseDataSet = new CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSet();
            this.jobDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDetailsTableAdapter = new CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSetTableAdapters.JobDetailsTableAdapter();
            this.tableAdapterManager = new CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSetTableAdapters.TableAdapterManager();
            this.jobDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jobDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carNoComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kmsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tuningNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alignmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.balancingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tiresNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.oilChangedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.oilQtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.oilFilterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gearOilNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gearOilQtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.condenserNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.plugNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.plugQtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fuelQtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fuelFilterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.airFilterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.customerTableAdapter = new CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSetTableAdapters.CustomerTableAdapter();
            carNoLabel = new System.Windows.Forms.Label();
            jobDateLabel = new System.Windows.Forms.Label();
            workerIdLabel = new System.Windows.Forms.Label();
            tuningLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            balancingLabel = new System.Windows.Forms.Label();
            tiresLabel = new System.Windows.Forms.Label();
            weightsLabel = new System.Windows.Forms.Label();
            oilChangedLabel = new System.Windows.Forms.Label();
            oilQtyLabel = new System.Windows.Forms.Label();
            oilFilterLabel = new System.Windows.Forms.Label();
            gearOilLabel = new System.Windows.Forms.Label();
            gearOilQtyLabel = new System.Windows.Forms.Label();
            condenserLabel = new System.Windows.Forms.Label();
            plugLabel = new System.Windows.Forms.Label();
            plugQtyLabel = new System.Windows.Forms.Label();
            fuelQtyLabel = new System.Windows.Forms.Label();
            fuelFilterLabel = new System.Windows.Forms.Label();
            airFilterLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerMaintenanceSystemDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingNavigator)).BeginInit();
            this.jobDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuningNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balancingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiresNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilChangedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilQtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilFilterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearOilNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearOilQtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condenserNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plugNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plugQtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelQtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelFilterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airFilterNumericUpDown)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // carNoLabel
            // 
            carNoLabel.AutoSize = true;
            carNoLabel.Location = new System.Drawing.Point(12, 30);
            carNoLabel.Name = "carNoLabel";
            carNoLabel.Size = new System.Drawing.Size(43, 13);
            carNoLabel.TabIndex = 1;
            carNoLabel.Text = "Car No:";
            // 
            // jobDateLabel
            // 
            jobDateLabel.AutoSize = true;
            jobDateLabel.Location = new System.Drawing.Point(12, 56);
            jobDateLabel.Name = "jobDateLabel";
            jobDateLabel.Size = new System.Drawing.Size(53, 13);
            jobDateLabel.TabIndex = 3;
            jobDateLabel.Text = "Job Date:";
            // 
            // workerIdLabel
            // 
            workerIdLabel.AutoSize = true;
            workerIdLabel.Location = new System.Drawing.Point(12, 82);
            workerIdLabel.Name = "workerIdLabel";
            workerIdLabel.Size = new System.Drawing.Size(57, 13);
            workerIdLabel.TabIndex = 5;
            workerIdLabel.Text = "Worker Id:";
            // 
            // tuningLabel
            // 
            tuningLabel.AutoSize = true;
            tuningLabel.Location = new System.Drawing.Point(12, 135);
            tuningLabel.Name = "tuningLabel";
            tuningLabel.Size = new System.Drawing.Size(43, 13);
            tuningLabel.TabIndex = 9;
            tuningLabel.Text = "Tuning:";
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new System.Drawing.Point(12, 160);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(56, 13);
            alignmentLabel.TabIndex = 11;
            alignmentLabel.Text = "Alignment:";
            // 
            // balancingLabel
            // 
            balancingLabel.AutoSize = true;
            balancingLabel.Location = new System.Drawing.Point(12, 186);
            balancingLabel.Name = "balancingLabel";
            balancingLabel.Size = new System.Drawing.Size(57, 13);
            balancingLabel.TabIndex = 13;
            balancingLabel.Text = "Balancing:";
            // 
            // tiresLabel
            // 
            tiresLabel.AutoSize = true;
            tiresLabel.Location = new System.Drawing.Point(12, 212);
            tiresLabel.Name = "tiresLabel";
            tiresLabel.Size = new System.Drawing.Size(33, 13);
            tiresLabel.TabIndex = 15;
            tiresLabel.Text = "Tires:";
            // 
            // weightsLabel
            // 
            weightsLabel.AutoSize = true;
            weightsLabel.Location = new System.Drawing.Point(12, 238);
            weightsLabel.Name = "weightsLabel";
            weightsLabel.Size = new System.Drawing.Size(49, 13);
            weightsLabel.TabIndex = 17;
            weightsLabel.Text = "Weights:";
            // 
            // oilChangedLabel
            // 
            oilChangedLabel.AutoSize = true;
            oilChangedLabel.Location = new System.Drawing.Point(12, 264);
            oilChangedLabel.Name = "oilChangedLabel";
            oilChangedLabel.Size = new System.Drawing.Size(68, 13);
            oilChangedLabel.TabIndex = 19;
            oilChangedLabel.Text = "Oil Changed:";
            // 
            // oilQtyLabel
            // 
            oilQtyLabel.AutoSize = true;
            oilQtyLabel.Location = new System.Drawing.Point(12, 290);
            oilQtyLabel.Name = "oilQtyLabel";
            oilQtyLabel.Size = new System.Drawing.Size(41, 13);
            oilQtyLabel.TabIndex = 21;
            oilQtyLabel.Text = "Oil Qty:";
            // 
            // oilFilterLabel
            // 
            oilFilterLabel.AutoSize = true;
            oilFilterLabel.Location = new System.Drawing.Point(357, 30);
            oilFilterLabel.Name = "oilFilterLabel";
            oilFilterLabel.Size = new System.Drawing.Size(47, 13);
            oilFilterLabel.TabIndex = 23;
            oilFilterLabel.Text = "Oil Filter:";
            // 
            // gearOilLabel
            // 
            gearOilLabel.AutoSize = true;
            gearOilLabel.Location = new System.Drawing.Point(357, 56);
            gearOilLabel.Name = "gearOilLabel";
            gearOilLabel.Size = new System.Drawing.Size(48, 13);
            gearOilLabel.TabIndex = 25;
            gearOilLabel.Text = "Gear Oil:";
            // 
            // gearOilQtyLabel
            // 
            gearOilQtyLabel.AutoSize = true;
            gearOilQtyLabel.Location = new System.Drawing.Point(357, 82);
            gearOilQtyLabel.Name = "gearOilQtyLabel";
            gearOilQtyLabel.Size = new System.Drawing.Size(67, 13);
            gearOilQtyLabel.TabIndex = 27;
            gearOilQtyLabel.Text = "Gear Oil Qty:";
            // 
            // condenserLabel
            // 
            condenserLabel.AutoSize = true;
            condenserLabel.Location = new System.Drawing.Point(357, 134);
            condenserLabel.Name = "condenserLabel";
            condenserLabel.Size = new System.Drawing.Size(61, 13);
            condenserLabel.TabIndex = 31;
            condenserLabel.Text = "Condenser:";
            // 
            // plugLabel
            // 
            plugLabel.AutoSize = true;
            plugLabel.Location = new System.Drawing.Point(357, 160);
            plugLabel.Name = "plugLabel";
            plugLabel.Size = new System.Drawing.Size(31, 13);
            plugLabel.TabIndex = 33;
            plugLabel.Text = "Plug:";
            // 
            // plugQtyLabel
            // 
            plugQtyLabel.AutoSize = true;
            plugQtyLabel.Location = new System.Drawing.Point(357, 186);
            plugQtyLabel.Name = "plugQtyLabel";
            plugQtyLabel.Size = new System.Drawing.Size(50, 13);
            plugQtyLabel.TabIndex = 35;
            plugQtyLabel.Text = "Plug Qty:";
            // 
            // fuelQtyLabel
            // 
            fuelQtyLabel.AutoSize = true;
            fuelQtyLabel.Location = new System.Drawing.Point(357, 212);
            fuelQtyLabel.Name = "fuelQtyLabel";
            fuelQtyLabel.Size = new System.Drawing.Size(49, 13);
            fuelQtyLabel.TabIndex = 37;
            fuelQtyLabel.Text = "Fuel Qty:";
            // 
            // fuelFilterLabel
            // 
            fuelFilterLabel.AutoSize = true;
            fuelFilterLabel.Location = new System.Drawing.Point(357, 238);
            fuelFilterLabel.Name = "fuelFilterLabel";
            fuelFilterLabel.Size = new System.Drawing.Size(55, 13);
            fuelFilterLabel.TabIndex = 39;
            fuelFilterLabel.Text = "Fuel Filter:";
            // 
            // airFilterLabel
            // 
            airFilterLabel.AutoSize = true;
            airFilterLabel.Location = new System.Drawing.Point(357, 264);
            airFilterLabel.Name = "airFilterLabel";
            airFilterLabel.Size = new System.Drawing.Size(47, 13);
            airFilterLabel.TabIndex = 41;
            airFilterLabel.Text = "Air Filter:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(357, 290);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 43;
            remarksLabel.Text = "Remarks:";
            // 
            // kmsLabel
            // 
            this.kmsLabel.AutoSize = true;
            this.kmsLabel.Location = new System.Drawing.Point(12, 108);
            this.kmsLabel.Name = "kmsLabel";
            this.kmsLabel.Size = new System.Drawing.Size(31, 13);
            this.kmsLabel.TabIndex = 7;
            this.kmsLabel.Text = "KMs:";
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Location = new System.Drawing.Point(357, 105);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(37, 13);
            this.pointLabel.TabIndex = 29;
            this.pointLabel.Text = "Point :";
            // 
            // customerMaintenanceSystemDatabaseDataSet
            // 
            this.customerMaintenanceSystemDatabaseDataSet.DataSetName = "CustomerMaintenanceSystemDatabaseDataSet";
            this.customerMaintenanceSystemDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobDetailsBindingSource
            // 
            this.jobDetailsBindingSource.DataMember = "JobDetails";
            this.jobDetailsBindingSource.DataSource = this.customerMaintenanceSystemDatabaseDataSet;
            // 
            // jobDetailsTableAdapter
            // 
            this.jobDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.JobDetailsTableAdapter = this.jobDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CustomerMaintenanceSystem.CustomerMaintenanceSystemDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // jobDetailsBindingNavigator
            // 
            this.jobDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jobDetailsBindingNavigator.BindingSource = this.jobDetailsBindingSource;
            this.jobDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jobDetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jobDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jobDetailsBindingNavigatorSaveItem});
            this.jobDetailsBindingNavigator.Location = new System.Drawing.Point(0, 336);
            this.jobDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobDetailsBindingNavigator.Name = "jobDetailsBindingNavigator";
            this.jobDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobDetailsBindingNavigator.Size = new System.Drawing.Size(664, 25);
            this.jobDetailsBindingNavigator.TabIndex = 0;
            this.jobDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // jobDetailsBindingNavigatorSaveItem
            // 
            this.jobDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jobDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jobDetailsBindingNavigatorSaveItem.Image")));
            this.jobDetailsBindingNavigatorSaveItem.Name = "jobDetailsBindingNavigatorSaveItem";
            this.jobDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jobDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.jobDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.JobDetailsBindingNavigatorSaveItem_Click);
            // 
            // carNoComboBox
            // 
            this.carNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "CarNo", true));
            this.carNoComboBox.DataSource = this.customerBindingSource;
            this.carNoComboBox.DisplayMember = "CarNo";
            this.carNoComboBox.Location = new System.Drawing.Point(86, 27);
            this.carNoComboBox.MaxLength = 15;
            this.carNoComboBox.Name = "carNoComboBox";
            this.carNoComboBox.Size = new System.Drawing.Size(200, 21);
            this.carNoComboBox.TabIndex = 2;
            this.carNoComboBox.ValueMember = "CarNo";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerMaintenanceSystemDatabaseDataSet;
            // 
            // jobDateDateTimePicker
            // 
            this.jobDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobDetailsBindingSource, "JobDate", true));
            this.jobDateDateTimePicker.Location = new System.Drawing.Point(86, 53);
            this.jobDateDateTimePicker.Name = "jobDateDateTimePicker";
            this.jobDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.jobDateDateTimePicker.TabIndex = 4;
            // 
            // workerIdNumericUpDown
            // 
            this.workerIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "WorkerId", true));
            this.workerIdNumericUpDown.Location = new System.Drawing.Point(86, 79);
            this.workerIdNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.workerIdNumericUpDown.Name = "workerIdNumericUpDown";
            this.workerIdNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.workerIdNumericUpDown.TabIndex = 6;
            // 
            // kmsNumericUpDown
            // 
            this.kmsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "KMs", true));
            this.kmsNumericUpDown.Location = new System.Drawing.Point(86, 105);
            this.kmsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kmsNumericUpDown.Name = "kmsNumericUpDown";
            this.kmsNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.kmsNumericUpDown.TabIndex = 8;
            // 
            // tuningNumericUpDown
            // 
            this.tuningNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Tuning", true));
            this.tuningNumericUpDown.Location = new System.Drawing.Point(86, 131);
            this.tuningNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tuningNumericUpDown.Name = "tuningNumericUpDown";
            this.tuningNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.tuningNumericUpDown.TabIndex = 10;
            // 
            // alignmentNumericUpDown
            // 
            this.alignmentNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Alignment", true));
            this.alignmentNumericUpDown.Location = new System.Drawing.Point(86, 157);
            this.alignmentNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alignmentNumericUpDown.Name = "alignmentNumericUpDown";
            this.alignmentNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.alignmentNumericUpDown.TabIndex = 12;
            // 
            // balancingNumericUpDown
            // 
            this.balancingNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Balancing", true));
            this.balancingNumericUpDown.Location = new System.Drawing.Point(86, 183);
            this.balancingNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.balancingNumericUpDown.Name = "balancingNumericUpDown";
            this.balancingNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.balancingNumericUpDown.TabIndex = 14;
            // 
            // tiresNumericUpDown
            // 
            this.tiresNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Tires", true));
            this.tiresNumericUpDown.Location = new System.Drawing.Point(86, 209);
            this.tiresNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tiresNumericUpDown.Name = "tiresNumericUpDown";
            this.tiresNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.tiresNumericUpDown.TabIndex = 16;
            // 
            // weightsNumericUpDown
            // 
            this.weightsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Weights", true));
            this.weightsNumericUpDown.Location = new System.Drawing.Point(86, 235);
            this.weightsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.weightsNumericUpDown.Name = "weightsNumericUpDown";
            this.weightsNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.weightsNumericUpDown.TabIndex = 18;
            // 
            // oilChangedNumericUpDown
            // 
            this.oilChangedNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "OilChanged", true));
            this.oilChangedNumericUpDown.Location = new System.Drawing.Point(86, 261);
            this.oilChangedNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.oilChangedNumericUpDown.Name = "oilChangedNumericUpDown";
            this.oilChangedNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.oilChangedNumericUpDown.TabIndex = 20;
            // 
            // oilQtyNumericUpDown
            // 
            this.oilQtyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "OilQty", true));
            this.oilQtyNumericUpDown.Location = new System.Drawing.Point(86, 287);
            this.oilQtyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.oilQtyNumericUpDown.Name = "oilQtyNumericUpDown";
            this.oilQtyNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.oilQtyNumericUpDown.TabIndex = 22;
            // 
            // oilFilterNumericUpDown
            // 
            this.oilFilterNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "OilFilter", true));
            this.oilFilterNumericUpDown.Location = new System.Drawing.Point(430, 27);
            this.oilFilterNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.oilFilterNumericUpDown.Name = "oilFilterNumericUpDown";
            this.oilFilterNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.oilFilterNumericUpDown.TabIndex = 24;
            // 
            // gearOilNumericUpDown
            // 
            this.gearOilNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "GearOil", true));
            this.gearOilNumericUpDown.Location = new System.Drawing.Point(430, 53);
            this.gearOilNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.gearOilNumericUpDown.Name = "gearOilNumericUpDown";
            this.gearOilNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.gearOilNumericUpDown.TabIndex = 26;
            // 
            // gearOilQtyNumericUpDown
            // 
            this.gearOilQtyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "GearOilQty", true));
            this.gearOilQtyNumericUpDown.Location = new System.Drawing.Point(430, 79);
            this.gearOilQtyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.gearOilQtyNumericUpDown.Name = "gearOilQtyNumericUpDown";
            this.gearOilQtyNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.gearOilQtyNumericUpDown.TabIndex = 28;
            // 
            // pointNumericUpDown
            // 
            this.pointNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Point ", true));
            this.pointNumericUpDown.Location = new System.Drawing.Point(430, 105);
            this.pointNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pointNumericUpDown.Name = "pointNumericUpDown";
            this.pointNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.pointNumericUpDown.TabIndex = 30;
            // 
            // condenserNumericUpDown
            // 
            this.condenserNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Condenser", true));
            this.condenserNumericUpDown.Location = new System.Drawing.Point(430, 131);
            this.condenserNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.condenserNumericUpDown.Name = "condenserNumericUpDown";
            this.condenserNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.condenserNumericUpDown.TabIndex = 32;
            // 
            // plugNumericUpDown
            // 
            this.plugNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Plug", true));
            this.plugNumericUpDown.Location = new System.Drawing.Point(430, 157);
            this.plugNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.plugNumericUpDown.Name = "plugNumericUpDown";
            this.plugNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.plugNumericUpDown.TabIndex = 34;
            // 
            // plugQtyNumericUpDown
            // 
            this.plugQtyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "PlugQty", true));
            this.plugQtyNumericUpDown.Location = new System.Drawing.Point(430, 183);
            this.plugQtyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.plugQtyNumericUpDown.Name = "plugQtyNumericUpDown";
            this.plugQtyNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.plugQtyNumericUpDown.TabIndex = 36;
            // 
            // fuelQtyNumericUpDown
            // 
            this.fuelQtyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "FuelQty", true));
            this.fuelQtyNumericUpDown.Location = new System.Drawing.Point(430, 209);
            this.fuelQtyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fuelQtyNumericUpDown.Name = "fuelQtyNumericUpDown";
            this.fuelQtyNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.fuelQtyNumericUpDown.TabIndex = 38;
            // 
            // fuelFilterNumericUpDown
            // 
            this.fuelFilterNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "FuelFilter", true));
            this.fuelFilterNumericUpDown.Location = new System.Drawing.Point(430, 235);
            this.fuelFilterNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fuelFilterNumericUpDown.Name = "fuelFilterNumericUpDown";
            this.fuelFilterNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.fuelFilterNumericUpDown.TabIndex = 40;
            // 
            // airFilterNumericUpDown
            // 
            this.airFilterNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "AirFilter", true));
            this.airFilterNumericUpDown.Location = new System.Drawing.Point(430, 261);
            this.airFilterNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.airFilterNumericUpDown.Name = "airFilterNumericUpDown";
            this.airFilterNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.airFilterNumericUpDown.TabIndex = 42;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDetailsBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(430, 287);
            this.remarksTextBox.MaxLength = 255;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarksTextBox.TabIndex = 44;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(664, 24);
            this.menuStrip.TabIndex = 45;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(airFilterLabel);
            this.Controls.Add(this.airFilterNumericUpDown);
            this.Controls.Add(fuelFilterLabel);
            this.Controls.Add(this.fuelFilterNumericUpDown);
            this.Controls.Add(fuelQtyLabel);
            this.Controls.Add(this.fuelQtyNumericUpDown);
            this.Controls.Add(plugQtyLabel);
            this.Controls.Add(this.plugQtyNumericUpDown);
            this.Controls.Add(plugLabel);
            this.Controls.Add(this.plugNumericUpDown);
            this.Controls.Add(condenserLabel);
            this.Controls.Add(this.condenserNumericUpDown);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.pointNumericUpDown);
            this.Controls.Add(gearOilQtyLabel);
            this.Controls.Add(this.gearOilQtyNumericUpDown);
            this.Controls.Add(gearOilLabel);
            this.Controls.Add(this.gearOilNumericUpDown);
            this.Controls.Add(oilFilterLabel);
            this.Controls.Add(this.oilFilterNumericUpDown);
            this.Controls.Add(oilQtyLabel);
            this.Controls.Add(this.oilQtyNumericUpDown);
            this.Controls.Add(oilChangedLabel);
            this.Controls.Add(this.oilChangedNumericUpDown);
            this.Controls.Add(weightsLabel);
            this.Controls.Add(this.weightsNumericUpDown);
            this.Controls.Add(tiresLabel);
            this.Controls.Add(this.tiresNumericUpDown);
            this.Controls.Add(balancingLabel);
            this.Controls.Add(this.balancingNumericUpDown);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(this.alignmentNumericUpDown);
            this.Controls.Add(tuningLabel);
            this.Controls.Add(this.tuningNumericUpDown);
            this.Controls.Add(this.kmsLabel);
            this.Controls.Add(this.kmsNumericUpDown);
            this.Controls.Add(workerIdLabel);
            this.Controls.Add(this.workerIdNumericUpDown);
            this.Controls.Add(jobDateLabel);
            this.Controls.Add(this.jobDateDateTimePicker);
            this.Controls.Add(carNoLabel);
            this.Controls.Add(this.carNoComboBox);
            this.Controls.Add(this.jobDetailsBindingNavigator);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(680, 400);
            this.Name = "JobDetailsForm";
            this.Text = "Job Details";
            this.Load += new System.EventHandler(this.JobDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerMaintenanceSystemDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsBindingNavigator)).EndInit();
            this.jobDetailsBindingNavigator.ResumeLayout(false);
            this.jobDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuningNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balancingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiresNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilChangedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilQtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilFilterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearOilNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearOilQtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condenserNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plugNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plugQtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelQtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelFilterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airFilterNumericUpDown)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerMaintenanceSystemDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}