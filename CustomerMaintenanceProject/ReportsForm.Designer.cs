namespace CustomerMaintenanceSystem
{
    public partial class ReportsForm
    {
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox reportsGroupBox;
        private System.Windows.Forms.RadioButton monthlyWorkerReportRadioButton;
        private System.Windows.Forms.RadioButton monthlyBalancingAndAlignmentReportRadioButton;
        private System.Windows.Forms.RadioButton monthlyConsumerVisitReportRadioButton;
        private System.Windows.Forms.RadioButton monthlyConsumableReportRadioButton;
        private System.Windows.Forms.Button exitButton;

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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.reportsGroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyWorkerReportRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyBalancingAndAlignmentReportRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyConsumerVisitReportRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyConsumableReportRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(320, 16);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Select the radio button to generate the report.";
            // 
            // reportsGroupBox
            // 
            this.reportsGroupBox.Controls.Add(this.monthlyWorkerReportRadioButton);
            this.reportsGroupBox.Controls.Add(this.monthlyBalancingAndAlignmentReportRadioButton);
            this.reportsGroupBox.Controls.Add(this.monthlyConsumerVisitReportRadioButton);
            this.reportsGroupBox.Controls.Add(this.monthlyConsumableReportRadioButton);
            this.reportsGroupBox.Location = new System.Drawing.Point(13, 36);
            this.reportsGroupBox.Name = "reportsGroupBox";
            this.reportsGroupBox.Size = new System.Drawing.Size(227, 119);
            this.reportsGroupBox.TabIndex = 1;
            this.reportsGroupBox.TabStop = false;
            this.reportsGroupBox.Text = "Reports";
            // 
            // monthlyWorkerReportRadioButton
            // 
            this.monthlyWorkerReportRadioButton.AutoSize = true;
            this.monthlyWorkerReportRadioButton.Location = new System.Drawing.Point(7, 92);
            this.monthlyWorkerReportRadioButton.Name = "monthlyWorkerReportRadioButton";
            this.monthlyWorkerReportRadioButton.Size = new System.Drawing.Size(135, 17);
            this.monthlyWorkerReportRadioButton.TabIndex = 3;
            this.monthlyWorkerReportRadioButton.TabStop = true;
            this.monthlyWorkerReportRadioButton.Text = "Monthly Worker Report";
            this.monthlyWorkerReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyBalancingAndAlignmentReportRadioButton
            // 
            this.monthlyBalancingAndAlignmentReportRadioButton.AutoSize = true;
            this.monthlyBalancingAndAlignmentReportRadioButton.Location = new System.Drawing.Point(7, 68);
            this.monthlyBalancingAndAlignmentReportRadioButton.Name = "monthlyBalancingAndAlignmentReportRadioButton";
            this.monthlyBalancingAndAlignmentReportRadioButton.Size = new System.Drawing.Size(217, 17);
            this.monthlyBalancingAndAlignmentReportRadioButton.TabIndex = 2;
            this.monthlyBalancingAndAlignmentReportRadioButton.TabStop = true;
            this.monthlyBalancingAndAlignmentReportRadioButton.Text = "Monthly Balancing and Alignment Report";
            this.monthlyBalancingAndAlignmentReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyConsumerVisitReportRadioButton
            // 
            this.monthlyConsumerVisitReportRadioButton.AutoSize = true;
            this.monthlyConsumerVisitReportRadioButton.Location = new System.Drawing.Point(7, 44);
            this.monthlyConsumerVisitReportRadioButton.Name = "monthlyConsumerVisitReportRadioButton";
            this.monthlyConsumerVisitReportRadioButton.Size = new System.Drawing.Size(169, 17);
            this.monthlyConsumerVisitReportRadioButton.TabIndex = 1;
            this.monthlyConsumerVisitReportRadioButton.TabStop = true;
            this.monthlyConsumerVisitReportRadioButton.Text = "Monthly Consumer Visit Report";
            this.monthlyConsumerVisitReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyConsumableReportRadioButton
            // 
            this.monthlyConsumableReportRadioButton.AutoSize = true;
            this.monthlyConsumableReportRadioButton.Location = new System.Drawing.Point(7, 20);
            this.monthlyConsumableReportRadioButton.Name = "monthlyConsumableReportRadioButton";
            this.monthlyConsumableReportRadioButton.Size = new System.Drawing.Size(158, 17);
            this.monthlyConsumableReportRadioButton.TabIndex = 0;
            this.monthlyConsumableReportRadioButton.TabStop = true;
            this.monthlyConsumableReportRadioButton.Text = "Monthly Consumable Report";
            this.monthlyConsumableReportRadioButton.UseVisualStyleBackColor = true;
            this.monthlyConsumableReportRadioButton.CheckedChanged += new System.EventHandler(this.MonthlyConsumableReportRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 167);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportsGroupBox);
            this.Controls.Add(this.descriptionLabel);
            this.MinimumSize = new System.Drawing.Size(360, 240);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.reportsGroupBox.ResumeLayout(false);
            this.reportsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}