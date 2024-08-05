using BuiTienThinh_22102363.BUS;
using BuiTienThinh_22102363.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            int count = 0;

            List<Category> categories = cateBUS.GetAll();
            treeView1.ExpandAll();
            foreach (Category category in categories)
            {
                TreeNode node = new TreeNode();
                node.Tag = category;
                node.Text = category.Name;
                Image categoryImage = FunctionHelper.ConvertBinaryToImage(category.Picture);

                if (categoryImage != null)
                {
                    imageList1.Images.Add(categoryImage);
                    node.ImageIndex = count;
                    count++;
                }

                treeView1.Nodes.Add(node);
            }


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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            listView1.SelectedItems.Clear();
            button1.Enabled = true;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isProductSelected && decimal.TryParse(textBox3.Text, out decimal price))
            {
                totalPrice += price;
                textBox2.Text = totalPrice.ToString("0.00");
                button1.Enabled = true;
                button4.Enabled = false;
                isProductSelected = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string totalPriceFormatted = totalPrice.ToString("0.00");


            MessageBox.Show($"Số tiền bạn cần trả là: {totalPriceFormatted} VND",
                            "Thông Báo Thanh Toán",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


            textBox2.Text = totalPriceFormatted;
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

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

      /*  private void button6_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}




