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
    public partial class fSubform : Form
    {
        public fSubform()
        {
            InitializeComponent();
        }
        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        public List<string> getListInfoFromSubForm()
        {
            List<string> listInfo = new List<string>();
            listInfo.Add(txt_Numberic.Text = txt_Numberic.Text=="" ? null:txt_Numberic.Text);
            listInfo.Add(txt_DissCount.Text = txt_DissCount.Text == "" ? "0" : txt_DissCount.Text);
            listInfo.Add(txt_Note.Text=txt_Note.Text=="" ? "Không có ghi chú":txt_Note.Text);
            return listInfo;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Tag = getListInfoFromSubForm();
            Close();
        }

        private void txt_Numberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                // hàm này chỉ cho phép nhập số , không cho nhập chữ và dấu
                e.Handled = true;
        }

        private void txt_DissCount_Leave(object sender, EventArgs e)
        {
            if (txt_DissCount.Text != "")
                if (int.Parse(txt_DissCount.Text.ToString()) >= 100)
                    {
                    MessageBox.Show("Không được giảm giá quá 100%");
                    txt_DissCount.Text = "";
                    }
        }
    }
}
