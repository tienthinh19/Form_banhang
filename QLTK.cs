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
    public partial class QLTK : Form
    {
        private AccountBUS accountBus;

        public QLTK()
        {
            InitializeComponent();
            new FunctionHelper();
            accountBus = new AccountBUS();
            InitializeListView1();
            if (textBox1 != null) textBox1.TextChanged += textBox1_TextChanged;
            if (textBox2 != null) textBox2.TextChanged += textBox2_TextChanged;
            if (textBox3 != null) textBox3.TextChanged += textBox3_TextChanged;
            if (textBox5 != null) textBox5.TextChanged += textBox4_TextChanged;
            button3.Enabled = false;

        }

        private void InitializeListView1()
        {
            // Thiết lập thuộc tính của ListView nếu cần
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Thêm cột vào ListView
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Name", 50);

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = textBox6.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadAccounts();
            }
            else
            {
                SearchAccounts(keyword);
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
        private void LoadAccounts()
        {
            listView1.Items.Clear();
            List<Account> accounts = accountBus.GetAll();
            foreach (var account in accounts)
            {
                ListViewItem item = new ListViewItem(account.Id.ToString());
                item.SubItems.Add(account.Email);
                item.SubItems.Add(account.FullName);
                item.SubItems.Add(account.RoleId);
                item.SubItems.Add(account.Password);
                listView1.Items.Add(item);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string hashedPassword = FunctionHelper.HashPassword(textBox5.Text);
            Account newAccount = new Account
            {
                FullName = textBox1.Text,
                RoleId = textBox2.Text,
                Email = textBox3.Text,
                Password = hashedPassword
            };

            accountBus.Insert(newAccount);
            LoadAccounts();
        }

        private void SearchAccounts(string keyword)
        {
            listView1.Items.Clear();
            List<Account> accounts = accountBus.SearchAccounts(keyword);
            foreach (var account in accounts)
            {
                ListViewItem item = new ListViewItem(account.Id.ToString());
                item.SubItems.Add(account.Email);
                item.SubItems.Add(account.FullName);
                item.SubItems.Add(account.RoleId);
                item.SubItems.Add(account.Password);
                listView1.Items.Add(item);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (selectedItem != null && textBox1 != null && textBox2 != null && textBox3 != null && textBox5 != null)
                {
                    textBox1.Text = selectedItem.SubItems[2].Text;
                    textBox2.Text = selectedItem.SubItems[3].Text;
                    textBox3.Text = selectedItem.SubItems[1].Text;
                    textBox5.Text = selectedItem.SubItems[4].Text;
                }
                else
                {
                    MessageBox.Show("Một hoặc nhiều trường không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Kiểm tra nếu các TextBox không null
                if (selectedItem != null && textBox1 != null && textBox2 != null && textBox3 != null && textBox5 != null)
                {
                    Account updatedAccount = new Account
                    {
                        Id = Convert.ToInt32(selectedItem.SubItems[0].Text),
                        Email = textBox3.Text,
                        FullName = textBox1.Text,
                        RoleId = textBox2.Text,
                        Password = FunctionHelper.HashPassword(textBox5.Text)
                    };

                    accountBus.Update(updatedAccount);
                    LoadAccounts();
                    button3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Một hoặc nhiều trường không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có mục nào được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
