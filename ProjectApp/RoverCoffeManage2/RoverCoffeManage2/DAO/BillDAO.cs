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
        //public DataRow getBill(string foodName, int number, double price, float dissCount = 0, string note = "")
        //{

        //    DataTable table = new DataTable();

        //    DataRow billInfo = table.NewRow();
        //  //  Bill bill= new Bill(foodName, number, price, dissCount, note);
        //    //billInfo[0] = bill.FoodName;
        //    //billInfo[1] = bill.Number;
        //    //billInfo[2] = bill.Price;
        //    //billInfo[3] = bill.DissCount;
        //    //billInfo[4] = bill.Note;
             
            
            
        //    return billInfo;
        //} 
    }
}
