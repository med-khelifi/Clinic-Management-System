namespace CMS.Appointments
{
    partial class frmAddEditAppointments
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePatientInfo = new System.Windows.Forms.TabPage();
            this.ucFindPatient2 = new CMS.Patients.Controls.ucFindPatient();
            this.ucFindPatient1 = new CMS.Patients.Controls.ucFindPatient();
            this.tabPageDoctorInformation = new System.Windows.Forms.TabPage();
            this.ucFindDoctor1 = new CMS.Doctors.Contorls.ucFindDoctor();
            this.tabPageAppointmentInformation = new System.Windows.Forms.TabPage();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePatientInfo.SuspendLayout();
            this.tabPageDoctorInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePatientInfo);
            this.tabControl1.Controls.Add(this.tabPageDoctorInformation);
            this.tabControl1.Controls.Add(this.tabPageAppointmentInformation);
            this.tabControl1.Location = new System.Drawing.Point(2, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePatientInfo
            // 
            this.tabPagePatientInfo.Controls.Add(this.ucFindPatient2);
            this.tabPagePatientInfo.Controls.Add(this.ucFindPatient1);
            this.tabPagePatientInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPagePatientInfo.Name = "tabPagePatientInfo";
            this.tabPagePatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatientInfo.Size = new System.Drawing.Size(832, 554);
            this.tabPagePatientInfo.TabIndex = 0;
            this.tabPagePatientInfo.Text = "Patient Information";
            this.tabPagePatientInfo.UseVisualStyleBackColor = true;
            // 
            // ucFindPatient2
            // 
            this.ucFindPatient2.Location = new System.Drawing.Point(0, 0);
            this.ucFindPatient2.Name = "ucFindPatient2";
            this.ucFindPatient2.Size = new System.Drawing.Size(836, 556);
            this.ucFindPatient2.TabIndex = 1;
            // 
            // ucFindPatient1
            // 
            this.ucFindPatient1.Location = new System.Drawing.Point(0, 0);
            this.ucFindPatient1.Name = "ucFindPatient1";
            this.ucFindPatient1.Size = new System.Drawing.Size(836, 556);
            this.ucFindPatient1.TabIndex = 0;
            // 
            // tabPageDoctorInformation
            // 
            this.tabPageDoctorInformation.Controls.Add(this.ucFindDoctor1);
            this.tabPageDoctorInformation.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoctorInformation.Name = "tabPageDoctorInformation";
            this.tabPageDoctorInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctorInformation.Size = new System.Drawing.Size(832, 554);
            this.tabPageDoctorInformation.TabIndex = 1;
            this.tabPageDoctorInformation.Text = "Doctor Information";
            this.tabPageDoctorInformation.UseVisualStyleBackColor = true;
            // 
            // ucFindDoctor1
            // 
            this.ucFindDoctor1.Location = new System.Drawing.Point(0, 4);
            this.ucFindDoctor1.Name = "ucFindDoctor1";
            this.ucFindDoctor1.Size = new System.Drawing.Size(828, 544);
            this.ucFindDoctor1.TabIndex = 0;
            // 
            // tabPageAppointmentInformation
            // 
            this.tabPageAppointmentInformation.Location = new System.Drawing.Point(4, 25);
            this.tabPageAppointmentInformation.Name = "tabPageAppointmentInformation";
            this.tabPageAppointmentInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointmentInformation.Size = new System.Drawing.Size(832, 554);
            this.tabPageAppointmentInformation.TabIndex = 2;
            this.tabPageAppointmentInformation.Text = "Appointment Information";
            this.tabPageAppointmentInformation.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(725, 644);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            // 
            // BtnClose
            // 
            this.BtnClose.BorderColor = System.Drawing.Color.DimGray;
            this.BtnClose.BorderRadius = 10;
            this.BtnClose.BorderThickness = 2;
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.FillColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClose.Location = new System.Drawing.Point(612, 644);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(107, 40);
            this.BtnClose.TabIndex = 86;
            this.BtnClose.Text = "Close";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(251, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 36);
            this.lblTitle.TabIndex = 87;
            this.lblTitle.Text = "Add/Edit Appointment";
            // 
            // frmAddEditAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 696);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditAppointments";
            this.Text = "frmAddEditAppointments";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePatientInfo.ResumeLayout(false);
            this.tabPageDoctorInformation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePatientInfo;
        private System.Windows.Forms.TabPage tabPageDoctorInformation;
        private System.Windows.Forms.TabPage tabPageAppointmentInformation;
        private Patients.Controls.ucFindPatient ucFindPatient1;
        private Doctors.Contorls.ucFindDoctor ucFindDoctor1;
        private Patients.Controls.ucFindPatient ucFindPatient2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}