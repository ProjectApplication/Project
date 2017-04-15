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
    public partial class StatisticYear : UserControl
    {
        public StatisticYear()
        {
            InitializeComponent();
        }

        private void btnYearSearch_Click(object sender, EventArgs e)
        {
            foreach (var value in chartYeah.Series)
            {
                value.Points.Clear();
            }
            DataTable dtTable = StatisticsBillDAO.Instance.getStatisticsBillOfYear(cbYear.Text);
            dgvYear.DataSource = dtTable;
            List<TotalOfBill> listBill = StatisticsBillDAO.Instance.getList(dtTable);
            foreach (var value in listBill)
            {
                chartYeah.Series[0].Points.AddXY(value.Id, value.Total);
            }
            long totalPrice = 0;
            foreach (DataGridViewRow item in dgvYear.Rows)
            {
                if (item.Cells[1].Value != null)
                    totalPrice += long.Parse(item.Cells[1].Value.ToString());
            }

            lb_totalPriceYear.Text = totalPrice.ToString() + " VND";
        }
    }
}
