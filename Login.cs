using System;
using System.Windows.Forms;
using BuiTienThinh_22102363.BUS;

namespace BuiTienThinh_22102363
{
    public partial class Login : Form
    {
        private AccountBUS accountBUS = new AccountBUS();

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void ValidateLogin()
        {
            string email = textBox1.Text;
            string password = textBox2.Text;


            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                button1.Enabled = false;
                return;
            }


            bool isValid = accountBUS.ValidateCredentials(email, password);
            button1.Enabled = isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (accountBUS.ValidateCredentials(email, password))
            {

                MainFormcs frm = new MainFormcs(email);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không chính xác.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hozaticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     
    }
}
