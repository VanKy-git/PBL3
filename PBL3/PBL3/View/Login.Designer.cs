namespace PBL3.View
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_forgetpw = new System.Windows.Forms.LinkLabel();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.ckb_hidepw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_username.Location = new System.Drawing.Point(123, 256);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(98, 16);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Tên đăng nhập";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_password.Location = new System.Drawing.Point(126, 298);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 16);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_username.Location = new System.Drawing.Point(228, 256);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(128, 22);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_password.Location = new System.Drawing.Point(228, 298);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(128, 22);
            this.txt_password.TabIndex = 3;
            // 
            // lbl_forgetpw
            // 
            this.lbl_forgetpw.AutoSize = true;
            this.lbl_forgetpw.Location = new System.Drawing.Point(189, 416);
            this.lbl_forgetpw.Name = "lbl_forgetpw";
            this.lbl_forgetpw.Size = new System.Drawing.Size(103, 16);
            this.lbl_forgetpw.TabIndex = 4;
            this.lbl_forgetpw.TabStop = true;
            this.lbl_forgetpw.Text = "Quên mật khẩu?";
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(147, 352);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(89, 33);
            this.btn_signin.TabIndex = 5;
            this.btn_signin.Text = "Đăng nhập";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(253, 352);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(89, 33);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Đăng ký";
            this.btn_signup.UseVisualStyleBackColor = true;
            // 
            // ckb_hidepw
            // 
            this.ckb_hidepw.AutoSize = true;
            this.ckb_hidepw.Location = new System.Drawing.Point(228, 326);
            this.ckb_hidepw.Name = "ckb_hidepw";
            this.ckb_hidepw.Size = new System.Drawing.Size(114, 20);
            this.ckb_hidepw.TabIndex = 7;
            this.ckb_hidepw.Text = "Hiện mật khẩu";
            this.ckb_hidepw.UseVisualStyleBackColor = true;
            this.ckb_hidepw.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 497);
            this.Controls.Add(this.ckb_hidepw);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.lbl_forgetpw);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.LinkLabel lbl_forgetpw;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.CheckBox ckb_hidepw;
    }
}