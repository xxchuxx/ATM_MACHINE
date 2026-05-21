namespace ATM_BANK
{
    partial class WithdrawForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.panel_Atm = new System.Windows.Forms.Panel();
            this.panelLogIn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.panelLogIn.Controls.Add(this.button1);
            this.panelLogIn.Controls.Add(this.panel3);
            this.panelLogIn.Controls.Add(this.panel2);
            this.panelLogIn.Controls.Add(this.panel1);
            this.panelLogIn.Controls.Add(this.btnWithdraw);
            this.panelLogIn.Location = new System.Drawing.Point(346, 1);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(455, 448);
            this.panelLogIn.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtbAmount);
            this.panel3.Location = new System.Drawing.Point(47, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 100);
            this.panel3.TabIndex = 18;
            // 
            // txtbAmount
            // 
            this.txtbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAmount.Location = new System.Drawing.Point(17, 35);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(309, 31);
            this.txtbAmount.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_184146_www_canva_com;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(24, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_183647_www_canva_com;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(47, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 61);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_181351_www_canva_com;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 70);
            this.panel1.TabIndex = 16;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.lblBalance.Location = new System.Drawing.Point(96, 29);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(206, 34);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Available Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available Balance";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackgroundImage = global::ATM_BANK.Properties.Resources.Withdraw;
            this.btnWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnWithdraw.Location = new System.Drawing.Point(261, 343);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(169, 78);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // panel_Atm
            // 
            this.panel_Atm.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_194217_www_canva_com;
            this.panel_Atm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Atm.Location = new System.Drawing.Point(0, 1);
            this.panel_Atm.Name = "panel_Atm";
            this.panel_Atm.Size = new System.Drawing.Size(348, 448);
            this.panel_Atm.TabIndex = 4;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.panel_Atm);
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawForm";
            this.panelLogIn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel panel_Atm;
    }
}