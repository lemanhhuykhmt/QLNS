using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Su.Models
{
    class PhongBan
    {
        public int MaPB { get; set; }
        public string TenPB { get; set; }
        public NhanVien TruongPhong { get; set; }
        public string ViTri { get; set; }
    }
}
