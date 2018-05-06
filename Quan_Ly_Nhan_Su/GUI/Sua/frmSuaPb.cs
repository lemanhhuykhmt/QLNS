using Quan_Ly_Nhan_Su.Controls;
using Quan_Ly_Nhan_Su.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.GUI.Sua
{
    public partial class frmSuaPB : Form
    {
        private int id;
        public frmSuaPB()
        {
            InitializeComponent();
        }
        public frmSuaPB(int id)
        {
            InitializeComponent();
            this.id = id;



            DataTable dt = PhongBanControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtTruongPhongCu.Text = dt.Rows[0][2].ToString();
            txtViTriCu.Text = dt.Rows[0][3].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string vitri = txtViTriMoi.Text;
            NhanVien nv = cbTruongPhongMoi.SelectedValue as NhanVien;
            
            if (kiemTra(ten, nv, vitri))
            {
                int ketQua = 0;
                ketQua = PhongBanControl.suaThongTin(id, ten, nv.MaNV, vitri);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, NhanVien nv, string vitri)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmSuaPB_Load(object sender, EventArgs e)
        {
            // load cbTruongPhongMoi
            int truongPhong = PhongBanControl.layMaTruongPhong(id); //thấy MaNV là trưởng phòng này
            List<NhanVien> listTruong = new List<NhanVien>();
            
            listTruong.Add(new NhanVien
            {
                MaNV = 0,
                TenNV = "---None---",
                NgaySinh = DateTime.Now,
                GioiTinh = "Nữ",
                Phong = 0,
                NQL = 0,
                Luong = 0
            }); // thêm none
            DataTable dtNV = PhongBanControl.layThongTinNV(truongPhong); 
            listTruong.Add(new NhanVien
            {
                MaNV = Convert.ToInt32(dtNV.Rows[0][0].ToString()),
                TenNV = dtNV.Rows[0][1].ToString(),
                NgaySinh = DateTime.Parse(dtNV.Rows[0][2].ToString()),
                GioiTinh = dtNV.Rows[0][3].ToString(),
                Phong = dtNV.Rows[0][4].ToString().Length != 0 ? Convert.ToInt32(dtNV.Rows[0][4].ToString()) : 0,
                NQL = dtNV.Rows[0][5].ToString().Length != 0 ? Convert.ToInt32(dtNV.Rows[0][5].ToString()) : 0,
                Luong = double.Parse(dtNV.Rows[0][6].ToString())
            });// thêm chính trưởng phòng hiện tại
            DataTable dt = PhongBanControl.layDanhSachNhanVien(); //  load ds nv kp trưởng phòng
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                listTruong.Add(new NhanVien
                {
                    MaNV = Convert.ToInt32(dt.Rows[i][0].ToString()),
                    TenNV = dt.Rows[i][1].ToString(),
                    NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString()),
                    GioiTinh = dt.Rows[i][3].ToString(),
                    Phong = dt.Rows[i][4].ToString().Length != 0 ? Convert.ToInt32(dt.Rows[i][4].ToString()) : 0,
                    NQL = dt.Rows[i][5].ToString().Length != 0 ? Convert.ToInt32(dt.Rows[i][5].ToString()) : 0,
                    Luong = double.Parse(dt.Rows[i][6].ToString())
                });
            }
            cbTruongPhongMoi.DataSource = listTruong;
            cbTruongPhongMoi.DisplayMember = "TenNV";
            cbTruongPhongMoi.SelectedIndex = 1;
        }
    }
}
