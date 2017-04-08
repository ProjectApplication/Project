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
                    return instance;
            }
            set
            {
                instance = value;
            }
        }

        // hàm này lấy danh sách món ăn của 1 danh mục 
        public List<Food> listFood(string id)
        {
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("proc_ShowFoodByFoodCategoryId " + id);// lấy Datatable của tất cả món ăn
            foreach (DataRow item in data.Rows)//mỗi item là 1 Food ở database
            {
                Food food = new Food(item);

                listFood.Add(food);
            }
            return listFood;// trả lại danh sách thứ ăn dưới dạng List<Food>
        }
        //hàm này lấy id của món ăn ở bill vừa mới xuất
        public string getIdFood(string nameOfFood)
        {
            return (string)DataProvider.Instance.ExecuteScalar("proc_GetIdFood " + "N'" +nameOfFood+ "'");//hàm này trả lại id của món 
        }
    }

}
