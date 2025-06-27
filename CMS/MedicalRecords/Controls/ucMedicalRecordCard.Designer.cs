namespace CMS.MediicalRecords.Controls
{
    partial class ucMedicalRecordCard
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
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.llShowPrescriptionInfo = new System.Windows.Forms.LinkLabel();
            this.llAddPrescription = new System.Windows.Forms.LinkLabel();
            this.llEdit = new System.Windows.Forms.LinkLabel();
            this.llAppointmentInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblVisitDiscription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.BorderColor = System.Drawing.Color.Black;
            this.gbFilter.BorderThickness = 3;
            this.gbFilter.Controls.Add(this.llShowPrescriptionInfo);
            this.gbFilter.Controls.Add(this.llAddPrescription);
            this.gbFilter.Controls.Add(this.llEdit);
            this.gbFilter.Controls.Add(this.llAppointmentInfo);
            this.gbFilter.Controls.Add(this.pictureBox3);
            this.gbFilter.Controls.Add(this.pictureBox2);
            this.gbFilter.Controls.Add(this.pictureBox1);
            this.gbFilter.Controls.Add(this.pictureBox4);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.lblMedicalRecordID);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.label4);
            this.gbFilter.Controls.Add(this.lblAdditionalNotes);
            this.gbFilter.Controls.Add(this.lblDiagnosis);
            this.gbFilter.Controls.Add(this.lblVisitDiscription);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.Black;
            this.gbFilter.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.ShadowDecoration.Parent = this.gbFilter;
            this.gbFilter.Size = new System.Drawing.Size(917, 351);
            this.gbFilter.TabIndex = 19;
            this.gbFilter.Text = "Medical Record Info :";
            // 
            // llShowPrescriptionInfo
            // 
            this.llShowPrescriptionInfo.AutoSize = true;
            this.llShowPrescriptionInfo.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowPrescriptionInfo.Location = new System.Drawing.Point(463, 305);
            this.llShowPrescriptionInfo.Name = "llShowPrescriptionInfo";
            this.llShowPrescriptionInfo.Size = new System.Drawing.Size(181, 21);
            this.llShowPrescriptionInfo.TabIndex = 97;
            this.llShowPrescriptionInfo.TabStop = true;
            this.llShowPrescriptionInfo.Text = "Show Prescription Info";
            this.llShowPrescriptionInfo.Visible = false;
            this.llShowPrescriptionInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowPrescriptionInfo_LinkClicked);
            // 
            // llAddPrescription
            // 
            this.llAddPrescription.AutoSize = true;
            this.llAddPrescription.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddPrescription.Location = new System.Drawing.Point(288, 305);
            this.llAddPrescription.Name = "llAddPrescription";
            this.llAddPrescription.Size = new System.Drawing.Size(136, 21);
            this.llAddPrescription.TabIndex = 98;
            this.llAddPrescription.TabStop = true;
            this.llAddPrescription.Text = "Add Prescription";
            this.llAddPrescription.Visible = false;
            this.llAddPrescription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddPrescription_LinkClicked);
            // 
            // llEdit
            // 
            this.llEdit.AutoSize = true;
            this.llEdit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEdit.Location = new System.Drawing.Point(737, 278);
            this.llEdit.Name = "llEdit";
            this.llEdit.Size = new System.Drawing.Size(45, 24);
            this.llEdit.TabIndex = 103;
            this.llEdit.TabStop = true;
            this.llEdit.Text = "Edit";
            this.llEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEdit_LinkClicked);
            // 
            // llAppointmentInfo
            // 
            this.llAppointmentInfo.AutoSize = true;
            this.llAppointmentInfo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAppointmentInfo.Location = new System.Drawing.Point(674, 302);
            this.llAppointmentInfo.Name = "llAppointmentInfo";
            this.llAppointmentInfo.Size = new System.Drawing.Size(164, 24);
            this.llAppointmentInfo.TabIndex = 103;
            this.llAppointmentInfo.TabStop = true;
            this.llAppointmentInfo.Text = "Appointment Info";
            this.llAppointmentInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CMS.Properties.Resources.EditPerson;
            this.pictureBox3.Location = new System.Drawing.Point(759, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CMS.Properties.Resources.EditPerson;
            this.pictureBox2.Location = new System.Drawing.Point(167, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMS.Properties.Resources.EditPerson;
            this.pictureBox1.Location = new System.Drawing.Point(167, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox4.Location = new System.Drawing.Point(167, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 102;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(628, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 94;
            this.label3.Text = "Additional Notes :";
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblMedicalRecordID.ForeColor = System.Drawing.Color.Red;
            this.lblMedicalRecordID.Location = new System.Drawing.Point(231, 68);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(35, 21);
            this.lblMedicalRecordID.TabIndex = 95;
            this.lblMedicalRecordID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Medical Record ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(81, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 97;
            this.label4.Text = "Diagnosis :";
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalNotes.ForeColor = System.Drawing.Color.Black;
            this.lblAdditionalNotes.Location = new System.Drawing.Point(628, 134);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(16, 22);
            this.lblAdditionalNotes.TabIndex = 98;
            this.lblAdditionalNotes.Text = "-";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.ForeColor = System.Drawing.Color.Black;
            this.lblDiagnosis.Location = new System.Drawing.Point(231, 238);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(16, 22);
            this.lblDiagnosis.TabIndex = 98;
            this.lblDiagnosis.Text = "-";
            // 
            // lblVisitDiscription
            // 
            this.lblVisitDiscription.AutoSize = true;
            this.lblVisitDiscription.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitDiscription.ForeColor = System.Drawing.Color.Black;
            this.lblVisitDiscription.Location = new System.Drawing.Point(231, 107);
            this.lblVisitDiscription.Name = "lblVisitDiscription";
            this.lblVisitDiscription.Size = new System.Drawing.Size(16, 22);
            this.lblVisitDiscription.TabIndex = 98;
            this.lblVisitDiscription.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "Visit Description  :";
            // 
            // ucMedicalRecordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Name = "ucMedicalRecordCard";
            this.Size = new System.Drawing.Size(917, 351);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblVisitDiscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llAppointmentInfo;
        private System.Windows.Forms.LinkLabel llEdit;
        private System.Windows.Forms.LinkLabel llShowPrescriptionInfo;
        private System.Windows.Forms.LinkLabel llAddPrescription;
    }
}
