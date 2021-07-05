using BTLW_BuiQuocAnh.Controller;
using BTLW_BuiQuocAnh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLW_BuiQuocAnh.View.FrmDangnhap
{
    public partial class FrmDangnhap : Form
    {
        private List<NguoiDung> listNguoiDung = new List<NguoiDung>();
        BALController bal = new BALController();
        public static Form frm = new Form();
        public FrmDangnhap()
        {
            InitializeComponent();
            listNguoiDung = bal.listNguoiDungForDangNhap();
            frm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTendangnhap.Text == "" || txtMatkhau.Text == "")
                    throw new EvaluateException("Bạn cần nhập tên tài khoản và mật khẩu !");
                String tentk = txtTendangnhap.Text;
                String matkhau = txtMatkhau.Text;
                Boolean flag = false;
                foreach(NguoiDung nd in listNguoiDung)
                {
                    if(nd.taiKhoan.userName.Equals(tentk) && nd.taiKhoan.passWord.Equals(matkhau))
                    {
                        flag = true;
                        if (nd.taiKhoan.loaiTk.Equals(0))
                        {
                            FrmNhanvienUse frm = new FrmNhanvienUse(nd.maNguoiDung);
                            frm.Show();
                            this.Hide();
                        }
                        else if (nd.taiKhoan.loaiTk.Equals(3))
                        {
                            Form1 frm = new Form1();
                            frm.Show();
                            this.Hide();
                        }
                    }
                }
                if (!flag)
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi sql: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
