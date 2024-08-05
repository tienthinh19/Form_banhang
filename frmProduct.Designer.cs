namespace BuiTienThinh_22102363
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            label1 = new Label();
            cbCategory = new ComboBox();
            btnDetail = new Button();
            btnLargeIcon = new Button();
            btnSmallIcon = new Button();
            imageList1 = new ImageList(components);
            listView1 = new ListView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            CategoryId = new ColumnHeader();
            Discount = new ColumnHeader();
            Price = new ColumnHeader();
            Description = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 53);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách loại hàng ";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(847, 52);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(369, 28);
            cbCategory.TabIndex = 1;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(847, 127);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnLargeIcon
            // 
            btnLargeIcon.Location = new Point(1122, 127);
            btnLargeIcon.Name = "btnLargeIcon";
            btnLargeIcon.Size = new Size(94, 29);
            btnLargeIcon.TabIndex = 3;
            btnLargeIcon.Text = "Large icon";
            btnLargeIcon.UseVisualStyleBackColor = true;
            btnLargeIcon.Click += btnLargeIcon_Click;
            // 
            // btnSmallIcon
            // 
            btnSmallIcon.Location = new Point(980, 127);
            btnSmallIcon.Name = "btnSmallIcon";
            btnSmallIcon.Size = new Size(94, 29);
            btnSmallIcon.TabIndex = 4;
            btnSmallIcon.Text = "Small icon";
            btnSmallIcon.UseVisualStyleBackColor = true;
            btnSmallIcon.Click += btnSmallIcon_Click;
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Description, Price, Discount, CategoryId });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(628, 210);
            listView1.Name = "listView1";
            listView1.Size = new Size(590, 254);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(628, 136);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 5;
            label2.Text = "Danh Mục Sản Phẩm";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 56);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 120);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 8;
            label4.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 170);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Giảm giá :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 240);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 10;
            label6.Text = "ID sản phẩm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 383);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 11;
            label7.Text = "Hình:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(181, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 27);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(341, 27);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(341, 27);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(368, 658);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 17;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(181, 722);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button3
            // 
            button3.Location = new Point(181, 658);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "Tải hình";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(368, 722);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 20;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(561, 658);
            button7.Name = "button7";
            button7.Size = new Size(94, 25);
            button7.TabIndex = 21;
            button7.Text = "Lưu";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Location = new Point(546, 722);
            button4.Name = "button4";
            button4.Size = new Size(197, 29);
            button4.TabIndex = 22;
            button4.Text = "Convert to binary";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(728, 654);
            button5.Name = "button5";
            button5.Size = new Size(197, 29);
            button5.TabIndex = 23;
            button5.Text = "Convert to image";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 779);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(btnSmallIcon);
            Controls.Add(btnLargeIcon);
            Controls.Add(btnDetail);
            Controls.Add(cbCategory);
            Controls.Add(label1);
            Name = "frmProduct";
            Text = "Product";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCategory;
        private Button btnDetail;
        private Button btnLargeIcon;
        private Button btnSmallIcon;
        private ImageList imageList1;
        private ListView listView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button5;
        private ColumnHeader Description;
        private ColumnHeader Price;
        private ColumnHeader Discount;
        private ColumnHeader CategoryId;
    }
}