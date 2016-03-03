namespace CustomerMaintenanceSystem
{
    public partial class JobDetailsForm
    {
        private System.Windows.Forms.Label labelCarNo;
        private System.Windows.Forms.TextBox textBoxCarNo;
        private System.Windows.Forms.Label labelJobDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerJobDate;
        private System.Windows.Forms.Label labelWorkerId;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkerId;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.NumericUpDown numericUpDownKms;
        private System.Windows.Forms.Label labelTuning;
        private System.Windows.Forms.NumericUpDown numericUpDownTuning;
        private System.Windows.Forms.Label labelAlignment;
        private System.Windows.Forms.NumericUpDown numericUpDownAlignment;
        private System.Windows.Forms.Label labelBalancing;
        private System.Windows.Forms.NumericUpDown numericUpDownBalancing;
        private System.Windows.Forms.Label labelTires;
        private System.Windows.Forms.NumericUpDown numericUpDownTires;
        private System.Windows.Forms.Label labelWeights;
        private System.Windows.Forms.NumericUpDown numericUpDownWeights;
        private System.Windows.Forms.Label labelOilChanged;
        private System.Windows.Forms.NumericUpDown numericUpDownOilChanged;
        private System.Windows.Forms.Label labelOilQty;
        private System.Windows.Forms.NumericUpDown numericUpDownOilQty;
        private System.Windows.Forms.Label labelOilFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownOilFilter;
        private System.Windows.Forms.Label labelGearOil;
        private System.Windows.Forms.NumericUpDown numericUpDownGearOil;
        private System.Windows.Forms.Label labelGearOilQty;
        private System.Windows.Forms.NumericUpDown numericUpDownGearOilQty;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownPoint;
        private System.Windows.Forms.Label labelCondenser;
        private System.Windows.Forms.NumericUpDown numericUpDownCondenser;
        private System.Windows.Forms.Label labelPlug;
        private System.Windows.Forms.NumericUpDown numericUpDownPlug;
        private System.Windows.Forms.Label labelPlugQty;
        private System.Windows.Forms.NumericUpDown numericUpDownPlugQty;
        private System.Windows.Forms.Label labelFuelFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelFilter;
        private System.Windows.Forms.Label labelAirFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownAirFilter;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Button buttonFirstRecord;
        private System.Windows.Forms.Button buttonPreviousRecord;
        private System.Windows.Forms.TextBox textBoxRecordSearch;
        private System.Windows.Forms.Button buttonNextRecord;
        private System.Windows.Forms.Button buttonLastRecord;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCancelAll;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ErrorProvider errorProviderJobDetailsForm;

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
            this.labelCarNo = new System.Windows.Forms.Label();
            this.textBoxCarNo = new System.Windows.Forms.TextBox();
            this.labelJobDate = new System.Windows.Forms.Label();
            this.dateTimePickerJobDate = new System.Windows.Forms.DateTimePicker();
            this.labelWorkerId = new System.Windows.Forms.Label();
            this.numericUpDownWorkerId = new System.Windows.Forms.NumericUpDown();
            this.labelKms = new System.Windows.Forms.Label();
            this.numericUpDownKms = new System.Windows.Forms.NumericUpDown();
            this.labelTuning = new System.Windows.Forms.Label();
            this.numericUpDownTuning = new System.Windows.Forms.NumericUpDown();
            this.labelAlignment = new System.Windows.Forms.Label();
            this.numericUpDownAlignment = new System.Windows.Forms.NumericUpDown();
            this.labelBalancing = new System.Windows.Forms.Label();
            this.numericUpDownBalancing = new System.Windows.Forms.NumericUpDown();
            this.labelTires = new System.Windows.Forms.Label();
            this.numericUpDownTires = new System.Windows.Forms.NumericUpDown();
            this.labelWeights = new System.Windows.Forms.Label();
            this.numericUpDownWeights = new System.Windows.Forms.NumericUpDown();
            this.labelOilChanged = new System.Windows.Forms.Label();
            this.numericUpDownOilChanged = new System.Windows.Forms.NumericUpDown();
            this.labelOilQty = new System.Windows.Forms.Label();
            this.numericUpDownOilQty = new System.Windows.Forms.NumericUpDown();
            this.labelOilFilter = new System.Windows.Forms.Label();
            this.numericUpDownOilFilter = new System.Windows.Forms.NumericUpDown();
            this.labelGearOil = new System.Windows.Forms.Label();
            this.numericUpDownGearOil = new System.Windows.Forms.NumericUpDown();
            this.labelGearOilQty = new System.Windows.Forms.Label();
            this.numericUpDownGearOilQty = new System.Windows.Forms.NumericUpDown();
            this.labelPoint = new System.Windows.Forms.Label();
            this.numericUpDownPoint = new System.Windows.Forms.NumericUpDown();
            this.labelCondenser = new System.Windows.Forms.Label();
            this.numericUpDownCondenser = new System.Windows.Forms.NumericUpDown();
            this.labelPlug = new System.Windows.Forms.Label();
            this.numericUpDownPlug = new System.Windows.Forms.NumericUpDown();
            this.labelPlugQty = new System.Windows.Forms.Label();
            this.numericUpDownPlugQty = new System.Windows.Forms.NumericUpDown();
            this.labelFuelFilter = new System.Windows.Forms.Label();
            this.numericUpDownFuelFilter = new System.Windows.Forms.NumericUpDown();
            this.labelAirFilter = new System.Windows.Forms.Label();
            this.numericUpDownAirFilter = new System.Windows.Forms.NumericUpDown();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.buttonFirstRecord = new System.Windows.Forms.Button();
            this.buttonPreviousRecord = new System.Windows.Forms.Button();
            this.textBoxRecordSearch = new System.Windows.Forms.TextBox();
            this.buttonNextRecord = new System.Windows.Forms.Button();
            this.buttonLastRecord = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCancelAll = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.errorProviderJobDetailsForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalancing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOilChanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOilQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOilFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGearOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGearOilQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCondenser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlugQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAirFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJobDetailsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(12, 15);
            this.labelCarNo.Name = "labelCarNo";
            this.labelCarNo.Size = new System.Drawing.Size(37, 13);
            this.labelCarNo.TabIndex = 0;
            this.labelCarNo.Text = "CarNo";
            // 
            // textBoxCarNo
            // 
            this.textBoxCarNo.Location = new System.Drawing.Point(82, 12);
            this.textBoxCarNo.MaxLength = 15;
            this.textBoxCarNo.Name = "textBoxCarNo";
            this.textBoxCarNo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCarNo.TabIndex = 1;
            // 
            // labelJobDate
            // 
            this.labelJobDate.AutoSize = true;
            this.labelJobDate.Location = new System.Drawing.Point(12, 44);
            this.labelJobDate.Name = "labelJobDate";
            this.labelJobDate.Size = new System.Drawing.Size(50, 13);
            this.labelJobDate.TabIndex = 2;
            this.labelJobDate.Text = "Job Date";
            // 
            // dateTimePickerJobDate
            // 
            this.dateTimePickerJobDate.Location = new System.Drawing.Point(82, 38);
            this.dateTimePickerJobDate.Name = "dateTimePickerJobDate";
            this.dateTimePickerJobDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerJobDate.TabIndex = 3;
            // 
            // labelWorkerId
            // 
            this.labelWorkerId.AutoSize = true;
            this.labelWorkerId.Location = new System.Drawing.Point(12, 66);
            this.labelWorkerId.Name = "labelWorkerId";
            this.labelWorkerId.Size = new System.Drawing.Size(54, 13);
            this.labelWorkerId.TabIndex = 4;
            this.labelWorkerId.Text = "Worker Id";
            // 
            // numericUpDownWorkerId
            // 
            this.numericUpDownWorkerId.Location = new System.Drawing.Point(82, 64);
            this.numericUpDownWorkerId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWorkerId.Name = "numericUpDownWorkerId";
            this.numericUpDownWorkerId.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownWorkerId.TabIndex = 5;
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(12, 92);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(28, 13);
            this.labelKms.TabIndex = 6;
            this.labelKms.Text = "KMs";
            // 
            // numericUpDownKms
            // 
            this.numericUpDownKms.Location = new System.Drawing.Point(82, 90);
            this.numericUpDownKms.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKms.Name = "numericUpDownKms";
            this.numericUpDownKms.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownKms.TabIndex = 7;
            // 
            // labelTuning
            // 
            this.labelTuning.AutoSize = true;
            this.labelTuning.Location = new System.Drawing.Point(12, 118);
            this.labelTuning.Name = "labelTuning";
            this.labelTuning.Size = new System.Drawing.Size(40, 13);
            this.labelTuning.TabIndex = 8;
            this.labelTuning.Text = "Tuning";
            // 
            // numericUpDownTuning
            // 
            this.numericUpDownTuning.Location = new System.Drawing.Point(82, 116);
            this.numericUpDownTuning.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTuning.Name = "numericUpDownTuning";
            this.numericUpDownTuning.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownTuning.TabIndex = 9;
            // 
            // labelAlignment
            // 
            this.labelAlignment.AutoSize = true;
            this.labelAlignment.Location = new System.Drawing.Point(12, 144);
            this.labelAlignment.Name = "labelAlignment";
            this.labelAlignment.Size = new System.Drawing.Size(53, 13);
            this.labelAlignment.TabIndex = 10;
            this.labelAlignment.Text = "Alignment";
            // 
            // numericUpDownAlignment
            // 
            this.numericUpDownAlignment.Location = new System.Drawing.Point(82, 142);
            this.numericUpDownAlignment.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAlignment.Name = "numericUpDownAlignment";
            this.numericUpDownAlignment.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownAlignment.TabIndex = 11;
            // 
            // labelBalancing
            // 
            this.labelBalancing.AutoSize = true;
            this.labelBalancing.Location = new System.Drawing.Point(12, 168);
            this.labelBalancing.Name = "labelBalancing";
            this.labelBalancing.Size = new System.Drawing.Size(54, 13);
            this.labelBalancing.TabIndex = 12;
            this.labelBalancing.Text = "Balancing";
            // 
            // numericUpDownBalancing
            // 
            this.numericUpDownBalancing.Location = new System.Drawing.Point(82, 168);
            this.numericUpDownBalancing.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBalancing.Name = "numericUpDownBalancing";
            this.numericUpDownBalancing.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownBalancing.TabIndex = 13;
            // 
            // labelTires
            // 
            this.labelTires.AutoSize = true;
            this.labelTires.Location = new System.Drawing.Point(12, 194);
            this.labelTires.Name = "labelTires";
            this.labelTires.Size = new System.Drawing.Size(30, 13);
            this.labelTires.TabIndex = 14;
            this.labelTires.Text = "Tires";
            // 
            // numericUpDownTires
            // 
            this.numericUpDownTires.Location = new System.Drawing.Point(82, 194);
            this.numericUpDownTires.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTires.Name = "numericUpDownTires";
            this.numericUpDownTires.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownTires.TabIndex = 15;
            // 
            // labelWeights
            // 
            this.labelWeights.AutoSize = true;
            this.labelWeights.Location = new System.Drawing.Point(12, 222);
            this.labelWeights.Name = "labelWeights";
            this.labelWeights.Size = new System.Drawing.Size(46, 13);
            this.labelWeights.TabIndex = 16;
            this.labelWeights.Text = "Weights";
            // 
            // numericUpDownWeights
            // 
            this.numericUpDownWeights.Location = new System.Drawing.Point(82, 220);
            this.numericUpDownWeights.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWeights.Name = "numericUpDownWeights";
            this.numericUpDownWeights.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownWeights.TabIndex = 17;
            // 
            // labelOilChanged
            // 
            this.labelOilChanged.AutoSize = true;
            this.labelOilChanged.Location = new System.Drawing.Point(12, 248);
            this.labelOilChanged.Name = "labelOilChanged";
            this.labelOilChanged.Size = new System.Drawing.Size(65, 13);
            this.labelOilChanged.TabIndex = 18;
            this.labelOilChanged.Text = "Oil Changed";
            // 
            // numericUpDownOilChanged
            // 
            this.numericUpDownOilChanged.Location = new System.Drawing.Point(82, 246);
            this.numericUpDownOilChanged.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownOilChanged.Name = "numericUpDownOilChanged";
            this.numericUpDownOilChanged.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownOilChanged.TabIndex = 19;
            // 
            // labelOilQty
            // 
            this.labelOilQty.AutoSize = true;
            this.labelOilQty.Location = new System.Drawing.Point(12, 274);
            this.labelOilQty.Name = "labelOilQty";
            this.labelOilQty.Size = new System.Drawing.Size(38, 13);
            this.labelOilQty.TabIndex = 20;
            this.labelOilQty.Text = "Oil Qty";
            // 
            // numericUpDownOilQty
            // 
            this.numericUpDownOilQty.Location = new System.Drawing.Point(82, 272);
            this.numericUpDownOilQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownOilQty.Name = "numericUpDownOilQty";
            this.numericUpDownOilQty.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownOilQty.TabIndex = 21;
            // 
            // labelOilFilter
            // 
            this.labelOilFilter.AutoSize = true;
            this.labelOilFilter.Location = new System.Drawing.Point(323, 15);
            this.labelOilFilter.Name = "labelOilFilter";
            this.labelOilFilter.Size = new System.Drawing.Size(44, 13);
            this.labelOilFilter.TabIndex = 22;
            this.labelOilFilter.Text = "Oil Filter";
            // 
            // numericUpDownOilFilter
            // 
            this.numericUpDownOilFilter.Location = new System.Drawing.Point(393, 12);
            this.numericUpDownOilFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownOilFilter.Name = "numericUpDownOilFilter";
            this.numericUpDownOilFilter.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownOilFilter.TabIndex = 23;
            // 
            // labelGearOil
            // 
            this.labelGearOil.AutoSize = true;
            this.labelGearOil.Location = new System.Drawing.Point(323, 44);
            this.labelGearOil.Name = "labelGearOil";
            this.labelGearOil.Size = new System.Drawing.Size(42, 13);
            this.labelGearOil.TabIndex = 24;
            this.labelGearOil.Text = "GearOil";
            // 
            // numericUpDownGearOil
            // 
            this.numericUpDownGearOil.Location = new System.Drawing.Point(393, 38);
            this.numericUpDownGearOil.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGearOil.Name = "numericUpDownGearOil";
            this.numericUpDownGearOil.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownGearOil.TabIndex = 25;
            // 
            // labelGearOilQty
            // 
            this.labelGearOilQty.AutoSize = true;
            this.labelGearOilQty.Location = new System.Drawing.Point(323, 66);
            this.labelGearOilQty.Name = "labelGearOilQty";
            this.labelGearOilQty.Size = new System.Drawing.Size(64, 13);
            this.labelGearOilQty.TabIndex = 26;
            this.labelGearOilQty.Text = "Gear Oil Qty";
            // 
            // numericUpDownGearOilQty
            // 
            this.numericUpDownGearOilQty.Location = new System.Drawing.Point(393, 64);
            this.numericUpDownGearOilQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGearOilQty.Name = "numericUpDownGearOilQty";
            this.numericUpDownGearOilQty.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownGearOilQty.TabIndex = 27;
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(323, 92);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(31, 13);
            this.labelPoint.TabIndex = 28;
            this.labelPoint.Text = "Point";
            // 
            // numericUpDownPoint
            // 
            this.numericUpDownPoint.Location = new System.Drawing.Point(393, 90);
            this.numericUpDownPoint.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPoint.Name = "numericUpDownPoint";
            this.numericUpDownPoint.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPoint.TabIndex = 29;
            // 
            // labelCondenser
            // 
            this.labelCondenser.AutoSize = true;
            this.labelCondenser.Location = new System.Drawing.Point(323, 118);
            this.labelCondenser.Name = "labelCondenser";
            this.labelCondenser.Size = new System.Drawing.Size(58, 13);
            this.labelCondenser.TabIndex = 30;
            this.labelCondenser.Text = "Condenser";
            // 
            // numericUpDownCondenser
            // 
            this.numericUpDownCondenser.Location = new System.Drawing.Point(393, 116);
            this.numericUpDownCondenser.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCondenser.Name = "numericUpDownCondenser";
            this.numericUpDownCondenser.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownCondenser.TabIndex = 31;
            // 
            // labelPlug
            // 
            this.labelPlug.AutoSize = true;
            this.labelPlug.Location = new System.Drawing.Point(323, 144);
            this.labelPlug.Name = "labelPlug";
            this.labelPlug.Size = new System.Drawing.Size(28, 13);
            this.labelPlug.TabIndex = 32;
            this.labelPlug.Text = "Plug";
            // 
            // numericUpDownPlug
            // 
            this.numericUpDownPlug.Location = new System.Drawing.Point(393, 142);
            this.numericUpDownPlug.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPlug.Name = "numericUpDownPlug";
            this.numericUpDownPlug.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPlug.TabIndex = 33;
            // 
            // labelPlugQty
            // 
            this.labelPlugQty.AutoSize = true;
            this.labelPlugQty.Location = new System.Drawing.Point(323, 168);
            this.labelPlugQty.Name = "labelPlugQty";
            this.labelPlugQty.Size = new System.Drawing.Size(47, 13);
            this.labelPlugQty.TabIndex = 34;
            this.labelPlugQty.Text = "Plug Qty";
            // 
            // numericUpDownPlugQty
            // 
            this.numericUpDownPlugQty.Location = new System.Drawing.Point(393, 168);
            this.numericUpDownPlugQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPlugQty.Name = "numericUpDownPlugQty";
            this.numericUpDownPlugQty.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPlugQty.TabIndex = 35;
            // 
            // labelFuelFilter
            // 
            this.labelFuelFilter.AutoSize = true;
            this.labelFuelFilter.Location = new System.Drawing.Point(323, 194);
            this.labelFuelFilter.Name = "labelFuelFilter";
            this.labelFuelFilter.Size = new System.Drawing.Size(52, 13);
            this.labelFuelFilter.TabIndex = 36;
            this.labelFuelFilter.Text = "Fuel Filter";
            // 
            // numericUpDownFuelFilter
            // 
            this.numericUpDownFuelFilter.Location = new System.Drawing.Point(393, 194);
            this.numericUpDownFuelFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFuelFilter.Name = "numericUpDownFuelFilter";
            this.numericUpDownFuelFilter.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownFuelFilter.TabIndex = 37;
            // 
            // labelAirFilter
            // 
            this.labelAirFilter.AutoSize = true;
            this.labelAirFilter.Location = new System.Drawing.Point(323, 222);
            this.labelAirFilter.Name = "labelAirFilter";
            this.labelAirFilter.Size = new System.Drawing.Size(44, 13);
            this.labelAirFilter.TabIndex = 38;
            this.labelAirFilter.Text = "Air Filter";
            // 
            // numericUpDownAirFilter
            // 
            this.numericUpDownAirFilter.Location = new System.Drawing.Point(393, 220);
            this.numericUpDownAirFilter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAirFilter.Name = "numericUpDownAirFilter";
            this.numericUpDownAirFilter.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownAirFilter.TabIndex = 39;
            // 
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(323, 248);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(49, 13);
            this.labelRemarks.TabIndex = 40;
            this.labelRemarks.Text = "Remarks";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Location = new System.Drawing.Point(393, 246);
            this.textBoxRemarks.MaxLength = 255;
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRemarks.Size = new System.Drawing.Size(200, 46);
            this.textBoxRemarks.TabIndex = 41;
            // 
            // buttonFirstRecord
            // 
            this.buttonFirstRecord.Location = new System.Drawing.Point(138, 323);
            this.buttonFirstRecord.Name = "buttonFirstRecord";
            this.buttonFirstRecord.Size = new System.Drawing.Size(23, 23);
            this.buttonFirstRecord.TabIndex = 42;
            this.buttonFirstRecord.Text = "|<";
            this.buttonFirstRecord.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousRecord
            // 
            this.buttonPreviousRecord.Location = new System.Drawing.Point(162, 323);
            this.buttonPreviousRecord.Name = "buttonPreviousRecord";
            this.buttonPreviousRecord.Size = new System.Drawing.Size(23, 23);
            this.buttonPreviousRecord.TabIndex = 43;
            this.buttonPreviousRecord.Text = "<";
            this.buttonPreviousRecord.UseVisualStyleBackColor = true;
            // 
            // textBoxRecordSearch
            // 
            this.textBoxRecordSearch.Location = new System.Drawing.Point(191, 325);
            this.textBoxRecordSearch.Name = "textBoxRecordSearch";
            this.textBoxRecordSearch.Size = new System.Drawing.Size(196, 20);
            this.textBoxRecordSearch.TabIndex = 44;
            // 
            // buttonNextRecord
            // 
            this.buttonNextRecord.Location = new System.Drawing.Point(393, 323);
            this.buttonNextRecord.Name = "buttonNextRecord";
            this.buttonNextRecord.Size = new System.Drawing.Size(23, 23);
            this.buttonNextRecord.TabIndex = 45;
            this.buttonNextRecord.Text = ">";
            this.buttonNextRecord.UseVisualStyleBackColor = true;
            // 
            // buttonLastRecord
            // 
            this.buttonLastRecord.Location = new System.Drawing.Point(422, 323);
            this.buttonLastRecord.Name = "buttonLastRecord";
            this.buttonLastRecord.Size = new System.Drawing.Size(23, 23);
            this.buttonLastRecord.TabIndex = 46;
            this.buttonLastRecord.Text = ">|";
            this.buttonLastRecord.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(20, 369);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 47;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(101, 369);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 48;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(182, 369);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 49;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(263, 369);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAll
            // 
            this.buttonCancelAll.Location = new System.Drawing.Point(344, 369);
            this.buttonCancelAll.Name = "buttonCancelAll";
            this.buttonCancelAll.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAll.TabIndex = 51;
            this.buttonCancelAll.Text = "Cancel All";
            this.buttonCancelAll.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(425, 369);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 52;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(506, 369);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 53;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // errorProviderJobDetailsForm
            // 
            this.errorProviderJobDetailsForm.ContainerControl = this;
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 416);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancelAll);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonLastRecord);
            this.Controls.Add(this.buttonNextRecord);
            this.Controls.Add(this.textBoxRecordSearch);
            this.Controls.Add(this.buttonPreviousRecord);
            this.Controls.Add(this.buttonFirstRecord);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.numericUpDownAirFilter);
            this.Controls.Add(this.labelAirFilter);
            this.Controls.Add(this.numericUpDownFuelFilter);
            this.Controls.Add(this.labelFuelFilter);
            this.Controls.Add(this.numericUpDownPlugQty);
            this.Controls.Add(this.labelPlugQty);
            this.Controls.Add(this.numericUpDownPlug);
            this.Controls.Add(this.labelPlug);
            this.Controls.Add(this.numericUpDownCondenser);
            this.Controls.Add(this.labelCondenser);
            this.Controls.Add(this.numericUpDownPoint);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.numericUpDownGearOilQty);
            this.Controls.Add(this.labelGearOilQty);
            this.Controls.Add(this.numericUpDownGearOil);
            this.Controls.Add(this.labelGearOil);
            this.Controls.Add(this.numericUpDownOilFilter);
            this.Controls.Add(this.labelOilFilter);
            this.Controls.Add(this.numericUpDownOilQty);
            this.Controls.Add(this.labelOilQty);
            this.Controls.Add(this.numericUpDownOilChanged);
            this.Controls.Add(this.labelOilChanged);
            this.Controls.Add(this.numericUpDownWeights);
            this.Controls.Add(this.labelWeights);
            this.Controls.Add(this.numericUpDownTires);
            this.Controls.Add(this.labelTires);
            this.Controls.Add(this.numericUpDownBalancing);
            this.Controls.Add(this.labelBalancing);
            this.Controls.Add(this.numericUpDownAlignment);
            this.Controls.Add(this.labelAlignment);
            this.Controls.Add(this.numericUpDownTuning);
            this.Controls.Add(this.labelTuning);
            this.Controls.Add(this.numericUpDownKms);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.numericUpDownWorkerId);
            this.Controls.Add(this.labelWorkerId);
            this.Controls.Add(this.dateTimePickerJobDate);
            this.Controls.Add(this.labelJobDate);
            this.Controls.Add(this.textBoxCarNo);
            this.Controls.Add(this.labelCarNo);
            this.Name = "JobDetailsForm";
            this.Text = "Job Details";
            this.Load += new System.EventHandler(this.JobDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalancing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOilChanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOilQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOilFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGearOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGearOilQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCondenser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlugQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAirFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJobDetailsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}