using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class ThucDon
    {
        public String maThucDon { get; set; }
        public String tenThucDon { get; set; }
        
        public ThucDon()
        {
            this.maThucDon = "";
            this.tenThucDon = "";
            
        }
        public ThucDon(String maThucDon, String tenThucDOn, SanPham sanPham)
        {
            this.maThucDon = maThucDon;
            this.tenThucDon = tenThucDon;
            
        }
    }
}
