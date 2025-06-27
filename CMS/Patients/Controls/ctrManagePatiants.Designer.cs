namespace CMS.Patients.Controls
{
    partial class ctrManagePatiants
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordCount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(22, 663);
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(180, 36);
            this.lbRecordCount.TabIndex = 14;
            this.lbRecordCount.Text = "#Count = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(403, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Patients";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToResizeColumns = false;
            this.dgvPatients.AllowUserToResizeRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.cmsUsers;
            this.dgvPatients.Location = new System.Drawing.Point(17, 364);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1240, 296);
            this.dgvPatients.TabIndex = 7;
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsIShowDetails,
            this.cmsIUpdate});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.Size = new System.Drawing.Size(169, 56);
            // 
            // cmsIShowDetails
            // 
            this.cmsIShowDetails.Image = global::CMS.Properties.Resources.PersonInfo;
            this.cmsIShowDetails.Name = "cmsIShowDetails";
            this.cmsIShowDetails.Size = new System.Drawing.Size(168, 26);
            this.cmsIShowDetails.Text = "Show Details";
            this.cmsIShowDetails.Click += new System.EventHandler(this.cmsIShowDetails_Click);
            // 
            // cmsIUpdate
            // 
            this.cmsIUpdate.Image = global::CMS.Properties.Resources.EditPerson;
            this.cmsIUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmsIUpdate.Name = "cmsIUpdate";
            this.cmsIUpdate.Size = new System.Drawing.Size(168, 26);
            this.cmsIUpdate.Text = "Edit";
            this.cmsIUpdate.Click += new System.EventHandler(this.cmsIUpdate_Click);
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
            this.btnAddNewUser.Location = new System.Drawing.Point(1207, 312);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.PressedColor = System.Drawing.Color.Silver;
            this.btnAddNewUser.ShadowDecoration.Parent = this.btnAddNewUser;
            this.btnAddNewUser.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewUser.TabIndex = 13;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CMS.Properties.Resources.patient;
            this.guna2PictureBox1.Location = new System.Drawing.Point(410, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(209, 182);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ctrManagePatiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRecordCount);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvPatients);
            this.Name = "ctrManagePatiants";
            this.Size = new System.Drawing.Size(1274, 708);
            this.Load += new System.EventHandler(this.ctrManagePatiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem cmsIShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsIUpdate;
    }
}
