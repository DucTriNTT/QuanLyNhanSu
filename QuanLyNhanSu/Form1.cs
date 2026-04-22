using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        bool isAdding = false;
        NhanVienBUS bus = new NhanVienBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAddNewEmployee f = new FormAddNewEmployee();
            f.Text = "Thêm nhân viên mới";
            f.ShowDialog();
            this.toolStripButton6_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string ma = dataGridView1.CurrentRow.Cells["MaNV"].Value?.ToString() ?? "";
                string ten = dataGridView1.CurrentRow.Cells["HoTen"].Value?.ToString() ?? "";
                FormAddNewEmployee f = new FormAddNewEmployee();
                f.Text = "Cập nhật thông tin: " + ten;
                f.GuiDuLieu(ma, ten);
                f.ShowDialog();
                toolStripButton6_Click(null, null);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!");
                isAdding = false;
                txtMaNV.Enabled = false;
                txtHoTen.Focus();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void phòngBanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPhongBan f = new frmPhongBan();
            f.Show();
        }

        private void toolStripButton6_Click(object? sender, EventArgs? e)
        {
            dataGridView1.DataSource = bus.LayDanhSach();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string ma = dataGridView1.CurrentRow.Cells["MaNV"].Value?.ToString() ?? "";
                if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên có mã {ma}?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bus.XoaNhanVien(ma))
                    {
                        MessageBox.Show("Xóa thành công!");
                        toolStripButton6_Click(null, null);
                    }
                }
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
