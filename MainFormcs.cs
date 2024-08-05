using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiTienThinh_22102363
{
    public partial class MainFormcs : Form
    {

        public MainFormcs(string email)
        {
            InitializeComponent();
        }



        private void qLSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSP QLSP = new QLSP();

            QLSP.MdiParent = this;
            QLSP.Show();
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void verticalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void casToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MainFormcs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.MdiParent = this;
            frmProduct.Show();
        }

        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView gridView = new GridView();
            gridView.MdiParent = this;
            gridView.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qLTKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLTK QLTK = new QLTK();
            QLTK.MdiParent = this;
            QLTK.Show();

        }

        private void banHangTreeViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BanHangTreeView BanHangTreeView = new BanHangTreeView();
            BanHangTreeView.MdiParent = this;
            BanHangTreeView.Show();

        }

        private void layOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
