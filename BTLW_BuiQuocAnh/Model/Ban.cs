using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class Ban
    {
        public String maBan { get; set; }
        public String tenBan { get; set; }
        public String viTri { get; set; }
        public int tinhTrang { get; set; }
        public Ban()
        {
            this.maBan = "";
            this.tenBan = "";
            this.viTri = "";
            this.tinhTrang = 0;

        }
        public Ban(String maban, String tenBan, String viTri, int tinhTrang)
        {
            this.maBan = maban;
            this.tenBan = tenBan;
            this.viTri = viTri;
            this.tinhTrang = tinhTrang;
        }
    }
}
