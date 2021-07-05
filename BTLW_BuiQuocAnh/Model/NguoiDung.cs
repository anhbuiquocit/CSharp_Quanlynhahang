using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class NguoiDung
    {
        public String maNguoiDung { get; set; }
        public String hoTen { get; set; }
        public String gioiTinh { get; set; }
        public Nullable<DateTime> ngaySinh { get; set; }
        public String email { get; set; }
        public TaiKhoan taiKhoan { get; set; }
        public String SoDienThoai { get; set; }
        public String DiaChi { get; set; }
        public NguoiDung()
        {
            this.maNguoiDung = "";
            this.hoTen = "";
            this.gioiTinh = "";
            this.ngaySinh = null;
            this.email = "";
            this.taiKhoan = null;
        }
        public NguoiDung(String maNguoiDung, String hoTen, String gioiTinh, DateTime ngaySinh, String email, TaiKhoan taiKhoan, String sodienthoai, String diachi)
        {
            this.maNguoiDung = maNguoiDung;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.taiKhoan = taiKhoan;
            this.SoDienThoai = sodienthoai;
            this.DiaChi = diachi;
        }
    }
}
