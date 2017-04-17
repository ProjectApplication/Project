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

namespace RoverCoffeManage2.FormOption
{
    public partial class OptionFoodCategory : UserControl
    {
        public OptionFoodCategory()
        {
            InitializeComponent();
            loadNameToComboBox();
        }
        // xử lý sự kiện khi thêm foodCategory
        private void btn_OKAdd_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_nameOfFoodCategory.Text != "")// đầy đủ thông tin thì mới được nhập
            {
                List<string> listID = FoodCategoryDAO.Instance.loadIdFoodCategory();//lấy danh sách id của danh mục thức uống
              
               if( listID.Contains(txt_id.Text) ) MessageBox.Show("ID bị trùng");//nếu ID mới được nhập đã tồn tại thì thông báo đã bị trùng
               else//nếu id hợp lệ
                {
                    FoodCategoryDAO.Instance.insertFoodCategory(txt_id.Text, txt_nameOfFoodCategory.Text);// thêm danh mục mới vào database
                    MessageBox.Show("Đã thêm danh mục thành công");
                    MessageBox.Show("Bạn cần chạy lại chương trình để thay đổi được áp dụng");
                }
            }
            else
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
        }
        //load dữ liệu tên danh mục lên combobox
        private void loadNameToComboBox()
        {
            FoodCategoryDAO.Instance.addFoodCategoryToComboBox(cb_foodCategory);
            FoodCategoryDAO.Instance.addFoodCategoryToComboBox(cb_foodCategory2);
        }
        // xử lý sự kiện khi sửa tên của danh mục
        private void btn_okFix_Click(object sender, EventArgs e)
        {
            if(cb_foodCategory.Text != "" && txtName.Text !="")
            {
                FoodCategoryDAO.Instance.updateFoodCategory(txtName.Text, cb_foodCategory.Text);
                MessageBox.Show("Đã thay đổi thành công");
                MessageBox.Show("Bạn cần chạy lại chương trình để thay đổi được áp dụng");
            }
            else
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
        }

        private void btn_OkDelete_Click(object sender, EventArgs e)
        {
            if(cb_foodCategory2.Text !="")
            {
                FoodCategoryDAO.Instance.deleteFoodCategory(cb_foodCategory2.Text);
                MessageBox.Show("Đã xóa danh mục thành công");
                MessageBox.Show("Bạn cần chạy lại chương trình để thay đổi được áp dụng");
            }
            else
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
        }

       
    }
}
