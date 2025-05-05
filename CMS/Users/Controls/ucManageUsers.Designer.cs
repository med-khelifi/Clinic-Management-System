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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIDeactivate = new System.Windows.Forms.ToolStripMenuItem();
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(322, 312);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(180, 36);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(135, 312);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(180, 36);
            this.guna2ComboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filter By : ";
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
            this.cmsIDeactivate,
            this.cmsIChangePassword});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.Size = new System.Drawing.Size(211, 128);
            // 
            // cmsIShowDetails
            // 
            this.cmsIShowDetails.Name = "cmsIShowDetails";
            this.cmsIShowDetails.Size = new System.Drawing.Size(210, 24);
            this.cmsIShowDetails.Text = "Show Details";
            this.cmsIShowDetails.Click += new System.EventHandler(this.cmsIShowDetails_Click);
            // 
            // cmsIUpdate
            // 
            this.cmsIUpdate.Name = "cmsIUpdate";
            this.cmsIUpdate.Size = new System.Drawing.Size(210, 24);
            this.cmsIUpdate.Text = "Edit";
            this.cmsIUpdate.Click += new System.EventHandler(this.cmsIUpdate_Click);
            // 
            // cmsIDeactivate
            // 
            this.cmsIDeactivate.Name = "cmsIDeactivate";
            this.cmsIDeactivate.Size = new System.Drawing.Size(210, 24);
            this.cmsIDeactivate.Text = "Deactivate";
            // 
            // cmsIChangePassword
            // 
            this.cmsIChangePassword.Name = "cmsIChangePassword";
            this.cmsIChangePassword.Size = new System.Drawing.Size(210, 24);
            this.cmsIChangePassword.Text = "Change Password";
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
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label2);
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem cmsIShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsIUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsIDeactivate;
        private System.Windows.Forms.ToolStripMenuItem cmsIChangePassword;
    }
}
