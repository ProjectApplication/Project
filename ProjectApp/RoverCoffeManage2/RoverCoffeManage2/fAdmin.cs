using CustomForm;
using MaterialSkin.Controls;
using RoverCoffeManage2.DAO;
using RoverCoffeManage2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace RoverCoffeManage2
{
    public partial class fAdmin : MyForm
    {
        public fAdmin()
        {
            InitializeComponent();
            loadTable(); // gọi từ method load table
            loadFoodCategory();// gọi từ method load foodcategory
        }
        #region HomePage
        #region Method load table
        // hàm load dữ liệu của bàn ăn
        public void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();// lấy list table

            foreach (Table item in tableList)
            {
                Button btn = new Button();// khởi tạo 1 button mới
                btn.Text = item.Name + Environment.NewLine + item.Status; //set text cho button
                btn.Cursor = System.Windows.Forms.Cursors.Hand; //khi chỉ vào button thì có hình bàn tay
                btn.ForeColor = Color.White; // màu chữ
                btn.Font = new System.Drawing.Font("UTM Penumbra", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));//set font , size,kiểu chữ
                btn.FlatAppearance.BorderColor = System.Drawing.Color.White;// chỉnh màu viền
                btn.FlatAppearance.BorderSize = 0; // size border
                btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White; //set màu khi nhắn button
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White; // set màu khi rê chuột qua button
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // set style =flat
                btn.Size = new System.Drawing.Size(110, 110); // kích thước button
                btn.Click += new EventHandler(btnTable_Click); ; // hàm này dùng để khởi tạo event cho mỗi button
                btn.Tag = item; // gắn đối tượng item cho mỗi btn , để dễ quản lý
                switch (item.Status)
                {
                    case "Trống": // nếu bàn nào còn trống thì chỉnh màu khác 
                        btn.Image = Properties.Resources.Ellipse;// màu cam
                        break;
                    default:
                        btn.Image = Properties.Resources.Ellipse_2;//màu xanh
                        break;
                }

                flpTable.Controls.Add(btn);// thêm button vào flow layout pannel (tự chia ô)
            }
        }
        #endregion
        #region Method load BillInfo 
        // hàm load bill 
        private void loadBillInfo(Food food, int number,  float discount = 0,string note = "Không có ghi chú")
        {
            double totalPrice = 0;// tổng giá 
            // load dữ liệu food lên dtgv
            foreach (DataGridViewRow items in DTGV_bill.Rows) // cứ mỗi hàng trên datagridview
            {
                if (food.Name.Equals(items.Cells[0].Value) && note == "Không có ghi chú") // nếu trùng tên cột 0 == "TÊN MÓN"
                {
                    number += (int)(items.Cells[1].Value); // Cộng dồn số lượng
                    DTGV_bill.Rows.Remove(items); // xóa hàng cũ
                }
               
            }
            DTGV_bill.Rows.Add(food.Name, number, food.Price*number, discount, note, food.Price * number - ((food.Price * number) * (double)discount /100 ));//thêm dữ liệu vào datagridview
                              //[tên món][số lượng]      [Giá]       [Giảm giá]                         [Thành tiền sau khi đã trừ đi % giảm giá]
            DTGV_bill.Sort(DTGV_bill.Columns[0], ListSortDirection.Ascending);//sắp xếp theo tên món 
            loadPrice();
        }
        // hàm tính tổng tiền 
        private void loadPrice()
        {
            double totalPrice = 0;
            foreach (DataGridViewRow items in DTGV_bill.Rows) // cứ mỗi hàng trên datagridview
            {
                if (items.Cells[5].Value != null)
                    totalPrice += (double)(items.Cells[5].Value); // cộng dồn giá tiền
            }
            lb_price.Text = totalPrice.ToString();//gán giá trị cho label price
            txt_Pay.Text = totalPrice - (totalPrice * (double.Parse(txt_Discount.Text) / 100)) + " "; //gán giá trị cho text thanh toán
                                                                                                     // set text cho tổng giá 
        }
        #endregion
        #region Method load food category
        public void loadFoodCategory()
        {
            List<FoodCategory> FoodCategoryList = FoodCategoryDAO.Instance.LoadFoodCategoryList(); // tạo danh sách category thông qua DAO
            foreach(FoodCategory item in FoodCategoryList )
            {
                MaterialRaisedButton btn = new MaterialRaisedButton();// khởi tạo một raisedButton
                btn.Text = item.Name;// set tên của button
                btn.Cursor = Cursors.Hand; // khi chỉ vào button có hình bàn tay
                btn.Size = new Size(98, 60); // kích thước button
                 btn.Click += new EventHandler(btnFoodCategory_Click); ; // hàm này dùng để khởi tạo event cho mỗi button
                 btn.Tag = item; // gắn đối tượng item cho mỗi btn , để dễ quản lý
                flpCategory.Controls.Add(btn);// thêm button vào flow layout category
            }
        }

      
        #endregion
        #region Method load food
        public void loadFood(string foodCategoryId)
        {
            List<Food> FoodList = FoodDAO.Instance.listFood(foodCategoryId);// tạo danh sách thức ăn thông qua lớp
            foreach (Food item in FoodList)
            {
                MaterialRaisedButton btn = new MaterialRaisedButton();//khởi tạo một reisedbutton
                btn.Text = item.Name +Environment.NewLine+item.Price; // gán tên và giá cho button text
                btn.Cursor = System.Windows.Forms.Cursors.Hand;// kkhi chỉ vào button có hình bàn tay
                btn.Size = new System.Drawing.Size(95, 60); //chỉnh kích thước của button
                 btn.Click += new EventHandler(btnFood_Click);//khởi tạo event khi nhấn chuột trái
             btn.MouseDown += new MouseEventHandler(btnFood_MouseClick);
                btn.Tag = item;// gắn tag cho button
                flpFood.Controls.Add(btn);// thêm button vào flow layout category
            }
        }
        #endregion
        #region Method process button, handle datagridview
        // hàm xử lý trên button table
        private void btnTable_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;//chuyền thông tin từ tag của button qua table mớ
            if (table.Status == "Trống")
            { 
                TableDAO.Instance.updateStatus("Có khách",table.ID); //Cập nhật lại trạng thái của bàn ăn
                txt_table.Text = ""+table.ID;
            }
            else
                TableDAO.Instance.updateStatus("Trống", table.ID); //Cập nhật lại trạng thái của bàn ăn
            flpTable.Controls.Clear();// xóa flow layout pannel bàn ăn
            loadTable();// load danh sách bàn ăn thông qua method load table
        }
        // Sự kiện hiển thị món ăn ứng với category
        private void btnFoodCategory_Click(object sender, EventArgs e)
        {
            flpFood.Controls.Clear();// xóa layout trước khi thêm button mới
            Button btn = sender as Button;// chuyền thông tin từ button trong layout đến btn này
            FoodCategory foodCategory = btn.Tag as FoodCategory;//chuyền thông tin từ tag của button qua table mớ
            loadFood(foodCategory.Id);// load danh sách bàn ăn thông qua method load table
        }
        // Sự kiện thêm món ăn vào bill khi nhắn vào button food
        private void btnFood_Click(object sender, EventArgs e)
        {
            Food food = (sender as Button).Tag as Food; // gán food cho button
            loadBillInfo(food, 1);
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
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));
                m.Show(flpFood, new Point(e.X, e.Y)); // hiện thị context menu ở vị trí của event

            }
            addNote.Click += new EventHandler(menuItemAddNote_Click); // khởi tạo sự kiện cho menu item ghi chú
        }
        List<string> list = new List<string>(); // khởi tạo 1 list string để lưu info của subform
        //hàm này dùng để nhận event khi nhắn thêm ghi chú ở menu food
        private void menuItemAddNote_Click(object sender, EventArgs e)
        {
            fSubform subForm = new fSubform();//tạo mới subform
            subForm.ShowDialog();// hiện subform
            list = subForm.getListInfoFromSubForm();//list[0]= số lượng , list[1] = giảm giá,list[2] =Ghi chú
            loadBillInfo((sender as MenuItem).Tag as Food, int.Parse(list[0]), float.Parse(list[1]), list[2]);//load dữ liệu lên DTGV
            list.Clear();// giải phóng list
        }
          // Thay đổi giá trị của text tiền thối cho khách
        private void txt_MoneyOfCus_OnValueChanged(object sender, EventArgs e)
        {
                if (txt_MoneyOfCus.Text != "" && txt_Pay.Text != "") // nếu bắt đầu nhập thì thay đổi giá trị của text tiền thừa
                {
                if (int.Parse(txt_MoneyOfCus.Text) > 10000000)
                { 
                    MessageBox.Show("Bạn không được nhập quá 10 triệu VND");
                    txt_MoneyOfCus.Text="";
                    txt_ExcessCash.Text = "0";
                }
                else
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
                if (DTGV_bill.CurrentRow.Index < DTGV_bill.RowCount - 1)   // không bị lỗi khi bấm vào dòng trống cuối cùng
                {
                    DTGV_bill.Rows.RemoveAt(DTGV_bill.CurrentRow.Index); // index 6 = button delete 
                    loadPrice();// khi xóa xong thì load lại giá
                }
            }
        }
        private double singlePrice = 0; //khởi tạo giá trị đơn giá để lưu
        private void DTGV_bill_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (DTGV_bill.Rows[e.RowIndex].Cells[1].Value != null && DTGV_bill.Rows[e.RowIndex].Cells[3].Value != null)//nếu cộng số lượng và giảm giá = null thì không tính
                singlePrice = float.Parse(DTGV_bill.Rows[e.RowIndex].Cells[2].Value.ToString()) / float.Parse(DTGV_bill.Rows[e.RowIndex].Cells[1].Value.ToString());//gán giá trị của đơn giá
        }
        private void DTGV_bill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGV_bill.Rows[e.RowIndex].Cells[1].Value != null && DTGV_bill.Rows[e.RowIndex].Cells[3].Value != null)//nếu cộng số lượng và giảm giá = null thì không tính
                if (e.ColumnIndex == 1 || e.ColumnIndex==3)//nếu thay đổi giá trị ở cột số lượng hoặc giảm giá
            { 
                DTGV_bill.Rows[e.RowIndex].Cells[2].Value=singlePrice* double.Parse( DTGV_bill.Rows[e.RowIndex].Cells[1].Value.ToString());//gán giá trị [thành tiền]
                DTGV_bill.Rows[e.RowIndex].Cells[5].Value = double.Parse(DTGV_bill.Rows[e.RowIndex].Cells[2].Value.ToString()) *(1- double.Parse(DTGV_bill.Rows[e.RowIndex].Cells[3].Value.ToString())/100); // giảm giá
                loadPrice();// sau khi thay đổi giá trị thì load lại giá
            }
            
        }
        private void btn_printBill_Click(object sender, EventArgs e)
        {

            if (txt_table.Text != "" && txt_MoneyOfCus.Text != "")
            {
              BillDAO.Instance.insertBill(int.Parse(txt_table.Text), int.Parse(txt_Discount.Text));
                foreach (DataGridViewRow items in DTGV_bill.Rows)
                {
                    if (items.Cells[0].Value != null)
                    {
                        int idBill = (int)DataProvider.Instance.ExecuteScalar("proc_GetIdOfLastRowBill");
                        string IDfood = (string)DataProvider.Instance.ExecuteScalar("proc_GetIdFood " + "N'" + items.Cells[0].Value + "'");
                        int quantity = int.Parse(items.Cells[1].Value.ToString());
                        int discount = int.Parse(items.Cells[3].Value.ToString());
                    DataProvider.Instance.ExecuteNonQuery("proc_InsertBillInfo " +idBill + ",N'" + IDfood + "'," + quantity + "," + discount);
                    }
                } 
                btn_ClearBill_Click(sender, e);
                txt_table.Text = "";
                txt_Pay.Text = "";
                txt_MoneyOfCus.Text = "";
                txt_ExcessCash.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
        }
        #endregion
        #region exception
        // xử lý exception => không cho nhập chữ
        private void KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) // hàm này chỉ cho phép nhập số , không cho nhập chữ và dấu
                e.Handled = true;
        }
        private void DTGV_bill_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
            e.Control.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
            if (DTGV_bill.CurrentCell.ColumnIndex == 1 && DTGV_bill.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(KeyPress_OnlyNumber);
                }
            }
        }

       
        #endregion
        #endregion



        #region ManagePage
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (sideMenu.Width == 50)
            {

                sideMenu.Visible = false;
                sideMenu.Width = 200;
                sideA.MaxAnimationTime = 4;
                sideA.ShowSync(sideMenu);
                LogoA.ShowSync(logo);

            }
            else
            {
                LogoA.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                sideA.ShowSync(sideMenu);


            }
        }

        private void btn_ClearBill_Click(object sender, EventArgs e)
        {
            DTGV_bill.DataSource = null;
            DTGV_bill.Rows.Clear();
            lb_price.Text = "0";
            txt_Pay.Text = "0";
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            OptionTable optiontable = new OptionTable();

            optiontable.Dock = DockStyle.Fill;

            panelMain.Controls.Add(optiontable);
        }

        #endregion

        private void txt_MoneyOfCus_Leave(object sender, EventArgs e)
        {
            if(txt_Pay.Text != "")
            if (int.Parse(txt_MoneyOfCus.Text) < int.Parse(txt_Pay.Text))
            {
                MessageBox.Show("Bạn không được nhập số tiền ít hơn so với giá");
                txt_MoneyOfCus.Text = "";
                txt_ExcessCash.Text = "0";
            }
         
        }
    }



}

