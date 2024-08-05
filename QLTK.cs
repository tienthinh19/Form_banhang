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
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox6.Text == null || textBox6.Text == "")
            {
                comboBox1.DataSource = accountBus.GetAll();

            }
            else
            {
                comboBox1.DataSource = accountBus.SearchAccounts(textBox6.Text);

            }
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Account selectedAccount = (Account)comboBox1.SelectedItem;

                
                textBox1.Text = selectedAccount.FullName;
                textBox2.Text = selectedAccount.RoleId;
                textBox3.Text = selectedAccount.Email;
                textBox5.Text = selectedAccount.Password;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = accountBus.GetAll();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string hashedPassword = FunctionHelper.HashPassword(textBox5.Text);
            Account newAccount = new Account
            {
                FullName = textBox1.Text,
                RoleId = textBox2.Text,
                Email = textBox3.Text,
                Password = textBox5.Text
            };

            accountBus.Insert(newAccount);


            comboBox1.DataSource = accountBus.GetAll();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
        }
    }
}
