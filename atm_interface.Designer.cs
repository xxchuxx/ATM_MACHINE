namespace ATM_BANK
{
    partial class atm_interface
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
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtbDeposit = new System.Windows.Forms.Button();
            this.txtbBalance = new System.Windows.Forms.Button();
            this.txtbCancel = new System.Windows.Forms.Button();
            this.txtbWithdraw = new System.Windows.Forms.Button();
            this.panel_Atm = new System.Windows.Forms.Panel();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.panelLogIn.Controls.Add(this.lblWelcome);
            this.panelLogIn.Controls.Add(this.txtbDeposit);
            this.panelLogIn.Controls.Add(this.txtbBalance);
            this.panelLogIn.Controls.Add(this.txtbCancel);
            this.panelLogIn.Controls.Add(this.txtbWithdraw);
            this.panelLogIn.Controls.Add(this.lblMessage);
            this.panelLogIn.Location = new System.Drawing.Point(346, 1);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(455, 448);
            this.panelLogIn.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(216, 383);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 10;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(198, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "label1";
            // 
            // txtbDeposit
            // 
            this.txtbDeposit.BackgroundImage = global::ATM_BANK.Properties.Resources.Deposit;
            this.txtbDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.txtbDeposit.Location = new System.Drawing.Point(17, 111);
            this.txtbDeposit.Name = "txtbDeposit";
            this.txtbDeposit.Size = new System.Drawing.Size(175, 94);
            this.txtbDeposit.TabIndex = 11;
            this.txtbDeposit.UseVisualStyleBackColor = true;
            this.txtbDeposit.Click += new System.EventHandler(this.txtbDeposit_Click);
            // 
            // txtbBalance
            // 
            this.txtbBalance.BackgroundImage = global::ATM_BANK.Properties.Resources.Check;
            this.txtbBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.txtbBalance.Location = new System.Drawing.Point(17, 267);
            this.txtbBalance.Name = "txtbBalance";
            this.txtbBalance.Size = new System.Drawing.Size(175, 94);
            this.txtbBalance.TabIndex = 13;
            this.txtbBalance.UseVisualStyleBackColor = true;
            this.txtbBalance.Click += new System.EventHandler(this.txtbBalance_Click);
            // 
            // txtbCancel
            // 
            this.txtbCancel.BackgroundImage = global::ATM_BANK.Properties.Resources.Cancel;
            this.txtbCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.txtbCancel.Location = new System.Drawing.Point(257, 267);
            this.txtbCancel.Name = "txtbCancel";
            this.txtbCancel.Size = new System.Drawing.Size(175, 94);
            this.txtbCancel.TabIndex = 14;
            this.txtbCancel.UseVisualStyleBackColor = true;
            this.txtbCancel.Click += new System.EventHandler(this.txtbCancel_Click);
            // 
            // txtbWithdraw
            // 
            this.txtbWithdraw.BackgroundImage = global::ATM_BANK.Properties.Resources.Withdraw;
            this.txtbWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.txtbWithdraw.Location = new System.Drawing.Point(257, 111);
            this.txtbWithdraw.Name = "txtbWithdraw";
            this.txtbWithdraw.Size = new System.Drawing.Size(175, 94);
            this.txtbWithdraw.TabIndex = 12;
            this.txtbWithdraw.UseVisualStyleBackColor = true;
            this.txtbWithdraw.Click += new System.EventHandler(this.txtbWithdraw_Click);
            // 
            // panel_Atm
            // 
            this.panel_Atm.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_17465_www_canva_com;
            this.panel_Atm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Atm.Location = new System.Drawing.Point(0, 1);
            this.panel_Atm.Name = "panel_Atm";
            this.panel_Atm.Size = new System.Drawing.Size(348, 448);
            this.panel_Atm.TabIndex = 2;
            // 
            // atm_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.panel_Atm);
            this.Name = "atm_interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atm_interface";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel_Atm;
        private System.Windows.Forms.Button txtbDeposit;
        private System.Windows.Forms.Button txtbBalance;
        private System.Windows.Forms.Button txtbCancel;
        private System.Windows.Forms.Button txtbWithdraw;
        private System.Windows.Forms.Label lblWelcome;
    }
}