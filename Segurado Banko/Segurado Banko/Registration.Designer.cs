namespace Segurado_Banko
{
    partial class Registration
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRegisterFirstname = new System.Windows.Forms.TextBox();
            this.txtRegisterLastname = new System.Windows.Forms.TextBox();
            this.txtRegisterEmailAddress = new System.Windows.Forms.TextBox();
            this.txtRegisterRecoveryPIN = new System.Windows.Forms.TextBox();
            this.txtRegisterPINCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(63, 518);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(99, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegisterFirstname
            // 
            this.txtRegisterFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterFirstname.Location = new System.Drawing.Point(70, 241);
            this.txtRegisterFirstname.Name = "txtRegisterFirstname";
            this.txtRegisterFirstname.Size = new System.Drawing.Size(239, 19);
            this.txtRegisterFirstname.TabIndex = 0;
            // 
            // txtRegisterLastname
            // 
            this.txtRegisterLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterLastname.Location = new System.Drawing.Point(70, 301);
            this.txtRegisterLastname.Name = "txtRegisterLastname";
            this.txtRegisterLastname.Size = new System.Drawing.Size(239, 19);
            this.txtRegisterLastname.TabIndex = 1;
            // 
            // txtRegisterEmailAddress
            // 
            this.txtRegisterEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterEmailAddress.Location = new System.Drawing.Point(70, 361);
            this.txtRegisterEmailAddress.Name = "txtRegisterEmailAddress";
            this.txtRegisterEmailAddress.Size = new System.Drawing.Size(239, 19);
            this.txtRegisterEmailAddress.TabIndex = 2;
            // 
            // txtRegisterRecoveryPIN
            // 
            this.txtRegisterRecoveryPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterRecoveryPIN.Location = new System.Drawing.Point(70, 422);
            this.txtRegisterRecoveryPIN.Name = "txtRegisterRecoveryPIN";
            this.txtRegisterRecoveryPIN.Size = new System.Drawing.Size(239, 19);
            this.txtRegisterRecoveryPIN.TabIndex = 3;
            // 
            // txtRegisterPINCode
            // 
            this.txtRegisterPINCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterPINCode.Location = new System.Drawing.Point(70, 487);
            this.txtRegisterPINCode.Name = "txtRegisterPINCode";
            this.txtRegisterPINCode.Size = new System.Drawing.Size(239, 19);
            this.txtRegisterPINCode.TabIndex = 4;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Segurado_Banko.Properties.Resources.register;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 700);
            this.Controls.Add(this.txtRegisterPINCode);
            this.Controls.Add(this.txtRegisterRecoveryPIN);
            this.Controls.Add(this.txtRegisterEmailAddress);
            this.Controls.Add(this.txtRegisterLastname);
            this.Controls.Add(this.txtRegisterFirstname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRegisterFirstname;
        private System.Windows.Forms.TextBox txtRegisterLastname;
        private System.Windows.Forms.TextBox txtRegisterEmailAddress;
        private System.Windows.Forms.TextBox txtRegisterRecoveryPIN;
        private System.Windows.Forms.TextBox txtRegisterPINCode;
    }
}