namespace CMS.MediicalRecords
{
    partial class frmMedicalRecordInfo
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
            this.ucMedicalRecordCard1 = new CMS.MediicalRecords.Controls.ucMedicalRecordCard();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucMedicalRecordCard1
            // 
            this.ucMedicalRecordCard1.Location = new System.Drawing.Point(2, 82);
            this.ucMedicalRecordCard1.Name = "ucMedicalRecordCard1";
            this.ucMedicalRecordCard1.Size = new System.Drawing.Size(917, 351);
            this.ucMedicalRecordCard1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(304, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 36);
            this.lblTitle.TabIndex = 93;
            this.lblTitle.Text = "Medical Record Info";
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
            this.btnSave.Location = new System.Drawing.Point(803, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "Close";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMedicalRecordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucMedicalRecordCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMedicalRecordInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Record Info";
            this.Load += new System.EventHandler(this.frmMedicalRecordInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ucMedicalRecordCard ucMedicalRecordCard1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}