namespace andyCheung_B8IT117
{
    partial class StaffRecords
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblDisplayStaff = new System.Windows.Forms.Label();
            this.dtpStaffDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffLName = new System.Windows.Forms.TextBox();
            this.txtStaffFName = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffDOB = new System.Windows.Forms.Label();
            this.lblStaffLName = new System.Windows.Forms.Label();
            this.lblStaffFName = new System.Windows.Forms.Label();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.lstStaff = new System.Windows.Forms.ListBox();
            this.btnStaffNames = new System.Windows.Forms.Button();
            this.btnStaffContactDetails = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.grpStaffRecords = new System.Windows.Forms.GroupBox();
            this.cmbStaffTitle = new System.Windows.Forms.ComboBox();
            this.btnStaffClose = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnShowStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.grpStaffRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(18, 363);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(496, 150);
            this.dgvStaff.TabIndex = 12;
            // 
            // lblDisplayStaff
            // 
            this.lblDisplayStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayStaff.Location = new System.Drawing.Point(112, 198);
            this.lblDisplayStaff.Name = "lblDisplayStaff";
            this.lblDisplayStaff.Size = new System.Drawing.Size(286, 23);
            this.lblDisplayStaff.TabIndex = 10;
            this.lblDisplayStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplayStaff.Click += new System.EventHandler(this.lblDisplayStaff_Click);
            // 
            // dtpStaffDOB
            // 
            this.dtpStaffDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStaffDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStaffDOB.Location = new System.Drawing.Point(327, 54);
            this.dtpStaffDOB.Name = "dtpStaffDOB";
            this.dtpStaffDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpStaffDOB.TabIndex = 5;
            this.dtpStaffDOB.Value = new System.DateTime(2000, 6, 1, 0, 0, 0, 0);
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(327, 109);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(100, 20);
            this.txtStaffPhone.TabIndex = 7;
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Location = new System.Drawing.Point(327, 81);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(100, 20);
            this.txtStaffEmail.TabIndex = 6;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(100, 18);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 1;
            // 
            // txtStaffLName
            // 
            this.txtStaffLName.Location = new System.Drawing.Point(100, 109);
            this.txtStaffLName.Name = "txtStaffLName";
            this.txtStaffLName.Size = new System.Drawing.Size(100, 20);
            this.txtStaffLName.TabIndex = 4;
            this.txtStaffLName.TextChanged += new System.EventHandler(this.txtStaffLName_TextChanged);
            // 
            // txtStaffFName
            // 
            this.txtStaffFName.Location = new System.Drawing.Point(100, 80);
            this.txtStaffFName.Name = "txtStaffFName";
            this.txtStaffFName.Size = new System.Drawing.Size(100, 20);
            this.txtStaffFName.TabIndex = 3;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Location = new System.Drawing.Point(251, 112);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(44, 13);
            this.lblStaffPhone.TabIndex = 6;
            this.lblStaffPhone.Text = "Phone :";
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Location = new System.Drawing.Point(251, 83);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(38, 13);
            this.lblStaffEmail.TabIndex = 5;
            this.lblStaffEmail.Text = "Email :";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(24, 21);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(24, 13);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "ID :";
            // 
            // lblStaffDOB
            // 
            this.lblStaffDOB.AutoSize = true;
            this.lblStaffDOB.Location = new System.Drawing.Point(251, 59);
            this.lblStaffDOB.Name = "lblStaffDOB";
            this.lblStaffDOB.Size = new System.Drawing.Size(36, 13);
            this.lblStaffDOB.TabIndex = 3;
            this.lblStaffDOB.Text = "DOB :";
            // 
            // lblStaffLName
            // 
            this.lblStaffLName.AutoSize = true;
            this.lblStaffLName.Location = new System.Drawing.Point(24, 112);
            this.lblStaffLName.Name = "lblStaffLName";
            this.lblStaffLName.Size = new System.Drawing.Size(64, 13);
            this.lblStaffLName.TabIndex = 2;
            this.lblStaffLName.Text = "Last Name :";
            // 
            // lblStaffFName
            // 
            this.lblStaffFName.AutoSize = true;
            this.lblStaffFName.Location = new System.Drawing.Point(24, 83);
            this.lblStaffFName.Name = "lblStaffFName";
            this.lblStaffFName.Size = new System.Drawing.Size(63, 13);
            this.lblStaffFName.TabIndex = 1;
            this.lblStaffFName.Text = "First Name :";
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Location = new System.Drawing.Point(24, 54);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(33, 13);
            this.lblStaffTitle.TabIndex = 0;
            this.lblStaffTitle.Text = "Title :";
            // 
            // lstStaff
            // 
            this.lstStaff.FormattingEnabled = true;
            this.lstStaff.Location = new System.Drawing.Point(19, 236);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(495, 121);
            this.lstStaff.TabIndex = 11;
            // 
            // btnStaffNames
            // 
            this.btnStaffNames.Location = new System.Drawing.Point(290, 519);
            this.btnStaffNames.Name = "btnStaffNames";
            this.btnStaffNames.Size = new System.Drawing.Size(151, 23);
            this.btnStaffNames.TabIndex = 14;
            this.btnStaffNames.Text = "Show All Staff Names";
            this.btnStaffNames.UseVisualStyleBackColor = true;
            this.btnStaffNames.Click += new System.EventHandler(this.btnStaffNames_Click);
            // 
            // btnStaffContactDetails
            // 
            this.btnStaffContactDetails.Location = new System.Drawing.Point(290, 548);
            this.btnStaffContactDetails.Name = "btnStaffContactDetails";
            this.btnStaffContactDetails.Size = new System.Drawing.Size(151, 23);
            this.btnStaffContactDetails.TabIndex = 16;
            this.btnStaffContactDetails.Text = "Show All Contact Details";
            this.btnStaffContactDetails.UseVisualStyleBackColor = true;
            this.btnStaffContactDetails.Click += new System.EventHandler(this.btnStaffContactDetails_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(217, 16);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(151, 23);
            this.btnSearchStaff.TabIndex = 9;
            this.btnSearchStaff.Text = "Search By ID";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(190, 160);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(151, 23);
            this.btnAddStaff.TabIndex = 8;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // grpStaffRecords
            // 
            this.grpStaffRecords.Controls.Add(this.cmbStaffTitle);
            this.grpStaffRecords.Controls.Add(this.dtpStaffDOB);
            this.grpStaffRecords.Controls.Add(this.txtStaffPhone);
            this.grpStaffRecords.Controls.Add(this.txtStaffEmail);
            this.grpStaffRecords.Controls.Add(this.txtStaffID);
            this.grpStaffRecords.Controls.Add(this.txtStaffLName);
            this.grpStaffRecords.Controls.Add(this.txtStaffFName);
            this.grpStaffRecords.Controls.Add(this.lblStaffPhone);
            this.grpStaffRecords.Controls.Add(this.btnSearchStaff);
            this.grpStaffRecords.Controls.Add(this.lblStaffEmail);
            this.grpStaffRecords.Controls.Add(this.lblStaffID);
            this.grpStaffRecords.Controls.Add(this.lblStaffDOB);
            this.grpStaffRecords.Controls.Add(this.lblStaffLName);
            this.grpStaffRecords.Controls.Add(this.lblStaffFName);
            this.grpStaffRecords.Controls.Add(this.lblStaffTitle);
            this.grpStaffRecords.Location = new System.Drawing.Point(12, 12);
            this.grpStaffRecords.Name = "grpStaffRecords";
            this.grpStaffRecords.Size = new System.Drawing.Size(495, 142);
            this.grpStaffRecords.TabIndex = 8;
            this.grpStaffRecords.TabStop = false;
            this.grpStaffRecords.Text = "Staff Member";
            // 
            // cmbStaffTitle
            // 
            this.cmbStaffTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffTitle.FormattingEnabled = true;
            this.cmbStaffTitle.Location = new System.Drawing.Point(100, 51);
            this.cmbStaffTitle.Name = "cmbStaffTitle";
            this.cmbStaffTitle.Size = new System.Drawing.Size(54, 21);
            this.cmbStaffTitle.TabIndex = 2;
            // 
            // btnStaffClose
            // 
            this.btnStaffClose.Location = new System.Drawing.Point(190, 597);
            this.btnStaffClose.Name = "btnStaffClose";
            this.btnStaffClose.Size = new System.Drawing.Size(151, 23);
            this.btnStaffClose.TabIndex = 17;
            this.btnStaffClose.Text = "Close";
            this.btnStaffClose.UseVisualStyleBackColor = true;
            this.btnStaffClose.Click += new System.EventHandler(this.btnStaffBack_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(96, 548);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteStaff.TabIndex = 15;
            this.btnDeleteStaff.Text = "Delete Selected Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Location = new System.Drawing.Point(96, 519);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(151, 23);
            this.btnShowStaff.TabIndex = 13;
            this.btnShowStaff.Text = "Show All Staff";
            this.btnShowStaff.UseVisualStyleBackColor = true;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // StaffRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 634);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnStaffClose);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.lblDisplayStaff);
            this.Controls.Add(this.lstStaff);
            this.Controls.Add(this.btnStaffNames);
            this.Controls.Add(this.btnStaffContactDetails);
            this.Controls.Add(this.grpStaffRecords);
            this.Controls.Add(this.btnAddStaff);
            this.Name = "StaffRecords";
            this.Text = "Staff Records";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.grpStaffRecords.ResumeLayout(false);
            this.grpStaffRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblDisplayStaff;
        private System.Windows.Forms.DateTimePicker dtpStaffDOB;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffLName;
        private System.Windows.Forms.TextBox txtStaffFName;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffDOB;
        private System.Windows.Forms.Label lblStaffLName;
        private System.Windows.Forms.Label lblStaffFName;
        private System.Windows.Forms.Label lblStaffTitle;
        private System.Windows.Forms.ListBox lstStaff;
        private System.Windows.Forms.Button btnStaffNames;
        private System.Windows.Forms.Button btnStaffContactDetails;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.GroupBox grpStaffRecords;
        private System.Windows.Forms.Button btnStaffClose;
        private System.Windows.Forms.ComboBox cmbStaffTitle;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnShowStaff;
    }
}