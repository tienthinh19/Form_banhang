namespace BuiTienThinh_22102363
{
    partial class QLTK
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            textBox6 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản Lí Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 89);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(272, 298);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(381, 27);
            textBox5.TabIndex = 6;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 145);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 7;
            label3.Text = "Role ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 216);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 305);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 10;
            label6.Text = "Mật khẩu :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 444);
            label7.Name = "label7";
            label7.Size = new Size(236, 20);
            label7.TabIndex = 13;
            label7.Text = "Danh sách tài khoản đang quản lí :";
            // 
            // button2
            // 
            button2.Location = new Point(691, 477);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(272, 479);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(381, 27);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(50, 369);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listView1
            // 
            listView1.Location = new Point(272, 571);
            listView1.Name = "listView1";
            listView1.Size = new Size(381, 121);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(272, 369);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Cập nhật";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // QLTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 756);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QLTK";
            Text = "QLTK";
            Load += QLTK_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button2;
        private TextBox textBox6;
        private Button button1;
        private ListView listView1;
        private Button button3;
    }
}