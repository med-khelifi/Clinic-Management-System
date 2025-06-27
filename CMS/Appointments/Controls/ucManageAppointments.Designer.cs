namespace CMS.Appointments.Controls
{
    partial class ucManageAppointments
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.csmAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReschedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.doctorInformarionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.medicalRecordInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewAppointment = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.csmAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordCount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(10, 660);
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
            this.label1.Location = new System.Drawing.Point(392, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Appointments\r\n";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.csmAppointments;
            this.dgvAppointments.Location = new System.Drawing.Point(5, 117);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(1253, 540);
            this.dgvAppointments.TabIndex = 15;
            // 
            // csmAppointments
            // 
            this.csmAppointments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuShowDetails,
            this.toolStripSeparator1,
            this.consultationToolStripMenuItem,
            this.ToolStripMenuConfirm,
            this.toolStripMenuReschedule,
            this.toolStripMenuCancel,
            this.toolStripMenuItem5,
            this.doctorInformarionToolStripMenuItem,
            this.patientInformationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.medicalRecordInformationToolStripMenuItem});
            this.csmAppointments.Name = "cmsUsers";
            this.csmAppointments.Size = new System.Drawing.Size(269, 230);
            this.csmAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.csmAppointments_Opening);
            // 
            // toolStripMenuShowDetails
            // 
            this.toolStripMenuShowDetails.Image = global::CMS.Properties.Resources.info;
            this.toolStripMenuShowDetails.Name = "toolStripMenuShowDetails";
            this.toolStripMenuShowDetails.Size = new System.Drawing.Size(268, 26);
            this.toolStripMenuShowDetails.Text = "Show Details";
            this.toolStripMenuShowDetails.Click += new System.EventHandler(this.toolStripMenuShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Enabled = false;
            this.consultationToolStripMenuItem.Image = global::CMS.Properties.Resources.consultation;
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // ToolStripMenuConfirm
            // 
            this.ToolStripMenuConfirm.Image = global::CMS.Properties.Resources.isActive;
            this.ToolStripMenuConfirm.Name = "ToolStripMenuConfirm";
            this.ToolStripMenuConfirm.Size = new System.Drawing.Size(268, 26);
            this.ToolStripMenuConfirm.Text = "Confirm";
            this.ToolStripMenuConfirm.Click += new System.EventHandler(this.ToolStripMenuConfirm_Click);
            // 
            // toolStripMenuReschedule
            // 
            this.toolStripMenuReschedule.Image = global::CMS.Properties.Resources.tasks;
            this.toolStripMenuReschedule.Name = "toolStripMenuReschedule";
            this.toolStripMenuReschedule.Size = new System.Drawing.Size(268, 26);
            this.toolStripMenuReschedule.Text = "Reschedule";
            this.toolStripMenuReschedule.Click += new System.EventHandler(this.toolStripMenuReschedule_Click);
            // 
            // toolStripMenuCancel
            // 
            this.toolStripMenuCancel.Image = global::CMS.Properties.Resources.deactivate;
            this.toolStripMenuCancel.Name = "toolStripMenuCancel";
            this.toolStripMenuCancel.Size = new System.Drawing.Size(268, 26);
            this.toolStripMenuCancel.Text = "Cancel";
            this.toolStripMenuCancel.Click += new System.EventHandler(this.toolStripMenuCancel_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(265, 6);
            // 
            // doctorInformarionToolStripMenuItem
            // 
            this.doctorInformarionToolStripMenuItem.Image = global::CMS.Properties.Resources.medical_assistance;
            this.doctorInformarionToolStripMenuItem.Name = "doctorInformarionToolStripMenuItem";
            this.doctorInformarionToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.doctorInformarionToolStripMenuItem.Text = "Doctor Informarion";
            this.doctorInformarionToolStripMenuItem.Click += new System.EventHandler(this.doctorInformarionToolStripMenuItem_Click);
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Image = global::CMS.Properties.Resources.name1_Icon;
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.patientInformationToolStripMenuItem.Text = "Patient Information";
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // medicalRecordInformationToolStripMenuItem
            // 
            this.medicalRecordInformationToolStripMenuItem.Enabled = false;
            this.medicalRecordInformationToolStripMenuItem.Name = "medicalRecordInformationToolStripMenuItem";
            this.medicalRecordInformationToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.medicalRecordInformationToolStripMenuItem.Text = "Medical Record Information";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.BorderRadius = 6;
            this.btnAddNewAppointment.BorderThickness = 2;
            this.btnAddNewAppointment.CheckedState.Parent = this.btnAddNewAppointment;
            this.btnAddNewAppointment.CustomImages.Parent = this.btnAddNewAppointment;
            this.btnAddNewAppointment.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.HoverState.Parent = this.btnAddNewAppointment;
            this.btnAddNewAppointment.Image = global::CMS.Properties.Resources.add_user;
            this.btnAddNewAppointment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewAppointment.Location = new System.Drawing.Point(1208, 51);
            this.btnAddNewAppointment.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddNewAppointment.PressedColor = System.Drawing.Color.Silver;
            this.btnAddNewAppointment.ShadowDecoration.Parent = this.btnAddNewAppointment;
            this.btnAddNewAppointment.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewAppointment.TabIndex = 21;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // ucManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRecordCount);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointments);
            this.Name = "ucManageAppointments";
            this.Size = new System.Drawing.Size(1274, 708);
            this.Load += new System.EventHandler(this.ucManageAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.csmAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordCount;
        private Guna.UI2.WinForms.Guna2Button btnAddNewAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip csmAppointments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReschedule;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem doctorInformarionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuConfirm;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicalRecordInformationToolStripMenuItem;
    }
}
