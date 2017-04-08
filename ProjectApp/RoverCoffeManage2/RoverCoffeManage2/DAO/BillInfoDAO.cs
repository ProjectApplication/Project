using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DAO
{
   public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public void insertBillInfo(int idBill,string IDfood,int quantity,int discount,string note)
        {
            DataProvider.Instance.ExecuteNonQuery("proc_InsertBillInfo " + idBill + ",N'" + IDfood + "'," + quantity + "," + discount + ",N'" + note + "'");

        }
    }
}
