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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //hàm này hiển thị form info account
        private void MnTripInfo_Click(object sender, EventArgs e)
        {
            finfoAccount f = new finfoAccount();//khởi tạo form info account
            this.Hide();//ẩn form chính
            f.ShowDialog();//hiển thị form info
            this.Show();//hiển thị form chính
        }
        //hàm đăng xuất
        private void MntripOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đăng xuất ?","Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
    }
}
