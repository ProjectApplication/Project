using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DTO
{
    public class FoodCategory
    {
        private string id;
        private string name;
        public FoodCategory(string id ,string name)
        {
            this.id = id;
            this.name = name;
        }
        public FoodCategory(DataRow data)
        {
            this.id = data["id"].ToString();
            this.name = data["name"].ToString();
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
