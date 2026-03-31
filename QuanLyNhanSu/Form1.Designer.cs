namespace QuanLyNhanSu_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtHoTen = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            colHoTen = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtSDT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Turquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colHoTen, colSDT, colTrangThai });
            dataGridView1.Location = new Point(112, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1268, 777);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Họ và Tên:";
            label1.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(134, 12);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(1135, 31);
            txtHoTen.TabIndex = 2;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1266, 9);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 34);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(2, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 777);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1378, 82);
            panel2.TabIndex = 7;
            // 
            // colHoTen
            // 
            colHoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.MinimumWidth = 8;
            colHoTen.Name = "colHoTen";
            // 
            // colSDT
            // 
            colSDT.HeaderText = "Số điện thoại";
            colSDT.MinimumWidth = 8;
            colSDT.Name = "colSDT";
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(171, 44);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(401, 31);
            txtSDT.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1382, 860);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Silver;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtHoTen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label label2;
        private TextBox txtSDT;
    }
}
