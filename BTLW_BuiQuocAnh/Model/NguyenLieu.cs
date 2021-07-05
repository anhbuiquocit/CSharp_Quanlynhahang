using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class NguyenLieu
    {
        public String maNguyenLieu { get; set; }
        public String tenNguyenLieu { get; set; }
        public String moTa { get; set; }

        public NguyenLieu()
        {
            this.maNguyenLieu = "";
            this.tenNguyenLieu = "";
            this.moTa = "";
        }
        public NguyenLieu(String maNguyenLieu, String tenNguyenLieu, String moTa)
        {
            this.maNguyenLieu = maNguyenLieu;
            this.tenNguyenLieu = tenNguyenLieu;
            this.moTa = moTa;
        }
    }
}
