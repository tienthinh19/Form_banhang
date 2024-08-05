namespace BuiTienThinh_22102363
{
    partial class QLSP
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(399, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(445, 129);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(276, 310);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 5;
            button3.Text = "convert to image";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(558, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 12;
            label4.Text = "Tìm sản phẩm :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 27);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 13;
            label5.Text = "Quản lý sản phẩm";
            // 
            // button2
            // 
            button2.Location = new Point(12, 310);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 4;
            button2.Text = "convert to binary";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QLSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 663);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "QLSP";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}