using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace QuanLyNhanSu
{
    public class UserBUS
    {

        UserDAL dal = new UserDAL();
        public bool ThemTaiKhoan(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable LayDanhSachTaiKhoan()
        {
            return dal.GetListUser();
        }

        internal bool XoaTaiKhoan(string userXoa)
        {
            throw new NotImplementedException();
        }
    }
}