using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoverCoffeManage2.DTO;
using RoverCoffeManage2.DAO;
using MaterialSkin.Controls;

namespace RoverCoffeManage2.FormOption
{
    public partial class OptionFood : UserControl
    {
        public OptionFood()
        {
            InitializeComponent();
            loadFood();
            loadNameToComboBox();
        }
        public void loadFood()
        {
            List<Food> FoodList = FoodDAO.Instance.listFood(); // tạo danh sách thức ăn thông qua lớp
            foreach (Food item in FoodList)
            {
                MaterialRaisedButton btn = new MaterialRaisedButton(); //khởi tạo một reisedbutton
                btn.Text = item.Name + Environment.NewLine + item.Price; // gán tên và giá cho button text
                btn.Cursor = Cursors.Hand; // kkhi chỉ vào button có hình bàn tay
                btn.Size = new Size(95, 60); //chỉnh kích thước của button
                flpFood.Controls.Add(btn);
            }
        }
        private void loadNameToComboBox()
        {
            FoodCategoryDAO.Instance.addFoodCategoryToComboBox(cb_foodCategory);
            FoodCategoryDAO.Instance.addFoodCategoryToComboBox(cb_foodCategory2);
            FoodCategoryDAO.Instance.addFoodCategoryToComboBox(cb_foodCategory3);
           
         
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) // hàm này chỉ cho phép nhập số , không cho nhập chữ và dấu
                e.Handled = true;
        }

        private void btn_OKAdd_Click(object sender, EventArgs e)
        {
            if (cb_foodCategory3.Text != "" && txt_idOfFood.Text != "" && txt_idOfFood.Text != "" && txt_price.Text != "")
            {
                List<string> listIdFood = FoodDAO.Instance.getIdFood();// lấy danh sách id thức uống
                string idFoodCategory = FoodCategoryDAO.Instance.getIdFoodCategoryByName(cb_foodCategory3.Text);//lấy mã danh mục tương ứng
                if (listIdFood.Contains(txt_idOfFood.Text)) MessageBox.Show("Mã món đã trùng");
                else
                {
                  FoodDAO.Instance.insertFood(txt_idOfFood.Text, txt_nameOfFood.Text, idFoodCategory, int.Parse(txt_price.Text.ToString()));//thêm thức uống vào database
                    MessageBox.Show("Bạn đã thêm món thành công ");
                    MessageBox.Show("Bạn cần khởi động lại chương trình ");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
        }

        private void cb_foodCategory_Leave(object sender, EventArgs e)
        {
            cb_nameOfFood.Items.Clear();// xóa combobox trước khi thêm

            if (cb_foodCategory.Text != "") //nếu khác rỗng
                FoodDAO.Instance.addFoodToComboBox(cb_nameOfFood, cb_foodCategory.Text.ToString());

        }

        private void btn_okFix_Click(object sender, EventArgs e)
        {
            if (cb_foodCategory.Text != "" && cb_nameOfFood.Text != "" && txtName.Text != "" && txt_newPrice.Text != "")
            {
                //update lại tên và giá tiền
                FoodDAO.Instance.updateFood(txtName.Text, cb_nameOfFood.Text, int.Parse(txt_newPrice.Text.ToString()));
                MessageBox.Show("Bạn đã sửa món thành công ");
                MessageBox.Show("Bạn cần khởi động lại chương trình ");
            }
            else
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
        }

        private void cb_foodCategory2_Leave(object sender, EventArgs e)
        {
            cb_nameOfFood2.Items.Clear();// xóa combobox trước khi thêm

            if (cb_foodCategory2.Text != "") //nếu khác rỗng
                FoodDAO.Instance.addFoodToComboBox(cb_nameOfFood2, cb_foodCategory2.Text.ToString());
        }

        private void btn_OkDelete_Click(object sender, EventArgs e)
        {
            if(cb_nameOfFood2.Text !="" && cb_foodCategory2.Text!="")
            {
                FoodDAO.Instance.deleteFood(cb_nameOfFood2.Text);
                MessageBox.Show("Bạn đã xóa món thành công ");
                MessageBox.Show("Bạn cần khởi động lại chương trình ");
            }
            else
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
        }
    }
}
