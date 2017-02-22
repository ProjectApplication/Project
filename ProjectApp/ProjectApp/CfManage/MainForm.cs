using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            load();
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
        //hàm này dùng để load dữ liệu
        private void load()
        {
            string connectionDTB = @"Data Source=DESKTOP-A1GD3SD\SQLEXPRESS;Initial Catalog=RoverCafe;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionDTB);
            // kết nối đến cơ sở dữ liệu

            string query = "SELECT * FROM dbo.Account";
            // câu query...

            connection.Open();//mở kết nối
            SqlCommand command = new SqlCommand(query, connection);//khởi tạo lệnh

            DataTable data = new DataTable();// tạo bảng dữ liệu

            SqlDataAdapter adapter = new SqlDataAdapter(command);//đổ ra 1 bảng giữ liệu adapter

            adapter.Fill(data);//điền dữ liệu này vào data

            connection.Close();//làm xong nhớ đóng kết nối

            DTGV_main.DataSource = data; //cho dtgv = bảng data
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin formadmin = new fAdmin();
            this.Hide();
            formadmin.ShowDialog();
            this.Show();
        }
    }
}
