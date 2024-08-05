using BuiTienThinh_22102363.BUS;
using BuiTienThinh_22102363.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuiTienThinh_22102363
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            cateBUS = new CategoryBUS();
            productBUS = new ProductBUS();
            imageList1 = new ImageList();
            button7.Enabled = false;
        }

        CategoryBUS cateBUS;
        ProductBUS productBUS;

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            listView1.Items.Clear();
            imageList1.Images.Clear();

            if (cbCategory.SelectedItem != null && cbCategory.SelectedValue != null)
            {

                int categoryId = ((Category)cbCategory.SelectedItem).CategoryId;
                textBox4.Text = categoryId.ToString();


                List<Product> proList = productBUS.GetProductsByCategoryId(categoryId);
                foreach (Product p in proList)
                {
                    if (p.Picture != null)
                    {
                        Image img = ConvertBinaryToImage(p.Picture);
                        imageList1.Images.Add(img);
                    }
                    ListViewItem item = new ListViewItem(p.Description);
                    item.ImageIndex = count;

                    item.SubItems.Add(p.Price.ToString());
                    item.SubItems.Add(p.Discount.ToString());
                    item.SubItems.Add(p.CategoryId.ToString());
                    item.Tag = p;
                    listView1.Items.Add(item);
                    count++;
                    if (count == imageList1.Images.Count)
                    {
                        count = 0;
                    }
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void btnLargeIcon_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void btnSmallIcon_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            List<Category> cateList = cateBUS.GetAll();
            if (cateList != null)
            {
                cbCategory.DataSource = cateList;
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "CategoryId";
                cbCategory.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Failed to load categories.");
            }

            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList1;
        }

        public byte[] ConvertImageToBinary(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                ms.Seek(0, SeekOrigin.Begin);
                return Image.FromStream(ms);
            }
        }

        public static Image GetImageFromByteArray(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data cannot be null or empty.");
            }

            using (MemoryStream ms = new MemoryStream(data))
            {
                ms.Seek(0, SeekOrigin.Begin);
                try
                {
                    return Image.FromStream(ms);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error creating image: " + ex.Message);
                    throw;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Product selectedProduct = (Product)selectedItem.Tag;

                textBox1.Text = selectedProduct.Description;
                textBox2.Text = selectedProduct.Price.ToString();
                textBox3.Text = selectedProduct.Discount.ToString();
                textBox4.Text = selectedProduct.Id.ToString();

                if (selectedProduct.Picture != null)
                {
                    pictureBox1.Image = ConvertBinaryToImage(selectedProduct.Picture);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateProductList(List<Product> products)
        {

            if (cbCategory.SelectedItem != null && cbCategory.SelectedValue != null)
            {
                int categoryId = ((Category)cbCategory.SelectedItem).CategoryId;
                List<Product> proList = productBUS.GetProductsByCategoryId(categoryId);
                listView1.Items.Clear();
                imageList1.Images.Clear();

                int count = 0;
                foreach (Product p in proList)
                {
                    if (p.Picture != null)
                    {
                        try
                        {
                            Image img = ConvertBinaryToImage(p.Picture);
                            imageList1.Images.Add(img);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error converting image: " + ex.Message);
                            continue;
                        }
                    }

                    ListViewItem item = new ListViewItem(p.Description)
                    {
                        ImageIndex = count,
                        Tag = p
                    };
                    item.SubItems.Add(p.Price.ToString());
                    item.SubItems.Add(p.Discount.ToString());
                    item.SubItems.Add(p.CategoryId.ToString());

                    listView1.Items.Add(item);
                    count++;
                    if (count == imageList1.Images.Count)
                    {
                        count = 0;
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin sản phẩm từ các điều khiển
                string description = textBox1.Text;
                float price = float.Parse(textBox2.Text);
                float discount = float.Parse(textBox3.Text);
                int categoryId = int.Parse(textBox4.Text);
                byte[] picture = pictureBox1.Image != null ? ConvertImageToBinary(pictureBox1.Image) : null;

                // Tạo đối tượng Product mới
                Product newProduct = new Product
                {
                    Description = description,
                    Price = price,
                    Discount = discount,
                    CategoryId = categoryId,
                    Picture = picture
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                bool success = productBUS.InsertProduct(newProduct);

                if (success)
                {
                    MessageBox.Show("Product added successfully.");
                    // Cập nhật danh sách sản phẩm
                    int selectedCategoryId = ((Category)cbCategory.SelectedItem).CategoryId;
                    List<Product> products = productBUS.GetProductsByCategoryId(selectedCategoryId);
                    UpdateProductList(products);
                    // Xóa thông tin các điều khiển sau khi thêm
                    ClearProductInfo();
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(textBox4.Text);

                // Xóa sản phẩm khỏi cơ sở dữ liệu
                bool success = productBUS.DeleteProduct(productId);

                if (success)
                {
                    MessageBox.Show("Product deleted successfully.");

                    // Cập nhật danh sách sản phẩm
                    int selectedCategoryId = ((Category)cbCategory.SelectedItem).CategoryId;
                    List<Product> products = productBUS.GetProductsByCategoryId(selectedCategoryId);
                    UpdateProductList(products);
                    // Xóa thông tin các điều khiển sau khi xóa
                    ClearProductInfo();
                }
                else
                {
                    MessageBox.Show("Failed to delete product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (DialogResult.OK == ofd.ShowDialog())
            {
                //   pictureBox1.Image = new Bitmap(ofd.OpenFile());
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(textBox4.Text);

                // Lấy thông tin sản phẩm từ các điều khiển
                string description = textBox1.Text;
                float price = float.Parse(textBox2.Text);
                float discount = float.Parse(textBox3.Text);
                int categoryId = int.Parse(textBox4.Text);
                byte[] picture = pictureBox1.Image != null ? ConvertImageToBinary(pictureBox1.Image) : null;

                // Tạo đối tượng Product mới để cập nhật
                Product updatedProduct = new Product
                {
                    Id = productId,
                    Description = description,
                    Price = price,
                    Discount = discount,
                    CategoryId = categoryId,
                    Picture = picture
                };

                // Cập nhật sản phẩm vào cơ sở dữ liệu
                bool success = productBUS.UpdateProduct(updatedProduct);

                if (success)
                {
                    MessageBox.Show("Product updated successfully.");
                    // Cập nhật danh sách sản phẩm
                    int selectedCategoryId = ((Category)cbCategory.SelectedItem).CategoryId;
                    List<Product> products = productBUS.GetProductsByCategoryId(selectedCategoryId);
                    UpdateProductList(products);
                    // Xóa thông tin các điều khiển sau khi lưu
                    ClearProductInfo();
                    button7.Enabled = false; // Vô hiệu hóa button7 sau khi lưu
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Product selectedProduct = (Product)selectedItem.Tag;

                textBox1.Text = selectedProduct.Description;
                textBox2.Text = selectedProduct.Price.ToString();
                textBox3.Text = selectedProduct.Discount.ToString();
                textBox4.Text = selectedProduct.Id.ToString();

                if (selectedProduct.Picture != null)
                {
                    pictureBox1.Image = ConvertBinaryToImage(selectedProduct.Picture);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }
        private void ClearProductInfo()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex >= 0)
            {

                Category selectedCategory = (Category)cbCategory.SelectedItem;


                byte[] data = selectedCategory.Picture;


                Image image = ConvertBinaryToImage(data);


                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Please select a category from the ComboBox.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
