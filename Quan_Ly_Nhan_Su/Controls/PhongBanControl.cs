using Quan_Ly_Nhan_Su.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Controls
{
    class PhongBanControl
    {
        private static PhongBanControl instance;
        public PhongBanControl Instance
        {
            private set { if (instance == null) instance = new PhongBanControl(); instance = value; }
            get { return instance; }
        }
        private PhongBanControl()
        {

        }
        public static int themDuLieu(string ten, int truongphong, string vitri)
        {
            string query = "exec thempb @ten , @truong , @vitri";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, truongphong, vitri });
        }
        public static DataTable layDanhSach()
        {
            string query = "select pb.MaPB, pb.TenPB, nv.TenNV, pb.ViTri "
                + " from PhongBan as pb left join NhanVien as nv on pb.TruongPB = nv.MaNV";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id)
        {
            string query = "select pb.MaPB, pb.TenPB, nv.TenNV, pb.ViTri "
                + " from PhongBan as pb left join NhanVien as nv on pb.TruongPB = nv.MaNV where pb.MaPB = @ma";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }

        public static int suaThongTin(int id, string ten, int truong, string vitri) // sửa thông tin của khách hàng
        {
            string query = "exec suapb @id , @ten , @truong , @vitri";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, truong, vitri });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoapb @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select pb.MaPB, pb.TenPB, nv.TenNV, pb.ViTri "
                + " from PhongBan as pb left join NhanVien as nv on pb.TruongPB = nv.MaNV"
                + " where pb.TenPB like @tenpb or nv.TenNV like @tennv or pb.ViTri like @vitri";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str });
        }
        public static DataTable layDanhSachNhanVien()
        {
            string query = "select nv.MaNV, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.Phong, nv.NQL, nv.Luong "
                + " from NhanVien as nv, (select MaNV from NhanVien except select TruongPB from PhongBan) as b "
                + " where nv.MaNV = b.MaNV";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public static int layMaTruongPhong(int idPB)
        {
            string query = "select TruongPB from PhongBan where MaPB = @ma";
            string ketQua = DataProvider.Instance.ExecuteQuery(query, new object[] { idPB }).Rows[0][0].ToString();
            return ketQua.Length > 0 ? Convert.ToInt32(ketQua) : 0;
        }
        public static DataTable layThongTinNV(int id)
        {
            string query = "select * from NhanVien where MaNV = @ma";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
        public static DataTable layDanhSachNhanVien(int idPB) // lấy danh sách nv trong phòng ban
        {
            string query = "select * from NhanVien where Phong = @maphong";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idPB });
        }
    }
}
