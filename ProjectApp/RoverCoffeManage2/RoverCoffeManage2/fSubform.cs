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
            this.Close();
        }
        public List<string> getListInfoFromSubForm()
        {
            List<string> listInfo = new List<string>();
            listInfo.Add(txt_Numberic.Text = txt_Numberic.Text=="" ? "0":txt_Numberic.Text);
            listInfo.Add(txt_Note.Text=txt_Note.Text=="" ? null:txt_Note.Text);
            listInfo.Add(txt_DissCount.Text =txt_DissCount.Text==""? "0":txt_DissCount.Text);
            listInfo.Add(txt_Bonus.Text = txt_Bonus.Text==""?"0":txt_Bonus.Text);
            return listInfo;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Tag=getListInfoFromSubForm();
            this.Close();
        }
    }
}
