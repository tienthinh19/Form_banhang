namespace BuiTienThinh_22102363
{
    partial class MainFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormcs));
            menuStrip1 = new MenuStrip();
            qLSPToolStripMenuItem = new ToolStripMenuItem();
            qLTKToolStripMenuItem = new ToolStripMenuItem();
            banHangTreeViewToolStripMenuItem = new ToolStripMenuItem();
            layOutToolStripMenuItem = new ToolStripMenuItem();
            casToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            gridViewToolStripMenuItem = new ToolStripMenuItem();
            frmProductToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { qLSPToolStripMenuItem, qLTKToolStripMenuItem, banHangTreeViewToolStripMenuItem, layOutToolStripMenuItem, gridViewToolStripMenuItem, frmProductToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1163, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // qLSPToolStripMenuItem
            // 
            qLSPToolStripMenuItem.Name = "qLSPToolStripMenuItem";
            qLSPToolStripMenuItem.Size = new Size(57, 24);
            qLSPToolStripMenuItem.Text = "QLSP";
            qLSPToolStripMenuItem.Click += qLSPToolStripMenuItem_Click;
            // 
            // qLTKToolStripMenuItem
            // 
            qLTKToolStripMenuItem.Name = "qLTKToolStripMenuItem";
            qLTKToolStripMenuItem.Size = new Size(57, 24);
            qLTKToolStripMenuItem.Text = "QLTK";
            qLTKToolStripMenuItem.Click += qLTKToolStripMenuItem_Click_1;
            // 
            // banHangTreeViewToolStripMenuItem
            // 
            banHangTreeViewToolStripMenuItem.Name = "banHangTreeViewToolStripMenuItem";
            banHangTreeViewToolStripMenuItem.Size = new Size(144, 24);
            banHangTreeViewToolStripMenuItem.Text = "BanHangTreeView";
            banHangTreeViewToolStripMenuItem.Click += banHangTreeViewToolStripMenuItem_Click_1;
            // 
            // layOutToolStripMenuItem
            // 
            layOutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { casToolStripMenuItem, verticalToolStripMenuItem });
            layOutToolStripMenuItem.Name = "layOutToolStripMenuItem";
            layOutToolStripMenuItem.Size = new Size(69, 24);
            layOutToolStripMenuItem.Text = "LayOut";
            layOutToolStripMenuItem.Click += layOutToolStripMenuItem_Click;
            // 
            // casToolStripMenuItem
            // 
            casToolStripMenuItem.Name = "casToolStripMenuItem";
            casToolStripMenuItem.Size = new Size(153, 26);
            casToolStripMenuItem.Text = "Casscade";
            casToolStripMenuItem.Click += casToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(153, 26);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click_1;
            // 
            // gridViewToolStripMenuItem
            // 
            gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            gridViewToolStripMenuItem.Size = new Size(83, 24);
            gridViewToolStripMenuItem.Text = "GridView";
            gridViewToolStripMenuItem.Click += gridViewToolStripMenuItem_Click;
            // 
            // frmProductToolStripMenuItem
            // 
            frmProductToolStripMenuItem.Name = "frmProductToolStripMenuItem";
            frmProductToolStripMenuItem.Size = new Size(97, 24);
            frmProductToolStripMenuItem.Text = "frmProduct";
            frmProductToolStripMenuItem.Click += frmProductToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 622);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1163, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // MainFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 644);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainFormcs";
            Text = "MainFormcs";
            Load += MainFormcs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem qLSPToolStripMenuItem;
        private ToolStripMenuItem qLTKToolStripMenuItem;
        private ToolStripMenuItem banHangTreeViewToolStripMenuItem;
        private ToolStripMenuItem layOutToolStripMenuItem;
        private ToolStripMenuItem casToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem gridViewToolStripMenuItem;
        private ToolStripMenuItem frmProductToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}