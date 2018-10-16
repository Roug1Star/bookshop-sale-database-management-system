namespace WindowsFormsApplication1
{
    partial class LoadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.useridname = new System.Windows.Forms.TextBox();
            this.userpassword = new System.Windows.Forms.TextBox();
            this.UserLogin = new System.Windows.Forms.Button();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.ExitL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 15;
            // 
            // useridname
            // 
            this.useridname.Location = new System.Drawing.Point(107, 24);
            this.useridname.Name = "useridname";
            this.useridname.Size = new System.Drawing.Size(100, 21);
            this.useridname.TabIndex = 2;
            // 
            // userpassword
            // 
            this.userpassword.Location = new System.Drawing.Point(107, 62);
            this.userpassword.Name = "userpassword";
            this.userpassword.PasswordChar = '*';
            this.userpassword.Size = new System.Drawing.Size(100, 21);
            this.userpassword.TabIndex = 3;
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(49, 135);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(75, 23);
            this.UserLogin.TabIndex = 4;
            this.UserLogin.Text = "用户登录";
            this.UserLogin.UseVisualStyleBackColor = true;
            this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.Location = new System.Drawing.Point(132, 135);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(75, 23);
            this.AdminLogin.TabIndex = 5;
            this.AdminLogin.Text = "管理员登录";
            this.AdminLogin.UseVisualStyleBackColor = true;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // ExitL
            // 
            this.ExitL.Location = new System.Drawing.Point(92, 164);
            this.ExitL.Name = "ExitL";
            this.ExitL.Size = new System.Drawing.Size(75, 23);
            this.ExitL.TabIndex = 6;
            this.ExitL.Text = "退出";
            this.ExitL.UseVisualStyleBackColor = true;
            this.ExitL.Click += new System.EventHandler(this.ExitL_Click);
            // 
            // LoadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 194);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExitL);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.useridname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadUser";
            this.Text = "LoadUser";
            this.Load += new System.EventHandler(this.LoadUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox useridname;
        private System.Windows.Forms.TextBox userpassword;
        private System.Windows.Forms.Button UserLogin;
        private System.Windows.Forms.Button AdminLogin;
        private System.Windows.Forms.Button ExitL;
        private System.Windows.Forms.Label label4;
    }
}