using RoverCoffeManage2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public int insertBill(int idTable, int discount)
        {
            return DataProvider.Instance.ExecuteNonQuery("proc_InsertBill " + idTable + "," + discount);
        }
        public int getIdOfLastRowBill()
        {
             return   (int)DataProvider.Instance.ExecuteScalar("proc_GetIdOfLastRowBill");
        }
    }
}
