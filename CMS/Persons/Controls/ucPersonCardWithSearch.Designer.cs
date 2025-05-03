namespace CMS.Persons.Controls
{
    partial class ucPersonCardWithSearch
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
            this.ucPersonCard1 = new CMS.Users.Controls.ucPersonCard();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.BackColor = System.Drawing.Color.White;
            this.ucPersonCard1.Location = new System.Drawing.Point(3, 116);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(828, 303);
            this.ucPersonCard1.TabIndex = 15;
            this.ucPersonCard1.Load += new System.EventHandler(this.ucPersonCard1_Load);
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.txtSearchBox);
            this.gbFilter.Controls.Add(this.btnSearchPerson);
            this.gbFilter.Controls.Add(this.btnAddNewPerson);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.Black;
            this.gbFilter.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.gbFilter.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.ShadowDecoration.Parent = this.gbFilter;
            this.gbFilter.Size = new System.Drawing.Size(828, 107);
            this.gbFilter.TabIndex = 17;
            this.gbFilter.Text = "Search Person by :";
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
            this.txtSearchBox.Location = new System.Drawing.Point(119, 41);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(8);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PasswordChar = '\0';
            this.txtSearchBox.PlaceholderText = "";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.ShadowDecoration.Parent = this.txtSearchBox;
            this.txtSearchBox.Size = new System.Drawing.Size(266, 42);
            this.txtSearchBox.TabIndex = 16;
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
            this.btnSearchPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearchPerson.Location = new System.Drawing.Point(396, 41);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.ShadowDecoration.Parent = this.btnSearchPerson;
            this.btnSearchPerson.Size = new System.Drawing.Size(52, 42);
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
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewPerson.Location = new System.Drawing.Point(472, 41);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.ShadowDecoration.Parent = this.btnAddNewPerson;
            this.btnAddNewPerson.Size = new System.Drawing.Size(52, 42);
            this.btnAddNewPerson.TabIndex = 12;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "National No :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucPersonCardWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ucPersonCard1);
            this.Name = "ucPersonCardWithSearch";
            this.Size = new System.Drawing.Size(834, 424);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Users.Controls.ucPersonCard ucPersonCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private Guna.UI2.WinForms.Guna2Button btnSearchPerson;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private System.Windows.Forms.Label label3;
    }
}
