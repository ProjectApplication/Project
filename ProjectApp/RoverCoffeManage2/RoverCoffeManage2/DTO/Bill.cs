using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DTO
{
    public class Bill
    {
        private string foodName;

        private int number;

        private double price;

        private float dissCount;

        private string note;
        public Bill(string foodName, int number, double price ,float dissCount =0,string note="")
        {
            this.foodName = foodName;
            this.number = number;
            this.price = price;
            this.dissCount = dissCount;
            if (note == "") this.note = "Không có ghi chú";
        }

        public string FoodName
        {
            get
            {
                return foodName;
            }

            set
            {
                foodName = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
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

        public float DissCount
        {
            get
            {
                return dissCount;
            }

            set
            {
                dissCount = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }
    }
}
