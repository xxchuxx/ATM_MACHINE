namespace ATM_BANK
{
    partial class Check_Balance
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Atm = new System.Windows.Forms.Panel();
            this.panelLogIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(216, 383);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 10;
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.panelLogIn.Controls.Add(this.btnDo);
            this.panelLogIn.Controls.Add(this.btnExit);
            this.panelLogIn.Controls.Add(this.panel1);
            this.panelLogIn.Controls.Add(this.lblMessage);
            this.panelLogIn.Location = new System.Drawing.Point(346, 1);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(455, 448);
            this.panelLogIn.TabIndex = 3;
            // 
            // btnDo
            // 
            this.btnDo.BackgroundImage = global::ATM_BANK.Properties.Resources.DO;
            this.btnDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnDo.Location = new System.Drawing.Point(293, 320);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(149, 80);
            this.btnDo.TabIndex = 15;
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ATM_BANK.Properties.Resources.EXIT1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnExit.Location = new System.Drawing.Point(34, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 80);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_181351_www_canva_com;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 131);
            this.panel1.TabIndex = 11;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.lblBalance.Location = new System.Drawing.Point(72, 60);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(279, 48);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Available Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Balance";
            // 
            // panel_Atm
            // 
            this.panel_Atm.BackgroundImage = global::ATM_BANK.Properties.Resources.CB;
            this.panel_Atm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Atm.Location = new System.Drawing.Point(0, 1);
            this.panel_Atm.Name = "panel_Atm";
            this.panel_Atm.Size = new System.Drawing.Size(348, 448);
            this.panel_Atm.TabIndex = 2;
            // 
            // Check_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.panel_Atm);
            this.Name = "Check_Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_Balance";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Atm;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnExit;
    }
}