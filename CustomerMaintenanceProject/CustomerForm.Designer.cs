namespace CustomerMaintenanceSystem
{
    public partial class CustomerForm
    {
        private System.Windows.Forms.Label lblCarNo;
        private System.Windows.Forms.TextBox textboxCarNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox textboxMake;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button btnNext;

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
            this.lblCarNo = new System.Windows.Forms.Label();
            this.textboxCarNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.textboxMake = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarNo
            // 
            this.lblCarNo.AutoSize = true;
            this.lblCarNo.Location = new System.Drawing.Point(13, 13);
            this.lblCarNo.Name = "lblCarNo";
            this.lblCarNo.Size = new System.Drawing.Size(43, 13);
            this.lblCarNo.TabIndex = 0;
            this.lblCarNo.Text = "Car No.";
            // 
            // tbCarNo
            // 
            this.textboxCarNo.Location = new System.Drawing.Point(62, 10);
            this.textboxCarNo.Name = "tbCarNo";
            this.textboxCarNo.Size = new System.Drawing.Size(160, 20);
            this.textboxCarNo.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.textboxName.Location = new System.Drawing.Point(62, 37);
            this.textboxName.Name = "tbName";
            this.textboxName.Size = new System.Drawing.Size(160, 20);
            this.textboxName.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(270, 13);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.textboxAddress.Location = new System.Drawing.Point(322, 13);
            this.textboxAddress.Name = "tbAddress";
            this.textboxAddress.Size = new System.Drawing.Size(160, 20);
            this.textboxAddress.TabIndex = 5;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(273, 40);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "Make";
            // 
            // tbMake
            // 
            this.textboxMake.Location = new System.Drawing.Point(322, 40);
            this.textboxMake.Name = "tbMake";
            this.textboxMake.Size = new System.Drawing.Size(160, 20);
            this.textboxMake.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(66, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(147, 88);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(309, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(66, 139);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textboxSearch.Location = new System.Drawing.Point(95, 139);
            this.textboxSearch.Name = "textBox1";
            this.textboxSearch.Size = new System.Drawing.Size(260, 20);
            this.textboxSearch.TabIndex = 13;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(361, 136);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 181);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textboxMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.textboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textboxCarNo);
            this.Controls.Add(this.lblCarNo);
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}