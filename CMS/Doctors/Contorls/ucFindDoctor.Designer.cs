namespace CMS.Doctors.Contorls
{
    partial class ucFindDoctor
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
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.btnSearchPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucShortDoctorCard1 = new CMS.Doctors.Contorls.ucShortDoctorCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.txtSearchBox);
            this.gbFilter.Controls.Add(this.cbFindBy);
            this.gbFilter.Controls.Add(this.btnSearchPerson);
            this.gbFilter.Controls.Add(this.btnAddNewPerson);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.Black;
            this.gbFilter.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.gbFilter.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.ShadowDecoration.Parent = this.gbFilter;
            this.gbFilter.Size = new System.Drawing.Size(820, 107);
            this.gbFilter.TabIndex = 19;
            this.gbFilter.Text = "Search Doctor";
            this.gbFilter.Click += new System.EventHandler(this.gbFilter_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.Parent = this.txtSearchBox;
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.FocusedState.Parent = this.txtSearchBox;
            this.txtSearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.HoverState.Parent = this.txtSearchBox;
            this.txtSearchBox.Location = new System.Drawing.Point(264, 41);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderText = "";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.ShadowDecoration.Parent = this.txtSearchBox;
            this.txtSearchBox.Size = new System.Drawing.Size(184, 41);
            this.txtSearchBox.TabIndex = 18;
            // 
            // cbFindBy
            // 
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Items.AddRange(new object[] {
            "NationalNo",
            "Username"});
            this.cbFindBy.Location = new System.Drawing.Point(58, 41);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(196, 41);
            this.cbFindBy.TabIndex = 17;
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearchPerson.BorderRadius = 10;
            this.btnSearchPerson.BorderThickness = 2;
            this.btnSearchPerson.CheckedState.Parent = this.btnSearchPerson;
            this.btnSearchPerson.CustomImages.Parent = this.btnSearchPerson;
            this.btnSearchPerson.FillColor = System.Drawing.Color.White;
            this.btnSearchPerson.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPerson.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPerson.HoverState.Parent = this.btnSearchPerson;
            this.btnSearchPerson.Image = global::CMS.Properties.Resources.SearchPerson;
            this.btnSearchPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearchPerson.Location = new System.Drawing.Point(452, 41);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.ShadowDecoration.Parent = this.btnSearchPerson;
            this.btnSearchPerson.Size = new System.Drawing.Size(66, 42);
            this.btnSearchPerson.TabIndex = 12;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddNewPerson.BorderRadius = 10;
            this.btnAddNewPerson.BorderThickness = 2;
            this.btnAddNewPerson.CheckedState.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.CustomImages.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.FillColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.HoverState.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Image = global::CMS.Properties.Resources.add_user;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewPerson.Location = new System.Drawing.Point(665, 34);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.ShadowDecoration.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Size = new System.Drawing.Size(66, 49);
            this.btnAddNewPerson.TabIndex = 12;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "by :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(524, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 49);
            this.label3.TabIndex = 13;
            this.label3.Text = "Or Add New Doctor :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucShortDoctorCard1
            // 
            this.ucShortDoctorCard1.BackColor = System.Drawing.Color.White;
            this.ucShortDoctorCard1.DoctorID = 0;
            this.ucShortDoctorCard1.Location = new System.Drawing.Point(0, 116);
            this.ucShortDoctorCard1.Name = "ucShortDoctorCard1";
            this.ucShortDoctorCard1.Size = new System.Drawing.Size(823, 424);
            this.ucShortDoctorCard1.TabIndex = 0;
            this.ucShortDoctorCard1.Load += new System.EventHandler(this.ucShortDoctorCard1_Load);
            // 
            // ucFindDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ucShortDoctorCard1);
            this.Name = "ucFindDoctor";
            this.Size = new System.Drawing.Size(828, 544);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucShortDoctorCard ucShortDoctorCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFindBy;
        private Guna.UI2.WinForms.Guna2Button btnSearchPerson;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
    }
}
