namespace CMS.Users.Controls
{
    partial class ucManageUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIActivate_Deactivate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordCount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(27, 664);
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(180, 36);
            this.lbRecordCount.TabIndex = 22;
            this.lbRecordCount.Text = "#Count = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Users";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToResizeColumns = false;
            this.dgvUsersList.AllowUserToResizeRows = false;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.ContextMenuStrip = this.cmsUsers;
            this.dgvUsersList.Location = new System.Drawing.Point(22, 365);
            this.dgvUsersList.MultiSelect = false;
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsersList.RowHeadersWidth = 51;
            this.dgvUsersList.RowTemplate.Height = 24;
            this.dgvUsersList.Size = new System.Drawing.Size(1240, 296);
            this.dgvUsersList.TabIndex = 15;
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsIShowDetails,
            this.cmsIUpdate,
            this.cmsIActivate_Deactivate,
            this.cmsIChangePassword});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.Size = new System.Drawing.Size(198, 108);
            this.cmsUsers.Opening += new System.ComponentModel.CancelEventHandler(this.cmsUsers_Opening);
            // 
            // cmsIShowDetails
            // 
            this.cmsIShowDetails.Image = global::CMS.Properties.Resources.PersonInfo;
            this.cmsIShowDetails.Name = "cmsIShowDetails";
            this.cmsIShowDetails.Size = new System.Drawing.Size(197, 26);
            this.cmsIShowDetails.Text = "Show Details";
            this.cmsIShowDetails.Click += new System.EventHandler(this.cmsIShowDetails_Click);
            // 
            // cmsIUpdate
            // 
            this.cmsIUpdate.Image = global::CMS.Properties.Resources.EditPerson;
            this.cmsIUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmsIUpdate.Name = "cmsIUpdate";
            this.cmsIUpdate.Size = new System.Drawing.Size(197, 26);
            this.cmsIUpdate.Text = "Edit";
            this.cmsIUpdate.Click += new System.EventHandler(this.cmsIUpdate_Click);
            // 
            // cmsIActivate_Deactivate
            // 
            this.cmsIActivate_Deactivate.Image = global::CMS.Properties.Resources.deactivate;
            this.cmsIActivate_Deactivate.Name = "cmsIActivate_Deactivate";
            this.cmsIActivate_Deactivate.Size = new System.Drawing.Size(197, 26);
            this.cmsIActivate_Deactivate.Text = "Deactivate";
            this.cmsIActivate_Deactivate.Click += new System.EventHandler(this.cmsIActivate_Deactivate_Click);
            // 
            // cmsIChangePassword
            // 
            this.cmsIChangePassword.Image = global::CMS.Properties.Resources.Change_password;
            this.cmsIChangePassword.Name = "cmsIChangePassword";
            this.cmsIChangePassword.Size = new System.Drawing.Size(197, 26);
            this.cmsIChangePassword.Text = "Change Password";
            this.cmsIChangePassword.Click += new System.EventHandler(this.cmsIChangePassword_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 6;
            this.btnAddNewUser.BorderThickness = 2;
            this.btnAddNewUser.CheckedState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.CustomImages.Parent = this.btnAddNewUser;
            this.btnAddNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverState.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Image = global::CMS.Properties.Resources.add_user;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewUser.Location = new System.Drawing.Point(1212, 313);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.PressedColor = System.Drawing.Color.Silver;
            this.btnAddNewUser.ShadowDecoration.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewUser.TabIndex = 21;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CMS.Properties.Resources.UsersImage;
            this.guna2PictureBox1.Location = new System.Drawing.Point(415, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(209, 182);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ucManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRecordCount);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "ucManageUsers";
            this.Size = new System.Drawing.Size(1274, 708);
            this.Load += new System.EventHandler(this.ucManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordCount;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem cmsIShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsIUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsIActivate_Deactivate;
        private System.Windows.Forms.ToolStripMenuItem cmsIChangePassword;
    }
}
