namespace BuiTienThinh_22102363
{
    partial class QLNS
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
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            imageList1 = new ImageList(components);
            openFileDialog1 = new OpenFileDialog();
            button5 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(40, 482);
            listView1.Name = "listView1";
            listView1.Size = new Size(705, 209);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 98);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 170);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 234);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "DiaChi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 292);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "DateofBirth";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(396, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(396, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(205, 234);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(396, 27);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(862, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(809, 500);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1077, 500);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1077, 581);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 414);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 27);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(651, 414);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Tìm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button5
            // 
            button5.Location = new Point(809, 581);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 19;
            button5.Text = "Chọn hình";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(540, 23);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 100;
            label5.Text = "Quản Lí Nhân Sự";
            // 
            // QLNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 724);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "QLNS";
            Text = "QLNS";
            Load += QLNS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private ImageList imageList1;
        private OpenFileDialog openFileDialog1;
        private Button button5;
        private Label label5;
    }
}