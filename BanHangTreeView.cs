using BuiTienThinh_22102363.BUS;
using BuiTienThinh_22102363.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuiTienThinh_22102363
{
    public partial class BanHangTreeView : Form
    {
        public BanHangTreeView()
        {
            InitializeComponent();
            productBUS = new ProductBUS();
            cateBUS = new CategoryBUS();
            imageList1 = new ImageList();
            new FunctionHelper();

            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Description", 200);
            listView1.Columns.Add("Price", 100);
            listView1.View = View.Details;

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(deleteButtonColumn);

            button1.Enabled = true; // Nhập mới
            button4.Enabled = false; // Tiếp tục

        }
        CategoryBUS cateBUS;
        ProductBUS productBUS;
        private decimal totalPrice = 0;
        private bool isProductSelected = false;
        private void BanHangTreeView_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;
            List<Category> categories = cateBUS.GetAll();
            treeView1.Nodes.Clear();

            int count = 0;
            foreach (Category category in categories)
            {
                TreeNode node = new TreeNode
                {
                    Tag = category,
                    Text = category.Name
                };

                Image categoryImage = FunctionHelper.ConvertBinaryToImage(category.Picture);
                if (categoryImage != null)
                {
                    if (count >= imageList1.Images.Count)
                    {
                        imageList1.Images.Add(categoryImage);
                    }
                    node.ImageIndex = count;
                    count++;
                }
                treeView1.Nodes.Add(node);
            }

            treeView1.ExpandAll();


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            TreeNode node = treeView1.SelectedNode;
            Category cate = node.Tag as Category;

            if (cate != null)
            {
                Image categoryImage = FunctionHelper.ConvertBinaryToImage(cate.Picture);
                if (categoryImage != null)
                {
                    pictureBox1.Image = categoryImage;
                }

                List<Product> prolist = productBUS.GetProductsByCategoryId(cate.CategoryId);
                foreach (Product p in prolist)
                {
                    ListViewItem item = new ListViewItem(p.Id.ToString());
                    item.Tag = p;
                    item.SubItems.Add(p.Description.ToString());
                    item.SubItems.Add(p.Price.ToString());

                    listView1.Items.Add(item);
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void button6_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }*/

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetForm()
        {
            textBox1.Clear();
            textBox3.Clear();
            listView1.SelectedItems.Clear();
            button1.Enabled = true;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (isProductSelected && decimal.TryParse(textBox3.Text, out decimal price))
            {
                totalPrice += price;
                textBox2.Text = totalPrice.ToString("0.00");

                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = selectedItem.Text; // ID
                    row.Cells[1].Value = selectedItem.SubItems[1].Text; // Description
                    row.Cells[2].Value = selectedItem.SubItems[2].Text; // Price
                    dataGridView1.Rows.Add(row);
                }

                ResetForm();
                isProductSelected = false;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all required fields (Tên khách hàng  and Id nhân viên).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thực hiện tiếp nếu các trường không được nhập đầy đủ
            }
            if (dataGridView1.Rows.Count > 0)
            {
                string query = "INSERT INTO [dbo].[Order] (Date, Status, EmployeeId) VALUES (@Date, @Status, @EmployeeId)";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Lấy ID của sản phẩm
                    string productId = row.Cells[0].Value.ToString();
                    string status = textBox6.Text;
                    string employeeId = textBox5.Text;

                    // Tạo câu truy vấn SQL để chèn đơn hàng mới vào bảng Order
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@Date", SqlDbType.DateTime) { Value = DateTime.Now },
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = status },
                new SqlParameter("@EmployeeId", SqlDbType.Int) { Value = employeeId }
                    };

                    try
                    {
                        // Thực hiện câu truy vấn
                        bool result = SqlDataAccessHelper.ExecuteNonQuery(query, parameters);

                        if (!result)
                        {
                            MessageBox.Show($"Failed to save the order for product ID {productId}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị lỗi nếu có
                        MessageBox.Show("An error occurred while saving the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Thông báo khi lưu tất cả đơn hàng thành công
                MessageBox.Show("All orders saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thông báo khi không có sản phẩm nào trong dataGridView1
                MessageBox.Show("Please select a product from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }









        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Product selectedProduct = selectedItem.Tag as Product;

                if (selectedProduct != null)
                {
                    textBox1.Text = selectedProduct.Description;
                    textBox3.Text = selectedProduct.Price.ToString("0.00");
                    Image productImage = FunctionHelper.ConvertBinaryToImage(selectedProduct.Picture);
                    if (productImage != null)
                    {
                        pictureBox1.Image = productImage;
                    }
                    isProductSelected = true;
                    button1.Enabled = false;
                    button4.Enabled = true;
                }
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }
        private void CheckInputFields()
        {
            // Kích hoạt nút button2 chỉ khi cả hai textBox đều có giá trị
            button2.Enabled = !string.IsNullOrWhiteSpace(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox5.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số hàng và cột có hợp lệ không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra nếu cột là cột nút xóa
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    // Xác nhận trước khi xóa hàng
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Xóa hàng khỏi DataGridView
                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        // Tính toán lại tổng giá sau khi xóa
                        CalculateTotalPrice();
                    }
                }
            }
        }

        private void CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra giá trị của ô giá có hợp lệ không
                if (row.Cells["Price"].Value != null)
                {
                    // Cộng giá vào tổng giá
                    totalPrice += Convert.ToDecimal(row.Cells["Price"].Value);
                }
            }
            // Cập nhật tổng giá vào textBox2
            textBox2.Text = totalPrice.ToString("C"); // Định dạng thành tiền tệ
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SearchAndDisplayProducts()
        {
            string description = textBox4.Text.Trim();
            List<Product> products = productBUS.SearchProductsByDescription(description);

            listView1.Items.Clear();
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString())
                {
                    Tag = product
                };
                item.SubItems.Add(product.Description);
                item.SubItems.Add(product.Price.ToString("0.00"));
                listView1.Items.Add(item);
            }
        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {
            SearchAndDisplayProducts();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchAndDisplayProducts();
        }
    }
}




