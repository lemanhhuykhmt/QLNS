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
    public partial class frmSuaNV : Form
    {
        private int id;
        public frmSuaNV()
        {
            InitializeComponent();
        }
        public frmSuaNV(int id)
        {
            InitializeComponent();
            this.id = id;
            DataTable dt = NhanVienControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtNgaySinhCu.Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][2]);
            txtGioiTinh.Text = dt.Rows[0][3].ToString();
            txtPhongBan.Text = dt.Rows[0][4].ToString().Length == 0 ? "None" : dt.Rows[0][4].ToString();
            txtQuanLy.Text = dt.Rows[0][5].ToString().Length == 0 ? "None" : dt.Rows[0][5].ToString();
            txtLuongCu.Text = dt.Rows[0][6].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string gioitinh = cbGioiTinhMoi.Text;
            string ngaysinh = dtpNgaySinhMoi.Text;
            int phong = (cbPhongBanMoi.SelectedValue as PhongBan).MaPB;
            int nql = (cbQuanLyMoi.SelectedValue as NhanVien).MaNV;
            double luong = 0;
            if(txtLuongMoi.Text.Length != 0)
            {
                luong = double.Parse(txtLuongMoi.Text);
            }
            if (ckbNgaySinh.Checked == false)
            {
                ngaysinh = "";
            }
            else
            {
                ngaysinh = String.Format("{0:yyyy/MM/dd}", ngaysinh);
            }
            if (kiemTra(ten, gioitinh, ngaysinh, phong, nql, luong))
            {
                int ketQua = 0;
                ketQua = NhanVienControl.suaThongTin(id, ten, ngaysinh, gioitinh, phong, nql, luong);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, string gioitinh, string ngaysinh, int phong, int nql, double luong)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaGV_Load(object sender, EventArgs e)
        {
            ckbNgaySinh.Checked = false;
            dtpNgaySinhMoi.Enabled = false;
            //
            int indexPhong = 0;
            int maPhong = NhanVienControl.layMaPhong(id);
            List<PhongBan> listPB = new List<PhongBan>();
            listPB.Add(new PhongBan
            {
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
                    PhongBan temp = new PhongBan
                    {
                        MaPB = Convert.ToInt32(dtPB.Rows[i][0].ToString()),
                        TenPB = dtPB.Rows[i][1].ToString(),
                        TruongPhong = dtPB.Rows[i][2].ToString().Length != 0 ? Convert.ToInt32(dtPB.Rows[i][2].ToString()) : 0,
                        ViTri = dtPB.Rows[i][3].ToString()
                    };
                    listPB.Add(temp);
                    if (maPhong == temp.MaPB)
                    {
                        indexPhong = i;
                    }
                }
            }
            cbPhongBanMoi.DataSource = listPB;
            cbPhongBanMoi.DisplayMember = "TenPB";
            cbPhongBanMoi.SelectedIndex = maPhong + 0;

            int indexNQL = -1;
            int maNQL = NhanVienControl.layNQL(id);

            List<NhanVien> listNV = new List<NhanVien>();
            DataTable dtNV = NhanVienControl.layDanhSachNQL();
            for (int i = 0; i < dtNV.Rows.Count; ++i)
            {
                if (id == Convert.ToInt32(dtNV.Rows[i][0].ToString()))
                {
                    dtNV.Rows.RemoveAt(i);
                }

            }
            listNV.Add(new NhanVien
            {
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
                    NhanVien temp = new NhanVien
                    {
                        MaNV = Convert.ToInt32(dtNV.Rows[i][0].ToString()),
                        TenNV = dtNV.Rows[i][1].ToString(),
                        NgaySinh = DateTime.Parse(dtNV.Rows[i][2].ToString()),
                        GioiTinh = dtNV.Rows[i][3].ToString(),
                        Phong = dtNV.Rows[i][4].ToString().Length != 0 ? Convert.ToInt32(dtNV.Rows[i][4].ToString()) : 0,
                        NQL = dtNV.Rows[i][5].ToString().Length != 0 ? Convert.ToInt32(dtNV.Rows[i][5].ToString()) : 0,
                        Luong = double.Parse(dtNV.Rows[i][6].ToString())
                    };
                    listNV.Add(temp);
                    if(maNQL == Convert.ToInt32(dtNV.Rows[i][0].ToString()))
                    {
                        indexNQL = i;
                    }
                }
            }
            cbQuanLyMoi.DataSource = listNV;
            cbQuanLyMoi.DisplayMember = "TenNV";
            cbQuanLyMoi.SelectedIndex = indexNQL + 1;
            //

            
        }

        private void ckbNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhMoi.Enabled = ckbNgaySinh.Checked;
        }
    }
}
