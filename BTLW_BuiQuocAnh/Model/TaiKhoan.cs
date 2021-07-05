using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLW_BuiQuocAnh.Model
{
    class TaiKhoan
    {

        public string userName { get; set; }
        public String passWord { get; set; }
        public int loaiTk { get; set; }
        public TaiKhoan()
        {
            this.userName = "";
            this.passWord = "";
            this.loaiTk = -1;
        }
        public TaiKhoan(String userName, String passWord, int loaiTk)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.loaiTk = loaiTk;
        }
    }
}
