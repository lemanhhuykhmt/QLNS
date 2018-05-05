﻿using Quan_Ly_Nhan_Su.ExtendModel;
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
            string sdt = txtSDT.Text;
            float luong = float.Parse(txtLuong.Text) / 1000000;
            if (kiemTraDuLieu(ten, gioiTinh, ngaySinh, sdt, luong))
            {
                string query = "exec themgv @ten , @ngaysinh , @sdt , @gioitinh , @luong";
                int ketqua = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaySinh, sdt, gioiTinh, luong });
                if (ketqua > 0)
                {
                    MessageBox.Show("thêm thành công");
                    txtHoTen.Text = "";
                    cbGioiTinh.Text = "Lựa chọn giới tính";
                    txtSDT.Text = "";
                    txtLuong.Text = "";
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
        }

        private bool kiemTraDuLieu(string ten, string gioiTinh, DateTime ngaySinh, string sdt, float luong)
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
        }
    }
}
