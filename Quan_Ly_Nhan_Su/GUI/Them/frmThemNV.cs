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
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
            PhongBan pb = cbPhongBan.SelectedValue as PhongBan;
            int phong = pb.MaPB;
            NhanVien nv = cbNQL.SelectedValue as NhanVien;
            int nql = nv.MaNV;
            double luong = double.Parse(txtLuong.Text);
            if (kiemTraDuLieu(ten, gioiTinh, ngaySinh, phong, nql, luong))
            {
                int ketqua = NhanVienControl.themDuLieu(ten, ngaySinh, gioiTinh, phong, nql, luong );
                if (ketqua > 0)
                {
                    MessageBox.Show("thêm thành công");
                    txtHoTen.Text = "";
                    cbGioiTinh.Text = "Lựa chọn giới tính";
                    //txtSDT.Text = "";
                    txtLuong.Text = "";
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
        }

        private bool kiemTraDuLieu(string ten, string gioiTinh, DateTime ngaySinh, int pb, int nql, double luong)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            List<NhanVien> listNV = new List<NhanVien>();
            DataTable dtNV = NhanVienControl.layDanhSachNQL();
            listNV.Add(new NhanVien {
                MaNV = 0,
                TenNV = "---None---",
                NgaySinh = DateTime.Now,
                GioiTinh = "Nữ",
                Phong = 0,
                NQL = 0,
                Luong = 0
            });
            for (int i = 0; i < dtNV.Rows.Count; ++i)
            {
                if (true)
                {
                    listNV.Add(new NhanVien {
                        MaNV = Convert.ToInt32(dtNV.Rows[i][0].ToString()),
                        TenNV = dtNV.Rows[i][1].ToString(),
                        NgaySinh = DateTime.Parse(dtNV.Rows[i][2].ToString()),
                        GioiTinh = dtNV.Rows[i][3].ToString(),
                        Phong = dtNV.Rows[i][4].ToString().Length != 0 ? Convert.ToInt32(dtNV.Rows[i][4].ToString()) : 0,
                        NQL = dtNV.Rows[i][5].ToString().Length != 0 ? Convert.ToInt32(dtNV.Rows[i][5].ToString()) : 0,
                        Luong = double.Parse(dtNV.Rows[i][6].ToString())
                    });
                }
            }
            cbNQL.DataSource = listNV;
            cbNQL.DisplayMember = "TenNV";
            cbNQL.Text = "----Chọn Người Quản Lý----";
            //
            List<PhongBan> listPB = new List<PhongBan>();
            listPB.Add(new PhongBan {
                MaPB = 0,
                TenPB = "---None---",
                TruongPhong = 0,
                ViTri = ""
            });
            DataTable dtPB = NhanVienControl.layDanhSachPB();
            for (int i = 0; i < dtPB.Rows.Count; ++i)
            {
                if (true)
                {
                    listPB.Add(new PhongBan
                    {
                        MaPB = Convert.ToInt32(dtPB.Rows[i][0].ToString()),
                        TenPB = dtPB.Rows[i][1].ToString(),
                        TruongPhong = dtPB.Rows[i][2].ToString().Length != 0 ? Convert.ToInt32(dtPB.Rows[i][2].ToString()) : 0,
                        ViTri = dtPB.Rows[i][3].ToString()
                    });
                }
            }
            cbPhongBan.DataSource = listPB;
            cbPhongBan.DisplayMember = "TenPB";
            cbPhongBan.Text = "----Chọn Phòng Ban----";
        }
    }
}
