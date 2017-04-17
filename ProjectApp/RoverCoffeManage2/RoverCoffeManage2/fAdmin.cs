using CustomForm;
using MaterialSkin.Controls;
using RoverCoffeManage2.DAO;
using RoverCoffeManage2.DTO;
using RoverCoffeManage2.FormOption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RoverCoffeManage2
{
    public partial class fAdmin : MyForm
    {
        public fAdmin()
        {
            InitializeComponent();
            loadTable(flpTable); // gọi từ method load table
            loadFoodCategory(flpCategory); // gọi từ method load foodcategory
        }

        #region HomePage

        #region Method load table

        // hàm load dữ liệu của bàn ăn
        public void loadTable(FlowLayoutPanel flp)
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList(); // lấy list table

            foreach (Table item in tableList)
            {
                Button btn = new Button(); // khởi tạo 1 button mới
                btn.Text = item.Name + Environment.NewLine + item.Status; //set text cho button
                btn.Cursor = Cursors.Hand; //khi chỉ vào button thì có hình bàn tay
                btn.ForeColor = Color.White; // màu chữ
                btn.Font = new Font("UTM Penumbra", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                //set font , size,kiểu chữ
                btn.FlatAppearance.BorderColor = Color.White; // chỉnh màu viền
                btn.FlatAppearance.BorderSize = 0; // size border
                btn.FlatAppearance.MouseDownBackColor = Color.White; //set màu khi nhắn button
                btn.FlatAppearance.MouseOverBackColor = Color.White; // set màu khi rê chuột qua button
                btn.FlatStyle = FlatStyle.Flat; // set style =flat
                btn.Size = new Size(100, 100); // kích thước button
                btn.Click += new EventHandler(btnTable_Click);
                ; // hàm này dùng để khởi tạo event cho mỗi button
                btn.Tag = item; // gắn đối tượng item cho mỗi btn , để dễ quản lý
                switch (item.Status)
                {
                    case "Trống": // nếu bàn nào còn trống thì chỉnh màu khác 
                        btn.Image = Properties.Resources.Ellipse; // màu cam
                        break;
                    default:
                        btn.Image = Properties.Resources.Ellipse_2; //màu xanh
                        break;
                }

                flp.Controls.Add(btn); // thêm button vào flow layout pannel (tự chia ô)
            }
        }

        #endregion

        #region Method load BillInfo 

        // hàm load bill 
        private void loadBillInfo(Food food, int number, float discount = 0, string note = "Không có ghi chú")
        {
            // load dữ liệu food lên dtgv
            foreach (DataGridViewRow items in DTGV_bill.Rows) // cứ mỗi hàng trên datagridview
            {
                if (food.Name.Equals(items.Cells[0].Value) && note == "Không có ghi chú")
                    // nếu trùng tên cột 0 == "TÊN MÓN"
                {
                    number += (int) (items.Cells[1].Value); // Cộng dồn số lượng
                    DTGV_bill.Rows.Remove(items); // xóa hàng cũ
                }
            }
            DTGV_bill.Rows.Add(food.Name, number, food.Price * number, discount, note,
                food.Price * number - ((food.Price * number) * (double) discount / 100));
            //thêm dữ liệu vào datagridview
            //[tên món][số lượng]      [Giá]       [Giảm giá]                         [Thành tiền sau khi đã trừ đi % giảm giá]
            DTGV_bill.Sort(DTGV_bill.Columns[0], ListSortDirection.Ascending); //sắp xếp theo tên món 
            loadPrice();
        }

        // hàm tính tổng tiền 
        private void loadPrice()
        {
            double totalPrice = 0;
            foreach (DataGridViewRow items in DTGV_bill.Rows) // cứ mỗi hàng trên datagridview
            {
                if (items.Cells[5].Value != null)
                    totalPrice += (double) (items.Cells[5].Value); // cộng dồn giá tiền
            }
            lb_price.Text = totalPrice.ToString(); //gán giá trị cho label price
            txt_Pay.Text = totalPrice - (totalPrice * (double.Parse(txt_Discount.Text) / 100)) + " ";
            //gán giá trị cho text thanh toán
            // set text cho tổng giá 
        }

        #endregion

        #region Method load food category

        public void loadFoodCategory(FlowLayoutPanel flp)
        {
            List<FoodCategory> FoodCategoryList = FoodCategoryDAO.Instance.LoadFoodCategoryList();
            // tạo danh sách category thông qua DAO
            foreach (FoodCategory item in FoodCategoryList)
            {
                MaterialRaisedButton btn = new MaterialRaisedButton(); // khởi tạo một raisedButton
                btn.Text = item.Name; // set tên của button
                btn.Cursor = Cursors.Hand; // khi chỉ vào button có hình bàn tay
                btn.Size = new Size(80, 50); // kích thước button
                btn.Click += new EventHandler(btnFoodCategory_Click);
                ; // hàm này dùng để khởi tạo event cho mỗi button
                btn.Tag = item; // gắn đối tượng item cho mỗi btn , để dễ quản lý
                flp.Controls.Add(btn); // thêm button vào flow layout category
            }
        }


        #endregion

        #region Method load food

        public void loadFood(string foodCategoryId)
        {
            List<Food> FoodList = FoodDAO.Instance.listFood(foodCategoryId); // tạo danh sách thức ăn thông qua lớp
            foreach (Food item in FoodList)
            {
                MaterialRaisedButton btn = new MaterialRaisedButton(); //khởi tạo một reisedbutton
                btn.Text = item.Name + Environment.NewLine + item.Price; // gán tên và giá cho button text
                btn.Cursor = Cursors.Hand; // kkhi chỉ vào button có hình bàn tay
                btn.Size = new Size(95, 60); //chỉnh kích thước của button
                btn.Click += new EventHandler(btnFood_Click); //khởi tạo event khi nhấn chuột trái
                btn.MouseDown += new MouseEventHandler(btnFood_MouseClick); //khởi tạo sự kiện khi nhắn vào món ăn
                btn.Tag = item; // gắn tag cho button
                flpFood.Controls.Add(btn); // thêm button vào flow layout category
            }
        }

        #endregion

        #region Method process button, handle datagridview

        // hàm xử lý trên button table
        private void btnTable_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table; //chuyền thông tin từ tag của button qua table mớ
            if (table.Status == "Trống")
            {
                TableDAO.Instance.updateStatus("Có khách", table.ID); //Cập nhật lại trạng thái của bàn ăn
                txt_table.Text = "" + table.ID;
            }
            else
                TableDAO.Instance.updateStatus("Trống", table.ID); //Cập nhật lại trạng thái của bàn ăn
            flpTable.Controls.Clear(); // xóa flow layout pannel bàn ăn
            loadTable(flpTable); // load danh sách bàn ăn thông qua method load table
        }

        // Sự kiện hiển thị món ăn ứng với category
        private void btnFoodCategory_Click(object sender, EventArgs e)
        {
            flpFood.Controls.Clear(); // xóa layout trước khi thêm button mới
            Button btn = sender as Button; // chuyền thông tin từ button trong layout đến btn này
            FoodCategory foodCategory = btn.Tag as FoodCategory; //chuyền thông tin từ tag của button qua table mớ
            loadFood(foodCategory.Id); // load danh sách bàn ăn thông qua method load table
        }

        // Sự kiện thêm món ăn vào bill khi nhắn vào button food
        private void btnFood_Click(object sender, EventArgs e)
        {
            Food food = (sender as Button).Tag as Food; // gán food cho button
            loadBillInfo(food, 1); // load food lên datagridview ,mặc định số lượng =1
        }

        //tạo context menu khi nhắn chuột phải ở khung food
        private void btnFood_MouseClick(object sender, MouseEventArgs e)
        {
            MenuItem addNote = new MenuItem("Ghi Chú"); // tạo mới menu item ghi chú
            addNote.Tag = (sender as Button).Tag as Food; // gán tag của menuItem = tag của button
            if (e.Button == MouseButtons.Right) // nếu kick = chuột phải
            {
                ContextMenu m = new ContextMenu(); //tạo context Menu
                m.MenuItems.Add(addNote); //thêm item ghi chú vào
                m.Show(flpFood, new Point(e.X, e.Y)); // hiện thị context menu ở vị trí của event
            }
            addNote.Click += new EventHandler(menuItemAddNote_Click); // khởi tạo sự kiện cho menu item ghi chú
        }

        List<string> list = new List<string>(); // khởi tạo 1 list string để lưu info của subform
        //hàm này dùng để nhận event khi nhắn thêm ghi chú ở menu food
        private void menuItemAddNote_Click(object sender, EventArgs e)
        {
            fSubform subForm = new fSubform(); //tạo mới subform
            subForm.ShowDialog(); // hiện subform
            list = subForm.getListInfoFromSubForm(); //list[0]= số lượng , list[1] = giảm giá,list[2] =Ghi chú
            if(list[0]!=null)// nếu số lượng món khác rỗng thì mới thêm vào datagridview
            loadBillInfo((sender as MenuItem).Tag as Food, int.Parse(list[0]), float.Parse(list[1]), list[2]);
            //load dữ liệu lên DTGV
            list.Clear(); // giải phóng list
        }

        // Thay đổi giá trị của text tiền thối cho khách
        private void txt_MoneyOfCus_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_MoneyOfCus.Text != "" && txt_Pay.Text != "")
                // mục thanh toán và tiền khách đưa phải khác rỗng thì mới thực hiện thay đổi
            {
                if (int.Parse(txt_MoneyOfCus.Text) > 10000000)
                    // nếu số tiền nhập vào quá lớn thì thông báo ko được nhập nữa , tránh phát sinh lỗi
                {
                    MessageBox.Show("Bạn không được nhập quá 10 triệu VND");
                    // sau khi thông báo thì đưa số tiền lại 0
                    txt_MoneyOfCus.Text = "";
                    txt_ExcessCash.Text = "0";
                }
                else
                    // tiền thừa = tiền khách đưa - số tiền cần thanh toán
                    txt_ExcessCash.Text = long.Parse(txt_MoneyOfCus.Text) - long.Parse(txt_Pay.Text) + "";

            }
            else
                txt_ExcessCash.Text = "0"; // nếu không nhập thì text tiền thừa có giá trị =0 
        }

        //Xử lý sự kiện của datagridview
        private void DTGV_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6) //nếu bấm vào nút xóa
            {
                if (DTGV_bill.CurrentRow.Index < DTGV_bill.RowCount - 1)
                    // không bị lỗi khi bấm vào dòng trống cuối cùng
                {
                    DTGV_bill.Rows.RemoveAt(DTGV_bill.CurrentRow.Index); // index 6 = button delete 
                    loadPrice(); // khi xóa xong thì load lại giá
                }
            }
        }

        private double singlePrice = 0; //khởi tạo giá trị đơn giá để lưu

        private void DTGV_bill_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (DTGV_bill.Rows[e.RowIndex].Cells[1].Value != null && DTGV_bill.Rows[e.RowIndex].Cells[3].Value != null)
                //nếu  số lượng và giảm giá = null thì không tính
                singlePrice = float.Parse(DTGV_bill.Rows[e.RowIndex].Cells[2].Value.ToString()) /
                              float.Parse(DTGV_bill.Rows[e.RowIndex].Cells[1].Value.ToString());
            //gán giá trị của đơn giá
        }

        private void DTGV_bill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGV_bill.Rows[e.RowIndex].Cells[1].Value != null && DTGV_bill.Rows[e.RowIndex].Cells[3].Value != null)
                //nếu số lượng và giảm giá = null thì không tính
                if (e.ColumnIndex == 1 || e.ColumnIndex == 3) //nếu thay đổi giá trị ở cột số lượng hoặc giảm giá
                {
                    if (double.Parse(DTGV_bill.Rows[e.RowIndex].Cells[3].Value.ToString()) > 100)
                        // nếu ở cột giảm giá nhập quá 100%
                    {
                        MessageBox.Show("Bạn không thể giảm giá hơn 100%");
                        DTGV_bill.Rows[e.RowIndex].Cells[3].Value = 0;
                    }

                    else // thay đổi cột giảm giá
                    {
                        DTGV_bill.Rows[e.RowIndex].Cells[2].Value = singlePrice *
                                                                    double.Parse(
                                                                        DTGV_bill.Rows[e.RowIndex].Cells[1].Value
                                                                            .ToString()); //gán giá trị [thành tiền]
                        DTGV_bill.Rows[e.RowIndex].Cells[5].Value =
                            double.Parse(DTGV_bill.Rows[e.RowIndex].Cells[2].Value.ToString()) *
                            (1 - double.Parse(DTGV_bill.Rows[e.RowIndex].Cells[3].Value.ToString()) / 100); // giảm giá
                        loadPrice(); // sau khi thay đổi giá trị thì load lại giá

                    }
                }

        }

        private void btn_printBill_Click(object sender, EventArgs e)
        {
            // đưa bill và billinfo vào cơ sở dữ liệu
            if (txt_table.Text != "" && txt_MoneyOfCus.Text != "") //Khi in bill thì cần phải nhập đầy đủ thông tin
            {
                if (int.Parse(txt_MoneyOfCus.Text) >= int.Parse(txt_Pay.Text))
                    // số tiền khách đưa phải lớn hơn số tiền cần thanh toán
                {
                    if (MessageBox.Show("Bạn có in hóa đơn ?", "Thông Báo", MessageBoxButtons.YesNo) ==
                        System.Windows.Forms.DialogResult.Yes) //chắn chắn in hóa đơn ?
                    {

                        BillDAO.Instance.insertBill(int.Parse(txt_table.Text), int.Parse(txt_Discount.Text));
                        // thêm bill thông qua lớp billDao
                        foreach (DataGridViewRow items in DTGV_bill.Rows)
                        {
                            if (items.Cells[0].Value != null)
                            {
                                int idBill = BillDAO.Instance.getIdOfLastRowBill(); // lấy id của bill vừa mới thêm vào
                                string IDfood = FoodDAO.Instance.getIdFood(items.Cells[0].Value.ToString());
                                //lấy tên món ăn từ datagridview rồi thông qua lớp foodDao để lấy id món ăn
                                int quantity = int.Parse(items.Cells[1].Value.ToString());
                                //lấy số lượng món ăn từ datagridview
                                int discount = int.Parse(items.Cells[3].Value.ToString());
                                //lấy số % giảm giá món ăn từ datagridview
                                string note = items.Cells[4].Value.ToString(); //lấy ghi chú của món ăn từ datagridview


                                BillInfoDAO.Instance.insertBillInfo(idBill, IDfood, quantity, discount, note);
                                // thêm bill info vào database
                            }
                        }
                        if (rbtn_normalBill.Checked == true) //nếu chọn bill bình thường
                        {
                            fPrintReport formReport = new fPrintReport();
                            formReport.ShowDialog(); //xuất hóa đơn bình thường
                        }
                        else //nếu chọn hóa đơn chiết khấu
                        {
                            fPrintBillDiscount formReport = new fPrintBillDiscount();
                            formReport.ShowDialog(); //xuất hóa đơn chiết khấu
                        }
                        btn_ClearBill_Click(sender, e);
                        // sử dụng button clearbill để xóa toàn bộ thông tin trên datagridview
                        //xóa các textbox liên quan
                        txt_table.Text = "";
                        txt_Pay.Text = "";
                        txt_MoneyOfCus.Text = "";
                        txt_ExcessCash.Text = "";
                        txt_Discount.Text = "";
                    }

                }
                else //nếu số tiền khách đưa nhỏ hơn số tiền cần thanh toán
                    txt_MoneyOfCus_Leave(sender, e); // gọi sự kiện kiểm tra khi thoát khỏi textbox tiền khách đưa
            }
            else //nếu nhập thiếu thông tin
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }

        }

        //hàm xử lý sự kiện khi nhắn vào nút in danh sách đồ uống
        private void btn_printListFood_Click(object sender, EventArgs e)
        {
            //hiện thông báo có chắc chắn muốn in danh sách đồ uống
            if (
                MessageBox.Show("Bạn có muốn in danh sách món ăn.Bạn phải thanh toán hóa đơn trước khi in danh sách ?",
                    "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (rbtn_takeAway.Checked) // nếu chọn danh sách đồ uống mang về
                {
                    fPrintListFoodTakeAway listfood = new fPrintListFoodTakeAway();
                    // tạo mới một danh sách món ăn mang về
                    listfood.ShowDialog(); // in ra 
                }
                else // nếu chọn danh sách đồ uống tại chỗ
                {
                    fPrintListFood listfood = new fPrintListFood(); // tạo mới một danh sách món ăn tại chỗ
                    listfood.ShowDialog(); //in ra
                }
            }

        }

        //hàm xử lý sự kiện của nút xóa thông tin thức uống đang hiển thị
        private void btn_ClearBill_Click(object sender, EventArgs e)
        {
            DTGV_bill.DataSource = null; // gán datasource = rỗng
            DTGV_bill.Rows.Clear(); // xóa toàn bộ các hàng của datagridview
            lb_price.Text = "0"; // set label tổng tiền =0
            txt_table.Text = "";
            txt_Pay.Text = "";
            txt_MoneyOfCus.Text = "";
            txt_ExcessCash.Text = "";
            txt_Discount.Text = "";

        }
        private void rbtn_discountBill_CheckedChanged(object sender, EventArgs e)
        {
            txt_Discount.Enabled = true;
        }
        private void rbtn_normalBill_CheckedChanged(object sender, EventArgs e)
        {
            txt_Discount.Enabled = false;
        }
        #endregion

        #region exception

        // xử lý exception => không cho nhập chữ
        private void KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                // hàm này chỉ cho phép nhập số , không cho nhập chữ và dấu
                e.Handled = true;
        }

        private void KeyPress_numberAndLetter(object sender, KeyPressEventArgs e) // hàm này cho phép nhập tự do
        {
            e.Handled = false;
        }

        //xử lý sự kiện khi đang chỉnh sửa datagridview
        private void DTGV_bill_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DTGV_bill.CurrentCell.ColumnIndex == 1 || DTGV_bill.CurrentCell.ColumnIndex == 3)
                // nếu cột hiện tại = 1 hoặc 3 (số lượng hoặc giảm giá)
                e.Control.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber); //chỉ được phép nhập chữ
            else //ngược lại , nếu là cột ghi chú
                e.Control.KeyPress += new KeyPressEventHandler(KeyPress_numberAndLetter); // được phép nhập tự do
        }

        //xử lý sự kiện khi rời khỏi textbox tiền khách đưa
        private void txt_MoneyOfCus_Leave(object sender, EventArgs e)
        {
            if (txt_Pay.Text != "" && txt_MoneyOfCus.Text != "") // nếu đầy đủ thông tin thì mới thực hiện
                if (int.Parse(txt_MoneyOfCus.Text) < int.Parse(txt_Pay.Text))
                    // nếu tiền khách đưa nhỏ hơn tiền cần thanh toán thì thông báo
                {
                    MessageBox.Show("Bạn không được nhập số tiền ít hơn so với giá");
                    txt_MoneyOfCus.Text = "";
                    txt_ExcessCash.Text = "0";
                }
        }

        //xử lý sự kiện khi thay đổi giá trị ở mục chiết khấu
        private void txt_Discount_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Discount.Text != "") // nếu mục chiết khấu khác rỗng
            { 
                if (int.Parse(txt_Discount.Text.ToString()) > 100) //nếu mục chiết khấu >100% thì thông báo không đúng
                {
                    MessageBox.Show("Bạn không được chiết khấu quá 100%");
                    txt_Discount.Text = "0"; // trả lại 0%
                }
                else
                    loadPrice();
            }
        }

        // không được nhập chữ hoặc dấu vào textbox chiết khấu
        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress_OnlyNumber(sender, e);
        }

        #endregion

        #endregion



        #region ManagePage

        private void btn_table_Click(object sender, EventArgs e)
        {
            panelMainManager.Controls.Clear();
            OptionTable optiontable = new OptionTable();

            optiontable.Dock = DockStyle.Fill;

            panelMainManager.Controls.Add(optiontable);

            loadTable(optiontable.flpTable);
        }

        private void btn_OptionFood_Click(object sender, EventArgs e)
        {
            panelMainManager.Controls.Clear();
            OptionFood optionfood = new OptionFood();

            optionfood.Dock = DockStyle.Fill;

            panelMainManager.Controls.Add(optionfood);

           
        }
        private void btn_OptionFoodCategory_Click(object sender, EventArgs e)
        {
            panelMainManager.Controls.Clear();
            OptionFoodCategory optionfoodCategory = new OptionFoodCategory();

            optionfoodCategory.Dock = DockStyle.Fill;

            panelMainManager.Controls.Add(optionfoodCategory);

            loadFoodCategory(optionfoodCategory.flpCategory);
        }
        #endregion


        #region Statistic
        private void btn_statisticsQuantity_Click(object sender, EventArgs e)
        {
            panelMainStatitis.Controls.Clear();
            StatisticsQuantity staticquantity = new StatisticsQuantity();
            staticquantity.Dock = DockStyle.Fill;
            panelMainStatitis.Controls.Add(staticquantity);

        }

        private void btn_statisticDate_Click(object sender, EventArgs e)
        {
            panelMainStatitis.Controls.Clear();
            StatisticDate statisticDate = new StatisticDate();
            statisticDate.Dock = DockStyle.Fill;
            panelMainStatitis.Controls.Add(statisticDate);
        }

        private void btn_statisticMonth_Click(object sender, EventArgs e)
        {
            panelMainStatitis.Controls.Clear();
            StatisticMonth statisticMonth = new StatisticMonth();
            statisticMonth.Dock = DockStyle.Fill;
            panelMainStatitis.Controls.Add(statisticMonth);
        }

        private void btn_statisticYear_Click(object sender, EventArgs e)
        {
            panelMainStatitis.Controls.Clear();
            StatisticYear statisticYear = new StatisticYear();
            statisticYear.Dock = DockStyle.Fill;
            panelMainStatitis.Controls.Add(statisticYear);
        }

        private void btn_settingAccount_Click(object sender, EventArgs e)
        {
            pn_account.Controls.Clear();
            AccountList accountList = new AccountList();
            accountList.Dock = DockStyle.Fill;
            pn_account.Controls.Add(accountList);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }
    }
    #endregion
}





