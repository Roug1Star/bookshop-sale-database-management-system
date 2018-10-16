namespace WindowsFormsApplication1
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserPhoneNumber = new System.Windows.Forms.TextBox();
            this.Useriden = new System.Windows.Forms.TextBox();
            this.UserAddress = new System.Windows.Forms.TextBox();
            this.UserSex = new System.Windows.Forms.ComboBox();
            this.UserRegi = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "昵称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "手机：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "身份证号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "收货地址：";
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(84, 28);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(100, 21);
            this.UserID.TabIndex = 7;
            this.UserID.TextChanged += new System.EventHandler(this.UserID_TextChanged);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(84, 70);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 21);
            this.UserName.TabIndex = 8;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(84, 117);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(100, 21);
            this.UserPassword.TabIndex = 9;
            // 
            // UserPhoneNumber
            // 
            this.UserPhoneNumber.Location = new System.Drawing.Point(84, 187);
            this.UserPhoneNumber.Name = "UserPhoneNumber";
            this.UserPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.UserPhoneNumber.TabIndex = 10;
            // 
            // Useriden
            // 
            this.Useriden.Location = new System.Drawing.Point(83, 226);
            this.Useriden.Name = "Useriden";
            this.Useriden.Size = new System.Drawing.Size(176, 21);
            this.Useriden.TabIndex = 11;
            // 
            // UserAddress
            // 
            this.UserAddress.Location = new System.Drawing.Point(83, 269);
            this.UserAddress.Multiline = true;
            this.UserAddress.Name = "UserAddress";
            this.UserAddress.Size = new System.Drawing.Size(176, 70);
            this.UserAddress.TabIndex = 12;
            // 
            // UserSex
            // 
            this.UserSex.FormattingEnabled = true;
            this.UserSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.UserSex.Location = new System.Drawing.Point(84, 157);
            this.UserSex.Name = "UserSex";
            this.UserSex.Size = new System.Drawing.Size(42, 20);
            this.UserSex.TabIndex = 13;
            this.UserSex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UserRegi
            // 
            this.UserRegi.Location = new System.Drawing.Point(26, 383);
            this.UserRegi.Name = "UserRegi";
            this.UserRegi.Size = new System.Drawing.Size(75, 23);
            this.UserRegi.TabIndex = 14;
            this.UserRegi.Text = "注册";
            this.UserRegi.UseVisualStyleBackColor = true;
            this.UserRegi.Click += new System.EventHandler(this.UserRegi_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(175, 383);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "返回";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 433);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UserRegi);
            this.Controls.Add(this.UserSex);
            this.Controls.Add(this.UserAddress);
            this.Controls.Add(this.Useriden);
            this.Controls.Add(this.UserPhoneNumber);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.TextBox UserPhoneNumber;
        private System.Windows.Forms.TextBox Useriden;
        private System.Windows.Forms.TextBox UserAddress;
        private System.Windows.Forms.ComboBox UserSex;
        private System.Windows.Forms.Button UserRegi;
        private System.Windows.Forms.Button Exit;
    }
}