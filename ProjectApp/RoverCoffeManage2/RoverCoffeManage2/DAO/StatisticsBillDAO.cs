using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverCoffeManage2.DTO;

namespace RoverCoffeManage2.DAO
{
    class StatisticsBillDAO
    {
        private static StatisticsBillDAO instance;
        public static StatisticsBillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StatisticsBillDAO();
                return StatisticsBillDAO.instance;
            }
            set
            {
                instance = value;
            }
        }

        public DataTable getStatisticsBillOfDay(DateTime dtBegin, DateTime dtEnd)
        {
            string query = "proc_getSumPriceOfBill  @dateBegin , @dateEnd ";
            string dateBegin = dtBegin.Date.ToString("yyyy-MM-dd");
            string dateEnd = dtEnd.Date.ToString("yyyy-MM-dd");
            //Lấy ra bảng dữ liệu account
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateBegin, dateEnd });
            return result;
        }

        public DataTable getStatisticsBillOfMonth(string month,string year)
        {
            string query = "proc_BillMonth @month , @year ";
            //Lấy ra bảng dữ liệu account
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {month, year});
            return result;
        }

        public DataTable getStatisticsBillOfYear(string year)
        {
            string query = "proc_BillYear @year ";
            //Lấy ra bảng dữ liệu account
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { year });
            return result;
        }


        public List<TotalOfBill> getList(DataTable data)
        {
            List<TotalOfBill> listStatisticses = new List<TotalOfBill>();
            foreach (DataRow item in data.Rows)
            {
                TotalOfBill statistics = new TotalOfBill(item);
                listStatisticses.Add(statistics);
            }
            return listStatisticses;
        }

    }
}
