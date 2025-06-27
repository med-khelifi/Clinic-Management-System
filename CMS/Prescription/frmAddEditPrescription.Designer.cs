namespace CMS.Prescription
{
    partial class frmAddEditPrescription
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
            this.gbPesonalInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtAdditionalNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFrequency = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDosage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMedicationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDosage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicationName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPesonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPesonalInfo
            // 
            this.gbPesonalInfo.Controls.Add(this.dtpStartDate);
            this.gbPesonalInfo.Controls.Add(this.dtpEndDate);
            this.gbPesonalInfo.Controls.Add(this.txtAdditionalNotes);
            this.gbPesonalInfo.Controls.Add(this.txtFrequency);
            this.gbPesonalInfo.Controls.Add(this.txtDosage);
            this.gbPesonalInfo.Controls.Add(this.txtMedicationName);
            this.gbPesonalInfo.Controls.Add(this.pictureBox9);
            this.gbPesonalInfo.Controls.Add(this.pictureBox8);
            this.gbPesonalInfo.Controls.Add(this.pictureBox6);
            this.gbPesonalInfo.Controls.Add(this.pictureBox4);
            this.gbPesonalInfo.Controls.Add(this.pictureBox3);
            this.gbPesonalInfo.Controls.Add(this.pictureBox2);
            this.gbPesonalInfo.Controls.Add(this.label5);
            this.gbPesonalInfo.Controls.Add(this.label4);
            this.gbPesonalInfo.Controls.Add(this.lblDosage);
            this.gbPesonalInfo.Controls.Add(this.label6);
            this.gbPesonalInfo.Controls.Add(this.lblMedicalRecordID);
            this.gbPesonalInfo.Controls.Add(this.lblPrescriptionID);
            this.gbPesonalInfo.Controls.Add(this.label1);
            this.gbPesonalInfo.Controls.Add(this.lblMedicationName);
            this.gbPesonalInfo.Controls.Add(this.label7);
            this.gbPesonalInfo.Controls.Add(this.lblFrequency);
            this.gbPesonalInfo.CustomBorderColor = System.Drawing.Color.Black;
            this.gbPesonalInfo.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.gbPesonalInfo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesonalInfo.ForeColor = System.Drawing.Color.Black;
            this.gbPesonalInfo.Location = new System.Drawing.Point(12, 58);
            this.gbPesonalInfo.Name = "gbPesonalInfo";
            this.gbPesonalInfo.ShadowDecoration.Parent = this.gbPesonalInfo;
            this.gbPesonalInfo.Size = new System.Drawing.Size(745, 347);
            this.gbPesonalInfo.TabIndex = 91;
            this.gbPesonalInfo.Text = "Prescription Details :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpStartDate.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(212, 194);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(193, 28);
            this.dtpStartDate.TabIndex = 105;
            this.dtpStartDate.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpEndDate.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(530, 190);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(193, 28);
            this.dtpEndDate.TabIndex = 105;
            this.dtpEndDate.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalNotes.DefaultText = "";
            this.txtAdditionalNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalNotes.DisabledState.Parent = this.txtAdditionalNotes;
            this.txtAdditionalNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalNotes.FocusedState.Parent = this.txtAdditionalNotes;
            this.txtAdditionalNotes.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.txtAdditionalNotes.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalNotes.HoverState.Parent = this.txtAdditionalNotes;
            this.txtAdditionalNotes.Location = new System.Drawing.Point(207, 239);
            this.txtAdditionalNotes.Margin = new System.Windows.Forms.Padding(647, 1229, 647, 1229);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.PasswordChar = '\0';
            this.txtAdditionalNotes.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAdditionalNotes.PlaceholderText = "";
            this.txtAdditionalNotes.SelectedText = "";
            this.txtAdditionalNotes.ShadowDecoration.Parent = this.txtAdditionalNotes;
            this.txtAdditionalNotes.Size = new System.Drawing.Size(516, 89);
            this.txtAdditionalNotes.TabIndex = 100;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrequency.DefaultText = "";
            this.txtFrequency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrequency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrequency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrequency.DisabledState.Parent = this.txtFrequency;
            this.txtFrequency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrequency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrequency.FocusedState.Parent = this.txtFrequency;
            this.txtFrequency.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.txtFrequency.ForeColor = System.Drawing.Color.Black;
            this.txtFrequency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrequency.HoverState.Parent = this.txtFrequency;
            this.txtFrequency.Location = new System.Drawing.Point(550, 145);
            this.txtFrequency.Margin = new System.Windows.Forms.Padding(52, 68, 52, 68);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.PasswordChar = '\0';
            this.txtFrequency.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtFrequency.PlaceholderText = "";
            this.txtFrequency.SelectedText = "";
            this.txtFrequency.ShadowDecoration.Parent = this.txtFrequency;
            this.txtFrequency.Size = new System.Drawing.Size(173, 33);
            this.txtFrequency.TabIndex = 101;
            this.txtFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.txtMedicationName_Validating);
            // 
            // txtDosage
            // 
            this.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosage.DefaultText = "";
            this.txtDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosage.DisabledState.Parent = this.txtDosage;
            this.txtDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosage.FocusedState.Parent = this.txtDosage;
            this.txtDosage.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.txtDosage.ForeColor = System.Drawing.Color.Black;
            this.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDosage.HoverState.Parent = this.txtDosage;
            this.txtDosage.Location = new System.Drawing.Point(212, 146);
            this.txtDosage.Margin = new System.Windows.Forms.Padding(52, 68, 52, 68);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.PasswordChar = '\0';
            this.txtDosage.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDosage.PlaceholderText = "";
            this.txtDosage.SelectedText = "";
            this.txtDosage.ShadowDecoration.Parent = this.txtDosage;
            this.txtDosage.Size = new System.Drawing.Size(173, 33);
            this.txtDosage.TabIndex = 101;
            this.txtDosage.Validating += new System.ComponentModel.CancelEventHandler(this.txtMedicationName_Validating);
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicationName.DefaultText = "";
            this.txtMedicationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicationName.DisabledState.Parent = this.txtMedicationName;
            this.txtMedicationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicationName.FocusedState.Parent = this.txtMedicationName;
            this.txtMedicationName.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.txtMedicationName.ForeColor = System.Drawing.Color.Black;
            this.txtMedicationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicationName.HoverState.Parent = this.txtMedicationName;
            this.txtMedicationName.Location = new System.Drawing.Point(212, 99);
            this.txtMedicationName.Margin = new System.Windows.Forms.Padding(8);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.PasswordChar = '\0';
            this.txtMedicationName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMedicationName.PlaceholderText = "";
            this.txtMedicationName.SelectedText = "";
            this.txtMedicationName.ShadowDecoration.Parent = this.txtMedicationName;
            this.txtMedicationName.Size = new System.Drawing.Size(511, 33);
            this.txtMedicationName.TabIndex = 102;
            this.txtMedicationName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMedicationName_Validating);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox9.Location = new System.Drawing.Point(508, 147);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 96;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CMS.Properties.Resources.date_Icon;
            this.pictureBox8.Location = new System.Drawing.Point(481, 190);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 95;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CMS.Properties.Resources.address_Icon;
            this.pictureBox6.Location = new System.Drawing.Point(169, 239);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 94;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox4.Location = new System.Drawing.Point(169, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox3.Location = new System.Drawing.Point(169, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CMS.Properties.Resources.date_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(169, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 83;
            this.label5.Text = "Special Instructions :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(79, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 86;
            this.label4.Text = "Start Date :";
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblDosage.ForeColor = System.Drawing.Color.Black;
            this.lblDosage.Location = new System.Drawing.Point(100, 147);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(65, 21);
            this.lblDosage.TabIndex = 84;
            this.lblDosage.Text = "Dosage :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(361, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 85;
            this.label6.Text = "Medical Record ID :";
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalRecordID.ForeColor = System.Drawing.Color.Red;
            this.lblMedicalRecordID.Location = new System.Drawing.Point(517, 53);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(39, 21);
            this.lblMedicalRecordID.TabIndex = 85;
            this.lblMedicalRecordID.Text = "N/A";
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionID.ForeColor = System.Drawing.Color.Red;
            this.lblPrescriptionID.Location = new System.Drawing.Point(169, 53);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(39, 21);
            this.lblPrescriptionID.TabIndex = 85;
            this.lblPrescriptionID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "Prescription ID :";
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblMedicationName.ForeColor = System.Drawing.Color.Black;
            this.lblMedicationName.Location = new System.Drawing.Point(32, 100);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(131, 21);
            this.lblMedicationName.TabIndex = 85;
            this.lblMedicationName.Text = "Medication Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(406, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 87;
            this.label7.Text = "End Date :";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblFrequency.ForeColor = System.Drawing.Color.Black;
            this.lblFrequency.Location = new System.Drawing.Point(417, 147);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(85, 21);
            this.lblFrequency.TabIndex = 81;
            this.lblFrequency.Text = "Frequency :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(243, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 36);
            this.lblTitle.TabIndex = 92;
            this.lblTitle.Text = "Add/Edit Prescription";
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
            this.btnSave.Location = new System.Drawing.Point(646, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 93;
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
            this.BtnClose.Location = new System.Drawing.Point(533, 411);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(107, 40);
            this.BtnClose.TabIndex = 94;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 466);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbPesonalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Prescription";
            this.Load += new System.EventHandler(this.frmAddEditPrescription_Load);
            this.gbPesonalInfo.ResumeLayout(false);
            this.gbPesonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbPesonalInfo;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtDosage;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicationName;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.Label lblMedicationName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txtFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}