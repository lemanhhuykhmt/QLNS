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
        public static int themDuLieu(string ten, DateTime ngaysinh, string sdt, string gioitinh, double luong)
        {
            string query = "exec themgv @ten , @ngaysinh , @sdt , @gioitinh , @luong";
            if(luong == 0) return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, sdt, gioitinh, null });
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, sdt, gioitinh, luong });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from GiaoVien";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from GiaoVien where MaGV = @ma";//lấy ra thông tin khách hàng có mã
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
        public static int suaThongTin(int id, string ten, string ngaysinh, string sdt, string gioitinh, double luong) // sửa thông tin của khách hàng
        {
            string query = "exec suagv @id , @ten , @ngaysinh , @sdt , @gioitinh , @luong";
            if(luong == 0) return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, ngaysinh, sdt, gioitinh, "" });
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, ngaysinh, sdt, gioitinh, luong });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoagv @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from GiaoVien where TenGV like @ten or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str });
        }
        public static DataTable layDanhSachPB()
        {
            string query = "select * ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
