namespace QuanLyNhanSu
{
    partial class FormAddNewEmployee
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            txtDiDong = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txtHoTen = new TextBox();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            cbPhongBan = new ComboBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            txtMaNV = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(txtDiDong);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1277, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(645, 289);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 15;
            label8.Text = "Chuyên môn";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(645, 206);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 14;
            label7.Text = "Văn Hoá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(643, 125);
            label6.Name = "label6";
            label6.Size = new Size(108, 32);
            label6.TabIndex = 13;
            label6.Text = "Di động ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(643, 61);
            label5.Name = "label5";
            label5.Size = new Size(108, 32);
            label5.TabIndex = 12;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 294);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 210);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 128);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 9;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 57);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 8;
            label1.Text = "Họ tên";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(784, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(403, 33);
            comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(193, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(401, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(803, 294);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(384, 31);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(784, 206);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(403, 31);
            textBox5.TabIndex = 4;
            // 
            // txtDiDong
            // 
            txtDiDong.BorderStyle = BorderStyle.FixedSingle;
            txtDiDong.Location = new Point(784, 125);
            txtDiDong.Name = "txtDiDong";
            txtDiDong.Size = new Size(403, 31);
            txtDiDong.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(191, 295);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(403, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(193, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 31);
            textBox2.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(193, 61);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(403, 31);
            txtHoTen.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(cbPhongBan);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(12, 437);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1277, 318);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hợp đồng";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(803, 156);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(384, 33);
            comboBox3.TabIndex = 11;
            // 
            // cbPhongBan
            // 
            cbPhongBan.FormattingEnabled = true;
            cbPhongBan.Location = new Point(803, 73);
            cbPhongBan.Name = "cbPhongBan";
            cbPhongBan.Size = new Size(384, 33);
            cbPhongBan.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(803, 236);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(384, 31);
            textBox10.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(250, 239);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(344, 31);
            textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(250, 156);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(344, 31);
            textBox8.TabIndex = 7;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(250, 70);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(344, 31);
            txtMaNV.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(650, 236);
            label14.Name = "label14";
            label14.Size = new Size(101, 32);
            label14.TabIndex = 5;
            label14.Text = "Phụ cấp";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(646, 153);
            label13.Name = "label13";
            label13.Size = new Size(131, 32);
            label13.TabIndex = 4;
            label13.Text = "Trạng thái ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(645, 67);
            label12.Name = "label12";
            label12.Size = new Size(132, 32);
            label12.TabIndex = 3;
            label12.Text = "Phòng ban";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(65, 239);
            label11.Name = "label11";
            label11.Size = new Size(84, 32);
            label11.TabIndex = 2;
            label11.Text = "Lương";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(65, 153);
            label10.Name = "label10";
            label10.Size = new Size(102, 32);
            label10.TabIndex = 1;
            label10.Text = "Chức vụ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(65, 70);
            label9.Name = "label9";
            label9.Size = new Size(163, 32);
            label9.TabIndex = 0;
            label9.Text = "Mã nhân viên";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(815, 779);
            button1.Name = "button1";
            button1.Size = new Size(168, 59);
            button1.TabIndex = 2;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(1031, 779);
            button2.Name = "button2";
            button2.Size = new Size(168, 59);
            button2.TabIndex = 3;
            button2.Text = "Huỷ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 871);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormAddNewEmployee";
            Text = "FormAddNewEmployee";
            Load += FormAddNewEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox txtDiDong;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtHoTen;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox cbPhongBan;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox txtMaNV;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button1;
        private Button button2;
    }
}