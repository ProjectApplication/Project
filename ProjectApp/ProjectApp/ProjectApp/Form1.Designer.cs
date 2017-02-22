namespace ProjectApp
{
    partial class flogin
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 321);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnExit_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(300, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPassWord);
            this.panel3.Controls.Add(this.lbPassWord);
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 57);
            this.panel3.TabIndex = 1;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(195, 17);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(272, 20);
            this.tbPassWord.TabIndex = 1;
            this.tbPassWord.UseSystemPasswordChar = true;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassWord.Location = new System.Drawing.Point(3, 11);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(132, 26);
            this.lbPassWord.TabIndex = 2;
            this.lbPassWord.Text = "Mật Khẩu :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 57);
            this.panel2.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(195, 17);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(272, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(3, 11);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(186, 26);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên Đăng Nhập :";
            this.lbUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 353);
            this.Controls.Add(this.panel1);
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

