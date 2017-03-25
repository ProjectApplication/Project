using RoverCoffeManage2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                    return FoodDAO.instance;
            }
            set
            {
                instance = value;
            }
        }


        public List<Food> listFood (string id)
        {
            List<Food> listFood = new List<Food>();

            //DataTable data = DataProvider.Instance.ExecuteQuery("USP_showAllfood"); // show tất cả món ăn
            DataTable data = DataProvider.Instance.ExecuteQuery("showFoodByFoodCategoryId " + id);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);

                listFood.Add(food);
            }
            return listFood;
        }
    }

}
