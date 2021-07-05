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

namespace BTLW_BuiQuocAnh.View
{
    public partial class FrmChart : Form
    {
        List<ChiTietHoaDon> listChitiethoadon = new List<ChiTietHoaDon>();
        BALController bal = new BALController();
        public FrmChart()
        {
            InitializeComponent();
            
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTongchi.DataSource = bal.TKChi();
                if (txtNgay.Text == "" && txtNam.Text == "" && txtThang.Text == "")
                    throw new EvaluateException("Bạn cần nhập dữ liệu để thống kê nhập năm hoặc tháng năm hoặc ngày tháng năm!");
                if (int.Parse(txtThang.Text) > 12 || int.Parse(txtThang.Text) < 1)
                    throw new EvaluateException("Bạn cần nhập tháng từ 1 - 12");
                if (int.Parse(txtNgay.Text) > 31 || int.Parse(txtNgay.Text) < 1)
                    throw new EvaluateException("Bạn cần ngày từ 1 - 31");
                if (txtNgay.Text == "" && txtThang.Text == "")
                    dgvThongke.DataSource = bal.TKByYear(txtNam.Text);
                else if (txtNgay.Text == "" )
                    dgvThongke.DataSource = bal.TKByMonth_Year(txtThang.Text, txtNam.Text);
                else
                    dgvThongke.DataSource = bal.TKByDay_Month_Year(txtNgay.Text, txtThang.Text, txtNam.Text);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
