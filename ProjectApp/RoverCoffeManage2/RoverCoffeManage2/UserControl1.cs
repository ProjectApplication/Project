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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void btnQuantitySearch_Click(object sender, EventArgs e)
        {
            foreach (var value in chartQuantityStatistics.Series)
            {
                value.Points.Clear();
            }
            DataTable dtTable = StatisticsQuantityDAO.Instance.getStatistics(dtpQuantityBegin.Value, dtpQuantityEnd.Value);
            dgvQuantityStatistics.DataSource = dtTable;
            List<FoodQuantity> listStatisticses = StatisticsQuantityDAO.Instance.getList(dtTable);

            foreach (var value in listStatisticses)
            {
                chartQuantityStatistics.Series[0].Points.AddXY(value.Id, value.Num);
            }
        }
    }
}
