using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DTO
{
    class FoodQuantity
    {
        private string id;
        private string nameFood;
        private int num;

        public string NameFood
        {
            get { return nameFood; }

            set { nameFood = value; }
        }

        public int Num
        {
            get { return num; }

            set { num = value; }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public FoodQuantity(DataRow data)
        {
            this.nameFood = data["Tên"].ToString();
            this.num = (int) data["Số lượng"];
            this.id = data["ID"].ToString();
        }

        public FoodQuantity(string id, string nameFood, int num)
        {
            this.id = id;
            this.nameFood = nameFood;
            this.num = num;
        }
    }
}
