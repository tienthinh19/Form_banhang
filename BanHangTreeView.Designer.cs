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
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(178, 521);
            listView1.Name = "listView1";
            listView1.Size = new Size(459, 228);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(-2, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(151, 749);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 198);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên sản phẩm :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 293);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Tổng giá :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(313, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(178, 366);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Nhập mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 366);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(434, 366);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(668, 460);
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
            label3.Location = new Point(178, 246);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Đơn giá :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 11;
            label4.Text = "Bán Hàng";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(313, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 27);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(543, 366);
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
            // textBox5
            // 
            textBox5.Location = new Point(313, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(291, 27);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 109);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 18;
            label5.Text = "Tên khách hàng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 153);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 19;
            label6.Text = "Id nhân viên";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(313, 102);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(291, 27);
            textBox6.TabIndex = 20;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(668, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(547, 218);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(543, 460);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 23;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(187, 462);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 27);
            textBox4.TabIndex = 24;
            textBox4.TextChanged += textBox4_TextChanged_2;
            // 
            // BanHangTreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 749);
            Controls.Add(textBox4);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button button5;
        private TextBox textBox4;
    }
}