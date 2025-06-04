namespace CMS.Payments
{
    partial class ucPaymentCard
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
            this.llTransactionList = new System.Windows.Forms.LinkLabel();
            this.llAppointmentInfo = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblisFullyPaid = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.White;
            this.gbFilter.Controls.Add(this.llTransactionList);
            this.gbFilter.Controls.Add(this.llAppointmentInfo);
            this.gbFilter.Controls.Add(this.pictureBox6);
            this.gbFilter.Controls.Add(this.pictureBox3);
            this.gbFilter.Controls.Add(this.pictureBox5);
            this.gbFilter.Controls.Add(this.pictureBox1);
            this.gbFilter.Controls.Add(this.pictureBox2);
            this.gbFilter.Controls.Add(this.lblisFullyPaid);
            this.gbFilter.Controls.Add(this.lblPaidAmount);
            this.gbFilter.Controls.Add(this.label11);
            this.gbFilter.Controls.Add(this.label5);
            this.gbFilter.Controls.Add(this.lblAppointmentID);
            this.gbFilter.Controls.Add(this.label9);
            this.gbFilter.Controls.Add(this.lblTotalAmount);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Controls.Add(this.lblPaymentID);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.Black;
            this.gbFilter.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.gbFilter.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.ShadowDecoration.Parent = this.gbFilter;
            this.gbFilter.Size = new System.Drawing.Size(828, 201);
            this.gbFilter.TabIndex = 88;
            this.gbFilter.Text = "Payment Info :";
            // 
            // llTransactionList
            // 
            this.llTransactionList.AutoSize = true;
            this.llTransactionList.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llTransactionList.Location = new System.Drawing.Point(63, 170);
            this.llTransactionList.Name = "llTransactionList";
            this.llTransactionList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.llTransactionList.Size = new System.Drawing.Size(139, 21);
            this.llTransactionList.TabIndex = 16;
            this.llTransactionList.TabStop = true;
            this.llTransactionList.Text = "Transactions List";
            this.llTransactionList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTransactionList_LinkClicked);
            // 
            // llAppointmentInfo
            // 
            this.llAppointmentInfo.AutoSize = true;
            this.llAppointmentInfo.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAppointmentInfo.Location = new System.Drawing.Point(229, 170);
            this.llAppointmentInfo.Name = "llAppointmentInfo";
            this.llAppointmentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.llAppointmentInfo.Size = new System.Drawing.Size(139, 21);
            this.llAppointmentInfo.TabIndex = 16;
            this.llAppointmentInfo.TabStop = true;
            this.llAppointmentInfo.Text = "Appointment Info";
            this.llAppointmentInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAppointmentInfo_LinkClicked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CMS.Properties.Resources.info;
            this.pictureBox6.Location = new System.Drawing.Point(486, 130);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CMS.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(170, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox5.Location = new System.Drawing.Point(486, 89);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMS.Properties.Resources.dollar;
            this.pictureBox1.Location = new System.Drawing.Point(170, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CMS.Properties.Resources.tasks;
            this.pictureBox2.Location = new System.Drawing.Point(170, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblisFullyPaid
            // 
            this.lblisFullyPaid.AutoSize = true;
            this.lblisFullyPaid.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisFullyPaid.ForeColor = System.Drawing.Color.Black;
            this.lblisFullyPaid.Location = new System.Drawing.Point(527, 130);
            this.lblisFullyPaid.Name = "lblisFullyPaid";
            this.lblisFullyPaid.Size = new System.Drawing.Size(17, 24);
            this.lblisFullyPaid.TabIndex = 13;
            this.lblisFullyPaid.Text = "-";
            this.lblisFullyPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.ForeColor = System.Drawing.Color.Black;
            this.lblPaidAmount.Location = new System.Drawing.Point(225, 130);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(17, 24);
            this.lblPaidAmount.TabIndex = 13;
            this.lblPaidAmount.Text = "-";
            this.lblPaidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(382, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "is Fully Paid :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Paid Amount :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentID.Location = new System.Drawing.Point(527, 89);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(17, 24);
            this.lblAppointmentID.TabIndex = 13;
            this.lblAppointmentID.Text = "-";
            this.lblAppointmentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(362, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Appointment ID :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(225, 89);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(17, 24);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "-";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Amount :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentID.Location = new System.Drawing.Point(225, 45);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(33, 24);
            this.lblPaymentID.TabIndex = 13;
            this.lblPaymentID.Text = "N/A";
            this.lblPaymentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Payment ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucPaymentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Name = "ucPaymentCard";
            this.Size = new System.Drawing.Size(837, 209);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.LinkLabel llAppointmentInfo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblisFullyPaid;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llTransactionList;
    }
}
