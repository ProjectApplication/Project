namespace CfManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 278);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(476, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(350, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 54);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPassWord);
            this.panel3.Controls.Add(this.lbPassWord);
            this.panel3.Location = new System.Drawing.Point(10, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 66);
            this.panel3.TabIndex = 1;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(181, 31);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(375, 20);
            this.tbPassWord.TabIndex = 2;
            this.tbPassWord.UseSystemPasswordChar = true;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassWord.Location = new System.Drawing.Point(3, 31);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(114, 24);
            this.lbPassWord.TabIndex = 0;
            this.lbPassWord.Text = "Mật Khẩu :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Location = new System.Drawing.Point(10, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 83);
            this.panel2.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(181, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(375, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(3, 31);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(162, 24);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên Đăng Nhập :";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(599, 292);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.TextBox tbUserName;
    }
}

