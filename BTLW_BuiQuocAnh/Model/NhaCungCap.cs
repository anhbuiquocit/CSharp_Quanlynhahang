using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class NhaCungCap
    {
        public String maNCC { get; set; }
        public String tenNCC { get; set; }
        public String diaChi { get; set; }

        public NhaCungCap()
        {
            this.maNCC = "";
            this.tenNCC = "";
            this.diaChi = "";
        }
        public NhaCungCap(String maNCC, String tenNCC, String diaChi)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
        }
    }
}
