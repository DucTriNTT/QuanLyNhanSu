using Microsoft.Data.SqlClient;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAL
{
    public class NhanVienDAL
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

        public DataTable GetListNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SELECT * FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

            public bool DeleteNhanVien(string ma)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sql = "DELETE FROM NhanVien WHERE MaNV = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE NhanVien SET HoTen=@ten, SDT=@sdt, PhongBan=@pb WHERE MaNV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", nv.MaNV);
                cmd.Parameters.AddWithValue("@ten", nv.HoTen);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@pb", nv.PhongBan);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
    }
