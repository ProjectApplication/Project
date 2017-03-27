using CustomForm;
using MaterialSkin.Controls;
using RoverCoffeManage2.DAO;
using RoverCoffeManage2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        #region Method load table
        // hàm load dữ liệu của bàn ăn
        public void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

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
                btn.Size = new System.Drawing.Size(120, 120); // kích thước button
                btn.Click += new EventHandler(btnTable_Click); ; // hàm này dùng để khởi tạo event cho mỗi button
                btn.Tag = item; // gắn đối tượng item cho mỗi btn , để dễ quản lý

                //  btn.UseVisualStyleBackColor = false;
                switch (item.Status)
                {
                    case "Trống": // nếu bàn nào còn trống thì chỉnh màu khác 
                        btn.Image = global::RoverCoffeManage2.Properties.Resources.Ellipse;// màu cam
                        break;
                    default:
                        btn.Image = global::RoverCoffeManage2.Properties.Resources.Ellipse_2;//màu xanh
                        break;
                }

                flpTable.Controls.Add(btn);// thêm button vào flow layout pannel (tự chia ô)
            }
        }
        #endregion
        #region Method load BillInfo 
        // hàm load bill với note mặc định =null --discount ,bonus mặc định =0
        private void loadBillInfo(int number, Food food, string note = null, int discount = 0, int bonus = 0)
        {
            for (int i = 0; i < lview_Bill.Items.Count; i++) // chạy từ đầu đến cuối item của listview
                if (food.Name.ToString().Equals(lview_Bill.Items[i].SubItems[0].Text) && note==null ) // nếu món muốn thêm đã có trong listview
                {
                    number += int.Parse(lview_Bill.Items[i].SubItems[1].Text);  // Cộng thêm số lượng
                    lview_Bill.Items.Remove(lview_Bill.Items[i]); //xóa Item cũ 
                }
            //khởi tạo và truyền dữ liệu của food , number
            if (number != 0)// nếu số lượng ==0 thì không thêm vào bill
            {
                var data = new[] {
                food.Name.ToString(), // tên món ăn
                number.ToString(), //số lượng
                food.Price.ToString(), //giá
                discount.ToString(),// giảm giá
                bonus.ToString(), // order thêm
                note == null ? "Không có ghi chú" : note.ToString(), //ghi chú
                (food.Price * number+ bonus -(100*(double)discount/(food.Price * number))).ToString() };//= thành tiền + tiền bonus - giảm giá (%)
                
                var item = new ListViewItem(data); // truyền dữ liệu vào item của listview
                lview_Bill.Items.Add(item);// thêm item vào listview
                lview_Bill.Sorting = SortOrder.Ascending; // tự động sắp xếp theo alphaB
            }
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
                btn.Cursor = System.Windows.Forms.Cursors.Hand; // khi chỉ vào button có hình bàn tay
                btn.Size = new System.Drawing.Size(98, 60); // kích thước button
                 btn.Click += new System.EventHandler(btnFoodCategory_Click); ; // hàm này dùng để khởi tạo event cho mỗi button
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
        #region Method process button, handle listview 
        private void btnTable_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // chuyền thông tin từ button trong layout đến btn này
            Table table = btn.Tag as Table;//chuyền thông tin từ tag của button qua table mớ
            if (table.Status.Equals("trống"))
                btn.Image = global::RoverCoffeManage2.Properties.Resources.Ellipse;// thay nền xanh thành cam (chưa có người)
            else
                btn.Image = global::RoverCoffeManage2.Properties.Resources.Ellipse_2;// thay nền cam thành xanh (đã có người)
            TableDAO.Instance.updateStatus(table.ID); //Cập nhật lại trạng thái của bàn ăn
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
            loadBillInfo(1,food);// set số lượng và object food đã lấy ở tag button truyền vào
            double totalPrice = 0; // khởi tạo giá trị tổng số tiền
           for (int i = 0; i < lview_Bill.Items.Count; i++)             
              totalPrice += Double.Parse( lview_Bill.Items[i].SubItems[6].Text); // dùng vòng for tính tổng số tiền
            label_price.Text = totalPrice.ToString();//set label giá = tổng tiền
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
            list = subForm.getListInfoFromSubForm();//list[0]= số lượng , list[1] = ghi chú,list[2] =giảm giá , list[3] = tăng giá
            loadBillInfo(int.Parse(list[0]), (sender as MenuItem).Tag as Food, list[1], int.Parse(list[2]), int.Parse(list[3]));
            list.Clear();// giải phóng list
            
        }

        private void lview_foodcategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem("Cut"));
                    m.MenuItems.Add(new MenuItem("Copy"));
                    m.MenuItems.Add(new MenuItem("Paste"));
                    m.Show(lview_Bill, new Point(e.X, e.Y));
                }

                else//left or middle click
                {
                    MessageBox.Show("1234");
                    //do something here
                }
            }
        }

        #endregion

     
    }
}

