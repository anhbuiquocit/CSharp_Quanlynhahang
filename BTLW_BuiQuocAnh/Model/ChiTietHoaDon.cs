using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class ChiTietHoaDon
    {
        public String MaCTHD { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
        public int SoLuong { get; set; }
        public ChiTietHoaDon()
        {
            this.MaCTHD = "";
            this.HoaDon = null;
            this.SanPham = null;
            this.SoLuong = 0;
        }
        public ChiTietHoaDon(String macthd, HoaDon hd, SanPham sp, int soluong)
        {
            this.MaCTHD = macthd;
            this.HoaDon = hd;
            this.SanPham = sp;
            this.SoLuong = soluong;
        }
    }
}
