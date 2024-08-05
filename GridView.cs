using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuiTienThinh_22102363.BUS;

namespace BuiTienThinh_22102363
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
            cateBUS = new CategoryBUS();

        }
        CategoryBUS cateBUS;
        private void GridView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DataTable catetable = cateBUS.GetAllTable();
            bindingSource1.DataSource = catetable;
            bindingSource1.Sort = "Id DESC";
            dataGridView1.DataSource = bindingSource1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                bindingSource1.RemoveCurrent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kq = cateBUS.UpdateTable((DataTable)bindingSource1.DataSource);
            MessageBox.Show(kq ? "Cập nhật thành công!" : "Cập nhật thất bại!");
        }
    }
}
