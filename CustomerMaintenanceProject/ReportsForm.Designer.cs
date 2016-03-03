namespace CustomerMaintenanceSystem
{
    public partial class ReportsForm
    {
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.RadioButton radioButtonMonthlyWorkerReport;
        private System.Windows.Forms.RadioButton radioButtonMonthlyBalancingAndAlignmentReport;
        private System.Windows.Forms.RadioButton radioButtonMonthlyConsumerVisitReport;
        private System.Windows.Forms.RadioButton radioButtonMonthlyConsumableReport;
        private System.Windows.Forms.Button buttonExit;

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
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthlyConsumableReport = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthlyConsumerVisitReport = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthlyBalancingAndAlignmentReport = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthlyWorkerReport = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(13, 13);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(320, 16);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Select the radio button to generate the report.";
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Controls.Add(this.radioButtonMonthlyWorkerReport);
            this.groupBoxReports.Controls.Add(this.radioButtonMonthlyBalancingAndAlignmentReport);
            this.groupBoxReports.Controls.Add(this.radioButtonMonthlyConsumerVisitReport);
            this.groupBoxReports.Controls.Add(this.radioButtonMonthlyConsumableReport);
            this.groupBoxReports.Location = new System.Drawing.Point(13, 30);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(227, 130);
            this.groupBoxReports.TabIndex = 1;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Reports";
            // 
            // radioButtonMonthlyConsumableReport
            // 
            this.radioButtonMonthlyConsumableReport.AutoSize = true;
            this.radioButtonMonthlyConsumableReport.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMonthlyConsumableReport.Name = "radioButtonMonthlyConsumableReport";
            this.radioButtonMonthlyConsumableReport.Size = new System.Drawing.Size(158, 17);
            this.radioButtonMonthlyConsumableReport.TabIndex = 0;
            this.radioButtonMonthlyConsumableReport.TabStop = true;
            this.radioButtonMonthlyConsumableReport.Text = "Monthly Consumable Report";
            this.radioButtonMonthlyConsumableReport.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthlyConsumerVisitReport
            // 
            this.radioButtonMonthlyConsumerVisitReport.AutoSize = true;
            this.radioButtonMonthlyConsumerVisitReport.Location = new System.Drawing.Point(7, 44);
            this.radioButtonMonthlyConsumerVisitReport.Name = "radioButtonMonthlyConsumerVisitReport";
            this.radioButtonMonthlyConsumerVisitReport.Size = new System.Drawing.Size(169, 17);
            this.radioButtonMonthlyConsumerVisitReport.TabIndex = 1;
            this.radioButtonMonthlyConsumerVisitReport.TabStop = true;
            this.radioButtonMonthlyConsumerVisitReport.Text = "Monthly Consumer Visit Report";
            this.radioButtonMonthlyConsumerVisitReport.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthlyBalancingAndAlignmentReport
            // 
            this.radioButtonMonthlyBalancingAndAlignmentReport.AutoSize = true;
            this.radioButtonMonthlyBalancingAndAlignmentReport.Location = new System.Drawing.Point(7, 68);
            this.radioButtonMonthlyBalancingAndAlignmentReport.Name = "radioButtonMonthlyBalancingAndAlignmentReport";
            this.radioButtonMonthlyBalancingAndAlignmentReport.Size = new System.Drawing.Size(217, 17);
            this.radioButtonMonthlyBalancingAndAlignmentReport.TabIndex = 2;
            this.radioButtonMonthlyBalancingAndAlignmentReport.TabStop = true;
            this.radioButtonMonthlyBalancingAndAlignmentReport.Text = "Monthly Balancing and Alignment Report";
            this.radioButtonMonthlyBalancingAndAlignmentReport.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthlyWorkerReport
            // 
            this.radioButtonMonthlyWorkerReport.AutoSize = true;
            this.radioButtonMonthlyWorkerReport.Location = new System.Drawing.Point(7, 92);
            this.radioButtonMonthlyWorkerReport.Name = "radioButtonMonthlyWorkerReport";
            this.radioButtonMonthlyWorkerReport.Size = new System.Drawing.Size(135, 17);
            this.radioButtonMonthlyWorkerReport.TabIndex = 3;
            this.radioButtonMonthlyWorkerReport.TabStop = true;
            this.radioButtonMonthlyWorkerReport.Text = "Monthly Worker Report";
            this.radioButtonMonthlyWorkerReport.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(13, 167);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 204);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxReports);
            this.Controls.Add(this.labelMessage);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.groupBoxReports.ResumeLayout(false);
            this.groupBoxReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}