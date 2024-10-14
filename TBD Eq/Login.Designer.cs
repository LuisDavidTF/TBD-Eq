
namespace TBD_Eq
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.lblUsernameR = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblPasswordR = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TBD_Eq.Properties.Resources.User1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(92, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Controls.Add(this.lblUsernameR);
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Location = new System.Drawing.Point(59, 146);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(228, 65);
            this.pnlUsername.TabIndex = 9;
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
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Controls.Add(this.lblPasswordR);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(59, 226);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(228, 65);
            this.pnlPassword.TabIndex = 10;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblUsernameR;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPasswordR;
        private System.Windows.Forms.TextBox txtPassword;
    }
}