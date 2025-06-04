namespace CMS.Transaction
{
    partial class frmTransactionList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnAddNewTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRecordCount = new System.Windows.Forms.Label();
            this.ucPaymentCard1 = new CMS.Payments.ucPaymentCard();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(305, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Payment History :";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeColumns = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(5, 319);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(827, 198);
            this.dgvTransactions.TabIndex = 21;
            // 
            // btnAddNewTransaction
            // 
            this.btnAddNewTransaction.BorderRadius = 6;
            this.btnAddNewTransaction.BorderThickness = 2;
            this.btnAddNewTransaction.CheckedState.Parent = this.btnAddNewTransaction;
            this.btnAddNewTransaction.CustomImages.Parent = this.btnAddNewTransaction;
            this.btnAddNewTransaction.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTransaction.HoverState.Parent = this.btnAddNewTransaction;
            this.btnAddNewTransaction.Image = global::CMS.Properties.Resources.wallet;
            this.btnAddNewTransaction.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddNewTransaction.Location = new System.Drawing.Point(792, 276);
            this.btnAddNewTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewTransaction.Name = "btnAddNewTransaction";
            this.btnAddNewTransaction.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddNewTransaction.PressedColor = System.Drawing.Color.Silver;
            this.btnAddNewTransaction.ShadowDecoration.Parent = this.btnAddNewTransaction;
            this.btnAddNewTransaction.Size = new System.Drawing.Size(40, 37);
            this.btnAddNewTransaction.TabIndex = 22;
            this.btnAddNewTransaction.Click += new System.EventHandler(this.btnAddNewTransaction_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(725, 523);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(107, 40);
            this.BtnClose.TabIndex = 87;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 21);
            this.label12.TabIndex = 88;
            this.label12.Text = "Transactions :";
            // 
            // lbRecordCount
            // 
            this.lbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordCount.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordCount.ForeColor = System.Drawing.Color.Black;
            this.lbRecordCount.Location = new System.Drawing.Point(12, 520);
            this.lbRecordCount.Name = "lbRecordCount";
            this.lbRecordCount.Size = new System.Drawing.Size(180, 36);
            this.lbRecordCount.TabIndex = 89;
            this.lbRecordCount.Text = "#Count = ";
            // 
            // ucPaymentCard1
            // 
            this.ucPaymentCard1.Location = new System.Drawing.Point(5, 64);
            this.ucPaymentCard1.Name = "ucPaymentCard1";
            this.ucPaymentCard1.Size = new System.Drawing.Size(837, 209);
            this.ucPaymentCard1.TabIndex = 1;
            // 
            // frmTransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 575);
            this.Controls.Add(this.lbRecordCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnAddNewTransaction);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucPaymentCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransactionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions List";
            this.Load += new System.EventHandler(this.frmTransactionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Payments.ucPaymentCard ucPaymentCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private Guna.UI2.WinForms.Guna2Button btnAddNewTransaction;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbRecordCount;
    }
}