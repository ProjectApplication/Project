namespace RoverCoffeManage2.FormOption
{
    partial class AccountList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_Account = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_typeAccount = new System.Windows.Forms.ComboBox();
            this.txt_passWord2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_displayName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_passWord1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OKAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_PassChange2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassChange1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cb_listUserName1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_okFix = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_listUserName2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_OkDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Account)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 44);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 44);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(395, 3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(311, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thiết Lập Tài Khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(395, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(281, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thiết Lập Món Ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtgv_Account);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(13, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 474);
            this.panel3.TabIndex = 13;
            // 
            // dtgv_Account
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Account.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Account.DoubleBuffered = true;
            this.dtgv_Account.Enabled = false;
            this.dtgv_Account.EnableHeadersVisualStyles = false;
            this.dtgv_Account.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dtgv_Account.HeaderForeColor = System.Drawing.Color.White;
            this.dtgv_Account.Location = new System.Drawing.Point(-31, 36);
            this.dtgv_Account.Name = "dtgv_Account";
            this.dtgv_Account.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_Account.Size = new System.Drawing.Size(288, 437);
            this.dtgv_Account.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Danh Sách Tài Khoản";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.materialTabSelector1);
            this.bunifuCards1.Controls.Add(this.materialTabControl1);
            this.bunifuCards1.Controls.Add(this.label10);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(277, 69);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(719, 473);
            this.bunifuCards1.TabIndex = 14;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-14, 48);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(734, 37);
            this.materialTabSelector1.TabIndex = 13;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 91);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(708, 382);
            this.materialTabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cb_typeAccount);
            this.tabPage1.Controls.Add(this.txt_passWord2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt_displayName);
            this.tabPage1.Controls.Add(this.txt_passWord1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_userName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_OKAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm Tài Khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại tài khoản :";
            // 
            // cb_typeAccount
            // 
            this.cb_typeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeAccount.FormattingEnabled = true;
            this.cb_typeAccount.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cb_typeAccount.Location = new System.Drawing.Point(281, 243);
            this.cb_typeAccount.Name = "cb_typeAccount";
            this.cb_typeAccount.Size = new System.Drawing.Size(197, 21);
            this.cb_typeAccount.TabIndex = 4;
            // 
            // txt_passWord2
            // 
            this.txt_passWord2.Depth = 0;
            this.txt_passWord2.Hint = "Mật khẩu";
            this.txt_passWord2.Location = new System.Drawing.Point(281, 166);
            this.txt_passWord2.MaxLength = 50;
            this.txt_passWord2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_passWord2.Name = "txt_passWord2";
            this.txt_passWord2.PasswordChar = '*';
            this.txt_passWord2.SelectedText = "";
            this.txt_passWord2.SelectionLength = 0;
            this.txt_passWord2.SelectionStart = 0;
            this.txt_passWord2.Size = new System.Drawing.Size(263, 39);
            this.txt_passWord2.TabIndex = 3;
            this.txt_passWord2.TabStop = false;
            this.txt_passWord2.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nhập lại mật khẩu :";
            // 
            // txt_displayName
            // 
            this.txt_displayName.Depth = 0;
            this.txt_displayName.Hint = "Nhập tên hiển thị ở đây";
            this.txt_displayName.Location = new System.Drawing.Point(281, 53);
            this.txt_displayName.MaxLength = 50;
            this.txt_displayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_displayName.Name = "txt_displayName";
            this.txt_displayName.PasswordChar = '\0';
            this.txt_displayName.SelectedText = "";
            this.txt_displayName.SelectionLength = 0;
            this.txt_displayName.SelectionStart = 0;
            this.txt_displayName.Size = new System.Drawing.Size(310, 39);
            this.txt_displayName.TabIndex = 1;
            this.txt_displayName.TabStop = false;
            this.txt_displayName.UseSystemPasswordChar = false;
            // 
            // txt_passWord1
            // 
            this.txt_passWord1.Depth = 0;
            this.txt_passWord1.Hint = "Mật khẩu";
            this.txt_passWord1.Location = new System.Drawing.Point(281, 105);
            this.txt_passWord1.MaxLength = 50;
            this.txt_passWord1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_passWord1.Name = "txt_passWord1";
            this.txt_passWord1.PasswordChar = '*';
            this.txt_passWord1.SelectedText = "";
            this.txt_passWord1.SelectionLength = 0;
            this.txt_passWord1.SelectionStart = 0;
            this.txt_passWord1.Size = new System.Drawing.Size(263, 39);
            this.txt_passWord1.TabIndex = 2;
            this.txt_passWord1.TabStop = false;
            this.txt_passWord1.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập mật khẩu :";
            // 
            // txt_userName
            // 
            this.txt_userName.Depth = 0;
            this.txt_userName.Hint = "Nhập tên ở đây";
            this.txt_userName.Location = new System.Drawing.Point(10, 53);
            this.txt_userName.MaxLength = 50;
            this.txt_userName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.PasswordChar = '\0';
            this.txt_userName.SelectedText = "";
            this.txt_userName.SelectionLength = 0;
            this.txt_userName.SelectionStart = 0;
            this.txt_userName.Size = new System.Drawing.Size(210, 39);
            this.txt_userName.TabIndex = 0;
            this.txt_userName.TabStop = false;
            this.txt_userName.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhập tên tài khoản và tên hiển thị bạn muốn thêm vào :";
            // 
            // btn_OKAdd
            // 
            this.btn_OKAdd.ActiveBorderThickness = 1;
            this.btn_OKAdd.ActiveCornerRadius = 20;
            this.btn_OKAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_OKAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btn_OKAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OKAdd.BackColor = System.Drawing.Color.White;
            this.btn_OKAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OKAdd.BackgroundImage")));
            this.btn_OKAdd.ButtonText = "OK";
            this.btn_OKAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OKAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKAdd.ForeColor = System.Drawing.Color.Black;
            this.btn_OKAdd.IdleBorderThickness = 1;
            this.btn_OKAdd.IdleCornerRadius = 20;
            this.btn_OKAdd.IdleFillColor = System.Drawing.Color.White;
            this.btn_OKAdd.IdleForecolor = System.Drawing.Color.Red;
            this.btn_OKAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_OKAdd.Location = new System.Drawing.Point(10, 293);
            this.btn_OKAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OKAdd.Name = "btn_OKAdd";
            this.btn_OKAdd.Size = new System.Drawing.Size(94, 55);
            this.btn_OKAdd.TabIndex = 5;
            this.btn_OKAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OKAdd.Click += new System.EventHandler(this.btn_OKAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txt_PassChange2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtPassChange1);
            this.tabPage2.Controls.Add(this.cb_listUserName1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_okFix);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đổi mặt khẩu";
            // 
            // txt_PassChange2
            // 
            this.txt_PassChange2.Depth = 0;
            this.txt_PassChange2.Hint = "Nhập lại mật khẩu mới";
            this.txt_PassChange2.Location = new System.Drawing.Point(10, 232);
            this.txt_PassChange2.MaxLength = 50;
            this.txt_PassChange2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_PassChange2.Name = "txt_PassChange2";
            this.txt_PassChange2.PasswordChar = '\0';
            this.txt_PassChange2.SelectedText = "";
            this.txt_PassChange2.SelectionLength = 0;
            this.txt_PassChange2.SelectionStart = 0;
            this.txt_PassChange2.Size = new System.Drawing.Size(396, 39);
            this.txt_PassChange2.TabIndex = 25;
            this.txt_PassChange2.TabStop = false;
            this.txt_PassChange2.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nhập mật khẩu mới :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nhập mật khẩu mới :";
            // 
            // txtPassChange1
            // 
            this.txtPassChange1.Depth = 0;
            this.txtPassChange1.Hint = "Nhập mật khẩu mới";
            this.txtPassChange1.Location = new System.Drawing.Point(10, 133);
            this.txtPassChange1.MaxLength = 50;
            this.txtPassChange1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassChange1.Name = "txtPassChange1";
            this.txtPassChange1.PasswordChar = '\0';
            this.txtPassChange1.SelectedText = "";
            this.txtPassChange1.SelectionLength = 0;
            this.txtPassChange1.SelectionStart = 0;
            this.txtPassChange1.Size = new System.Drawing.Size(396, 39);
            this.txtPassChange1.TabIndex = 5;
            this.txtPassChange1.TabStop = false;
            this.txtPassChange1.UseSystemPasswordChar = false;
            // 
            // cb_listUserName1
            // 
            this.cb_listUserName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listUserName1.FormattingEnabled = true;
            this.cb_listUserName1.Location = new System.Drawing.Point(10, 43);
            this.cb_listUserName1.Name = "cb_listUserName1";
            this.cb_listUserName1.Size = new System.Drawing.Size(396, 21);
            this.cb_listUserName1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Chọn tài khoản mà bạn muốn đổi mật khẩu :";
            // 
            // btn_okFix
            // 
            this.btn_okFix.ActiveBorderThickness = 1;
            this.btn_okFix.ActiveCornerRadius = 20;
            this.btn_okFix.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_okFix.ActiveForecolor = System.Drawing.Color.White;
            this.btn_okFix.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_okFix.BackColor = System.Drawing.Color.White;
            this.btn_okFix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_okFix.BackgroundImage")));
            this.btn_okFix.ButtonText = "OK";
            this.btn_okFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_okFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okFix.ForeColor = System.Drawing.Color.Black;
            this.btn_okFix.IdleBorderThickness = 1;
            this.btn_okFix.IdleCornerRadius = 20;
            this.btn_okFix.IdleFillColor = System.Drawing.Color.White;
            this.btn_okFix.IdleForecolor = System.Drawing.Color.Red;
            this.btn_okFix.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_okFix.Location = new System.Drawing.Point(10, 279);
            this.btn_okFix.Margin = new System.Windows.Forms.Padding(5);
            this.btn_okFix.Name = "btn_okFix";
            this.btn_okFix.Size = new System.Drawing.Size(94, 55);
            this.btn_okFix.TabIndex = 19;
            this.btn_okFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_okFix.Click += new System.EventHandler(this.btn_okFix_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cb_listUserName2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btn_OkDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(700, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xóa tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(438, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lưu ý : Khi xóa một tài khoản , bạn không thể phục hồi lại tài khoản đó\r\n";
            // 
            // cb_listUserName2
            // 
            this.cb_listUserName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listUserName2.FormattingEnabled = true;
            this.cb_listUserName2.Location = new System.Drawing.Point(10, 57);
            this.cb_listUserName2.Name = "cb_listUserName2";
            this.cb_listUserName2.Size = new System.Drawing.Size(299, 21);
            this.cb_listUserName2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Chọn tài khoản mà bạn muốn xóa :";
            // 
            // btn_OkDelete
            // 
            this.btn_OkDelete.ActiveBorderThickness = 1;
            this.btn_OkDelete.ActiveCornerRadius = 20;
            this.btn_OkDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_OkDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_OkDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OkDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_OkDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OkDelete.BackgroundImage")));
            this.btn_OkDelete.ButtonText = "OK";
            this.btn_OkDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkDelete.ForeColor = System.Drawing.Color.Black;
            this.btn_OkDelete.IdleBorderThickness = 1;
            this.btn_OkDelete.IdleCornerRadius = 20;
            this.btn_OkDelete.IdleFillColor = System.Drawing.Color.White;
            this.btn_OkDelete.IdleForecolor = System.Drawing.Color.Red;
            this.btn_OkDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_OkDelete.Location = new System.Drawing.Point(10, 250);
            this.btn_OkDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OkDelete.Name = "btn_OkDelete";
            this.btn_OkDelete.Size = new System.Drawing.Size(94, 55);
            this.btn_OkDelete.TabIndex = 18;
            this.btn_OkDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OkDelete.Click += new System.EventHandler(this.btn_OkDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Chỉnh Sửa Danh Mục Các Món Ăn";
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Account)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_passWord1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_userName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_OKAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassChange1;
        private System.Windows.Forms.ComboBox cb_listUserName1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_okFix;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_listUserName2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_OkDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_typeAccount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_passWord2;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_displayName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_PassChange2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_Account;
    }
}
