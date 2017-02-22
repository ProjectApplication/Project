using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CfManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Hàm này tương đương với nút close
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;//hủy event e
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//Hàm này tương đương với nút close
        }
        //Khi click vào nút login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();//khởi tạo form chính
            this.Hide();//ẩn form login
            f.ShowDialog();// hiện form chính, khi nào tắt form chính thì mới chạy lệnh tiếp theo
            this.Show();//hiện form login
        }
    }
}
