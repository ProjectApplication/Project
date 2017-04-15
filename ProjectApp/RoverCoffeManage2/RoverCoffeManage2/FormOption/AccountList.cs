using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoverCoffeManage2.DAO;

namespace RoverCoffeManage2.FormOption
{
    public partial class AccountList : UserControl
    {
        public AccountList()
        {
            InitializeComponent();
            loadComponent();
        }
        public void loadComponent()
        {
            dtgv_Account.DataSource = AccountDAO.Instance.getUserName();
            AccountDAO.Instance.addUserName(cb_listUserName1);
            AccountDAO.Instance.addUserName(cb_listUserName2);
        }

        private void btn_OKAdd_Click(object sender, EventArgs e)
        {
            if (txt_userName.Text != "" && txt_displayName.Text != "" && txt_passWord1.Text != "" && txt_passWord2.Text != "" && cb_typeAccount.Text != "")
            {
                if (txt_passWord1.Text != txt_passWord2.Text) MessageBox.Show("Bạn phải nhập đúng mật khẩu đã nhập trước đó ");
                 else
                {

                    if (cb_listUserName1.Items.Contains(txt_userName.Text.ToString())) MessageBox.Show("Trùng tên đăng nhập");
                    else
                    { 
                    int type = cb_typeAccount.Text == "Admin" ? 0 : 1;
                        AccountDAO.Instance.insertAccount(txt_userName.Text, txt_displayName.Text, txt_passWord1.Text, type);
                        MessageBox.Show("Đã thêm thành công");
                    }
                }
                       
            }
            else MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
        }

        private void btn_okFix_Click(object sender, EventArgs e)
        {
            if(cb_listUserName1.Text !="" && txtPassChange1.Text !="" && txt_PassChange2.Text!="")
            {
                if (txtPassChange1.Text != txt_PassChange2.Text) MessageBox.Show("Bạn phải nhập đúng mật khẩu đã nhập trước đó ");
                else
                {
                    AccountDAO.Instance.changePassWord(cb_listUserName1.Text, txtPassChange1.Text);
                    MessageBox.Show("Đã sửa thành công");
                }
            }
            else MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
        }

        private void btn_OkDelete_Click(object sender, EventArgs e)
        {
            if (cb_listUserName2.Text != "")
            {
                AccountDAO.Instance.deleteAccount(cb_listUserName2.Text);
                MessageBox.Show("Đã xóa thành công");
            }
            else MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
        }
    }
}
