using BTLW_BuiQuocAnh.Controller;
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
    public partial class FrmChiTietHoaDon : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvQuanlychitiethoadon.DataSource = bal.getlistChitietHoadon();

            //

            cbbMahd.ValueMember = "mahd";
            cbbMahd.DisplayMember = "mahd";
            cbbMahd.DataSource = bal.getNameofMahd();

            //
            cbbTensp.ValueMember = "masp";
            cbbTensp.DisplayMember = "tensp";
            cbbTensp.DataSource = bal.getNameOfSanpham();
            //cbb
            cbbTim.ValueMember = "mahd";
            cbbTim.DisplayMember = "mahd";
            cbbTim.DataSource = bal.getNameofMahd();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMacthd.Text == "" || txtSoluong.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm!");
                bal.insertIntoChitiethoadon(cbbMahd.SelectedValue.ToString(), cbbTensp.SelectedValue.ToString(), int.Parse(txtSoluong.Text));
                FrmChiTietHoaDon_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMacthd.Text == "" || txtSoluong.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm!");
                bal.updateChitiethoadon(txtMacthd.Text, cbbMahd.SelectedValue.ToString(), cbbTensp.SelectedValue.ToString(), int.Parse(txtSoluong.Text));
                FrmChiTietHoaDon_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMacthd.Text == "" || txtSoluong.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm!");
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {

                    bal.deleteChitiethoadon(txtMacthd.Text);
                    FrmChiTietHoaDon_Load(sender, e);
                }
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtMacthd.Text = "";
            txtSoluong.Text = "";
        }

        private void dgvQuanlychitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMacthd.Text = dgvQuanlychitiethoadon.Rows[selectedRow].Cells[0].Value.ToString();
            txtSoluong.Text = dgvQuanlychitiethoadon.Rows[selectedRow].Cells[3].Value.ToString();
        }

        private void btnXemhd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMacthd.Text == "")
                    throw new EvaluateException("Bạn cần nhập mã chi tiết hoá đơn để xem");
                FrmHoadonxuat frm = new FrmHoadonxuat(cbbMahd.SelectedValue.ToString());
                frm.Show();
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbbTim.SelectedValue.ToString() == "")
                    throw new EvaluateException("Bạn cần chọn mã hoá đơn để tìm!");
                dgvQuanlychitiethoadon.DataSource = bal.getListChitiethoadonByMahd(cbbTim.SelectedValue.ToString());
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
