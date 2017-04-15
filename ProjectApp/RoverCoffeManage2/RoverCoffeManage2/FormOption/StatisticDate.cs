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
          
           
            DataTable dtTable = StatisticsBillDAO.Instance.getStatisticsBillOfDay(dtpTotalBegin.Value, dtpTotalBegin.Value.AddDays(1));
            dgvTotalStatistics.DataSource = dtTable;
            List<TotalOfBill> listStatisticses = StatisticsBillDAO.Instance.getList(dtTable);

            foreach (var value in listStatisticses)
            {
                chartTotalStatistics.Series[0].Points.AddXY(value.Id, value.Total);
            }

            long totalPrice = 0;
            foreach(DataGridViewRow item in dgvTotalStatistics.Rows)
                if (item.Cells[2].Value !=null)
               totalPrice += long.Parse(item.Cells[4].Value.ToString());
            lb_totalPrice.Text = totalPrice.ToString()+"  VND";            
        }
    }
}
