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
            this.ucFindPatient1 = new CMS.Patients.Controls.ucFindPatient();
            this.tabPageDoctorInformation = new System.Windows.Forms.TabPage();
            this.ucFindDoctor1 = new CMS.Doctors.Contorls.ucFindDoctor();
            this.tabPageAppointmentInformation = new System.Windows.Forms.TabPage();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAppointmentStatus = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePatientInfo.SuspendLayout();
            this.tabPageDoctorInformation.SuspendLayout();
            this.tabPageAppointmentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
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
            this.tabPagePatientInfo.Controls.Add(this.ucFindPatient1);
            this.tabPagePatientInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPagePatientInfo.Name = "tabPagePatientInfo";
            this.tabPagePatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatientInfo.Size = new System.Drawing.Size(832, 554);
            this.tabPagePatientInfo.TabIndex = 0;
            this.tabPagePatientInfo.Text = "Patient Information";
            this.tabPagePatientInfo.UseVisualStyleBackColor = true;
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
            this.ucFindDoctor1.OnSearchButtonClicked += new CMS.Doctors.Contorls.ucFindDoctor.OnSearchButtonClickedDelegate(this.ucFindDoctor1_OnSearchButtonClicked);
            // 
            // tabPageAppointmentInformation
            // 
            this.tabPageAppointmentInformation.Controls.Add(this.dtpAppointmentDate);
            this.tabPageAppointmentInformation.Controls.Add(this.pictureBox3);
            this.tabPageAppointmentInformation.Controls.Add(this.lblTotalAmount);
            this.tabPageAppointmentInformation.Controls.Add(this.pictureBox1);
            this.tabPageAppointmentInformation.Controls.Add(this.label4);
            this.tabPageAppointmentInformation.Controls.Add(this.lblAppointmentStatus);
            this.tabPageAppointmentInformation.Controls.Add(this.lblAppointmentID);
            this.tabPageAppointmentInformation.Controls.Add(this.label1);
            this.tabPageAppointmentInformation.Controls.Add(this.pictureBox6);
            this.tabPageAppointmentInformation.Controls.Add(this.label10);
            this.tabPageAppointmentInformation.Controls.Add(this.pictureBox11);
            this.tabPageAppointmentInformation.Controls.Add(this.label12);
            this.tabPageAppointmentInformation.Location = new System.Drawing.Point(4, 25);
            this.tabPageAppointmentInformation.Name = "tabPageAppointmentInformation";
            this.tabPageAppointmentInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppointmentInformation.Size = new System.Drawing.Size(832, 554);
            this.tabPageAppointmentInformation.TabIndex = 2;
            this.tabPageAppointmentInformation.Text = "Appointment Information";
            this.tabPageAppointmentInformation.UseVisualStyleBackColor = true;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(226, 79);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(258, 22);
            this.dtpAppointmentDate.TabIndex = 83;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CMS.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(172, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(222, 176);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(48, 21);
            this.lblTotalAmount.TabIndex = 81;
            this.lblTotalAmount.Text = "N/A $";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMS.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(172, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 81;
            this.label4.Text = "Total amount :";
            // 
            // lblAppointmentStatus
            // 
            this.lblAppointmentStatus.AutoSize = true;
            this.lblAppointmentStatus.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblAppointmentStatus.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentStatus.Location = new System.Drawing.Point(222, 128);
            this.lblAppointmentStatus.Name = "lblAppointmentStatus";
            this.lblAppointmentStatus.Size = new System.Drawing.Size(106, 21);
            this.lblAppointmentStatus.TabIndex = 81;
            this.lblAppointmentStatus.Text = "Not Confirmed";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblAppointmentID.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentID.Location = new System.Drawing.Point(222, 32);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(35, 21);
            this.lblAppointmentID.TabIndex = 81;
            this.lblAppointmentID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Appointment status :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CMS.Properties.Resources.date_Icon;
            this.pictureBox6.Location = new System.Drawing.Point(172, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(48, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 81;
            this.label10.Text = "Appointment ID :";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::CMS.Properties.Resources.date_Icon;
            this.pictureBox11.Location = new System.Drawing.Point(172, 69);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 82;
            this.pictureBox11.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 21);
            this.label12.TabIndex = 81;
            this.label12.Text = "Appointment Date :";
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditAppointments";
            this.Load += new System.EventHandler(this.frmAddEditAppointments_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePatientInfo.ResumeLayout(false);
            this.tabPageDoctorInformation.ResumeLayout(false);
            this.tabPageAppointmentInformation.ResumeLayout(false);
            this.tabPageAppointmentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAppointmentStatus;
    }
}