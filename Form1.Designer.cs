namespace andyCheung_B8IT117
{
    partial class Form1
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
            this.btnPatientRecords = new System.Windows.Forms.Button();
            this.btnStaffRecords = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatientRecords
            // 
            this.btnPatientRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRecords.Location = new System.Drawing.Point(57, 40);
            this.btnPatientRecords.Name = "btnPatientRecords";
            this.btnPatientRecords.Size = new System.Drawing.Size(151, 23);
            this.btnPatientRecords.TabIndex = 1;
            this.btnPatientRecords.Text = "Patient Records";
            this.btnPatientRecords.UseVisualStyleBackColor = true;
            this.btnPatientRecords.Click += new System.EventHandler(this.btnPatientRecords_Click);
            // 
            // btnStaffRecords
            // 
            this.btnStaffRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffRecords.Location = new System.Drawing.Point(57, 85);
            this.btnStaffRecords.Name = "btnStaffRecords";
            this.btnStaffRecords.Size = new System.Drawing.Size(151, 23);
            this.btnStaffRecords.TabIndex = 2;
            this.btnStaffRecords.Text = "Staff Records";
            this.btnStaffRecords.UseVisualStyleBackColor = true;
            this.btnStaffRecords.Click += new System.EventHandler(this.btnStaffRecords_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(57, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnPatientRecords);
            this.grpButtons.Controls.Add(this.btnLogout);
            this.grpButtons.Controls.Add(this.btnStaffRecords);
            this.grpButtons.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpButtons.Location = new System.Drawing.Point(12, 12);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(262, 183);
            this.grpButtons.TabIndex = 3;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Hospital Records";
            this.grpButtons.Enter += new System.EventHandler(this.grpButtons_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 207);
            this.Controls.Add(this.grpButtons);
            this.Name = "Form1";
            this.Text = "Administration";
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatientRecords;
        private System.Windows.Forms.Button btnStaffRecords;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpButtons;
    }
}

