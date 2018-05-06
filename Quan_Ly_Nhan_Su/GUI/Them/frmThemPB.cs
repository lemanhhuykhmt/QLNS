using Quan_Ly_Nhan_Su.Controls;
using Quan_Ly_Nhan_Su.ExtendModel;
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

namespace Quan_Ly_Nhan_Su.GUI.Them
{
    public partial class frmThemPB : Form
    {
        public frmThemPB()
        {
            InitializeComponent();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenPhong.Text;
            NhanVien nv = cbTruongPhong.SelectedValue as NhanVien;
            string vitri = txtViTri.Text;
            if (kiemTraDuLieu(ten, nv, vitri))
            {
                int ketqua = PhongBanControl.themDuLieu(ten, nv.MaNV, vitri);
                if (ketqua > 0)
                {
                    MessageBox.Show("thêm thành công");
                    txtTenPhong.Text = "";
                    cbTruongPhong.Text = "Lựa chọn giới tính";
                    txtViTri.Text = "";
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
        }

        private bool kiemTraDuLieu(string ten, NhanVien nv, string vitri)
        {
            if (nv == null) return false;
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThemPB_Load(object sender, EventArgs e)
        {
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
            });
            DataTable dt = PhongBanControl.layDanhSachNhanVien();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                listTruong.Add(new NhanVien {
                    MaNV = Convert.ToInt32(dt.Rows[i][0].ToString()),
                    TenNV = dt.Rows[i][1].ToString(),
                    NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString()),
                    GioiTinh = dt.Rows[i][3].ToString(),
                    Phong = dt.Rows[i][4].ToString().Length != 0 ? Convert.ToInt32(dt.Rows[i][4].ToString()) : 0,
                    NQL = dt.Rows[i][5].ToString().Length != 0 ? Convert.ToInt32(dt.Rows[i][5].ToString()) : 0,
                    Luong = double.Parse(dt.Rows[i][6].ToString())
                });
            }
            cbTruongPhong.DataSource = listTruong;
            cbTruongPhong.DisplayMember = "TenNV";
            cbTruongPhong.Text = "Chọn Trưởng Phòng";
        }
    }
}
