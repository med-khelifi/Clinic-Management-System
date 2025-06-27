namespace CMS.MediicalRecords.Controls
{
    partial class ucManageMedicalRecords
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csmAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.doctorInformarionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.lbRecordCount = new System.Windows.Forms.Label();
            this.csmAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // PrescriptionToolStripMenuItem
            // 
            this.PrescriptionToolStripMenuItem.Enabled = false;
            this.PrescriptionToolStripMenuItem.Image = global::CMS.Properties.Resources.tasks;
            this.PrescriptionToolStripMenuItem.Name = "PrescriptionToolStripMenuItem";
            this.PrescriptionToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.PrescriptionToolStripMenuItem.Text = "Prescription Details";
            this.PrescriptionToolStripMenuItem.Click += new System.EventHandler(this.PrescriptionToolStripMenuItem_Click);
            // 
            // csmAppointments
            // 
            this.csmAppointments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuShowDetails,
            this.toolStripSeparator1,
            this.doctorInformarionToolStripMenuItem,
            this.patientInformationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.PrescriptionToolStripMenuItem});
            this.csmAppointments.Name = "cmsUsers";
            this.csmAppointments.Size = new System.Drawing.Size(211, 120);
            this.csmAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.csmAppointments_Opening);
            // 
            // toolStripMenuShowDetails
            // 
            this.toolStripMenuShowDetails.Image = global::CMS.Properties.Resources.info;
            this.toolStripMenuShowDetails.Name = "toolStripMenuShowDetails";
            this.toolStripMenuShowDetails.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuShowDetails.Text = "Show Details";
            this.toolStripMenuShowDetails.Click += new System.EventHandler(this.toolStripMenuShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // doctorInformarionToolStripMenuItem
            // 
            this.doctorInformarionToolStripMenuItem.Image = global::CMS.Properties.Resources.medical_assistance;
            this.doctorInformarionToolStripMenuItem.Name = "doctorInformarionToolStripMenuItem";
            this.doctorInformarionToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.doctorInformarionToolStripMenuItem.Text = "Doctor Informarion";
            this.doctorInformarionToolStripMenuItem.Click += new System.EventHandler(this.doctorInformarionToolStripMenuItem_Click);
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Image = global::CMS.Properties.Resources.name1_Icon;
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.patientInformationToolStripMenuItem.Text = "Patient Information";
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(473, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Manage Medical Records";
            // 
            // dgvMedicalRecords
            // 
            this.dgvMedicalRecords.AllowUserToAddRows = false;
            this.dgvMedicalRecords.AllowUserToDeleteRows = false;
            this.dgvMedicalRecords.AllowUserToResizeColumns = false;
            this.dgvMedicalRecords.AllowUserToResizeRows = false;
            this.dgvMedicalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalRecords.ContextMenuStrip = this.csmAppointments;
            this.dgvMedicalRecords.Location = new System.Drawing.Point(11, 117);
            this.dgvMedicalRecords.MultiSelect = false;
            this.dgvMedicalRecords.Name = "dgvMedicalRecords";
            this.dgvMedicalRecords.ReadOnly = true;
            this.dgvMedicalRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicalRecords.RowHeadersWidth = 51;
            this.dgvMedicalRecords.RowTemplate.Height = 24;
            this.dgvMedicalRecords.Size = new System.Drawing.Size(1253, 540);
            this.dgvMedicalRecords.TabIndex = 23;
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordCount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(16, 660);
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(180, 36);
            this.lbRecordCount.TabIndex = 29;
            this.lbRecordCount.Text = "#Count = ";
            // 
            // ucManageMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicalRecords);
            this.Controls.Add(this.lbRecordCount);
            this.Name = "ucManageMedicalRecords";
            this.Size = new System.Drawing.Size(1274, 708);
            this.Load += new System.EventHandler(this.ucManageMedicalRecords_Load);
            this.csmAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorInformarionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuShowDetails;
        private System.Windows.Forms.ContextMenuStrip csmAppointments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.Label lbRecordCount;
    }
}
