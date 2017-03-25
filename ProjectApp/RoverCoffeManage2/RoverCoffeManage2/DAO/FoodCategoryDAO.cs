using RoverCoffeManage2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;
            // hot key tạo instance ctrl + r + e
        public static FoodCategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance;
            }

            set
            {
                FoodCategoryDAO.instance = value;
            }
        }
        //public DataTable LoadFoodCategoryList()
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("USP_getNameOfFoodCategory");// thực hiện thủ tục để lấy về thông tin danh mục thức ăn
        //    return data;
        //}
        public List<FoodCategory> LoadFoodCategoryList()
        {
            List<FoodCategory> tableList = new List<FoodCategory>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_getFoodCategory");

            foreach (DataRow item in data.Rows)
            {
                FoodCategory foodCategory = new FoodCategory(item);
                tableList.Add(foodCategory);
            }

            return tableList;
        }
    }
}
