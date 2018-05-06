using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Nhan_Su.GUI.UC;

namespace Quan_Ly_Nhan_Su.GUI
{
    public partial class frmChinh : Form
    { 
        public frmChinh()
        {
            InitializeComponent();
        }


        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thực sự có muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // thoát
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucNhanVien frm = new ucNhanVien();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);

        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucPhongBan frm = new ucPhongBan();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
        }
    }
}
