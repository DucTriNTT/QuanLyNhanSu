using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DTO;

namespace QuanLyNhanSu
{
    public partial class FormAddNewEmployee : Form
    {

        public FormAddNewEmployee()
        {
            InitializeComponent();
        }

        public void GuiDuLieu(string ma, string ten)
        {
            txtMaNV.Text = ma;
            txtMaNV.Enabled = false;
            txtHoTen.Text = ten;
        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            nv.SDT = txtDiDong.Text;
            nv.PhongBan = cbPhongBan.Text;
            NhanVienBUS bus = new NhanVienBUS();

            if (bus.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên mới thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

