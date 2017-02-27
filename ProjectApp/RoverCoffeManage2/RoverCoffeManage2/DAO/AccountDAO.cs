using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoverCoffeManage2.DAO
{
    class AccountDAO
    {

        // Hạn chế việc tạo AccountDao nhiều lần phát sinh các connection để chỉ tạo duy nhất 1 lần
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }


        //Kiểm tra tài khoản và mật khẩu có nằm trong database hay không 
        public bool Login(string userName, string passWord)
        {
            
            // truy vấn các username và password trong database để kiểm tra
            string query = "USP_Login @userName , @passWord";


            //Lấy ra bảng dữ liệu account
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {userName,passWord});

            //Trả về số dòng đã tìm được 
            return result.Rows.Count > 0;
        }
        public int getTypeOfAccount(string username)
        {
            // câu lệnh này dùng để get giá trị type của account
            return(int) DataProvider.Instance.ExecuteScalar("SELECT  dbo.Account.Type FROM dbo.Account WHERE UserName = '" + username + "'");
            
        }
        public void addUserName(ComboBox a)
        {
            // Thay đổi giá trị của combo box username tại đây
            // hàm này lấy giá trị từng hàng của table 
            foreach (DataRow row in DAO.DataProvider.Instance.ExecuteQuery("SELECT dbo.Account.UserName FROM dbo.Account").Rows)
                //hàm này để add giá trị từng hàng của cột username 
                a.Items.Add((string)row["UserName"]);
        }
    }
}