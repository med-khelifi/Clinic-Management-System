namespace CMS.Doctors.Contorls
{
    partial class ucDoctorCard
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
            this.ucUserCard1 = new CMS.Users.Controls.ucUserCard();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblspecializationValue = new System.Windows.Forms.Label();
            this.pbspecialization = new System.Windows.Forms.PictureBox();
            this.lblspecialization = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbspecialization)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUserCard1
            // 
            this.ucUserCard1.BackColor = System.Drawing.Color.White;
            this.ucUserCard1.Location = new System.Drawing.Point(0, 0);
            this.ucUserCard1.Name = "ucUserCard1";
            this.ucUserCard1.Size = new System.Drawing.Size(824, 483);
            this.ucUserCard1.TabIndex = 0;
            this.ucUserCard1.UserID = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblspecializationValue);
            this.guna2GroupBox1.Controls.Add(this.pbspecialization);
            this.guna2GroupBox1.Controls.Add(this.lblspecialization);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 485);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(817, 109);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Doctor Details :";
            // 
            // lblspecializationValue
            // 
            this.lblspecializationValue.AutoSize = true;
            this.lblspecializationValue.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.lblspecializationValue.ForeColor = System.Drawing.Color.Black;
            this.lblspecializationValue.Location = new System.Drawing.Point(319, 61);
            this.lblspecializationValue.Name = "lblspecializationValue";
            this.lblspecializationValue.Size = new System.Drawing.Size(16, 21);
            this.lblspecializationValue.TabIndex = 0;
            this.lblspecializationValue.Text = "_";
            // 
            // pbspecialization
            // 
            this.pbspecialization.Image = global::CMS.Properties.Resources.medical_assistance;
            this.pbspecialization.Location = new System.Drawing.Point(271, 50);
            this.pbspecialization.Name = "pbspecialization";
            this.pbspecialization.Size = new System.Drawing.Size(32, 32);
            this.pbspecialization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbspecialization.TabIndex = 1;
            this.pbspecialization.TabStop = false;
            // 
            // lblspecialization
            // 
            this.lblspecialization.AutoSize = true;
            this.lblspecialization.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecialization.ForeColor = System.Drawing.Color.Black;
            this.lblspecialization.Location = new System.Drawing.Point(158, 61);
            this.lblspecialization.Name = "lblspecialization";
            this.lblspecialization.Size = new System.Drawing.Size(107, 21);
            this.lblspecialization.TabIndex = 0;
            this.lblspecialization.Text = "specialization :";
            // 
            // ucDoctorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.ucUserCard1);
            this.Name = "ucDoctorCard";
            this.Size = new System.Drawing.Size(824, 597);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbspecialization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Users.Controls.ucUserCard ucUserCard1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblspecializationValue;
        private System.Windows.Forms.PictureBox pbspecialization;
        private System.Windows.Forms.Label lblspecialization;
    }
}
