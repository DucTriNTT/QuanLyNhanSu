namespace QuanLyNhanSu
{
    partial class FormUsers
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
            label3 = new Label();
            btnThem_Click = new Button();
            button2 = new Button();
            btnXoa_Click = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            cbRole = new ComboBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 165);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 288);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 2;
            label3.Text = "Loại tài khoản";
            // 
            // btnThem_Click
            // 
            btnThem_Click.FlatStyle = FlatStyle.Popup;
            btnThem_Click.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem_Click.Location = new Point(48, 383);
            btnThem_Click.Name = "btnThem_Click";
            btnThem_Click.Size = new Size(112, 50);
            btnThem_Click.TabIndex = 3;
            btnThem_Click.Text = "Thêm";
            btnThem_Click.UseVisualStyleBackColor = true;
            btnThem_Click.Click += btnThem_Click_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(225, 383);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 4;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnXoa_Click
            // 
            btnXoa_Click.FlatStyle = FlatStyle.Popup;
            btnXoa_Click.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa_Click.Location = new Point(410, 383);
            btnXoa_Click.Name = "btnXoa_Click";
            btnXoa_Click.Size = new Size(112, 50);
            btnXoa_Click.TabIndex = 5;
            btnXoa_Click.Text = "Xoá";
            btnXoa_Click.UseVisualStyleBackColor = true;
            btnXoa_Click.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(48, 602);
            button4.Name = "button4";
            button4.Size = new Size(112, 50);
            button4.TabIndex = 6;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(633, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(541, 614);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(228, 287);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(353, 33);
            cbRole.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 47);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(356, 31);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(356, 31);
            txtPassword.TabIndex = 10;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 711);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(cbRole);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(btnXoa_Click);
            Controls.Add(button2);
            Controls.Add(btnThem_Click);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUsers";
            Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem_Click;
        private Button button2;
        private Button btnXoa_Click;
        private Button button4;
        private DataGridView dataGridView1;
        private ComboBox cbRole;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}