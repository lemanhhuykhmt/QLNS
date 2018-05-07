using Quan_Ly_Nhan_Su.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.GUI.ChiTiet
{
    public partial class frmChiTietPB : Form
    {
        private int idPB;
        public frmChiTietPB()
        {
            InitializeComponent();
        }
        public frmChiTietPB(int id)
        {
            InitializeComponent();
            idPB = id;
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = PhongBanControl.layDanhSachNhanVien(idPB);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string date = String.Format("{0:dd/MM/yyyy}", dt.Rows[i][2]);
                dgvDanhSach.Rows.Add(new object[] { dt.Rows[i][0], dt.Rows[i][1], date, dt.Rows[i][3], dt.Rows[i][5], dt.Rows[i][6] });
            }
        }

        private void frmChiTietPB_Load(object sender, EventArgs e)
        {
            DataTable dt = PhongBanControl.layThongTin(idPB);
            lbTenPhong.Text = dt.Rows[0][1].ToString();
            lbTruongPhong.Text = dt.Rows[0][2].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
