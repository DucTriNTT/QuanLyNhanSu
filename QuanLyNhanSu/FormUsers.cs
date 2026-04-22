using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class FormUsers : Form
    {
        UserBUS busUser = new UserBUS();

        public FormUsers() => InitializeComponent();

        private void button3_Click(object sender, EventArgs e)
        {
            string userXoa = txtUsername.Text;
            if (userXoa == Const.CurrentUser)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản đang sử dụng!");
                return;
            }

            if (busUser.XoaTaiKhoan(userXoa))
            {
                MessageBox.Show("Đã xóa tài khoản!");
                LoadData();
            }
        }

        private void btnThem_Click_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ tên và mật khẩu!");
                return;
            }
            if (busUser.ThemTaiKhoan(txtUsername.Text, txtPassword.Text, cbRole.Text))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadData();
            }
        }

        void LoadData()
        {
            dataGridView1.DataSource = busUser.LayDanhSachTaiKhoan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
