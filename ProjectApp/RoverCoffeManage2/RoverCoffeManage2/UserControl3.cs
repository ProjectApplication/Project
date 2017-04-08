using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoverCoffeManage2.DAO;
using RoverCoffeManage2.DTO;

namespace RoverCoffeManage2
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void btnMonthBillSearch_Click(object sender, EventArgs e)
        {
            foreach (var value in chartMonth.Series)
            {
                value.Points.Clear();
            }
            DataTable dtTable = StatisticsBillDAO.Instance.getStatisticsBillOfMonth(cbMonth.Text, cbYearOfMonth.Text);
            dgvMonth.DataSource = dtTable;
            List<TotalOfBill> listBill = StatisticsBillDAO.Instance.getList(dtTable);
            foreach (var value in listBill)
            {
                chartMonth.Series[0].Points.AddXY(value.Id, value.Total);
            }
        }
    }
}
