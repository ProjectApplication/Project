using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverCoffeManage2.DTO;

namespace RoverCoffeManage2.DAO
{
    class StatisticsQuantityDAO
    {
        private static StatisticsQuantityDAO instance;
        public static StatisticsQuantityDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StatisticsQuantityDAO();
                return StatisticsQuantityDAO.instance;
            }
            set
            {
                instance = value;
            }
        }

  
        public DataTable getStatistics(DateTime dtBegin,DateTime dtEnd)
        {
            string query = "proc_Statistics @dateBegin , @dateEnd";
            string dateBegin = dtBegin.Date.ToString("yyyy-MM-dd");
            string dateEnd = dtEnd.Date.ToString("yyyy-MM-dd");
            //Lấy ra bảng dữ liệu account
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateBegin,dateEnd });
            return result;
        }
        public List<FoodQuantity> getList(DataTable data)
        {
            List<FoodQuantity> listStatisticses = new List<FoodQuantity>();
            foreach (DataRow item in data.Rows)
            {
                FoodQuantity statistics = new FoodQuantity(item);
                listStatisticses.Add(statistics);
            }
            return listStatisticses;
        }
    }
}
