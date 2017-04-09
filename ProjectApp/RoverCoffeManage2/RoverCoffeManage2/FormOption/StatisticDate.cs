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
    public partial class StatisticDate : UserControl
    {
        public StatisticDate()
        {
            InitializeComponent();
        }

        private void btnTotalSearch_Click(object sender, EventArgs e)
        {
            foreach (var value in chartTotalStatistics.Series)
            {
                value.Points.Clear();
            }
            DataTable dtTable = StatisticsBillDAO.Instance.getStatisticsBillOfDay(dtpTotalBegin.Value, dtpTotalEnd.Value);
            dgvTotalStatistics.DataSource = dtTable;
            List<TotalOfBill> listStatisticses = StatisticsBillDAO.Instance.getList(dtTable);

            foreach (var value in listStatisticses)
            {
                Console.WriteLine("Hello");
                chartTotalStatistics.Series[0].Points.AddXY(value.Id, value.Total);
            }
        }
    }
}
