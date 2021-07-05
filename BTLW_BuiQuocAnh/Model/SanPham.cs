using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class SanPham
    {
        public String maSp { get; set; }
        public String tenSp { get; set; }
        public String moTa { get; set; }
        public float giaBan { get; set; }
        
        public String loai { get; set; }
        public String anh { get; set; }
        public SanPham()
        {
            this.maSp = "";
            this.tenSp = "";
            this.moTa = "";
            this.giaBan = 0;
            
            this.loai = "";
            this.anh = "";
        }
        public SanPham(String masp, String tenSp , String mota, float giaBan, String loai, String anh)
        {
            this.maSp = masp;
            this.tenSp = tenSp;
            this.moTa = mota;
            this.giaBan = giaBan;
            
            this.loai = loai;
            this.anh = anh;
        }
    }
}
