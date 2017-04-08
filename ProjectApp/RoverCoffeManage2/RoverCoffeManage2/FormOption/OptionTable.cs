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

namespace RoverCoffeManage2
{
    public partial class OptionTable : UserControl
    {
        public OptionTable()
        {
            InitializeComponent();
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) // hàm này chỉ cho phép nhập số , không cho nhập chữ và dấu
                e.Handled = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_quantity.Text != "")
            {
                TableDAO.Instance.settingTable(int.Parse(txt_quantity.Text.ToString()));
                MessageBox.Show("Thành Công");
                MessageBox.Show("Bạn cần reset lại chương trình");
            }
            else
                MessageBox.Show("Bạn cần nhập số lượng bàn mà bạn muốn thay đổi");
        }
    }
}
