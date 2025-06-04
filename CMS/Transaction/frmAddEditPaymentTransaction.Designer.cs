namespace CMS.Transaction
{
    partial class frmAddEditPaymentTransaction
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.udAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ucPaymentCard1 = new CMS.Payments.ucPaymentCard();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbPaymentMethod);
            this.guna2GroupBox1.Controls.Add(this.cbPaymentType);
            this.guna2GroupBox1.Controls.Add(this.udAmount);
            this.guna2GroupBox1.Controls.Add(this.pictureBox4);
            this.guna2GroupBox1.Controls.Add(this.pictureBox10);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.lblTransactionID);
            this.guna2GroupBox1.Controls.Add(this.pictureBox3);
            this.guna2GroupBox1.Controls.Add(this.pictureBox2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 257);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(831, 166);
            this.guna2GroupBox1.TabIndex = 97;
            this.guna2GroupBox1.Text = "Payment Transaction Details :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox4.Location = new System.Drawing.Point(538, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox10.Location = new System.Drawing.Point(538, 55);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(405, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Payment Method :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(424, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Payment Type :";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.ForeColor = System.Drawing.Color.Red;
            this.lblTransactionID.Location = new System.Drawing.Point(231, 66);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(35, 21);
            this.lblTransactionID.TabIndex = 0;
            this.lblTransactionID.Text = "N/A";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CMS.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(180, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox2.Location = new System.Drawing.Point(180, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment Transaction ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(266, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 36);
            this.lblTitle.TabIndex = 98;
            this.lblTitle.Text = "Add/Edit Trnasaction";
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
            this.BtnClose.Location = new System.Drawing.Point(623, 429);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(107, 40);
            this.BtnClose.TabIndex = 99;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseWaitCursor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(736, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Save";
            this.btnSave.UseWaitCursor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // udAmount
            // 
            this.udAmount.BackColor = System.Drawing.Color.Transparent;
            this.udAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.udAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.udAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.udAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.udAmount.DisabledState.Parent = this.udAmount;
            this.udAmount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.udAmount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.udAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.udAmount.FocusedState.Parent = this.udAmount;
            this.udAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.udAmount.Location = new System.Drawing.Point(235, 105);
            this.udAmount.Name = "udAmount";
            this.udAmount.ShadowDecoration.Parent = this.udAmount;
            this.udAmount.Size = new System.Drawing.Size(100, 32);
            this.udAmount.TabIndex = 9;
            this.udAmount.UpDownButtonFillColor = System.Drawing.Color.Gray;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.cbPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.FocusedColor = System.Drawing.Color.Empty;
            this.cbPaymentType.FocusedState.Parent = this.cbPaymentType;
            this.cbPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.HoverState.Parent = this.cbPaymentType;
            this.cbPaymentType.ItemHeight = 30;
            this.cbPaymentType.Items.AddRange(new object[] {
            "Advance",
            "Remaining",
            "FullPayment"});
            this.cbPaymentType.ItemsAppearance.Parent = this.cbPaymentType;
            this.cbPaymentType.Location = new System.Drawing.Point(595, 51);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.ShadowDecoration.Parent = this.cbPaymentType;
            this.cbPaymentType.Size = new System.Drawing.Size(140, 36);
            this.cbPaymentType.TabIndex = 11;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FocusedColor = System.Drawing.Color.Empty;
            this.cbPaymentMethod.FocusedState.Parent = this.cbPaymentMethod;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.HoverState.Parent = this.cbPaymentMethod;
            this.cbPaymentMethod.ItemHeight = 30;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "CreditCard"});
            this.cbPaymentMethod.ItemsAppearance.Parent = this.cbPaymentMethod;
            this.cbPaymentMethod.Location = new System.Drawing.Point(595, 101);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.ShadowDecoration.Parent = this.cbPaymentMethod;
            this.cbPaymentMethod.Size = new System.Drawing.Size(140, 36);
            this.cbPaymentMethod.TabIndex = 11;
            // 
            // ucPaymentCard1
            // 
            this.ucPaymentCard1.Location = new System.Drawing.Point(12, 42);
            this.ucPaymentCard1.Name = "ucPaymentCard1";
            this.ucPaymentCard1.Size = new System.Drawing.Size(838, 209);
            this.ucPaymentCard1.TabIndex = 96;
            // 
            // frmAddEditPaymentTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 478);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.ucPaymentCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPaymentTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEdit Payment Transaction";
            this.Load += new System.EventHandler(this.frmAddEditPaymentTransaction_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Payments.ucPaymentCard ucPaymentCard1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2NumericUpDown udAmount;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaymentMethod;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaymentType;
    }
}