using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class HoaDon
    {
        public String maHD { get; set; }
        public String MaNguoiDung { get; set; }
        public String MaBan { get; set; }
        public Nullable<DateTime> ngayLap;
        public int trangthaiHD;
        public NguoiDung nguoiDung { get; set; }
        public Ban ban { get; set; }

        public HoaDon()
        {
            this.maHD = "";
            this.MaNguoiDung = "";
            this.MaBan = "";
            this.nguoiDung = null;
            this.ban = null;
            this.ngayLap = null;
            this.trangthaiHD = 0;
        }
        public HoaDon(String maHD, String manguoidung, String maban, NguoiDung nguoiDung, Ban ban, DateTime ngayLap, int trangthaiHD)
        {
            this.maHD = maHD;
            this.MaNguoiDung = manguoidung;
            this.MaBan = maban;
            this.nguoiDung = nguoiDung;
            this.ban = ban;
            this.ngayLap = ngayLap;
            this.trangthaiHD = trangthaiHD;
        }
    }
}
