using Quan_Ly_Nhan_Su.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Controls
{
    class NhanVienControl
    {
        private static NhanVienControl instance;
        public NhanVienControl Instance
        {
            private set { if (instance == null) instance = new NhanVienControl(); instance = value; }
            get { return instance; }
        }
        private NhanVienControl()
        {

        }
        public static int themDuLieu(string ten, DateTime ngaysinh, string gioitinh, int phong, int nql, double luong)
        {
            string query = "exec themnv @ten , @ngaysinh , @gioitinh , @phong , @nql , @luong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, gioitinh, phong, nql, luong });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = " select a.MaNV, a.TenNV, a.NgaySinh, a.GioiTinh, b.TenPB, a.NQL, a.Luong "
                + "from(select nv1.MaNV, nv1.TenNV, nv1.NgaySinh, nv1.GioiTinh, nv1.Phong, nv2.TenNV as NQL, nv1.Luong "
                + " from NhanVien as nv1 left join NhanVien as nv2 on nv1.NQL = nv2.MaNV) as a "
                + " left join PhongBan as b on a.Phong = b.MaPB";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = " select a.MaNV, a.TenNV, a.NgaySinh, a.GioiTinh, b.TenPB, a.NQL, a.Luong "
               + "from(select nv1.MaNV, nv1.TenNV, nv1.NgaySinh, nv1.GioiTinh, nv1.Phong, nv2.TenNV as NQL, nv1.Luong "
               + " from NhanVien as nv1 left join NhanVien as nv2 on nv1.NQL = nv2.MaNV) as a "
               + " left join PhongBan as b on a.Phong = b.MaPB where a.MaNV = @ma";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        //public static string layTenKH(int id)
        //{
        //    if (id == 0)
        //    {
        //        return "";
        //    }
        //    string query = "select TenKH from KhachHang where MaKH = @ma";
        //    return DataProvider.Instance.ExecuteScalar(query, new object[] { id }).ToString();
        //}
        public static int suaThongTin(int id, string ten, string ngaysinh, string gioitinh, int phong, int nql, double luong) // sửa thông tin của khách hàng
        {
            string query = "exec suanv @id , @ten , @ngaysinh , @gioitinh , @phong , @nql , @luong";
            if (luong == 0) return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, ngaysinh, gioitinh, phong, nql, "" });
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, ngaysinh, gioitinh, phong, nql, luong });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoanv @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = " select a.MaNV, a.TenNV, a.NgaySinh, a.GioiTinh, b.TenPB, a.NQL, a.Luong "
               + "from(select nv1.MaNV, nv1.TenNV, nv1.NgaySinh, nv1.GioiTinh, nv1.Phong, nv2.TenNV as NQL, nv1.Luong "
               + " from NhanVien as nv1 left join NhanVien as nv2 on nv1.NQL = nv2.MaNV) as a "
               + " left join PhongBan as b on a.Phong = b.MaPB "
               + " where a.TenNV like @ten or a.GioiTinh like @gioitinh or b.TenPB like @phong or a.NQL like @nql";
            //string query = "select * from GiaoVien where TenGV like @ten or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str, str });
        }
        public static DataTable layDanhSachPB()
        {
            string query = "select * from PhongBan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static DataTable layDanhSachNQL()
        {
            string query = "select * from NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int layMaPhong(int idNV)
        {
            string query = "select Phong from NhanVien where MaNV = @ma";
            string ketQua = DataProvider.Instance.ExecuteQuery(query, new object[] { idNV }).Rows[0][0].ToString();
            return ketQua.Length > 0 ? Convert.ToInt32(ketQua) : 0;
        }
        public static int layNQL(int idNV)
        {
            string query = "select NQL from NhanVien where MaNV = @ma";
            string ketQua = DataProvider.Instance.ExecuteQuery(query, new object[] { idNV }).Rows[0][0].ToString();
            return ketQua.Length > 0 ? Convert.ToInt32(ketQua) : 0;
        }
    }
}
