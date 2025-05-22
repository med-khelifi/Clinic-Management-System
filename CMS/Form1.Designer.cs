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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnMessages = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointements = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashbord = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnMessages);
            this.panel1.Controls.Add(this.btnAppointements);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 808);
            this.panel1.TabIndex = 0;
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
            this.btnDoctors.Location = new System.Drawing.Point(15, 305);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.ShadowDecoration.Parent = this.btnDoctors;
            this.btnDoctors.Size = new System.Drawing.Size(251, 52);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseTransparentBackground = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
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
            this.btnUsers.Location = new System.Drawing.Point(15, 243);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(251, 52);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseTransparentBackground = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 22;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogin.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLogin.CheckedState.Image = global::CMS.Properties.Resources.MessagesBlue;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Image = global::CMS.Properties.Resources.MessagesWthite;
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogin.Location = new System.Drawing.Point(12, 744);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(251, 52);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log out";
            this.btnLogin.UseTransparentBackground = true;
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnMessages.BorderRadius = 22;
            this.btnMessages.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMessages.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMessages.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnMessages.CheckedState.Image = global::CMS.Properties.Resources.MessagesBlue;
            this.btnMessages.CheckedState.Parent = this.btnMessages;
            this.btnMessages.CustomImages.Parent = this.btnMessages;
            this.btnMessages.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnMessages.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.Color.White;
            this.btnMessages.HoverState.Parent = this.btnMessages;
            this.btnMessages.Image = global::CMS.Properties.Resources.MessagesWthite;
            this.btnMessages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMessages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMessages.Location = new System.Drawing.Point(15, 491);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.ShadowDecoration.Parent = this.btnMessages;
            this.btnMessages.Size = new System.Drawing.Size(251, 52);
            this.btnMessages.TabIndex = 2;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseTransparentBackground = true;
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
            this.btnAppointements.Location = new System.Drawing.Point(15, 429);
            this.btnAppointements.Name = "btnAppointements";
            this.btnAppointements.ShadowDecoration.Parent = this.btnAppointements;
            this.btnAppointements.Size = new System.Drawing.Size(251, 52);
            this.btnAppointements.TabIndex = 2;
            this.btnAppointements.Text = "Appointments";
            this.btnAppointements.UseTransparentBackground = true;
            this.btnAppointements.Click += new System.EventHandler(this.btnAppointements_Click);
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
            this.btnPatients.Location = new System.Drawing.Point(15, 367);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.ShadowDecoration.Parent = this.btnPatients;
            this.btnPatients.Size = new System.Drawing.Size(251, 52);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseTransparentBackground = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
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
            this.btnDashbord.Location = new System.Drawing.Point(12, 185);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.ShadowDecoration.Parent = this.btnDashbord;
            this.btnDashbord.Size = new System.Drawing.Size(251, 52);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Dashboard";
            this.btnDashbord.UseTransparentBackground = true;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 56);
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
            this.label1.Location = new System.Drawing.Point(155, 26);
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
            this.pHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(274, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1274, 100);
            this.pHeader.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CMS.Properties.Resources.doctorWhite;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1198, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(274, 100);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1274, 708);
            this.pMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1548, 808);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnMessages;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Panel pHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel pMain;
    }
}

