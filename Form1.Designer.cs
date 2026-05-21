namespace ATM_BANK
{
    partial class Form1
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbPin = new System.Windows.Forms.TextBox();
            this.txtbCardNumber = new System.Windows.Forms.TextBox();
            this.panel_Atm = new System.Windows.Forms.Panel();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.panelLogIn.Controls.Add(this.lblMessage);
            this.panelLogIn.Controls.Add(this.btnEnter);
            this.panelLogIn.Controls.Add(this.label2);
            this.panelLogIn.Controls.Add(this.label1);
            this.panelLogIn.Controls.Add(this.txtbPin);
            this.panelLogIn.Controls.Add(this.txtbCardNumber);
            this.panelLogIn.Location = new System.Drawing.Point(346, 0);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(455, 448);
            this.panelLogIn.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(216, 383);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 10;
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = global::ATM_BANK.Properties.Resources.Enter;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnEnter.Location = new System.Drawing.Point(170, 270);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(138, 80);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CARD NUMBER";
            // 
            // txtbPin
            // 
            this.txtbPin.Location = new System.Drawing.Point(132, 200);
            this.txtbPin.MaxLength = 6;
            this.txtbPin.Name = "txtbPin";
            this.txtbPin.PasswordChar = '*';
            this.txtbPin.Size = new System.Drawing.Size(297, 20);
            this.txtbPin.TabIndex = 6;
            // 
            // txtbCardNumber
            // 
            this.txtbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCardNumber.Location = new System.Drawing.Point(132, 149);
            this.txtbCardNumber.MaxLength = 12;
            this.txtbCardNumber.Name = "txtbCardNumber";
            this.txtbCardNumber.Size = new System.Drawing.Size(297, 29);
            this.txtbCardNumber.TabIndex = 5;
            // 
            // panel_Atm
            // 
            this.panel_Atm.BackgroundImage = global::ATM_BANK.Properties.Resources.Screenshot_28_4_2026_175952_www_canva_com;
            this.panel_Atm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Atm.Location = new System.Drawing.Point(0, 0);
            this.panel_Atm.Name = "panel_Atm";
            this.panel_Atm.Size = new System.Drawing.Size(348, 448);
            this.panel_Atm.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.panel_Atm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Atm;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbPin;
        private System.Windows.Forms.TextBox txtbCardNumber;
        private System.Windows.Forms.Label lblMessage;
    }
}

