using RoverCoffeManage2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<Food> listFood()
        {
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("proc_ShowAllFood");// lấy Datatable của tất cả món ăn
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
            return (string)DataProvider.Instance.ExecuteScalar("proc_GetIdFood " + "N'" + nameOfFood + "'");//hàm này trả lại id của món 
        }
        public List<string> getIdFood()
        {
            List<string> listID = new List<string>();
            DataTable data = DataProvider.Instance.ExecuteQuery("proc_GetFullIDFood");
            foreach (DataRow item in data.Rows)
                listID.Add(item[0].ToString());

            return listID;
        }
        public int insertFood(string id, string name, string idCate, int price)
        {
            return DataProvider.Instance.ExecuteNonQuery("proc_InsertFood " + "N'" + id + "' , N'" + name + "' , N'" + idCate + "' ," + price);
        }

        public void addFoodToComboBox(ComboBox combobox, string categoryName)
        {
            // Thay đổi giá trị của combo box username tại đây
            // hàm này lấy giá trị từng hàng của table 
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery("proc_ShowFoodByCategoryName " + "N'" + categoryName + "'").Rows)
                //hàm này để add giá trị từng hàng của cột username 
                combobox.Items.Add((string)row["name"]);
        }
        public int updateFood(string newName, string oldName, int price)
        {
            return DataProvider.Instance.ExecuteNonQuery("pro_UpdateFood "+ "N'" + newName + "' , N'" + oldName + "',"+ price);
        }
        public int deleteFood(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("proc_DeleteFood " + "N'" + name + "'");
        }
    }

}
