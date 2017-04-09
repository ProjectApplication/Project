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
        public List<FoodCategory> LoadFoodCategoryList()
        {
            List<FoodCategory> tableList = new List<FoodCategory>();

            DataTable data = DataProvider.Instance.ExecuteQuery("proc_GetFoodCategory");

            foreach (DataRow item in data.Rows)
            {
                FoodCategory foodCategory = new FoodCategory(item);
                tableList.Add(foodCategory);
            }

            return tableList;
        }
        public List<string> loadIdFoodCategory()
        {
            List<string> listID = new List<string>();
            DataTable data = DataProvider.Instance.ExecuteQuery("proc_GetIdFoodCategory");
            foreach (DataRow item in data.Rows)
                listID.Add(item[0].ToString());
          
            return listID;
        }
        public string getIdFoodCategoryByName(string name)
        {
            return (string)DataProvider.Instance.ExecuteScalar("proc_GetIdFoodCategoryByName " + "N'" + name + "'");
        }
        public int insertFoodCategory(string id, string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("proc_InsertFoodCategory " + "N'" + id + "'," +"N'"+ name+"'");
        }
        public int updateFoodCategory(string newname ,string oldname)
        {
            return DataProvider.Instance.ExecuteNonQuery("proc_UpdateNameFoodCategory " + "N'" + oldname + "'," + "N'" + newname + "'");
        }
        public void addFoodCategoryToComboBox(ComboBox combobox)
        {
            // Thay đổi giá trị của combo box username tại đây
            // hàm này lấy giá trị từng hàng của table 
            foreach (DataRow row in DAO.DataProvider.Instance.ExecuteQuery("proc_GetFoodNameFoodCategory").Rows)
                //hàm này để add giá trị từng hàng của cột username 
                combobox.Items.Add((string)row["name"]);
        }
        public int deleteFoodCategory(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("proc_DeleteFoodCategory " + "N'" + name + "'");
        }
    }
}
