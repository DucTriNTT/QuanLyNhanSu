using QuanLyNhanSu.DAL;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL dal = new NhanVienDAL();

        public DataTable LayDanhSach()
        {
            return dal.GetListNhanVien();
        }

        public bool XoaNhanVien(string ma)
        {
            return dal.DeleteNhanVien(ma);
        }

        public bool SuaNhanVien(NhanVienDTO nv)
        {
            return dal.UpdateNhanVien(nv);
        }

        internal bool ThemNhanVien(NhanVienDTO nv)
        {
            throw new NotImplementedException();
        }

        internal object GetListNhanVien()
        {
            throw new NotImplementedException();
        }
    }
}