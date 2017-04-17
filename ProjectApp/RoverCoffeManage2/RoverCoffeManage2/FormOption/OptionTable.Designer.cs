namespace RoverCoffeManage2
{
    partial class OptionTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_quantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(358, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(356, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Số Lượng Bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Location = new System.Drawing.Point(1, 50);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(404, 414);
            this.flpTable.TabIndex = 1;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.btn_OK);
            this.bunifuCards1.Controls.Add(this.txt_quantity);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(410, 50);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(437, 414);
            this.bunifuCards1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 57);
            this.label3.TabIndex = 17;
            this.label3.Text = "Xin lưu ý : \r\n1)Khi cài đặt lại số bàn thì mọi thông tin về hóa đơn liên quan sẽ " +
    "bị xóa \r\n2)Sau khi tùy chỉnh lại số lượng bàn , bạn cần chạy lại chương trình";
            // 
            // btn_OK
            // 
            this.btn_OK.ActiveBorderThickness = 1;
            this.btn_OK.ActiveCornerRadius = 20;
            this.btn_OK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_OK.ActiveForecolor = System.Drawing.Color.White;
            this.btn_OK.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OK.BackColor = System.Drawing.Color.White;
            this.btn_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OK.BackgroundImage")));
            this.btn_OK.ButtonText = "OK";
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.IdleBorderThickness = 1;
            this.btn_OK.IdleCornerRadius = 20;
            this.btn_OK.IdleFillColor = System.Drawing.Color.White;
            this.btn_OK.IdleForecolor = System.Drawing.Color.Red;
            this.btn_OK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.btn_OK.Location = new System.Drawing.Point(7, 137);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 55);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Depth = 0;
            this.txt_quantity.Hint = "Nhập số lượng ở đây";
            this.txt_quantity.Location = new System.Drawing.Point(7, 61);
            this.txt_quantity.MaxLength = 3;
            this.txt_quantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.Size = new System.Drawing.Size(263, 39);
            this.txt_quantity.TabIndex = 2;
            this.txt_quantity.TabStop = false;
            this.txt_quantity.UseSystemPasswordChar = false;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số lượng bàn mà bạn muốn thay đổi :";
            // 
            // OptionTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.Name = "OptionTable";
            this.Size = new System.Drawing.Size(1366, 737);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flpTable;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_quantity;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_OK;
        private System.Windows.Forms.Label label3;
    }
}
