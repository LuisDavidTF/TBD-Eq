
namespace TBD_Eq
{
    partial class FormSignUp
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
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblPasswordR = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblUsernameR = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.lblPasswordCR = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnlPassword.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlConfirmPass.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Controls.Add(this.lblPasswordR);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(12, 101);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(275, 65);
            this.pnlPassword.TabIndex = 12;
            this.pnlPassword.Click += new System.EventHandler(this.pnlPassword_Click);
            // 
            // lblPasswordR
            // 
            this.lblPasswordR.AutoSize = true;
            this.lblPasswordR.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasswordR.Location = new System.Drawing.Point(3, 22);
            this.lblPasswordR.Name = "lblPasswordR";
            this.lblPasswordR.Size = new System.Drawing.Size(134, 33);
            this.lblPasswordR.TabIndex = 2;
            this.lblPasswordR.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(3, 22);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Controls.Add(this.lblUsernameR);
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Location = new System.Drawing.Point(12, 21);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(275, 65);
            this.pnlUsername.TabIndex = 11;
            this.pnlUsername.Click += new System.EventHandler(this.pnlUsername_Click);
            // 
            // lblUsernameR
            // 
            this.lblUsernameR.AutoSize = true;
            this.lblUsernameR.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsernameR.Location = new System.Drawing.Point(3, 20);
            this.lblUsernameR.Name = "lblUsernameR";
            this.lblUsernameR.Size = new System.Drawing.Size(218, 33);
            this.lblUsernameR.TabIndex = 2;
            this.lblUsernameR.Text = "Nombre de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(3, 22);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 32);
            this.txtUsername.TabIndex = 1;
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.White;
            this.pnlConfirmPass.Controls.Add(this.lblPasswordCR);
            this.pnlConfirmPass.Controls.Add(this.txtConfirmPass);
            this.pnlConfirmPass.Location = new System.Drawing.Point(12, 180);
            this.pnlConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(275, 65);
            this.pnlConfirmPass.TabIndex = 13;
            this.pnlConfirmPass.Click += new System.EventHandler(this.pnlConfirmPass_Click);
            // 
            // lblPasswordCR
            // 
            this.lblPasswordCR.AutoSize = true;
            this.lblPasswordCR.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasswordCR.Location = new System.Drawing.Point(3, 22);
            this.lblPasswordCR.Name = "lblPasswordCR";
            this.lblPasswordCR.Size = new System.Drawing.Size(253, 33);
            this.lblPasswordCR.TabIndex = 2;
            this.lblPasswordCR.Text = "Confirmar Contraseña";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(3, 22);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(221, 32);
            this.txtConfirmPass.TabIndex = 1;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(12, 262);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(275, 65);
            this.pnlEmail.TabIndex = 14;
            this.pnlEmail.Click += new System.EventHandler(this.pnlEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(3, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 33);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(3, 22);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(78, 347);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(144, 60);
            this.btnSignUp.TabIndex = 15;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlConfirmPass);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSignUp";
            this.Text = "Sign Up";
            this.Click += new System.EventHandler(this.FormSignUp_Click);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlConfirmPass.ResumeLayout(false);
            this.pnlConfirmPass.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPasswordR;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblUsernameR;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private System.Windows.Forms.Label lblPasswordCR;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignUp;
    }
}