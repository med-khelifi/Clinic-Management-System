namespace CMS.Patients
{
    partial class ucManagePayments
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.cmsPayments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsIShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.cmsPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordCount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(13, 661);
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
            this.label1.Location = new System.Drawing.Point(389, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Payments";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ContextMenuStrip = this.cmsPayments;
            this.dgvPayments.Location = new System.Drawing.Point(17, 255);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(1240, 403);
            this.dgvPayments.TabIndex = 15;
            // 
            // cmsPayments
            // 
            this.cmsPayments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsIShowDetails,
            this.cmsIUpdate});
            this.cmsPayments.Name = "cmsUsers";
            this.cmsPayments.Size = new System.Drawing.Size(209, 56);
            // 
            // cmsIShowDetails
            // 
            this.cmsIShowDetails.Image = global::CMS.Properties.Resources.PersonInfo;
            this.cmsIShowDetails.Name = "cmsIShowDetails";
            this.cmsIShowDetails.Size = new System.Drawing.Size(208, 26);
            this.cmsIShowDetails.Text = "Show Details";
            this.cmsIShowDetails.Click += new System.EventHandler(this.cmsIShowDetails_Click);
            // 
            // cmsIUpdate
            // 
            this.cmsIUpdate.Image = global::CMS.Properties.Resources.date_Icon;
            this.cmsIUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmsIUpdate.Name = "cmsIUpdate";
            this.cmsIUpdate.Size = new System.Drawing.Size(208, 26);
            this.cmsIUpdate.Text = "Transaction History";
            this.cmsIUpdate.Click += new System.EventHandler(this.cmsIUpdate_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CMS.Properties.Resources.Payments;
            this.guna2PictureBox1.Location = new System.Drawing.Point(431, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(167, 152);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ucManagePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "ucManagePayments";
            this.Size = new System.Drawing.Size(1274, 708);
            this.Load += new System.EventHandler(this.ucManagePayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.cmsPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.ContextMenuStrip cmsPayments;
        private System.Windows.Forms.ToolStripMenuItem cmsIShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsIUpdate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
