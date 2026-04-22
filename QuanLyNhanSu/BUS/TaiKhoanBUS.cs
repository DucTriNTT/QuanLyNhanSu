using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.DAL;

namespace QuanLyNhanSu.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public bool Authenticate(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                return false;
            }

            return dal.CheckLogin(user, pass);
        }
    }
}
