using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BuiTienThinh_22102363.BUS;
using BuiTienThinh_22102363.DTO;

namespace BuiTienThinh_22102363
{
    public partial class QLNS : Form
    {
        private EmployeeBUS employeeBus;

        public QLNS()
        {
            new FunctionHelper();
            InitializeComponent();
            employeeBus = new EmployeeBUS();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Full Name", 150);
            listView1.Columns.Add("Position", 100);
            listView1.Columns.Add("Address", 150);
            listView1.Columns.Add("Date of Birth", 100);
        }

        private void QLNS_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            listView1.Items.Clear();
            List<Employee> employees = employeeBus.GetAllEmployees();
            foreach (var employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.FullName);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(employee.DiaChi);
                item.SubItems.Add(employee.DateofBirth.ToShortDateString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy mục đã chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Lấy ID nhân viên từ mục đã chọn
                int employeeId = int.Parse(selectedItem.Text);

                // Sử dụng ID để lấy thông tin nhân viên từ cơ sở dữ liệu
                Employee employee = employeeBus.GetById(employeeId);

                // Cập nhật các TextBox với thông tin của nhân viên
                if (employee != null)
                {
                    textBox1.Text = employee.Position;
                    textBox3.Text = employee.FullName;
                    textBox6.Text = employee.DiaChi;
                    textBox4.Text = employee.DateofBirth.ToShortDateString();

                    // Cập nhật hình ảnh trong PictureBox nếu có
                    if (employee.Picture != null)
                    {
                        using (MemoryStream ms = new MemoryStream(employee.Picture))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    // Nếu không tìm thấy nhân viên, xóa thông tin trong các TextBox và PictureBox
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    pictureBox1.Image = null;
                }
            }
        }

        private void DisplayEmployeeDetails(int employeeId)
        {
            Employee employee = employeeBus.GetById(employeeId); 
            if (employee != null)
            {
                textBox1.Text = employee.Position;
                textBox6.Text = employee.DiaChi;
                textBox4.Text = employee.DateofBirth.ToShortDateString();
                textBox3.Text = employee.FullName;

                if (employee.Picture != null)
                {
                    using (MemoryStream ms = new MemoryStream(employee.Picture))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin đã được nhập đầy đủ
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuyển đổi ngày tháng từ chuỗi
            DateTime dateOfBirth;
            if (!DateTime.TryParseExact(textBox4.Text, "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture,
                                        System.Globalization.DateTimeStyles.None,
                                        out dateOfBirth))
            {
                MessageBox.Show("Định dạng ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Employee mới
            Employee newEmployee = new Employee
            {
                FullName = textBox1.Text,
                Position = textBox3.Text,
                DiaChi = textBox6.Text,
                DateofBirth = dateOfBirth,
                Picture = pictureBox1.Image != null ? FunctionHelper.ConvertImageToBinary(pictureBox1.Image) : null
            };

            // Thêm nhân viên vào cơ sở dữ liệu
            employeeBus.AddEmployee(newEmployee);

            // Tải lại danh sách nhân viên
            LoadEmployees();

            // Thông báo thành công
            MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Kiểm tra các trường thông tin đã được nhập đầy đủ
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chuyển đổi ngày tháng từ chuỗi
                DateTime dateOfBirth;
                if (!DateTime.TryParseExact(textBox4.Text, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.InvariantCulture,
                                            System.Globalization.DateTimeStyles.None,
                                            out dateOfBirth))
                {
                    MessageBox.Show("Định dạng ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng Employee với thông tin đã cập nhật
                Employee updatedEmployee = new Employee
                {
                    Id = Convert.ToInt32(selectedItem.SubItems[0].Text),
                    FullName = textBox1.Text,
                    Position = textBox3.Text,
                    DiaChi = textBox6.Text,
                    DateofBirth = dateOfBirth,
                    Picture = pictureBox1.Image != null ? FunctionHelper.ConvertImageToBinary(pictureBox1.Image) : null
                };

                // Cập nhật thông tin nhân viên trong cơ sở dữ liệu
                employeeBus.UpdateEmployee(updatedEmployee);

                // Tải lại danh sách nhân viên
                LoadEmployees();

                // Thông báo thành công
                MessageBox.Show("Cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int employeeId = int.Parse(selectedItem.Text);

                employeeBus.DeleteEmployee(employeeId);
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string keyword = textBox2.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadEmployees();
            }
            else
            {
                SearchEmployees(keyword);
            }
        }

        private void SearchEmployees(string keyword)
        {
            listView1.Items.Clear();
            List<Employee> employees = employeeBus.SearchEmployees(keyword);
            foreach (var employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.FullName);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(employee.DiaChi);
                item.SubItems.Add(employee.DateofBirth.ToShortDateString());
                listView1.Items.Add(item);
            }
        }

        private byte[] GetImageBytes(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (DialogResult.OK == ofd.ShowDialog())
            {
                
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
