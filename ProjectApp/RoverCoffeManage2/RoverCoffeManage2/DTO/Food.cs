using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DTO
{
    public class Food
    {
        private string id;
        private string name;
        private string idCategory;
        private double price;
        public Food(string id , string name,string idCategory,double price)
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.price = price;
        }
        public Food(DataRow data)
        {
            this.id = data["id"].ToString();
            this.name = data["name"].ToString();
            this.idCategory = data["idCategory"].ToString();
            this.price = (double)data["price"];
        }
        #region get/set
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

        public string IdCategory
        {
            get
            {
                return idCategory;
            }

            set
            {
                idCategory = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        #endregion
    }
}
