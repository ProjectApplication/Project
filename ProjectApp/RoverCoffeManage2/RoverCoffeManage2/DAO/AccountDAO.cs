using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            //Lấy ra bảng dữ liệu account
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            //Trả về số dòng đã tìm được 
            return result.Rows.Count > 0;
        }
    }
}