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
            loadBillInfo(); // gọi từ method load food
            loadFoodCategory();// gọi từ method load foodcategory
        }
        #region Method load table
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
                btn.Click += new System.EventHandler(btnTable_Click); ; // hàm này dùng để khởi tạo event cho mỗi button
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
        }// hàm load dữ liệu của bàn ăn
        #endregion
        #region Method load BillInfo 
        private void loadBillInfo()
        {

            //List  data= FoodCategoryDAO.Instance.LoadFoodCategoryList();
            //  lview_foodcategory.Items.Add(data);
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                lview_foodcategory.Items.Add(item);
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
                btn.Size = new System.Drawing.Size(100, 60); // kích thước button
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
                btn.Size = new System.Drawing.Size(100, 60); //chỉnh kích thước của button
                flpFood.Controls.Add(btn);// thêm button vào flow layout category
            }
        }
        #endregion
        #region Method process button of table , handle listview 
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

        private void btnFoodCategory_Click(object sender, EventArgs e)
        {
            flpFood.Controls.Clear();// xóa layout trước khi thêm button mới
            Button btn = sender as Button;// chuyền thông tin từ button trong layout đến btn này
            FoodCategory foodCategory = btn.Tag as FoodCategory;//chuyền thông tin từ tag của button qua table mớ
            loadFood(foodCategory.Id);// load danh sách bàn ăn thông qua method load table

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
                    m.Show(lview_foodcategory, new Point(e.X, e.Y));
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

