namespace andyCheung_B8IT117
{
    partial class PatientRecords
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.grpPatientRecords = new System.Windows.Forms.GroupBox();
            this.cmbPatientTitle = new System.Windows.Forms.ComboBox();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.dtpPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientEmail = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientLName = new System.Windows.Forms.TextBox();
            this.txtPatientFName = new System.Windows.Forms.TextBox();
            this.lblPatientPhone = new System.Windows.Forms.Label();
            this.lblPatientEmail = new System.Windows.Forms.Label();
            this.lblPatientDOB = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientLName = new System.Windows.Forms.Label();
            this.lblPatientFName = new System.Windows.Forms.Label();
            this.lblPatientTitle = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnShowPatients = new System.Windows.Forms.Button();
            this.btnPatientContactDetails = new System.Windows.Forms.Button();
            this.btnPatientNames = new System.Windows.Forms.Button();
            this.lblDisplayPatient = new System.Windows.Forms.Label();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.btnPatientClose = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.grpPatientRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPatientRecords
            // 
            this.grpPatientRecords.Controls.Add(this.cmbPatientTitle);
            this.grpPatientRecords.Controls.Add(this.btnSearchPatient);
            this.grpPatientRecords.Controls.Add(this.dtpPatientDOB);
            this.grpPatientRecords.Controls.Add(this.txtPatientPhone);
            this.grpPatientRecords.Controls.Add(this.txtPatientEmail);
            this.grpPatientRecords.Controls.Add(this.txtPatientID);
            this.grpPatientRecords.Controls.Add(this.txtPatientLName);
            this.grpPatientRecords.Controls.Add(this.txtPatientFName);
            this.grpPatientRecords.Controls.Add(this.lblPatientPhone);
            this.grpPatientRecords.Controls.Add(this.lblPatientEmail);
            this.grpPatientRecords.Controls.Add(this.lblPatientDOB);
            this.grpPatientRecords.Controls.Add(this.lblPatientID);
            this.grpPatientRecords.Controls.Add(this.lblPatientLName);
            this.grpPatientRecords.Controls.Add(this.lblPatientFName);
            this.grpPatientRecords.Controls.Add(this.lblPatientTitle);
            this.grpPatientRecords.Location = new System.Drawing.Point(13, 13);
            this.grpPatientRecords.Name = "grpPatientRecords";
            this.grpPatientRecords.Size = new System.Drawing.Size(498, 143);
            this.grpPatientRecords.TabIndex = 0;
            this.grpPatientRecords.TabStop = false;
            this.grpPatientRecords.Text = "Patient";
            // 
            // cmbPatientTitle
            // 
            this.cmbPatientTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientTitle.FormattingEnabled = true;
            this.cmbPatientTitle.Location = new System.Drawing.Point(100, 51);
            this.cmbPatientTitle.Name = "cmbPatientTitle";
            this.cmbPatientTitle.Size = new System.Drawing.Size(54, 21);
            this.cmbPatientTitle.TabIndex = 2;
            this.cmbPatientTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(210, 18);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(151, 23);
            this.btnSearchPatient.TabIndex = 9;
            this.btnSearchPatient.Text = "Search By ID";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // dtpPatientDOB
            // 
            this.dtpPatientDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatientDOB.Location = new System.Drawing.Point(330, 52);
            this.dtpPatientDOB.Name = "dtpPatientDOB";
            this.dtpPatientDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpPatientDOB.TabIndex = 5;
            this.dtpPatientDOB.Value = new System.DateTime(2000, 6, 1, 0, 0, 0, 0);
            this.dtpPatientDOB.ValueChanged += new System.EventHandler(this.dtpPatientDOB_ValueChanged);
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Location = new System.Drawing.Point(330, 109);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPatientPhone.TabIndex = 7;
            // 
            // txtPatientEmail
            // 
            this.txtPatientEmail.Location = new System.Drawing.Point(330, 80);
            this.txtPatientEmail.Name = "txtPatientEmail";
            this.txtPatientEmail.Size = new System.Drawing.Size(100, 20);
            this.txtPatientEmail.TabIndex = 6;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(100, 20);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtPatientID.TabIndex = 1;
            // 
            // txtPatientLName
            // 
            this.txtPatientLName.Location = new System.Drawing.Point(100, 109);
            this.txtPatientLName.Name = "txtPatientLName";
            this.txtPatientLName.Size = new System.Drawing.Size(100, 20);
            this.txtPatientLName.TabIndex = 4;
            // 
            // txtPatientFName
            // 
            this.txtPatientFName.Location = new System.Drawing.Point(100, 80);
            this.txtPatientFName.Name = "txtPatientFName";
            this.txtPatientFName.Size = new System.Drawing.Size(100, 20);
            this.txtPatientFName.TabIndex = 3;
            // 
            // lblPatientPhone
            // 
            this.lblPatientPhone.AutoSize = true;
            this.lblPatientPhone.Location = new System.Drawing.Point(254, 112);
            this.lblPatientPhone.Name = "lblPatientPhone";
            this.lblPatientPhone.Size = new System.Drawing.Size(44, 13);
            this.lblPatientPhone.TabIndex = 6;
            this.lblPatientPhone.Text = "Phone :";
            // 
            // lblPatientEmail
            // 
            this.lblPatientEmail.AutoSize = true;
            this.lblPatientEmail.Location = new System.Drawing.Point(254, 83);
            this.lblPatientEmail.Name = "lblPatientEmail";
            this.lblPatientEmail.Size = new System.Drawing.Size(38, 13);
            this.lblPatientEmail.TabIndex = 5;
            this.lblPatientEmail.Text = "Email :";
            // 
            // lblPatientDOB
            // 
            this.lblPatientDOB.AutoSize = true;
            this.lblPatientDOB.Location = new System.Drawing.Point(254, 54);
            this.lblPatientDOB.Name = "lblPatientDOB";
            this.lblPatientDOB.Size = new System.Drawing.Size(36, 13);
            this.lblPatientDOB.TabIndex = 3;
            this.lblPatientDOB.Text = "DOB :";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(24, 23);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(24, 13);
            this.lblPatientID.TabIndex = 4;
            this.lblPatientID.Text = "ID :";
            // 
            // lblPatientLName
            // 
            this.lblPatientLName.AutoSize = true;
            this.lblPatientLName.Location = new System.Drawing.Point(24, 112);
            this.lblPatientLName.Name = "lblPatientLName";
            this.lblPatientLName.Size = new System.Drawing.Size(64, 13);
            this.lblPatientLName.TabIndex = 2;
            this.lblPatientLName.Text = "Last Name :";
            // 
            // lblPatientFName
            // 
            this.lblPatientFName.AutoSize = true;
            this.lblPatientFName.Location = new System.Drawing.Point(24, 83);
            this.lblPatientFName.Name = "lblPatientFName";
            this.lblPatientFName.Size = new System.Drawing.Size(63, 13);
            this.lblPatientFName.TabIndex = 1;
            this.lblPatientFName.Text = "First Name :";
            // 
            // lblPatientTitle
            // 
            this.lblPatientTitle.AutoSize = true;
            this.lblPatientTitle.Location = new System.Drawing.Point(24, 54);
            this.lblPatientTitle.Name = "lblPatientTitle";
            this.lblPatientTitle.Size = new System.Drawing.Size(33, 13);
            this.lblPatientTitle.TabIndex = 0;
            this.lblPatientTitle.Text = "Title :";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(184, 162);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(151, 23);
            this.btnAddPatient.TabIndex = 8;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnShowPatients
            // 
            this.btnShowPatients.Location = new System.Drawing.Point(97, 534);
            this.btnShowPatients.Name = "btnShowPatients";
            this.btnShowPatients.Size = new System.Drawing.Size(151, 23);
            this.btnShowPatients.TabIndex = 13;
            this.btnShowPatients.Text = "Show All Patients";
            this.btnShowPatients.UseVisualStyleBackColor = true;
            this.btnShowPatients.Click += new System.EventHandler(this.btnShowPatients_Click);
            // 
            // btnPatientContactDetails
            // 
            this.btnPatientContactDetails.Location = new System.Drawing.Point(281, 563);
            this.btnPatientContactDetails.Name = "btnPatientContactDetails";
            this.btnPatientContactDetails.Size = new System.Drawing.Size(151, 23);
            this.btnPatientContactDetails.TabIndex = 16;
            this.btnPatientContactDetails.Text = "Show All Contact Details";
            this.btnPatientContactDetails.UseVisualStyleBackColor = true;
            this.btnPatientContactDetails.Click += new System.EventHandler(this.btnPatientContactDetails_Click);
            // 
            // btnPatientNames
            // 
            this.btnPatientNames.Location = new System.Drawing.Point(281, 534);
            this.btnPatientNames.Name = "btnPatientNames";
            this.btnPatientNames.Size = new System.Drawing.Size(151, 23);
            this.btnPatientNames.TabIndex = 14;
            this.btnPatientNames.Text = "Show All Patient Names";
            this.btnPatientNames.UseVisualStyleBackColor = true;
            this.btnPatientNames.Click += new System.EventHandler(this.btnPatientNames_Click);
            // 
            // lblDisplayPatient
            // 
            this.lblDisplayPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayPatient.Location = new System.Drawing.Point(113, 205);
            this.lblDisplayPatient.Name = "lblDisplayPatient";
            this.lblDisplayPatient.Size = new System.Drawing.Size(283, 23);
            this.lblDisplayPatient.TabIndex = 10;
            this.lblDisplayPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(16, 241);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(495, 121);
            this.lstPatients.TabIndex = 11;
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(15, 368);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(496, 150);
            this.dgvPatients.TabIndex = 12;
            // 
            // btnPatientClose
            // 
            this.btnPatientClose.Location = new System.Drawing.Point(184, 603);
            this.btnPatientClose.Name = "btnPatientClose";
            this.btnPatientClose.Size = new System.Drawing.Size(151, 23);
            this.btnPatientClose.TabIndex = 17;
            this.btnPatientClose.Text = "Close";
            this.btnPatientClose.UseVisualStyleBackColor = true;
            this.btnPatientClose.Click += new System.EventHandler(this.btnPatientBack_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(97, 563);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(151, 23);
            this.btnDeletePatient.TabIndex = 15;
            this.btnDeletePatient.Text = "Delete Selected Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 639);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnPatientClose);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.lstPatients);
            this.Controls.Add(this.lblDisplayPatient);
            this.Controls.Add(this.btnPatientNames);
            this.Controls.Add(this.btnPatientContactDetails);
            this.Controls.Add(this.btnShowPatients);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.grpPatientRecords);
            this.Name = "PatientRecords";
            this.Text = "Patient Records";
            this.grpPatientRecords.ResumeLayout(false);
            this.grpPatientRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatientRecords;
        private System.Windows.Forms.DateTimePicker dtpPatientDOB;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientEmail;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientLName;
        private System.Windows.Forms.TextBox txtPatientFName;
        private System.Windows.Forms.Label lblPatientPhone;
        private System.Windows.Forms.Label lblPatientEmail;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientDOB;
        private System.Windows.Forms.Label lblPatientLName;
        private System.Windows.Forms.Label lblPatientFName;
        private System.Windows.Forms.Label lblPatientTitle;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnShowPatients;
        private System.Windows.Forms.Button btnPatientContactDetails;
        private System.Windows.Forms.Button btnPatientNames;
        private System.Windows.Forms.Label lblDisplayPatient;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnPatientClose;
        private System.Windows.Forms.ComboBox cmbPatientTitle;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnDeletePatient;
    }
}