namespace BuiTienThinh_22102363
{
    partial class GridView
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
            dataGridView1 = new DataGridView();
            CateID = new DataGridViewTextBoxColumn();
            CateName = new DataGridViewTextBoxColumn();
            CatePic = new DataGridViewImageColumn();
            Delete = new DataGridViewButtonColumn();
            btnAdd = new Button();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CateID, CateName, CatePic, Delete });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(691, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CateID
            // 
            CateID.DataPropertyName = "Id";
            CateID.HeaderText = "CateID";
            CateID.MinimumWidth = 6;
            CateID.Name = "CateID";
            CateID.ReadOnly = true;
            CateID.Width = 125;
            // 
            // CateName
            // 
            CateName.DataPropertyName = "Name";
            CateName.HeaderText = "CateName";
            CateName.MinimumWidth = 6;
            CateName.Name = "CateName";
            CateName.Width = 125;
            // 
            // CatePic
            // 
            CatePic.DataPropertyName = "Picture";
            CatePic.HeaderText = "CatePic";
            CatePic.MinimumWidth = 6;
            CatePic.Name = "CatePic";
            CatePic.ReadOnly = true;
            CatePic.Width = 125;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Del";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(625, 301);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(412, 301);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "GridView";
            Text = "GridView";
            Load += GridView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CateID;
        private DataGridViewTextBoxColumn CateName;
        private DataGridViewImageColumn CatePic;
        private DataGridViewButtonColumn Delete;
        private Button btnAdd;
        private Button button1;
        private BindingSource bindingSource1;
    }
}