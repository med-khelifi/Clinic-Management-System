namespace CMS
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashbord = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointements = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicalRecords = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pbUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.flpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpPanel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 770);
            this.panel1.TabIndex = 0;
            // 
            // flpPanel
            // 
            this.flpPanel.Controls.Add(this.btnDashbord);
            this.flpPanel.Controls.Add(this.btnUsers);
            this.flpPanel.Controls.Add(this.btnDoctors);
            this.flpPanel.Controls.Add(this.btnPatients);
            this.flpPanel.Controls.Add(this.btnAppointements);
            this.flpPanel.Controls.Add(this.btnPayments);
            this.flpPanel.Controls.Add(this.btnMedicalRecords);
            this.flpPanel.Location = new System.Drawing.Point(3, 186);
            this.flpPanel.Name = "flpPanel";
            this.flpPanel.Size = new System.Drawing.Size(279, 479);
            this.flpPanel.TabIndex = 0;
            // 
            // btnDashbord
            // 
            this.btnDashbord.BackColor = System.Drawing.Color.Transparent;
            this.btnDashbord.BorderRadius = 22;
            this.btnDashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashbord.Checked = true;
            this.btnDashbord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashbord.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDashbord.CheckedState.Image = global::CMS.Properties.Resources.dashboardBleu;
            this.btnDashbord.CheckedState.Parent = this.btnDashbord;
            this.btnDashbord.CustomImages.Parent = this.btnDashbord;
            this.btnDashbord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDashbord.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.HoverState.Parent = this.btnDashbord;
            this.btnDashbord.Image = global::CMS.Properties.Resources.dashboard;
            this.btnDashbord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashbord.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashbord.Location = new System.Drawing.Point(3, 3);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.ShadowDecoration.Parent = this.btnDashbord;
            this.btnDashbord.Size = new System.Drawing.Size(251, 52);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Dashboard";
            this.btnDashbord.UseTransparentBackground = true;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderRadius = 22;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUsers.CheckedState.Image = global::CMS.Properties.Resources.usersBlue;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUsers.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::CMS.Properties.Resources.usersWthite;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUsers.Location = new System.Drawing.Point(3, 61);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(251, 52);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseTransparentBackground = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctors.BorderRadius = 22;
            this.btnDoctors.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDoctors.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDoctors.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDoctors.CheckedState.Image = global::CMS.Properties.Resources.doctorBleu;
            this.btnDoctors.CheckedState.Parent = this.btnDoctors;
            this.btnDoctors.CustomImages.Parent = this.btnDoctors;
            this.btnDoctors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDoctors.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.HoverState.Parent = this.btnDoctors;
            this.btnDoctors.Image = global::CMS.Properties.Resources.doctorWhite;
            this.btnDoctors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctors.Location = new System.Drawing.Point(3, 119);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.ShadowDecoration.Parent = this.btnDoctors;
            this.btnDoctors.Size = new System.Drawing.Size(251, 52);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseTransparentBackground = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.Transparent;
            this.btnPatients.BorderRadius = 22;
            this.btnPatients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPatients.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPatients.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPatients.CheckedState.Image = global::CMS.Properties.Resources.patientBleu;
            this.btnPatients.CheckedState.Parent = this.btnPatients;
            this.btnPatients.CustomImages.Parent = this.btnPatients;
            this.btnPatients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPatients.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.HoverState.Parent = this.btnPatients;
            this.btnPatients.Image = global::CMS.Properties.Resources.patientWhite;
            this.btnPatients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPatients.Location = new System.Drawing.Point(3, 177);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.ShadowDecoration.Parent = this.btnPatients;
            this.btnPatients.Size = new System.Drawing.Size(251, 52);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseTransparentBackground = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnAppointements
            // 
            this.btnAppointements.BackColor = System.Drawing.Color.Transparent;
            this.btnAppointements.BorderRadius = 22;
            this.btnAppointements.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAppointements.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAppointements.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnAppointements.CheckedState.Image = global::CMS.Properties.Resources.appointementBleu;
            this.btnAppointements.CheckedState.Parent = this.btnAppointements;
            this.btnAppointements.CustomImages.Parent = this.btnAppointements;
            this.btnAppointements.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnAppointements.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointements.ForeColor = System.Drawing.Color.White;
            this.btnAppointements.HoverState.Parent = this.btnAppointements;
            this.btnAppointements.Image = global::CMS.Properties.Resources.appointementWhite;
            this.btnAppointements.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAppointements.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAppointements.Location = new System.Drawing.Point(3, 235);
            this.btnAppointements.Name = "btnAppointements";
            this.btnAppointements.ShadowDecoration.Parent = this.btnAppointements;
            this.btnAppointements.Size = new System.Drawing.Size(251, 52);
            this.btnAppointements.TabIndex = 2;
            this.btnAppointements.Text = "Appointments";
            this.btnAppointements.UseTransparentBackground = true;
            this.btnAppointements.Click += new System.EventHandler(this.btnAppointements_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.BorderRadius = 22;
            this.btnPayments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPayments.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPayments.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPayments.CheckedState.Image = global::CMS.Properties.Resources.Bleu_payment;
            this.btnPayments.CheckedState.Parent = this.btnPayments;
            this.btnPayments.CustomImages.Parent = this.btnPayments;
            this.btnPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPayments.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.HoverState.Parent = this.btnPayments;
            this.btnPayments.Image = global::CMS.Properties.Resources.White_payment;
            this.btnPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayments.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPayments.Location = new System.Drawing.Point(3, 293);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.ShadowDecoration.Parent = this.btnPayments;
            this.btnPayments.Size = new System.Drawing.Size(251, 52);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseTransparentBackground = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnMedicalRecords
            // 
            this.btnMedicalRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicalRecords.BorderRadius = 22;
            this.btnMedicalRecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicalRecords.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedicalRecords.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnMedicalRecords.CheckedState.Image = global::CMS.Properties.Resources.Blue_medical_record;
            this.btnMedicalRecords.CheckedState.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.CustomImages.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnMedicalRecords.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalRecords.ForeColor = System.Drawing.Color.White;
            this.btnMedicalRecords.HoverState.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.Image = global::CMS.Properties.Resources.white_medical_record;
            this.btnMedicalRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicalRecords.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedicalRecords.Location = new System.Drawing.Point(3, 351);
            this.btnMedicalRecords.Name = "btnMedicalRecords";
            this.btnMedicalRecords.ShadowDecoration.Parent = this.btnMedicalRecords;
            this.btnMedicalRecords.Size = new System.Drawing.Size(251, 52);
            this.btnMedicalRecords.TabIndex = 2;
            this.btnMedicalRecords.Text = "Medical Records";
            this.btnMedicalRecords.UseTransparentBackground = true;
            this.btnMedicalRecords.Click += new System.EventHandler(this.btnMedicalRecords_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plus";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinica";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CMS.Properties.Resources.clinicLogo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 128);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.pbUserPicture);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(246, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1342, 83);
            this.pHeader.TabIndex = 1;
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.Image = global::CMS.Properties.Resources.doctorWhite;
            this.pbUserPicture.Location = new System.Drawing.Point(1230, 4);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserPicture.ShadowDecoration.Parent = this.pbUserPicture;
            this.pbUserPicture.Size = new System.Drawing.Size(84, 80);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPicture.TabIndex = 0;
            this.pbUserPicture.TabStop = false;
            this.pbUserPicture.Click += new System.EventHandler(this.pbUserPicture_Click);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(246, 83);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1342, 687);
            this.pMain.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowUserDetails,
            this.tsmChangePassword,
            this.toolStripSeparator2,
            this.tsmSignOut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(266, 124);
            // 
            // tsmShowUserDetails
            // 
            this.tsmShowUserDetails.ForeColor = System.Drawing.Color.Black;
            this.tsmShowUserDetails.Image = global::CMS.Properties.Resources.name1_Icon;
            this.tsmShowUserDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowUserDetails.Name = "tsmShowUserDetails";
            this.tsmShowUserDetails.Size = new System.Drawing.Size(265, 38);
            this.tsmShowUserDetails.Text = "User Profile";
            this.tsmShowUserDetails.Click += new System.EventHandler(this.tsmShowUserDetails_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.ForeColor = System.Drawing.Color.Black;
            this.tsmChangePassword.Image = global::CMS.Properties.Resources.password;
            this.tsmChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(265, 38);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.ForeColor = System.Drawing.Color.Black;
            this.tsmSignOut.Image = global::CMS.Properties.Resources.deactivate;
            this.tsmSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(265, 38);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1588, 770);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "&";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashbord;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Button btnAppointements;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private System.Windows.Forms.Panel pHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserPicture;
        private System.Windows.Forms.Panel pMain;
        private Guna.UI2.WinForms.Guna2Button btnMedicalRecords;
        private System.Windows.Forms.FlowLayoutPanel flpPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowUserDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
    }
}

