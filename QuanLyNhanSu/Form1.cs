using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu_
{
    public partial class Form1 : Form
    {
        // Sử dụng database hệ thống 'master' để đảm bảo không bao giờ lỗi file .mdf
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            // Sự kiện khi click vào một dòng trên bảng
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatDatabaseVaHienThi();
        }

        // --- HÀM CHÍNH: TẠO BẢNG 2 CỘT VÀ HIỂN THỊ ---
        private void CapNhatDatabaseVaHienThi()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Lệnh tạo bảng NhanVien có 2 cột: HoTen và SDT
                    string sqlSetup = @"
                        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'NhanVien')
                        BEGIN
                            CREATE TABLE NhanVien (
                                Id INT PRIMARY KEY IDENTITY, 
                                HoTen NVARCHAR(100),
                                SDT NVARCHAR(20)
                            );
                            INSERT INTO NhanVien (HoTen, SDT) VALUES 
                            (N'Nguyễn Văn Anh', '0901234567'), 
                            (N'Trần Thị Bình', '0911223344');
                        END";
                    new SqlCommand(sqlSetup, conn).ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        // Thêm vào bảng: Cột 0 (Họ tên), Cột 1 (SDT), Cột 2 (Trạng thái mẫu)
                        dataGridView1.Rows.Add(row["HoTen"].ToString(), row["SDT"].ToString(), "Chính thức");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
            }
        }

        // --- NÚT THÊM (Button 1) ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập ít nhất là Họ và Tên!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sqlInsert = "INSERT INTO NhanVien (HoTen, SDT) VALUES (@name, @phone)";
                    SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.AddWithValue("@name", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@phone", txtSDT.Text); // Lấy dữ liệu từ ô Số điện thoại
                    cmd.ExecuteNonQuery();

                    LamMoiOPhieu();
                    CapNhatDatabaseVaHienThi();
                    MessageBox.Show("Thêm nhân viên mới thành công!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi thêm: " + ex.Message); }
            }
        }

        // --- NÚT XOÁ (Button 2) ---
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow) return;

            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc muốn xoá {name}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE HoTen = @name", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
                CapNhatDatabaseVaHienThi();
            }
        }

        // --- NÚT SỬA (Button 3) ---
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Tag == null)
            {
                MessageBox.Show("Hãy chọn một dòng dưới bảng trước khi nhấn Sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sqlUpdate = "UPDATE NhanVien SET HoTen = @newName, SDT = @newPhone WHERE HoTen = @oldName";
                    SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                    cmd.Parameters.AddWithValue("@newName", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@newPhone", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@oldName", txtHoTen.Tag.ToString());
                    cmd.ExecuteNonQuery();

                    LamMoiOPhieu();
                    CapNhatDatabaseVaHienThi();
                    MessageBox.Show("Đã cập nhật thông tin thành công!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi sửa: " + ex.Message); }
            }
        }

        // --- KHI CLICK VÀO BẢNG: HIỆN CẢ TÊN VÀ SDT LÊN Ô NHẬP ---
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                // Cột 1 là Số điện thoại
                txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";

                // Ghi nhớ tên cũ để làm điều kiện tìm kiếm khi Sửa
                txtHoTen.Tag = txtHoTen.Text;
            }
        }

        private void LamMoiOPhieu()
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtHoTen.Tag = null;
        }

        // Các hàm trống để tránh lỗi Design
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtHoTen_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}