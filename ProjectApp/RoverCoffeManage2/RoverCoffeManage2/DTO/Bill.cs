using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DTO
{
    public class BillInfo
    {
        private string id;

        private string idBill;

        private string idFood;

        private int quantity;

        private int discount;

        private string note;
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

        public string IdBill
        {
            get
            {
                return idBill;
            }

            set
            {
                idBill = value;
            }
        }

        public string IdFood
        {
            get
            {
                return idFood;
            }

            set
            {
                idFood = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
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

        public BillInfo(string id,string idBill, string idFood ,int quantity =0,int discount=0,string note="Không Có Ghi Chú")
        {
            this.id = id;
            this.idBill = idBill;
            this.idFood = idFood;
            this.quantity = quantity;
            this.discount = discount;
           this.note=note;
        }
        

    }
}
