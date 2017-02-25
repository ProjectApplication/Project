using CustomForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoverCoffeManage2
{
    public partial class fLogin : MyForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = cbUserName.Text;
            String password = tbPassWord.Text;
            if (Login(username, password))
            {
                fAdmin fadmin = new fAdmin();
                this.Hide();//ẩn form login
                fadmin.ShowDialog();//hiện form admin
                this.Show();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }
        private bool Login(String username,String password)
        {
            return DAO.AccountDAO.Instance.Login(username, password);
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
