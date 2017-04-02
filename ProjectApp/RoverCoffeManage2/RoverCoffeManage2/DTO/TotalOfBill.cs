using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverCoffeManage2.DTO
{
    class TotalOfBill
    {
        private string id;
        private double total;
        private DateTime dateTimeOfBill;
   
        public TotalOfBill(DataRow data)
        {
            this.id = data["ID"].ToString();
            this.total = (double) data["Thành tiền"];
            try
            {
                this.dateTimeOfBill = (DateTime) data["Ngày"];
            }
            catch (Exception e)
            {
                
            }
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

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public DateTime DateTimeOfBill
        {
            get
            {
                return dateTimeOfBill;
            }

            set
            {
                dateTimeOfBill = value;
            }
        }
    }
}
