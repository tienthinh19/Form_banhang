using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuiTienThinh_22102363.BUS;
using BuiTienThinh_22102363.DTO;
namespace BuiTienThinh_22102363
{
    public partial class QLSP : Form
    {
        public QLSP()
        {
            InitializeComponent();
            cateBus = new CategoryBUS();
        }
        CategoryBUS cateBus;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null || textBox1.Text == "")
            {
                comboBox1.DataSource = cateBus.GetAll();

            }
            else
            {
                comboBox1.DataSource = cateBus.SearchCategories(textBox1.Text);

            }
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryId";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cateBus.GetAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryId";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Category selectedCategory)
            {
                byte[] data = selectedCategory.Picture;
                Image image = ConvertBinaryToImage(data);
                pictureBox1.Image = image;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
        private void AddCategory(string name, Image image)
        {
            Category category = new Category();
            byte[] data = ConvertImageToBinary(image);
            category.Name = name;
            category.Picture = data;
            cateBus.Insert(category);
        }
        public byte[] ConvertImageToBinary(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }
        public Image ConvertBinaryToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                
                Category selectedCategory = (Category)comboBox1.SelectedItem;

               
                byte[] data = selectedCategory.Picture;

               
                Image image = ConvertBinaryToImage(data);

                
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Please select a category from the ComboBox.");
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
