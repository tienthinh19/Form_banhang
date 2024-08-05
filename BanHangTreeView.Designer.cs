namespace BuiTienThinh_22102363
{
    partial class BanHangTreeView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHangTreeView));
            listView1 = new ListView();
            treeView1 = new TreeView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(191, 301);
            listView1.Name = "listView1";
            listView1.Size = new Size(471, 228);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(-2, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(151, 655);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 173);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Tổng giá :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(472, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(472, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(191, 240);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Nhập mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 240);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(434, 240);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(698, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 112);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Đơn giá :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 11);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 11;
            label4.Text = "Bán Hàng";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(409, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(472, 27);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(553, 240);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Tiếp tục  ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bongtai1.png");
            imageList1.Images.SetKeyName(1, "bongtai2.png");
            imageList1.Images.SetKeyName(2, "bongtai3.png");
            imageList1.Images.SetKeyName(3, "lactay1.png");
            imageList1.Images.SetKeyName(4, "lactay2.png");
            imageList1.Images.SetKeyName(5, "lactay3.png");
            imageList1.Images.SetKeyName(6, "nhan1.png");
            imageList1.Images.SetKeyName(7, "nhan2.png");
            imageList1.Images.SetKeyName(8, "nhan3.png");
            imageList1.Images.SetKeyName(9, "vongco1.png");
            imageList1.Images.SetKeyName(10, "vongco2.png");
            imageList1.Images.SetKeyName(11, "vongco3.png");
            // 
            // BanHangTreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 655);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Name = "BanHangTreeView";
            Text = "BanHangTreeView";
            Load += BanHangTreeView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button4;
        private ImageList imageList1;
    }
}